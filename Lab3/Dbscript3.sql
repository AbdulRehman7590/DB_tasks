-- Write a query to report orders which were delayed shipped.
SELECT * FROM Orders WHERE Orders.ShippedDate > Orders.RequiredDate;


-- Our employees belong to how many countries. List the names.
SELECT Employees.Country FROM Employees


-- Is there any employee who is not accountable?
SELECT * FROM Employees WHERE Employees.ReportsTo IS NULL;


-- List the names of products which have been discontinued.
SELECT Products.ProductName FROM Products WHERE Products.Discontinued = 1;


-- List the IDs the orders on which discount was not provided.
SELECT [Order Details].OrderID FROM [Order Details] WHERE [Order Details].Discount <> 0;


-- Enlist the names of customers who have not specified their region.
SELECT Customers.ContactName FROM Customers WHERE Customers.Region IS NULL;


-- Enlist the names of customers along with contact number who either belongs to UK or USA.
SELECT Customers.ContactName, Customers.Phone AS ContactNUmber FROM Customers WHERE Customers.Country = 'UK' OR Customers.Country = 'USA';


-- Report the names of companies who have provided their web page.
SELECT Suppliers.CompanyName FROM Suppliers WHERE Suppliers.HomePage IS NOT NULL;


-- In which countries, products were sold in year 1997.
SELECT Orders.ShipCountry AS CountryName FROM Orders WHERE YEAR(Orders.ShippedDate) = 1997;


-- List the ids of customers whose orders were never shipped.
SELECT Orders.CustomerID FROM Orders WHERE Orders.ShippedDate IS NULL;


-- Write a query to report suppliers with their id, company name and city.
SELECT Suppliers.SupplierID, Suppliers.CompanyName, Suppliers.City FROM Suppliers;


-- Our employees belong to how many countries. List them who are used to live in London.
SELECT COUNT(Employees.Country) AS CountryCount FROM Employees WHERE Employees.City = 'London';


-- List the names of products which have not been discontinued.
SELECT Products.ProductName FROM Products WHERE Products.Discontinued = 0;


-- List the IDs the orders on which discount was 0.1 or less.
SELECT [Order Details].OrderID FROM [Order Details] WHERE ([Order Details].Discount < 0.1 OR [Order Details].Discount = 0.1) AND [Order Details].Discount > 0;  


-- Enlist the IDS, names of employees and their contact number with extensions who have not specified their region.
SELECT Employees.EmployeeID, (Employees.FirstName+Employees.LastName) AS EmployeeName, Employees.HomePhone AS ContactNumber, Employees.Extension FROM Employees WHERE Employees.Region IS NULL;