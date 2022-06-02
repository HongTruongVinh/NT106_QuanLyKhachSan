USE QuanLyKhachSan

--DELETE dbo.KHACHHANG
--DELETE dbo.PHIEUTHUEPHONG


SELECT * FROM KHACHHANG

SELECT * FROM PHIEUTHUEPHONG

SELECT * FROM PHONG


SELECT * FROM KHACHHANG kh, PHIEUTHUEPHONG ptp WHERE kh.MaKH = ptp.MaKH AND ptp.MaKH = 16 

SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, SDT numberPhone FROM dbo.KHACHHANG WHERE MaKH = '1'


SELECT MaPhieu id, MaPhong roomID, ptp.MaKH ClientID, NgayBatDau dateTimeCheckIn, NgayKetThuc dateTimeCheckOut, SoLuongKhach countPeople , TenLoaiKH typeCLient, HeSoPhuThu dependencyFactor
FROM dbo.PHIEUTHUEPHONG ptp, dbo.LOAIKHACHHANG lkh 
WHERE ptp.MaLoaiKH = lkh.MaLoaiKH AND  MaPhong = 2