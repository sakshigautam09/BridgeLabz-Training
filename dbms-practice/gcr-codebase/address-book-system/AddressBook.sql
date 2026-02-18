CREATE DATABASE AddressBookDB;
GO

USE AddressBookDB;
GO

CREATE TABLE Contacts(
    Id INT IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Address NVARCHAR(200),
    City NVARCHAR(50),
    State NVARCHAR(50),
    Zip NVARCHAR(20),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    BookName NVARCHAR(50)
);
