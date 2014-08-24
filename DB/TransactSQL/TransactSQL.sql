--Create a database with two tables: 
--Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance). 
--Insert few records for testing. Write a stored procedure that selects the full names of all persons.



--CREATE DATABASE TestDB;
--GO
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
SELECT FirstName + ' ' + LastName
FROM Persons
GO

EXEC usp_SelectFullName