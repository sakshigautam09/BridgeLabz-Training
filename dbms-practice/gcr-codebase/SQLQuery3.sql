CREATE DATABASE companyDatabase;

USE companyDatabase;

/* ================================
   DEPARTMENT
================================ */
CREATE TABLE Department (
    DeptID INT IDENTITY(1,1) PRIMARY KEY,
    DeptName VARCHAR(50) UNIQUE NOT NULL
);

/* ================================
   EMPLOYEE
================================ */
CREATE TABLE EmployeeDetails (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT,
    DeptID INT,
    Email VARCHAR(100),

    CONSTRAINT FK_Employee_Department
    FOREIGN KEY (DeptID)
    REFERENCES Department(DeptID)
);

/* ================================
   PROJECT
================================ */
CREATE TABLE Project (
    ProjectID INT PRIMARY KEY,
    ProjectName VARCHAR(50),
    DeptID INT,

    CONSTRAINT FK_Project_Department
    FOREIGN KEY (DeptID)
    REFERENCES Department(DeptID)
);

/* ================================
   EMPLOYEE - PROJECT (RELATION TABLE)
================================ */
CREATE TABLE EmployeeProject (
    EmpID INT,
    ProjectID INT,
    Role VARCHAR(50),

    CONSTRAINT PK_EmployeeProject PRIMARY KEY (EmpID, ProjectID),

    CONSTRAINT FK_EmpProj_Employee
    FOREIGN KEY (EmpID)
    REFERENCES EmployeeDetails(EmpID),

    CONSTRAINT FK_EmpProj_Project
    FOREIGN KEY (ProjectID)
    REFERENCES Project(ProjectID)
);


/* ================================
   INSERT DATA
================================ */

INSERT INTO Department (DeptName)
VALUES ('HR'), ('IT'), ('Finance'), ('Sales'), ('Marketing'), ('Admin');

INSERT INTO EmployeeDetails VALUES
(101,'Amit',60000,2,'amit@company.com'),
(102,'Neha',50000,1,'neha@company.com'),
(103,'Ravi',55000,3,'ravi@company.com');

INSERT INTO Project VALUES
(1,'Payroll System',1),
(2,'Website Development',2),
(3,'Finance Tracker',3);

INSERT INTO EmployeeProject VALUES
(101,1,'Developer'),
(102,2,'Tester'),
(103,3,'Analyst');


/* ================================
   TRANSACTIONS
================================ */

BEGIN TRANSACTION;
INSERT INTO Department VALUES ('Support');
COMMIT;

BEGIN TRANSACTION;
INSERT INTO Department VALUES ('TempDept');
ROLLBACK;

BEGIN TRANSACTION;
INSERT INTO Department VALUES ('HR-Backup');
SAVE TRANSACTION SP1;
INSERT INTO Department VALUES ('IT-Backup');
ROLLBACK TRANSACTION SP1;
COMMIT;


/* ================================
   DCL
================================ */

IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'CompanyUser')
CREATE LOGIN CompanyUser WITH PASSWORD = 'Company@123';

CREATE USER CompanyUser FOR LOGIN CompanyUser;

GRANT SELECT, INSERT ON EmployeeDetails TO CompanyUser;
REVOKE INSERT ON EmployeeDetails FROM CompanyUser;


/* ================================
   JOINS
================================ */

SELECT E.EmpID, E.EmpName, D.DeptName
FROM EmployeeDetails E
INNER JOIN Department D ON E.DeptID = D.DeptID;

SELECT E.EmpID, E.EmpName, D.DeptName
FROM EmployeeDetails E
LEFT JOIN Department D ON E.DeptID = D.DeptID;

SELECT E.EmpID, E.EmpName, D.DeptName
FROM EmployeeDetails E
RIGHT JOIN Department D ON E.DeptID = D.DeptID;

SELECT E.EmpID, E.EmpName, D.DeptName
FROM EmployeeDetails E
FULL OUTER JOIN Department D ON E.DeptID = D.DeptID;

SELECT E.EmpName, D.DeptName
FROM EmployeeDetails E
CROSS JOIN Department D;


/* ================================
   NORMALIZATION
================================ */

CREATE TABLE Department_1NF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Employee_1NF (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT,
    DeptID INT,
    Email VARCHAR(100),
    CONSTRAINT FK_Emp1NF_Dept
    FOREIGN KEY (DeptID)
    REFERENCES Department_1NF(DeptID)
);

CREATE TABLE Department_2NF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Employee_2NF (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT,
    DeptID INT,
    Email VARCHAR(100),
    CONSTRAINT FK_Emp2NF_Dept
    FOREIGN KEY (DeptID)
    REFERENCES Department_2NF(DeptID)
);

CREATE TABLE Department_3NF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50),
    DeptLocation VARCHAR(50)
);

CREATE TABLE Employee_3NF (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT,
    DeptID INT,
    Email VARCHAR(100),
    CONSTRAINT FK_Emp3NF_Dept
    FOREIGN KEY (DeptID)
    REFERENCES Department_3NF(DeptID)
);

CREATE TABLE Department_BCNF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50) UNIQUE,
    DeptLocation VARCHAR(50)
);

CREATE TABLE Employee_BCNF (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT,
    DeptID INT,
    Email VARCHAR(100),
    CONSTRAINT FK_EmpBCNF_Dept
    FOREIGN KEY (DeptID)
    REFERENCES Department_BCNF(DeptID)
);


/* ================================
   NORMALIZATION DATA
================================ */

INSERT INTO Department_1NF VALUES (1,'HR'),(2,'IT');
INSERT INTO Employee_1NF VALUES
(101,'Amit',60000,2,'amit@company.com'),
(102,'Neha',50000,1,'neha@company.com');

INSERT INTO Department_2NF VALUES (1,'HR'),(2,'IT');
INSERT INTO Employee_2NF VALUES
(101,'Amit',60000,2,'amit@company.com'),
(102,'Neha',50000,1,'neha@company.com');

INSERT INTO Department_3NF VALUES
(1,'HR','Building A'),
(2,'IT','Building B');

INSERT INTO Employee_3NF VALUES
(101,'Amit',60000,2,'amit@company.com'),
(102,'Neha',50000,1,'neha@company.com');

INSERT INTO Department_BCNF VALUES
(1,'HR','Building A'),
(2,'IT','Building B');

INSERT INTO Employee_BCNF VALUES
(101,'Amit',60000,2,'amit@company.com'),
(102,'Neha',50000,1,'neha@company.com');


