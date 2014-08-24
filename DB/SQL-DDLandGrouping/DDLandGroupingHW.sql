--01-Write a SQL query to find the names and salaries of the employees 
--that take the minimal salary in the company. 
--Use a nested SELECT statement.

SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE Salary = (SELECT MIN(Salary) FROM Employees)

--02-Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% 
--higher than the minimal salary for the company.

SELECT FirstName,LastName,Salary
FROM Employees
WHERE Salary < (SELECT MIN(Salary) FROM Employees) * 1.1

--03-Write a SQL query to find the full name, salary and department of the employees 
--that take the minimal salary in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS FullName,
d.Name
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = (SELECT MIN(Salary) FROM Employees WHERE DepartmentID = e.DepartmentID)

--04-Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS AVGSalary 
FROM Employees
WHERE DepartmentID = 1

--05-Write a SQL query to find the average salary  in the "Sales" department.

SELECT AVG(e.Salary) AS AVGSalary
FROM Employees e
INNER JOIN Departments d
ON d.Name = 'Sales'

--06-Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e
INNER JOIN Departments d
ON d.Name = 'Sales'

--07-Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(e.EmployeeID) AS EmplWithManager
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--08-Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(e.EmployeeID) AS DirectorsCount
FROM Employees e
WHERE e.ManagerID IS NULL

--09-Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name, AVG(e.Salary) AS AVGSalary
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

--10-Write a SQL query to find the count of all employees in each department and for each town.

SELECT t.Name, d.Name, COUNT(e.EmployeeID) AS EmplCount
FROM Employees e
JOIN Addresses a
ON a.AddressID = e.AddressID
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
JOIN Towns t
ON t.TownID = a.AddressID
GROUP BY t.Name, d.Name

--11-Write a SQL query to find all managers that have exactly 5 employees. 
--Display their first name and last name.

SELECT m.FirstName, m.LastName
FROM Employees m
INNER JOIN Employees e
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.ManagerID) = 5

--12-Write a SQL query to find all employees along with their managers.
--For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName, e.LastName AS Employee,
ISNULL(m.FirstName,'no manager') AS Manager
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--13-Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--Use the built-in LEN(str) function.

SELECT e.LastName
FROM Employees e
WHERE LEN(LastName) = 5

--14-Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds". 
--Search in  Google to find how to format dates in SQL Server.

SELECT CONVERT(varchar, GETDATE(),113) AS Date

--15-Write a SQL statement to create a table Users. 
--Users should have username, password, full name and last login time. 
--Choose appropriate data types for the table fields. 
--Define a primary key column with a primary key constraint. 
--Define the primary key column as identity to facilitate inserting records. 
--Define unique constraint to avoid repeating usernames. 
--Define a check constraint to ensure the password is at least 5 characters long.
DROP TABLE[Users]
GO
CREATE TABLE Users (
UserID int IDENTITY,
UserName nvarchar(20) NOT NULL,
UserPass nvarchar(100),
FullName nvarchar(100) NOT NULL,
LastLogin datetime,
CONSTRAINT PK_Persons PRIMARY KEY(UserID),
CONSTRAINT UC_UserName UNIQUE (UserName),
CONSTRAINT CC_PASSWORD CHECK (LEN(UserPass)>=5)
)
GO

--16-Write a SQL statement to create a view that displays the users from the Users table 
--that have been in the system today. Test if the view works correctly.
SET IDENTITY_INSERT Users ON
INSERT INTO Users
(UserID,UserName,UserPass,FullName,LastLogin) VALUES(1,'Tarikat','123456','Stavri Petrov',GETDATE())
GO
INSERT INTO Users
(UserID,UserName,UserPass,FullName,LastLogin) VALUES(2,'Pedro','13131313','Pesho Petrov',GETDATE())
GO
INSERT INTO Users
(UserID,UserName,UserPass,FullName,LastLogin) VALUES(3,'QkIGotqn','111111','Miro Dalakov',GETDATE())
SET IDENTITY_INSERT Users OFF
GO
DROP VIEW[LoggedToday]
GO
CREATE VIEW LoggedToday
AS 
SELECT *
FROM Users u
WHERE CAST(u.LastLogin AS DATE) >= GETDATE()
GO

--17-Write a SQL statement to create a table Groups. 
--Groups should have unique name (use unique constraint). Define primary key and identity column.
DROP TABLE[Groups]
GO
CREATE TABLE Groups
(
Group_ID INT IDENTITY,
Name VARCHAR(50) NOT NULL
)
GO

--18-Write a SQL statement to add a column GroupID to the table Users. 
--Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
--ALTER TABLE [dbo].[Users] DROP COLUMN Group_ID
--GO
ALTER TABLE Users ADD Group_ID int
GO

INSERT INTO Groups
(Name) VALUES('Driver'),('Cleaner'),('Web Developer'),('Mobile Developer')
GO

--19-Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO GROUPS
(Name) VALUES('Freelancer')
GO
SET IDENTITY_INSERT Users ON
INSERT INTO Users(UserID,UserName,UserPass,FullName,LastLogin) 
VALUES(6,'Goshko','123456','Georgi Petrov',GETDATE())
SET IDENTITY_INSERT Users OFF
GO
--20-Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Groups
SET Name = 'NotCleaner'
WHERE Name = 'Cleaner'
GO
--21-Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
WHERE FullName = 'Georgi Petrov'
GO

--22-Write SQL statements to insert in the Users table the names of all employees from the Employees table. 
--Combine the first and last names as a full name. 
--For username use the first letter of the first name + the last name (in lowercase). 
--Use the same for the password, and NULL for last login time.

INSERT INTO Users(UserName,FullName,UserPass)
SELECT LEFT(LOWER(e.FirstName),1) + LOWER(e.LastName) AS UserName,
e.FirstName + ' ' + e.LastName AS FullName,
LEFT(LOWER(e.FirstName),1) + LOWER(e.LastName) AS UserPassword
FROM Employees e
WHERE LEN(e.LastName) >= 5
GO

--23-Write a SQL statement that changes the password to NULL for all users 
--that have not been in the system since 10.03.2010.

UPDATE Users
SET UserPass = NULL
WHERE LastLogin < '10.03.2010'

--24-Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
WHERE UserPass IS NULL

--25-Write a SQL query to display the average employee salary by department and job title.
SELECT AVG(e.Salary) AS AVGSalary, 
e.JobTitle, 
d.Name AS DepartmentName
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name

--26-Write a SQL query to display the minimal employee salary by department and job title 
--along with the name of some of the employees that take it.

SELECT MIN(e.Salary) AS MinSalary,
e.JobTitle,
d.Name AS DepartmentName
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (SELECT MIN(Salary) 
FROM Employees
WHERE e.DepartmentID = d.DepartmentID)
GROUP BY e.JobTitle,d.Name

--27-Write a SQL query to display the town where maximal number of employees work.
SELECT TOP(1) t.Name, COUNT(e.EmployeeID) AS EmployeesCount 
FROM Employees e
INNER JOIN Addresses a
ON a.AddressID = e.AddressID
INNER JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name

--28-Write a SQL query to display the number of managers from each town.
SELECT t.Name, COUNT(e.EmployeeID)
FROM Employees e
INNER JOIN Addresses a
ON a.AddressID = e.AddressID
INNER JOIN Towns t
ON t.TownID = a.TownID
WHERE e.ManagerID IS NULL
GROUP BY t.Name
ORDER BY COUNT(e.EmployeeID) DESC

--Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments). 
--Don't forget to define  identity, primary key and appropriate foreign key. 
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. 
--For each change keep the old record data, the new record data and the command (insert / update / delete).

DROP TABLE[WorkHours]
CREATE TABLE WorkHours(
	WorkHourID INTEGER IDENTITY,
	EntryDate Date, 
	Task varchar(50) NOT NULL,
	WorkingHours INTEGER NOT NULL,
	Comments varchar(50)
	CONSTRAINT WorkHourID PRIMARY KEY(WorkHourID),
	EmployeesID int FOREIGN KEY REFERENCES Employees(EmployeeID) NOT NULL
);
GO
DROP TABLE[WorkHoursLog]
CREATE TABLE WorkHoursLog
(
	EntryLogID int IDENTITY,
	WorkHourIdOLD int,
	EntryDateOld Date,
	TaskOld varchar(50),
	WorkingHoursOld int,
	CommentsOld varchar(50),
	EmployeesIdOld int,
	WorkHoursIdNew int,
	EntryDateNew Date,
	TaskNew varchar(50),
	WorkingHoursNew int,
	CommentsNew varchar(50),
	EmployeesIdNew int
	CONSTRAINT EntryLogID PRIMARY KEY(EntryLogID)
)

