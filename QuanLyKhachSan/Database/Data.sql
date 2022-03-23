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
	type Int NOT NULL, --Loại 1 || Loại 2 || Loại 3 
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