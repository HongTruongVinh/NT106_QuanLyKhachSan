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
--SELECT * FROM TINNHAN
--DELETE TINNHAN WHERE UserNameKhachHang = '123'
--DELETE TAIKHOAN WHERE TenDangNhap = '123'
--DELETE THONGBAO WHERE TenDangNhap = '12345'
--INSERT INTO dbo.THONGBAO ( TenDangNhap , TieuDe , NoiDung, NgayThongBao) VALUES ( '12345' , 'sdfs' , 'fsdf', '6/14/2022')

CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(100)  PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT DEFAULT 0, check(LoaiTaiKhoan = 0 or LoaiTaiKhoan = 1 or LoaiTaiKhoan = 3) -- 0 là loại TK của nhân viên, 1 là loại TK của admin , 3 là loại TK của khách hàng
)
GO
--UPDATE dbo.TAIKHOAN SET MatKhau = '0' WHERE TenDangNhap = 'Vinh'
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
--SELECT p.MaPhong, p.TenPhong, p.GhiChu, kh.TenKhachHang FROM PHONG p, PHIEUTHUEPHONG ptp, KHACHHANG kh WHERE ptp.MaKH = kh.MaKH AND ptp.MaPhong = p.MaPhong AND kh.MaKH = 7
CREATE TABLE LOAIKHACHHANG
(
	MaLoaiKH INT IDENTITY PRIMARY KEY,  --1 la NoiDia, 2 la NuocNgoai
	TenLoaiKH NVARCHAR(50) NOT NULL,
	HeSoPhuThu FLOAT
)
GO
--UPDATE dbo.PHONG SET TinhTrang = 0 WHERE MaPhong = 4
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
	MaKH INT NOT NULL,
	MaPhong INT NOT NULL,
	SoNgayThue Int NOT NULL,
	ThanhTien Int NOT NULL DEFAULT 0,
	NgayThanhToan Date,
	DonGia INT NOT NULL DEFAULT 0,
	TrangThai INT NOT NULL DEFAULT 0, --- 0 là chưa thanh toán, 1 là đã thanh toán

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
	FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH)
)
GO

CREATE TABLE THAMSO
(
	ID INT DEFAULT 1,
	KhachToiDa Int,
	DonGiaPhongCho Int,
	PhuThuTuKhach FLOAT,
	PhuThuTuKhachNuocNgoai FLOAT DEFAULT 0,
	check(ID = 1)
)
GO

CREATE TABLE TINNHAN
(
	MaTN INT IDENTITY PRIMARY KEY,
	UserNameNhanVien NVARCHAR(100) NOT NULL,
	UserNameKhachHang NVARCHAR(100) NOT NULL,
	NoiDung NVARCHAR(3000), 

	FOREIGN KEY (UserNameNhanVien) REFERENCES dbo.TAIKHOAN(TenDangNhap),
	FOREIGN KEY (UserNameKhachHang) REFERENCES dbo.TAIKHOAN(TenDangNhap)
)
GO
GO
--drop table THAMSO
















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

---Proc lấy danh sách bill theo năm---
CREATE PROC USP_GetListBillByYear 
@year INT
AS
BEGIN
	SELECT MONTH(NgayThanhToan) AS 'THANG', COUNT(MaHD) 'SỐ HÓA ĐƠN', SUM(ThanhTien) AS 'DOANH THU'
	FROM HOADON
	WHERE	TrangThai = 1 AND
			YEAR(NgayThanhToan) = @year
	GROUP BY MONTH(NgayThanhToan)
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

INSERT INTO dbo.TAIKHOAN
			( TenDangNhap,
			  TenHienThi,
			  MatKhau,
			  LoaiTaiKhoan
			)
VALUES       	( N'admin',
			  N'admin',
			  N'c4ca4238a0b923820dcc509a6f75849b',
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
			  N'cfcd208495d565ef66e7dff9f98764da',
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

INSERT INTO THAMSO
(
	ID,
	KhachToiDa,
	DonGiaPhongCho,
	PhuThuTuKhach,
	PhuThuTuKhachNuocNgoai
)
VALUES
(
	1,
	3,
	2,
	1,
	1.5
)

INSERT INTO HOADON
(
	MaKH,
	MaPhong,
	SoNgayThue,
	ThanhTien,
	NgayThanhToan,
	DonGia,
	TrangThai --- 0 là chưa thanh toán, 1 là đã thanh toán
)
VALUES
(
	1,
	2,
	2,
	3000,
	'20220601',
	1000,
	1
)

INSERT INTO HOADON
(
	MaKH,
	MaPhong,
	SoNgayThue,
	ThanhTien,
	NgayThanhToan,
	DonGia,
	TrangThai --- 0 là chưa thanh toán, 1 là đã thanh toán
)
VALUES
(
	1,
	2,
	5,
	5000,
	'20220710',
	2000,
	1
)

INSERT INTO HOADON
(
	MaKH,
	MaPhong,
	SoNgayThue,
	ThanhTien,
	NgayThanhToan,
	DonGia,
	TrangThai --- 0 là chưa thanh toán, 1 là đã thanh toán
)
VALUES
(
	1,
	2,
	3,
	4000,
	'20220715',
	2000,
	1
)

INSERT INTO HOADON
(
	MaKH,
	MaPhong,
	SoNgayThue,
	ThanhTien,
	NgayThanhToan,
	DonGia,
	TrangThai --- 0 là chưa thanh toán, 1 là đã thanh toán
)
VALUES
(
	1,
	3,
	5,
	10000,
	'20160601',
	2000,
	1
)

INSERT INTO KHACHHANG
(
	TenKhachHang,
	CMND,
	SDT,
	DiaChi
)
VALUES
(
	N'BUI HAI DANG',
	'1234',
	'1234',
	'1234'
)

INSERT INTO HOADON
(
	MaKH,
	MaPhong,
	SoNgayThue,
	ThanhTien,
	NgayThanhToan,
	DonGia,
	TrangThai --- 0 là chưa thanh toán, 1 là đã thanh toán
)
VALUES
(
	5,
	1,
	1,
	10000,
	'20221201',
	2000,
	0
)