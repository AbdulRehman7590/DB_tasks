-- Return customers and their orders, including customers who placed no orders (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID, O.OrderID, O.OrderDate
FROM [Customers] C LEFT JOIN [Orders] O
	ON C.CustomerID = O.CustomerID;


-- Report only those customer IDs who never placed any order. (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID, O.OrderID, O.OrderDate
FROM [Customers] C LEFT JOIN [Orders] O
	ON C.CustomerID = O.CustomerID
WHERE O.OrderID IS NULL;


-- Report those customers who placed orders on July,1997. (CustomerID, OrderID, OrderDate)
SELECT C.CustomerID, O.OrderID, O.OrderDate
FROM [Customers] C JOIN [Orders] O
	ON C.CustomerID = O.CustomerID
WHERE MONTH(O.OrderDate) = '7' AND YEAR(O.OrderDate) = '1997'; 


-- Report the total orders of each customer. (customerID, totalorders)
SELECT O.CustomerID, COUNT(O.OrderID) as TotalOrders
FROM [Customers] C INNER JOIN [Orders] O
	ON C.CustomerID = O.CustomerID
GROUP BY O.CustomerID;


-- Write a query to generate a five copies of each employee. (EmployeeID, FirstName, LastName)
SELECT EmployeeID, FirstName, LastName
FROM Employees
CROSS JOIN (SELECT 1 AS Num
    UNION ALL SELECT 2
    UNION ALL SELECT 3
    UNION ALL SELECT 4
    UNION ALL SELECT 5 ) AS Numbers;


-- Write a query that returns a row for each employee and day in the range 04-07-1996 through 04-08-1997. (EmployeeID, Date)
SELECT E.EmployeeID, CAST(O.OrderDate AS Date) AS Date
FROM [Employees] E JOIN [Orders] O
	ON E.EmployeeID = O.EmployeeID
WHERE O.OrderDate >= '1996-07-04' AND O.OrderDate <= '1997-08-04'
ORDER BY Date;


-- Return US customers, and for each customer return the total number of orders and total quantities. (CustomerID, Totalorders, totalquantity)
SELECT C.CustomerID, COUNT(O.OrderID) AS TotalOrders, SUM(OD.Quantity) AS TotalQuantity
FROM [Customers] C INNER JOIN [Orders] O
	ON C.CustomerID = O.CustomerID
	JOIN [Order Details] OD
		ON O.OrderID = OD.OrderID
WHERE C.Country = 'USA'
GROUP BY C.CustomerID;


-- Write a query that returns all customers in the output, but matches them with their respective orders only if they were placed on July 04,1997. (CustomerID, CompanyName, OrderID, Orderdate)
SELECT C.CustomerID, C.CompanyName, O.OrderID, O.OrderDate
FROM [Customers] C LEFT JOIN [Orders] O
	ON C.CustomerID = O.CustomerID AND O.OrderDate = '1997-07-04';


-- Are there any employees who are older than their managers?
SELECT *
FROM [Employees] E JOIN [Employees] E1
	ON E.ReportsTo = E1.EmployeeID
WHERE E.BirthDate < E1.BirthDate AND E.ReportsTo IS NOT NULL;


-- List that names of those employees and their ages. (EmployeeName, Age, Manager Age)
SELECT (E.FirstName+E.LastName) AS EmployeeName, 
		YEAR(GETDATE())-YEAR(E.BirthDate) AS Age,
        YEAR(GETDATE())-YEAR(E1.BirthDate) AS ManagerAge
FROM [Employees] E JOIN [Employees] E1
	ON E.ReportsTo = E1.EmployeeID
WHERE E.BirthDate < E1.BirthDate AND E.ReportsTo IS NOT NULL;


-- List the names of products which were ordered on 8th August 1997. (ProductName, OrderDate)
SELECT P.ProductName, O.OrderDate
FROM [Orders] O JOIN [Order Details] OD
	ON O.OrderID = OD.OrderID
	JOIN [Products] P
		ON OD.ProductID = P.ProductID
WHERE CAST(O.OrderDate AS DATE) = '1997-08-08';


-- List the addresses, cities, countries of all orders which were serviced by Anne and were shipped late. (Address, City, Country)
SELECT O.ShipAddress AS OrderAddress, O.ShipCity AS City, O.ShipCountry AS Country 
FROM [Orders] O JOIN [Employees] E
	ON O.EmployeeID = E.EmployeeID
WHERE E.FirstName = 'Anne' AND O.ShippedDate > O.RequiredDate;


-- List all countries to which beverages have been shipped. (Country)
SELECT O.ShipCountry AS Country
FROM [Orders] O JOIN [Order Details] OD
	ON O.OrderID = OD.OrderID
	JOIN [Products] P
		ON OD.ProductID = P.ProductID
		JOIN Categories CT
			ON P.CategoryID = CT.CategoryID
WHERE LOWER(CT.CategoryName) = 'beverages';