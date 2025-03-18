-- Create the database
CREATE DATABASE SubqueryPracticeDB;
GO

USE SubqueryPracticeDB;
GO

-- Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Salary DECIMAL(10,2),
    Department VARCHAR(50),
    EmployeeType VARCHAR(20)
);

-- Insert sample data into Employees
INSERT INTO Employees (Name, Salary, Department, EmployeeType) VALUES
('Amit Sharma', 60000, 'IT', 'Full-Time'),
('Priya Iyer', 55000, 'IT', 'Full-Time'),
('Ravi Verma', 50000, 'Sales', 'Full-Time'),
('Sneha Reddy', 45000, 'Sales', 'Part-Time'),
('Kiran Kumar', 75000, 'HR', 'Full-Time'),
('Deepika Nair', 72000, 'HR', 'Part-Time'),
('Arjun Singh', 90000, 'Finance', 'Full-Time');

-- Create Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100)
);

-- Insert sample data into Customers
INSERT INTO Customers (Name) VALUES
('Rajesh Khanna'),
('Neha Mehta'),
('Vikram Choudhury'),
('Anjali Desai');

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    OrderDate DATE,
    Amount DECIMAL(10,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Insert sample data into Orders
INSERT INTO Orders (CustomerID, OrderDate, Amount) VALUES
(1, '2024-01-15', 200.00),
(2, '2024-02-10', 450.50),
(1, '2024-03-05', 120.75),
(3, '2024-03-20', 300.00);

-- Create Departments table
CREATE TABLE Departments (
    Department VARCHAR(50) PRIMARY KEY,
    EmployeeCount INT
);

-- Insert sample data into Departments
INSERT INTO Departments (Department, EmployeeCount) VALUES
('IT', 2),
('Sales', 2),
('HR', 2),
('Finance', 1);

SELECT * FROM Employees;

-- Single-Row Subquery
SELECT Name, Salary
FROM Employees
WHERE Salary > (SELECT MAX(Salary) FROM Employees WHERE Department = 'IT');

SELECT * FROM Customers;
SELECT * FROM Orders;

-- Multiple-Row SubQuery
SELECT Name FROM Customers
WHERE CustomerID IN (SELECT DISTINCT CustomerID FROM Orders);

SELECT * FROM Employees;
SELECT * FROM Departments;

-- Multi- Column Subquery
SELECT Name, Salary, Department
FROM Employees
WHERE Salary = (SELECT Salary FROM Employees WHERE Name = 'Ravi Verma')
AND Department = (SELECT Department FROM Employees WHERE Name = 'Ravi Verma');

-- Correlated Subquery
SELECT Name, Salary, Department
FROM Employees E1
WHERE Salary = (SELECT MAX(Salary) FROM Employees E2 WHERE E2.Department = E1.Department);

-- Nested Subquery
SELECT Name, Salary,Department
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM (SELECT Salary FROM Employees WHERE Department = 'Sales') AS SalesAvg);

-- Exists Subquery
SELECT DISTINCT Department 
FROM Employees e1 
WHERE EXISTS (
    SELECT 1 
    FROM Employees e2 
    WHERE e1.Department = e2.Department 
    AND Salary > 50000
);

