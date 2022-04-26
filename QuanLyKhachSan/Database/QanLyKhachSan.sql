﻿CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

--USE  master

--Drop database QuanLyKhachSan

---------------------------------------------------------------------------
-- Phần tạo bảng



CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(100)  PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT DEFAULT 0 -- 0 là nhân viên, 1 là admin 
)
GO

CREATE TABLE LOAIPHONG
(
	MaLoaiPhong INT IDENTITY  PRIMARY KEY,
	TenLoaiPhong NVARCHAR(100) NOT NULL,
	DonGia	INT
)
GO

CREATE TABLE PHONG
(
	MaPhong INT IDENTITY  PRIMARY KEY,
	MaLoaiPhong INT NOT NULL,
	TenPhong NVARCHAR(100) NOT NULL,
	GhiChu NVARCHAR(500),
	TinhTrang INT DEFAULT 0, --- 0 là trống, 1 là có người
	--Tang INT NULL,

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)
)
GO

CREATE TABLE LOAIKHACHHANG
(
	MaLoaiKH INT IDENTITY  PRIMARY KEY,  --1 la NoiDia, 2 la NuocNgoai
	TenLoaiKH NVARCHAR(50) NOT NULL,
	HeSoPhuThu FLOAT
)
GO

CREATE TABLE KHACHHANG
(
	MaKH INT IDENTITY  PRIMARY KEY,
	TenKhachHang NVARCHAR(50) NOT NULL,
	CMND VARCHAR(15) NOT NULL,
	SDT VARCHAR(15),
	DiaChi NVARCHAR(500)
)
GO

CREATE TABLE PHIEUTHUEPHONG
(
	MaPhieu INT IDENTITY  PRIMARY KEY,
	MaPhong	INT NOT NULL,
	MaKH INT NOT NULL,
	MaLoaiKH INT NOT NULL,
	SoLuongKhach INT NOT NULL,
	NgayBatDau Date NOT NULL,
	NgayKetThuc	Date,

	FOREIGN KEY (MaLoaiKH) REFERENCES dbo.LOAIKHACHHANG(MaLoaiKH),
	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
	FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH)
)
GO

CREATE TABLE HOADON
(
	MaHD INT IDENTITY  PRIMARY KEY,
	MaKH INT NOT NULL,
	TriGia INT NOT NULL DEFAULT 0,

	FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH)
)
GO

CREATE TABLE CHITIETHOADON
(
	MaHD INT NOT NULL  PRIMARY KEY,
	MaPhong INT NOT NULL,
	SoNgayThue Int NOT NULL,
	ThanhTien Int NOT NULL DEFAULT 0,
	NgayThanhToan Date,
	DonGia INT NOT NULL DEFAULT 0,

	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
)
GO


CREATE TABLE THAMSO
(
	KhachToiDa Int,
	DonGiaPhongCho Int,
	PhuThuTuKhach FLOAT

)
GO

----------------------------------------------------------------------------
--Phần tạo PROC
-- Tạo phiếu thuê phòng cho phòng theo id phòng
CREATE PROC USP_InsertRentalVoucher
@idRoom INT, @idClient INT, @MaLoaiKH INT, @countPeople INT
AS
BEGIN
	INSERT INTO dbo.PHIEUTHUEPHONG
			(	
				MaPhong,
				MaKH,
				MaLoaiKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(	
				@idRoom,
				@idClient,
				@MaLoaiKH,
				@countPeople,
				GETDATE(),
				NULL
			)
END
GO

CREATE PROC USP_InsertClient
	@TenKhachHang NVARCHAR(50),--(50) NOT NULL,
	@CMND VARCHAR(15),--(15) NOT NULL,
	@SDT VARCHAR(15),--(15),
	@DiaChi NVARCHAR(500) 
AS
BEGIN
	INSERT INTO dbo.KHACHHANG
			(	
				TenKhachHang,
				CMND,
				DiaChi,
				SDT
			)
VALUES		(	
				@TenKhachHang,
				@CMND,
				@DiaChi,
				@SDT
			)
END
GO

---------------------------------------------------------------------------
-- Phần tạo rằng buộc 
--rằng buộc đăng nhập
CREATE PROC USP_Login
@UserName NVARCHAR(100), @PassWord NVARCHAR(1000)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = @UserName AND MatKhau = @PassWord
END
GO





---------------------------------------------------------------------------
-- Phần thêm dữ liệu

INSERT INTO dbo.TAIKHOAN
			( TenDangNhap,
			  TenHienThi,
			  MatKhau,
			  LoaiTaiKhoan
			)
VALUES       	( N'admin',
			  N'admin',
			  N'0',
			  1 -- MÌNH CẦN MỘT TÀI KHOẢN ADMIN ĐỂ TEST
			)
GO

INSERT INTO dbo.TAIKHOAN
			( TenDangNhap,
			  TenHienThi,
			  MatKhau,
			  LoaiTaiKhoan
			)
VALUES       	( N'Vinh',
			  N'Vinh',
			  N'1',
			  0
			)
GO
--USE QuanLyKS1
INSERT INTO dbo.LOAIPHONG
			(	
				TenLoaiPhong,
				DonGia
			)
VALUES      	 (
				N'A',
				150
			)
GO

INSERT INTO dbo.LOAIPHONG
			(	
				TenLoaiPhong,
				DonGia
			)
VALUES      	 (
				N'B',
				170
			)
GO

INSERT INTO dbo.LOAIPHONG
			(	
				TenLoaiPhong,
				DonGia
			)
VALUES      	 (
				N'C',
				200
			)
GO

INSERT INTO dbo.PHONG
			(	
				MaLoaiPhong ,
				TenPhong ,
				GhiChu ,
				TinhTrang
			)
VALUES 	    	  (	
				'3',
				N'101',
				'',
				0
			)
GO

INSERT INTO dbo.PHONG
			(
				MaLoaiPhong ,
				TenPhong ,
				GhiChu ,
				TinhTrang
			)
VALUES      	 (
				'2',
				N'102',
				'Khong co den',
				0
			)
GO

INSERT INTO dbo.PHONG
			(
				MaLoaiPhong ,
				TenPhong ,
				GhiChu ,
				TinhTrang
			)
VALUES       	(
				'0001',
				N'103',
				'',
				0
			)
GO

INSERT INTO dbo.LOAIKHACHHANG
			(
				TenLoaiKH,
				HeSoPhuThu
			)
VALUES		(
				N'NoiDia',
				1
			)
GO
INSERT INTO dbo.LOAIKHACHHANG
			(
				TenLoaiKH,
				HeSoPhuThu
			)
VALUES		(
				N'NuocNgoai',
				1.5
			)
GO

