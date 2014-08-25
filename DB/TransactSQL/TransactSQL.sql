--01-Create a database with two tables: 
--Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance). 
--Insert few records for testing. Write a stored procedure that selects the full names of all persons.
DROP DATABASE [TestDB]
CREATE DATABASE TestDB;
GO
USE TestDB
GO
CREATE TABLE Persons
(
	PersonID INTEGER IDENTITY,
	FirstName varchar(20) NOT NULL,
	LastName varchar(30) NOT NULL,
	SSN varchar(20),
	CONSTRAINT PK_PersonID PRIMARY KEY(PersonID)
)
GO
CREATE TABLE Accounts
(
	AccountID INTEGER IDENTITY,
	Balance INTEGER,
	PersonID INTEGER,
	CONSTRAINT PK_AccountID PRIMARY KEY(AccountID),
	CONSTRAINT FK_PersonsID FOREIGN KEY(PersonID) REFERENCES Persons(PersonID)
)
GO
INSERT INTO Persons(FirstName,LastName,SSN)
VALUES('Tosho','Ivanov','8320145689'),
('Gero','Gerov','3213456892')
GO
INSERT INTO Accounts(Balance,PersonID)
VALUES(20000,1),
(1000,2)
GO

CREATE PROC usp_SelectFullName
AS
	SELECT FirstName + ' ' + LastName AS FullName
	FROM Persons
GO

EXEC usp_SelectFullName
GO
--02-Create a stored procedure that accepts a number as a parameter 
--and returns all persons who have more money in their accounts than the supplied number.


CREATE PROC usp_GetGreaterMoney(@Amount money)
AS
	SELECT p.FirstName + ' ' + p.LastName AS GreaterBalanceAccounts,
	a.Balance
	FROM Persons p
	INNER JOIN Accounts a
	ON a.PersonID = p.PersonID
	WHERE a.Balance >= @Amount
GO

EXEC usp_GetGreaterMoney 1000
GO

--03-Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
--It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_CalcSum (@Sum money, @InterestRate float, @NumberOfMonths int)
RETURNS money
BEGIN
RETURN @Sum + (@InterestRate/100) * (@NumberOfMonths/12.0);
END
GO

SELECT dbo.ufn_CalcSum(1500, 8, 6) AS 'NewSum'
GO

--04Create a stored procedure that uses the function from the previous example 
--to give an interest to a person's account for one month. 
--It should take the AccountId and the interest rate as parameters.

CREATE PROC usp_GiveInterest(@AccountID int, @InterestRate float)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalcSum(Balance,@InterestRate,1)
	WHERE AccountID = @AccountID
GO

EXEC usp_GiveInterest 1, 5
GO
--05-Add two more stored procedures WithdrawMoney( AccountId, money) 
--and DepositMoney (AccountId, money) that operate in transactions.

CREATE PROC usp_WithdrawMoney(@AccountID int, @WithdrawSum money)
AS
BEGIN
	BEGIN TRAN
	IF NOT EXISTS(SELECT 1 FROM Accounts a WHERE a.AccountID = @AccountID)
	BEGIN
		ROLLBACK TRAN
	END
	ELSE
	BEGIN
		DECLARE @Balance money;
		SET @Balance = (SELECT a.Balance FROM Accounts a WHERE a.AccountID = @AccountID)
		
		IF(@Balance - @WithdrawSum > 0)
		BEGIN
			UPDATE Accounts
			SET Balance = @Balance - @WithdrawSum WHERE AccountID = @AccountID
			COMMIT TRAN
		END
		ELSE
		BEGIN
			ROLLBACK TRAN
		END 
	END
END
GO

CREATE PROC usp_DepositMoney (@AccountID int, @DepositAmmount money)
AS
BEGIN
	BEGIN TRAN
	IF(@DepositAmmount <= 0)
	BEGIN
		ROLLBACK TRAN
		RAISERROR('Invalid deposit',16,1)
	END
	ELSE
	BEGIN
		DECLARE @Balance money;
		SET @Balance = (SELECT a.Balance FROM Accounts a WHERE a.AccountID = @AccountID)
		UPDATE Accounts
			SET Balance = @Balance + @DepositAmmount WHERE AccountID = @AccountID
			COMMIT TRAN
	END
END
GO

DECLARE @AccountID int;
SET @AccountID = 2

EXEC usp_DepositMoney 2, 2000

SELECT a.Balance FROM Accounts a WHERE a.AccountID = @AccountID
GO

--06-Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
--Add a trigger to the Accounts table that enters a new entry into the Logs table 
--every time the sum on an account changes.

CREATE TABLE Logs
(
	LogID int IDENTITY,
	AccountID int NOT NULL,
	OldSum money,
	NewSum money,
	CONSTRAINT PK_LogID PRIMARY KEY(LogID),
	CONSTRAINT FK_AccountID FOREIGN KEY(AccountID) REFERENCES Accounts(AccountID)
)
GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountID,OldSum,NewSum)
	SELECT d.AccountID,d.Balance,i.Balance
	FROM deleted d INNER JOIN inserted i ON d.AccountID = i.AccountID
GO

CREATE TRIGGER tr_AccountsInsert ON Accounts FOR INSERT
AS
	INSERT INTO Logs(AccountID,OldSum,NewSum)
	SELECT d.AccountID,d.Balance,i.Balance
	FROM deleted d INNER JOIN inserted i ON d.AccountID = i.AccountID
GO

--07-Define a function in the database TelerikAcademy 
--that returns all Employee's names (first or middle or last name) 
--and all town's names that are comprised of given set of letters. 
--Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
USE TelerikAcademy
GO

CREATE FUNCTION IsContainingString(@LettersSet varchar(50), @Name varchar(50))
RETURNS BIT
BEGIN
	DECLARE @IsContaining bit = 1,
			@CurrentIndex int = 1,
			@CurrentLetter varchar(1),
			@NameLength int = LEN(@Name);

			WHILE(@CurrentIndex <= @NameLength)
			BEGIN
				SET @CurrentLetter = SUBSTRING(@Name,@CurrentIndex,1)

				IF(CHARINDEX(@CurrentLetter,@LettersSet) = 0)
				BEGIN
					SET @IsContaining = 0
					BREAK
				END
				SET @CurrentIndex = @CurrentIndex + 1
			END
		RETURN @IsContaining
END
GO

CREATE FUNCTION ufn_SelectEmployeesAndTowns (@Letter varchar(50))
RETURNS TABLE
AS
	 RETURN
	 (
		SELECT fn.FirstName AS FirstName
		FROM Employees fn
		WHERE dbo.IsContainingString(@Letter, fn.FirstName) = 1
		UNION 
		SELECT ln.LastName AS LastName
		FROM Employees ln
		WHERE dbo.IsContainingString(@Letter, ln.LastName) = 1
		UNION
		SELECT mn.MiddleName AS MiddleName
		FROM Employees mn
		WHERE dbo.IsContainingString(@Letter, mn.MiddleName) = 1
		UNION
		SELECT t.Name
		FROM Towns t
		WHERE dbo.IsContainingString(@Letter, t.Name) = 1)
GO

SELECT * FROM dbo.ufn_SelectEmployeesAndTowns('oistmiahf')