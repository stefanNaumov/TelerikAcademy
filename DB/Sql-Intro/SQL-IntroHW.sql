/****** Script for SelectTopNRows command from SSMS  ******/
SELECT * FROM Departments

SELECT Name FROM Departments

SELECT Salary,LastName 
FROM Employees

SELECT FirstName + ' ' + LastName 
FROM Employees

SELECT FirstName + '.' + LastName + '@telerik.com'
AS [FullEmailAddress]
FROM Employees

SELECT DISTINCT Salary s 
FROM Employees


SELECT * FROM Employees e
WHERE e.JobTitle = 'Sales Representative'


SELECT FirstName
FROM Employees
WHERE FirstName LIKE '%SA'

SELECT LastName
FROM Employees
WHERE LastName LIKE '%ei%'

SELECT Salary
FROM Employees
WHERE Salary BETWEEN 200000 AND 300000

SELECT FirstName, LastName
FROM Employees
WHERE Salary = 25000
OR Salary = 14000
OR Salary = 12500
OR Salary = 23600

SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL

SELECT Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

SELECT TOP 5 FirstName,LastName, Salary
FROM Employees
ORDER BY Salary DESC

SELECT e.FirstName, e.LastName,
a.AddressText
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

SELECT FirstName,LastName
FROM Employees, Addresses
WHERE Employees.AddressID = 
Addresses.AddressID

SELECT e.FirstName, e.LastName,
m.FirstName,m.LastName
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID

SELECT e.FirstName, e.LastName,
m.FirstName, m.LastName,
a.AddressText
FROM Employees e, Employees m, Addresses a
WHERE e.AddressID = a.AddressID
AND m.AddressID = a.AddressID

SELECT Name 
FROM Departments
UNION
SELECT Name FROM Towns

SELECT e.FirstName, e.LastName,
m.FirstName,m.LastName,
v.FirstName, v.LastName
FROM Employees e, Employees m
RIGHT OUTER JOIN Employees v
ON v.ManagerID IS NUll 

SELECT e.FirstName, e.LastName,
m.FirstName,m.LastName,
v.FirstName, v.LastName
FROM Employees e, Employees m
LEFT OUTER JOIN Employees v
ON v.ManagerID IS NUll

SELECT e.FirstName,e.LastName, e.HireDate
FROM Employees e
WHERE e.DepartmentID = 1
OR e.DepartmentID = 3
AND (YEAR(e.HireDate) > 1995) AND (YEAR(e.HireDate) < 2005)

