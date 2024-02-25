/* Lab 3 Database

SELECT *
FROM Student;

SELECT RegNo, LastName, GPA
FROM Student;

SELECT *
FROM Student
WHERE GPA > 3.5;

SELECT * 
FROM Student
WHERE GPA <= 3.5;

SELECT FirstName+LastName AS FullName, GPA
FROM Student;
*/

/* Northwind  */

SELECT *
FROM Employees
WHERE Employees.TitleOfCourtesy = 'Ms.';

SELECT *
FROM Employees
WHERE Employees.City LIKE 'Sea%';

SELECT *
FROM Employees
WHERE Employees.Title NOT LIKE 'Sales%';

SELECT *
FROM Orders
WHERE Orders.EmployeeID BETWEEN 4 AND 9;

SELECT *
FROM Employees
WHERE Employees.Region IS NULL;

SELECT *
FROM Products
WHERE (Products.UnitPrice > 40 AND Products.UnitsOnOrder < UnitsInStock) OR Products.Discontinued = 1;
/*
SELECT *
FROM Orders
ORDER BY Orders.CustomerID ASC;

SELECT *
FROM Orders
WHERE Orders.ShipRegion IS NOT NULL
ORDER BY Orders.ShipRegion ASC;

SELECT TOP(10) *
FROM Products
ORDER BY Products.UnitsInStock DESC;
*/

