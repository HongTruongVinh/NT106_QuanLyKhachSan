USE QuanLyKS

SELECT * FROM dbo.PHONG

SELECT * FROM dbo.LOAIKHACHHANG

SELECT * FROM dbo.HOADON

SELECT * FROM dbo.PHIEUTHUEPHONG

-- Load ds phòng
SELECT MaPhong as id, TenPhong as name, TinhTrang as status, TenLoaiPhong as type, DonGia as price
FROM dbo.PHONG p, dbo.LOAIPHONG lp 
WHERE p.MaLoaiPhong = lp.MaLoaiPhong
GO

-- Load thông tin phòng // rental voucher
SELECT TenKhachHang name, CMND idPerson, DiaChi address, TenLoaiKH typeClient, HeSoPhuThu dependencyFactor 
FROM dbo.KHACHHANG kh, dbo.LOAIKHACHHANG lkh
WHERE kh.MaLoaiKH = lkh.MaLoaiKH AND kh.MaKH = '0003'
GO

-- LOAD PHIEUTHUEPHONG từ id phòng
SELECT MaPhieu id, MaPhong roomID, MaKH ClientID, NgayBatDau dateTimeCheckIn, NgayKetThuc dateTimeCheckOut, SoLuongKhach numberPeople
FROM dbo.PHIEUTHUEPHONG
WHERE MaPhong = '101'