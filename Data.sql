CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE FoodTable
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Untitled',
	status NVARCHAR(100) NOT NULL DEFAULT N'Available'  -- Available || Full
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'User',
	passWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --1: Admin && 0: Member
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Untitled'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Untitled',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL --1: query && 0: payed

	FOREIGN KEY (idTable) REFERENCES dbo.FoodTable(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
) 
GO

INSERT INTO dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'admin',
	N'Admin',
	N'2202',
	1
)
GO

INSERT INTO dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
VALUES
(
	N'staff',
	N'Staff',
	N'1234',
	0
)
GO



CREATE PROC USP_GetAccountByUserName
@UserName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName =@UserName
END
GO

EXEC dbo.USP_GetAccountByUserName @UserName = N'admin'
Go


SELECT * FROM dbo.Account WHERE UserName = N'admin' AND passWord = N'2202'
GO

CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND passWord = @passWord
END
GO

DECLARE @i INT = 0

WHILE @i <= 10
BEGIN
	INSERT dbo.FoodTable (name) VALUES (N'B?n ' + CAST( @i AS NVARCHAR(100)))
	SET @i = @i + 1
END

INSERT dbo.FoodTable (name,status) VALUES (N'B?n DB', N'Full')
SELECT * FROM FoodTable

GO

CREATE PROC USP_GetTableList
AS
BEGIN
	SELECT * FROM dbo.FoodTable
END
GO


USE master
DROP DATABASE QuanLyQuanCafe
GO

