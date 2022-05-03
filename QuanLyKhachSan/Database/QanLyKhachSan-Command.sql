USE QuanLyKhachSan

--DELETE dbo.KHACHHANG
--DELETE dbo.PHIEUTHUEPHONG


SELECT * FROM KHACHHANG

SELECT * FROM PHIEUTHUEPHONG

SELECT * FROM PHONG

SELECT * FROM HOADON

--Update dbo.PHONG SET TinhTrang = 0 WHERE MaPhong = 2


SELECT * FROM KHACHHANG kh, PHIEUTHUEPHONG ptp WHERE kh.MaKH = ptp.MaKH AND ptp.MaKH = 16 

SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, SDT numberPhone FROM dbo.KHACHHANG WHERE MaKH = '1'


SELECT MaPhieu id, MaPhong roomID, ptp.MaKH ClientID, NgayBatDau dateTimeCheckIn, NgayKetThuc dateTimeCheckOut, SoLuongKhach countPeople , TenLoaiKH typeCLient, HeSoPhuThu dependencyFactor
FROM dbo.PHIEUTHUEPHONG ptp, dbo.LOAIKHACHHANG lkh 
WHERE ptp.MaLoaiKH = lkh.MaLoaiKH AND  MaPhong = 2


---Load list vé thuê phòng đang có người dùng
SELECT ptp.MaKH clientID, p.MaPhong roomID, TenPhong roomName, TenKhachHang nameClient, SDT numberPhone, DiaChi adsress, CMND, lkh.MaLoaiKH typeClient, SoLuongKhach  FROM dbo.PHIEUTHUEPHONG ptp, dbo.PHONG p, dbo.KHACHHANG kh, dbo.LOAIKHACHHANG lkh WHERE p.TinhTrang = 1 AND ptp.MaPhong = p.MaPhong AND ptp.MaKH = kh.MaKH AND ptp.MaLoaiKH = lkh.MaLoaiKH