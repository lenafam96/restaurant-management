USE quanlynhahang
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ListHoaDon')
	DROP VIEW ListHoaDon
GO

CREATE VIEW ListHoaDon AS 
SELECT maHoaDon,
       NhanVien.hoTen AS tenNhanVien,
       CASE KhachHang.hoTen WHEN N'Khách vãng lai' THEN ''
	   ELSE KhachHang.hoTen END AS tenKhachHang,
       maBan,
       diemCong,
       diemTru,
       ngayTao,
       ngayThanhToan,
	   Voucher.moTa AS Voucher,
       tongTien,
       CASE trangThai WHEN 0 THEN 'Chưa thanh toán'
	   ELSE 'Đã thanh toán'
	   END AS trangThai
FROM dbo.HoaDon
INNER JOIN dbo.NhanVien ON NhanVien.maNhanVien = HoaDon.maNhanVien
INNER JOIN dbo.KhachHang ON KhachHang.maKhachHang = HoaDon.maKhachHang
INNER JOIN dbo.Voucher ON Voucher.maVoucher = HoaDon.maVoucher
WHERE trangThai NOT LIKE -1
