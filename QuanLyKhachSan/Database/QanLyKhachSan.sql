CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

--USE  master

--Drop database QuanLyKhachSan

---------------------------------------------------------------------------
-- Phần tạo bảng
--SELECT * FROM PHONG
--SELECT * FROM KHACHHANG
--SELECT * FROM TAIKHOAN
--SELECT TIEUDE, NOIDUNG FROM THONGBAO GROUP BY TIEUDE, NOIDUNG
--DELETE dbo.THONGBAO WHERE TieuDe = ''
CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(100)  PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT DEFAULT 0, check(LoaiTaiKhoan = 0 or LoaiTaiKhoan = 1 or LoaiTaiKhoan = 3) -- 0 là loại TK của nhân viên, 1 là loại TK của admin , 3 là loại TK của khách hàng
)
GO

CREATE TABLE THONGBAO
(
	MaThongBao INT IDENTITY PRIMARY KEY,
	TenDangNhap NVARCHAR(100) NOT NULL,
	NgayThongBao DATETIME,
	TieuDe NVARCHAR(1000) NOT NULL DEFAULT '',
	NoiDung NVARCHAR(3000),

	FOREIGN KEY (TenDangNhap) REFERENCES dbo.TAIKHOAN(TenDangNhap)
)
GO

CREATE TABLE LOAIPHONG
(
	MaLoaiPhong INT IDENTITY PRIMARY KEY,
	TenLoaiPhong NVARCHAR(100) NOT NULL,
	DonGia	INT
)
GO

CREATE TABLE PHONG
(
	MaPhong INT IDENTITY PRIMARY KEY,
	MaLoaiPhong INT NOT NULL,
	TenPhong NVARCHAR(100) NOT NULL,
	GhiChu NVARCHAR(500),
	TinhTrang INT DEFAULT 0, 

	check(TinhTrang = 0 or TinhTrang = 1), --- 0 là trống, 1 là có người
	
	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)
)
GO

CREATE TABLE LOAIKHACHHANG
(
	MaLoaiKH INT IDENTITY PRIMARY KEY,  --1 la NoiDia, 2 la NuocNgoai
	TenLoaiKH NVARCHAR(50) NOT NULL,
	HeSoPhuThu FLOAT
)
GO

CREATE TABLE KHACHHANG
(
	MaKH INT IDENTITY PRIMARY KEY,
	TenKhachHang NVARCHAR(50) NOT NULL,
	CMND VARCHAR(15) NOT NULL,
	SDT VARCHAR(15)  NOT NULL,
	DiaChi NVARCHAR(500)

	--CONSTRAINT PK_Person PRIMARY KEY (MaKH, CMND, SDT)
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
--ALTER TABLE dbo.KHACHHANG ADD CONSTRAINT PK_Person PRIMARY KEY (CMND, SDT)
--GO

CREATE TABLE HOADON
(
	MaHD INT IDENTITY PRIMARY KEY,
	MaPhong INT NOT NULL,
	SoNgayThue Int NOT NULL,
	ThanhTien Int NOT NULL DEFAULT 0,
	NgayThanhToan Date,
	DonGia INT NOT NULL DEFAULT 0,
	TrangThai INT NOT NULL DEFAULT 0 --- 0 là chưa thanh toán, 1 là đã thanh toán,

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
)
GO

CREATE TABLE THAMSO
(
	ID INT DEFAULT 1,
	KhachToiDa Int,
	DonGiaPhongCho Int,
	PhuThuTuKhach FLOAT,
	check(ID = 1)
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

--ALTER TABLE dbo.KHACHHANG ADD CONSTRAINT PK_Person PRIMARY KEY (MaKH,CMND, SDT)



---------------------------------------------------------------------------
-- Phần thêm dữ liệu

INSERT INTO dbo.THAMSO (KhachToiDa, DonGiaPhongCho, PhuThuTuKhach) VALUES (3, 2, 0.25) 

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

USP_InsertClient
@TenKhachHang=[Nguyễn Văn A],
@CMND='123',
@SDT='123',
@DiaChi=[Việt Nam]