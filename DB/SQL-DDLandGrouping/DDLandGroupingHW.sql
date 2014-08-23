--Write a SQL query to find the names and salaries of the employees t
--hat take the minimal salary in the company. 
--Use a nested SELECT statement.

SELECT FirstName,LastName,Salary
FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees)

--Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% 
--higher than the minimal salary for the company.

SELECT FirstName,LastName,Salary
FROM Employees
WHERE Salary < (SELECT MIN(Salary) FROM Employees) * 1.1

--Write a SQL query to find the full name, salary and department of the employees 
--that take the minimal salary in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS FullName,
d.Name
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = (SELECT MIN(Salary) FROM Employees WHERE DepartmentID = e.DepartmentID)

--Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS AVGSalary 
FROM Employees
WHERE DepartmentID = 1

--Write a SQL query to find the average salary  in the "Sales" department.

SELECT AVG(e.Salary) AS AVGSalary
FROM Employees e
INNER JOIN Departments d
ON d.Name = 'Sales'

--Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e
INNER JOIN Departments d
ON d.Name = 'Sales'

--Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(e.EmployeeID) AS EmplWithManager
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(e.EmployeeID) AS DirectorsCount
FROM Employees e
WHERE e.ManagerID IS NULL

--Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name, AVG(e.Salary) AS AVGSalary
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name







