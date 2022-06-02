CREATE DATABASE QuanLyKS1
GO

USE QuanLyKS1
GO

--USE  master

--Drop database QuanLyKS1

---------------------------------------------------------------------------
-- Phần tạo bảng



CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(100)  PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT -- 0 là nhân viên, 1 là admin 
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
	TinhTrang INT, --- 0 là trống, 1 là có người
	--Tang INT NULL,

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)
)
GO

CREATE TABLE LOAIKHACHHANG
(
	MaLoaiKH INT IDENTITY  PRIMARY KEY,
	TenLoaiKH NVARCHAR(50) NOT NULL,
	HeSoPhuThu FLOAT
)
GO

CREATE TABLE KHACHHANG
(
	MaKH INT IDENTITY  PRIMARY KEY,
	TenKhachHang NVARCHAR(50) NOT NULL,
	CMND VARCHAR(15),
	DiaChi NVARCHAR(500),

	MaLoaiKH INT NOT NULL,

	FOREIGN KEY (MaLoaiKH) REFERENCES dbo.LOAIKHACHHANG(MaLoaiKH)
)
GO

CREATE TABLE PHIEUTHUEPHONG
(
	MaPhieu INT IDENTITY  PRIMARY KEY,
	MaPhong	INT NOT NULL,
	MaKH INT NOT NULL,
	SoLuongKhach INT,
	NgayBatDau Date NOT NULL,
	NgayKetThuc	Date ,


	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
	FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH)
)
GO

CREATE TABLE HOADON
(
	MaHD INT IDENTITY  PRIMARY KEY,
	MaPhieu INT NOT NULL,
	TriGia INT,

	FOREIGN KEY (MaPhieu) REFERENCES dbo.PHIEUTHUEPHONG(MaPhieu)
)
GO

CREATE TABLE CHITIETHOADON
(
	MaHD INT NOT NULL  PRIMARY KEY,
	MaPhong INT NOT NULL,
	SoNgayThue Int,
	ThanhTien Int,
	NgayThanhToan Date,
	DonGia INT,

	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
)
GO

CREATE TABLE BAOCAODOANHTHU
(
	MaBaoCao INT IDENTITY  PRIMARY KEY,
	Thang Int,
	Nam Int,
	TongDoanhThu INT

)
GO

CREATE TABLE CHITIETBAOCAO
(
	MaBaoCao INT NOT NULL  PRIMARY KEY,
	NgayThanhToan Date,
	DoanhThu Int,
	TyLe Int,

	FOREIGN KEY (MaBaoCao) REFERENCES dbo.BAOCAODOANHTHU(MaBaoCao)
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
@idRoom INT, @idClient INT, @countPeople INT
AS
BEGIN
	INSERT INTO dbo.PHIEUTHUEPHONG
			(	
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(	
				@idRoom,
				@idClient,
				@countPeople,
				GETDATE(),
				NULL
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
				1
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

---BỔ XUNG THÊM

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

INSERT INTO dbo.KHACHHANG
			(	
				TenKhachHang,
				CMND,
				DiaChi,
				MaLoaiKH
			)
VALUES		(	
				N'Dang',
				N'000000000',
				N'CaMau',
				1
			)
GO

INSERT INTO dbo.KHACHHANG
			(
				TenKhachHang,
				CMND,
				DiaChi,
				MaLoaiKH
			)
VALUES		(
				N'Vinh',
				N'111111111',
				N'SaiGon',
				1
			)
GO

INSERT INTO dbo.KHACHHANG
			(
				TenKhachHang,
				CMND,
				DiaChi,
				MaLoaiKH
			)
VALUES		(
				N'Dat',
				N'222222222',
				N'HaNoi',
				1
			)
GO

INSERT INTO dbo.KHACHHANG
			(	
				TenKhachHang,
				CMND,
				DiaChi,
				MaLoaiKH
			)
VALUES		(	
				N'Quoc',
				N'333333333',
				N'Helsinki',
				2
			)
GO

INSERT INTO dbo.KHACHHANG
			(	
				TenKhachHang,
				CMND,
				DiaChi,
				MaLoaiKH
			)
VALUES		(	
				N'Kiet',
				N'444444444',
				N'VungTau',
				2
			)
GO

INSERT INTO dbo.PHIEUTHUEPHONG
			(	
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(	
				1,
				N'0001',
				3,
				'2022/4/21',
				'2022/4/25'
			)
GO

INSERT INTO dbo.PHIEUTHUEPHONG
			(	
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(	 --T KHÔNG BIẾT LÀ PHIẾU THUÊ PHÒNG CỦA MỘT PHÒNG DUY NHẤT THÌ CÓ CẦN KHÁC MÃ KHÔNG?
				1,
				2,
				3,
				'2022/4/21',
				'2022/4/21'
			)
GO

INSERT INTO dbo.PHIEUTHUEPHONG
			(	
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(	
				1,
				3,
				3,
				'2022/4/21',
				'2022/4/25'
			)
GO

INSERT INTO dbo.PHIEUTHUEPHONG
			(
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(
				3,
				4,
				1,
				'2022/4/23',
				'2022/4/25'
			)
GO

INSERT INTO dbo.PHIEUTHUEPHONG
			(
				MaPhong,
				MaKH,
				SoLuongKhach,
				NgayBatDau,
				NgayKetThuc 
			)
VALUES		(
				2,
				5,
				1,
				'2022/3/19',
				'2022/3/24'
			)
GO

INSERT INTO dbo.HOADON
			(
				MaKH,
				TriGia 
			)
VALUES		(
				1,
				1000 -- 250 * 4
			)
GO

INSERT INTO dbo.HOADON
			(
				MaKH,
				TriGia 
			)
VALUES		(	
				2,
				1000
			)
GO

INSERT INTO dbo.HOADON
			(
				MaKH,
				TriGia 
			)
VALUES		(
				3,
				1000
			)
GO

INSERT INTO dbo.HOADON
			(
				MaKH,
				TriGia 
			)
VALUES		(
				4,
				450
			)
GO

INSERT INTO dbo.HOADON
			(
				MaKH,
				TriGia 
			)
VALUES		(
				5,
				850
			)
GO

INSERT INTO dbo.CHITIETHOADON
			(	MaHD,
				MaPhong,
				SoNgayThue,
				ThanhTien,
				NgayThanhToan,
				DonGia
			)
VALUES		(	1,
				1,
				4,
				1000, 
				'2022/4/25',
				200
			)
GO

INSERT INTO dbo.CHITIETHOADON
			(	MaHD,
				MaPhong,
				SoNgayThue,
				ThanhTien,
				NgayThanhToan,
				DonGia
			)
VALUES		(	2,
				3,
				2,
				450, 
				'2022/4/25',
				150
			)
GO

INSERT INTO dbo.CHITIETHOADON
			(	MaHD,
				MaPhong,
				SoNgayThue,
				ThanhTien,
				NgayThanhToan,
				DonGia
			)
VALUES		(	3,
				2,
				5,
				850, 
				'2022/3/24',
				170
			)
GO

INSERT INTO dbo.BAOCAODOANHTHU
			(	
				Thang,
				Nam,
				TongDoanhThu
			)
VALUES		(	
				3,
				2022,
				850
			)
GO

INSERT INTO dbo.BAOCAODOANHTHU
			(	
				Thang,
				Nam,
				TongDoanhThu
			)
VALUES		(	
				4,
				2022,
				1450
			)
GO

INSERT INTO dbo.BAOCAODOANHTHU
			(	
				Thang,
				Nam,
				TongDoanhThu
			)
VALUES		(	
				4,
				2022,
				1500
			)
GO

INSERT INTO dbo.CHITIETBAOCAO
			(	MaBaoCao,
				NgayThanhToan,
				DoanhThu,
				TyLe
			)
VALUES		(	1,
				'2022/3/24',
				850,
				0.3696
			)
GO

INSERT INTO dbo.CHITIETBAOCAO
			(	MaBaoCao,
				NgayThanhToan,
				DoanhThu,
				TyLe
			)
VALUES		(	2,
				'2022/4/25',
				450,
				0.1957
			)
GO

INSERT INTO dbo.CHITIETBAOCAO
			(	MaBaoCao,
				NgayThanhToan,
				DoanhThu,
				TyLe
			)
VALUES		(	3,
				'2022/4/25',
				1000,
				0.4347
			)
GO

--INSERT INTO dbo.THAMSO
--			(	KhachToiDa,
--				TyLe,
--				PhuThuTuKhach
--			)
--VALUES		(	3,
--				,
--				,--CÁI PHỤ THU VỚI CÁI TỶ LỆ NÀY LÀ GÌ VẬY?
--			)
--GO

-- Load ds phòng
--SELECT MaPhong as id, TenPhong as name, TinhTrang as status, TenLoaiPhong as type, DonGia as price
--FROM dbo.PHONG p, dbo.LOAIPHONG lp 
--WHERE p.MaLoaiPhong = lp.MaLoaiPhong
--GO

--SELECT MaPhong as id, TenPhong as name, TinhTrang as status, TenLoaiPhong as type, DonGia as price FROM dbo.PHONG p, dbo.LOAIPHONG lp WHERE p.MaLoaiPhong = lp.MaLoaiPhong