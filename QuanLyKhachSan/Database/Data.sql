CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

--Phong
--Account
--Bill


CREATE TABLE Account
(
	UserName NVARCHAR(100)  PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
)
GO

CREATE TABLE Client
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	birthday DATETIME NOT NULL,
	phone INT NOT NULL,
	sex Int, -- 0 la nam || 1 la nu
	CMND NVARCHAR(100) NOT NULL,
	Address NVARCHAR(1000),
	nationality NVARCHAR(100)
)
GO

CREATE TABLE Room
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL  DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) NOT NULL, --Trống || Có người
	type NVARCHAR(100) NOT NULL, --Vip hoặc loại thường 
	price FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE NOT NULL,
	dateCheckOut DATE,
	idRoom INT NOT NULL,
	idClient INT NOT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT 0 --Thanh toan || chua thanh toan

	FOREIGN KEY (idRoom) REFERENCES dbo.Room(id),
	FOREIGN KEY (idClient) REFERENCES dbo.Client(id)
)
GO

USE QuanLyKhachSan
GO
INSERT INTO dbo.Account
			( UserName,
			  DisplayName,
			  Password
			)
VALUES       ( N'HongVinh',
			  N'Hong Truong Vinh',
			  N'1'
			)
GO

INSERT INTO dbo.Account
			( UserName,
			  DisplayName,
			  Password
			)
VALUES       ( N'staff',
			  N'staff',
			  N'1'
			)
GO

INSERT INTO dbo.Account
			( UserName,
			  DisplayName,
			  Password
			)
VALUES       ( N'admin',
			  N'admin',
			  N'0'
			)
GO
-------------------------------------------------------
USE QuanLyKhachSan
GO

CREATE PROC USP_Login
@UserName NVARCHAR(100), @PassWord NVARCHAR(1000)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @UserName AND PassWord = @PassWord
END
GO
-------------------------------------------------------
USE QuanLyKhachSan
GO

INSERT INTO dbo.Room VALUES (N'Phòng 101',N'Trống', N'Vip', 300000)
INSERT INTO dbo.Room VALUES (N'Phòng 102',N'Trống', N'Vip', 300000)
INSERT INTO dbo.Room VALUES (N'Phòng 103',N'Trống', N'Vip', 300000)
INSERT INTO dbo.Room VALUES (N'Phòng 104',N'Trống', N'Thường', 200000)
INSERT INTO dbo.Room VALUES (N'Phòng 105',N'Trống', N'Thường', 200000)
INSERT INTO dbo.Room VALUES (N'Phòng 106',N'Trống', N'Thường', 200000)

--DROP PROCEDURE [USP_GetRoomList];  
--GO

--ALTER TABLE dbo.Room
--ALTER COLUMN type NVARCHAR(100) NOT NULL
ALTER TABLE dbo.Room ADD floor INT NOT NULL
GO

CREATE PROC USP_GetRoomList
AS
BEGIN
	SELECT * FROM dbo.Room
END
GO

EXEC USP_GetRoomList

UPDATE dbo.Room SET STATUS = 'Có người' WHERE id = 4

-------------------------------------------------------