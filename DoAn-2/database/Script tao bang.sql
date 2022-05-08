USE master
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'quanlynhahang')
BEGIN
    ALTER DATABASE quanlynhahang SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE quanlynhahang
END
GO

CREATE DATABASE quanlynhahang
GO

USE quanlynhahang
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'PhanQuyen')
	DROP TABLE PhanQuyen
GO

CREATE TABLE PhanQuyen
(
	role INT PRIMARY KEY, --0: admin, 1: quản kho, 2: thu ngân, 3: order
	nameRole NVARCHAR(20),
	quyenBan BIT,
	quyenNhanVien BIT,
	quyenKhachHang BIT,
	quyenVoucher BIT,
	quyenThongKe BIT,
	quyenKho BIT,
	quyenThietLap BIT
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'NhanVien')
	DROP TABLE NhanVien
GO

CREATE TABLE NhanVien
(
	maNhanVien INT IDENTITY PRIMARY KEY,
	hoTen NVARCHAR(50) NOT NULL,
	ngaySinh DATE NOT NULL,
	gioiTinh NVARCHAR(5) NOT NULL DEFAULT 'Nam',
	chucVu NVARCHAR(50),
	sdt VARCHAR(15) NOT NULL,
	cccd VARCHAR(15),
	luong INT NOT NULL DEFAULT 0,
	xoa INT NOT NULL DEFAULT 0, -- 1 là xoá

	CHECK(YEAR(GETDATE()) - YEAR(ngaySinh) >= 18)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'TaiKhoan')
	DROP TABLE TaiKhoan
GO

CREATE TABLE TaiKhoan
(
	userName VARCHAR(30) PRIMARY KEY,
	maNhanVien INT NOT NULL,
	passWord VARCHAR(50) NOT NULL,
	role INT NOT NULL, 
	
	FOREIGN KEY(maNhanVien) REFERENCES dbo.NhanVien(maNhanVien),
	FOREIGN KEY(role) REFERENCES dbo.PhanQuyen(role)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DanhMucMon')
	DROP TABLE DanhMucMon
GO

CREATE TABLE DanhMucMon
(
	maDanhMucMon INT IDENTITY PRIMARY KEY,
	tenDanhMucMon NVARCHAR(50) NOT NULL,
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ThucPham')
	DROP TABLE ThucPham
GO

CREATE TABLE ThucPham
(
	maThucPham INT IDENTITY PRIMARY KEY,
	tenThucPham NVARCHAR(50) NOT NULL,
	donViTinh NVARCHAR(50) NOT NULL,
	tonKho INT NOT NULL DEFAULT 0,	
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'MonAn')
	DROP TABLE MonAn
GO

CREATE TABLE MonAn
(
	maMonAn INT IDENTITY PRIMARY KEY,
	tenMonAn NVARCHAR(50) NOT NULL,
	gia INT NOT NULL,
	maDanhMucMon INT NOT NULL,
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá

	FOREIGN KEY(maDanhMucMon) REFERENCES dbo.DanhMucMon(maDanhMucMon)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ChiTietMonAn')
	DROP TABLE ChiTietMonAn
GO

CREATE TABLE ChiTietMonAn
(
	maMonAn INT NOT NULL,
	maThucPham INT NOT NULL,
	soLuong INT NOT NULL DEFAULT 0,

	PRIMARY KEY(maMonAn,maThucPham),
	FOREIGN KEY(maMonAn) REFERENCES dbo.MonAn(maMonAn),
	FOREIGN KEY(maThucPham) REFERENCES dbo.ThucPham(maThucPham)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'NhaCungCap')
	DROP TABLE NhaCungCap
GO

CREATE TABLE NhaCungCap
(
	maNhaCungCap INT IDENTITY PRIMARY KEY,
	tenNhaCungCap NVARCHAR(50) NOT NULL,
	diaChi NVARCHAR(200),
	sdt VARCHAR(15) NOT NULL,
	email VARCHAR(50),
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'PhieuNhap')
	DROP TABLE PhieuNhap
GO

CREATE TABLE PhieuNhap
(
	maPhieuNhap INT IDENTITY PRIMARY KEY,
	maNhaCungCap INT NOT NULL,
	ngayNhap DATE NOT NULL DEFAULT GETDATE(),
	tongTien INT,
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá
	
	FOREIGN KEY(maNhaCungCap) REFERENCES dbo.NhaCungCap(maNhaCungCap)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ChiTietPhieuNhap')
	DROP TABLE ChiTietPhieuNhap
GO

CREATE TABLE ChiTietPhieuNhap
(
	maPhieuNhap INT NOT NULL,
	maThucPham INT NOT NULL,
	soLuong INT NOT NULL DEFAULT 0,
	gia INT NOT NULL DEFAULT 0,

	PRIMARY KEY(maPhieuNhap,maThucPham),
	FOREIGN KEY(maPhieuNhap) REFERENCES dbo.PhieuNhap(maPhieuNhap),
	FOREIGN KEY(maThucPham) REFERENCES dbo.ThucPham(maThucPham)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'KhachHang')
	DROP TABLE KhachHang
GO

CREATE TABLE KhachHang
(
	maKhachHang INT IDENTITY PRIMARY KEY,
	hoTen NVARCHAR(50),
	ngaySinh DATE,
	gioiTinh NVARCHAR(5) NOT NULL DEFAULT 'Nam',
	sdt VARCHAR(15) NOT NULL,
	diemTichLuy INT NOT NULL DEFAULT 0,
	xoa INT NOT NULL DEFAULT 0 -- 1 là xoá
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Voucher')
	DROP TABLE Voucher
GO

CREATE TABLE Voucher
(
	maVoucher INT IDENTITY PRIMARY KEY,
	ngayBatDau DATE NOT NULL DEFAULT GETDATE(),
	ngayKetThuc DATE,
	moTa NVARCHAR(300),
	giaTri INT NOT NULL DEFAULT 0,
	loai INT NOT NULL DEFAULT 0, --0: theo %, 1: theo tiền mặt
	xoa INT NOT NULL DEFAULT 0, -- 1 là xoá

	CHECK (ngayBatDau<=ngayKetThuc)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Ban')
	DROP TABLE Ban
GO

CREATE TABLE Ban
(
	maBan INT PRIMARY KEY,
	trangThai INT NOT NULL DEFAULT 0, -- 0: trống, 1: có khách
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'HoaDon')
	DROP TABLE HoaDon
GO

CREATE TABLE HoaDon
(
	maHoaDon INT IDENTITY PRIMARY KEY,
	maNhanVien INT NOT NULL, -- Mã nhân viên order
	maKhachHang INT NOT NULL DEFAULT 1, -- 1: không có mã khách hàng
	maBan INT NOT NULL,
	diemCong INT NOT NULL DEFAULT 0,
	diemTru INT NOT NULL DEFAULT 0,
	ngayTao DATETIME NOT NULL DEFAULT GETDATE(),
	ngayThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
	tongTien INT NOT NULL DEFAULT 0,
	maVoucher INT NOT NULL DEFAULT 1, -- 1: không có mã giảm giá
	trangThai INT NOT NULL DEFAULT 0 -- 0: chưa thanh toán, 1: đã thanh toán, -1: xoá

	FOREIGN KEY(maNhanVien) REFERENCES dbo.NhanVien(maNhanVien),
	FOREIGN KEY(maKhachHang) REFERENCES dbo.KhachHang(maKhachHang),
	FOREIGN KEY(maVoucher) REFERENCES dbo.Voucher(maVoucher),
	FOREIGN KEY(maBan) REFERENCES dbo.Ban(maBan),
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ChiTietHoaDon')
	DROP TABLE ChiTietHoaDon
GO

CREATE TABLE ChiTietHoaDon
(
	maHoaDon INT NOT NULL,
	maMonAn INT NOT NULL,
	soLuong INT NOT NULL DEFAULT 0,

	PRIMARY KEY(maHoaDon,maMonAn),
	FOREIGN KEY(maHoaDon) REFERENCES dbo.HoaDon(maHoaDon),
	FOREIGN KEY(maMonAn) REFERENCES dbo.MonAn(maMonAn)
)
GO
