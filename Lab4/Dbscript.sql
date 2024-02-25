-- List name of all the products whose price is above average. (Product Name)
SELECT [ProductName] 
FROM [Northwind].[dbo].[Products] 
WHERE UnitPrice > (SELECT AVG(Products.UnitPrice) FROM [Northwind].[dbo].[Products]);


-- Write a query to generate report showing date wise orders shipped. (ShippedDate, numberoforders)
SELECT [ShippedDate], COUNT(*) as [numberoforders]
FROM [Northwind].[dbo].[Orders]
GROUP BY ShippedDate;


-- List name of all countries from where two or more suppliers belong to. (Country)
SELECT [Country]
FROM [Northwind].[dbo].[Suppliers]
GROUP BY Country
HAVING COUNT(*) >= 2;


-- Write a query to generate report showing month wise orders delayed shipped. Your output should look like this (Month Number, Orders Delayed)
SELECT MONTH(ShippedDate) as [Month Number], COUNT(*) as [Orders Delayed] 
FROM [Northwind].[dbo].[Orders]
WHERE ShippedDate > RequiredDate
GROUP BY MONTH(ShippedDate)
ORDER BY [Month Number] ASC;


-- Report all the orders which have been discounted. Your result should show the total discount against each order. Output should look like this (Order ID, Discount)
SELECT [OrderID], SUM(Discount) AS Discount
FROM [Northwind].[dbo].[Order Details]
GROUP BY [OrderID]
HAVING SUM(Discount) > 0;


-- Write a query to list the number of orders which were shipped in the cities of USA in 1997. Show the number of order against each city. (Ship City, Number of orders)
SELECT [ShipCity], COUNT(*) as [Number of orders]
FROM [Northwind].[dbo].[Orders]
WHERE YEAR(ShippedDate) = 1997 AND [ShipCountry] = 'USA'
GROUP BY [ShipCity];


-- Write a query to generate report showing country wise orders delayed shipped. Your output should look like this: (Country, Orders Delayes)
SELECT [ShipCountry], COUNT(*) as [Orders Delayed]
FROM [Northwind].[dbo].[Orders]
WHERE ShippedDate > RequiredDate
GROUP BY ShipCountry;


-- Report all the orders which have been discounted with total price of order. Your result should show the total discount against each order. Output should look like this: (Order ID, Discount, Total Price)
SELECT [OrderID], SUM(Discount) AS [Discount], SUM(UnitPrice * Quantity * (1 - Discount)) AS [Total Price]
FROM [Northwind].[dbo].[Order Details]
WHERE Discount > 0
GROUP BY OrderID;


-- Write a query to list the number of orders which were shipped in the cities of each region in 1997. Show the number of order against each city. Your results should look like this: (ShipRegion, ShipCity, Numberoforders)
SELECT [ShipRegion], [ShipCity], COUNT(*) AS [Numberoforders]
FROM [Northwind].[dbo].[Orders]
WHERE YEAR(ShippedDate) = 1997
GROUP BY ShipCity, ShipRegion;