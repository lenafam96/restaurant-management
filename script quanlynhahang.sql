-- script tao bang
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

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'TaiKhoan')
    DROP TABLE TaiKhoan
GO

CREATE TABLE TaiKhoan
(
    userName VARCHAR(30) PRIMARY KEY,
    displayName NVARCHAR(50),
    passWord VARCHAR(50) NOT NULL,
    role INT NOT NULL, 

    FOREIGN KEY(role) REFERENCES dbo.PhanQuyen(role)
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

    CHECK(YEAR(GETDATE()) - YEAR(ngaySinh) >= 18)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DanhMucMon')
    DROP TABLE DanhMucMon
GO

CREATE TABLE DanhMucMon
(
    maDanhMucMon INT IDENTITY PRIMARY KEY,
    tenDanhMucMon NVARCHAR(50) NOT NULL,
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

    CHECK (ngayBatDau<=ngayKetThuc)
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Ban')
    DROP TABLE Ban
GO

CREATE TABLE Ban
(
    maBan INT IDENTITY PRIMARY KEY,
    trangThai INT NOT NULL DEFAULT 0, -- 0: trống, 1: có khách
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'HoaDon')
    DROP TABLE HoaDon
GO

CREATE TABLE HoaDon
(
    maHoaDon INT IDENTITY PRIMARY KEY,
    maNhanVien INT NOT NULL,
    maKhachHang INT NOT NULL DEFAULT -1, -- -1: không có mã khách hàng
    maBan INT NOT NULL,
    diemCong INT NOT NULL DEFAULT 0,
    diemTru INT NOT NULL DEFAULT 0,
    ngayThanhToan DATE NOT NULL DEFAULT GETDATE(),
    tongTien INT,
    maVoucher INT NOT NULL DEFAULT -1, -- -1: không có mã giảm giá
    trangThai INT NOT NULL DEFAULT 0 -- 0: chưa thanh toán, 1: đã thanh toán

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

    FOREIGN KEY(maHoaDon) REFERENCES dbo.HoaDon(maHoaDon),
    FOREIGN KEY(maMonAn) REFERENCES dbo.MonAn(maMonAn)
)
GO

-- script tao store procedure
USE quanlynhahang
GO

--0. Test connection
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'TESTCONNECTION')
    DROP PROC TESTCONNECTION
GO

CREATE PROC TESTCONNECTION
AS
BEGIN
    declare @result bit
    set @result=0
    IF object_id('Ban') is not null
        if object_id('ChiTietHoaDon') is not null
        if object_id('ChiTietMonAn') is not null
        if object_id('ChiTietPhieuNhap') is not null
        if object_id('DanhMucMon') is not null
        if object_id('HoaDon') is not null
        if object_id('KhachHang') is not null
        if object_id('MonAn') is not null
        if object_id('NhaCungCap') is not null
        if object_id('NhanVien') is not null
        if object_id('PhanQuyen') is not null
        if object_id('PhieuNhap') is not null
        if object_id('TaiKhoan') is not null
        if object_id('ThucPham') is not null
        if object_id('Voucher') is not null
        set @result=1
    select @result
END
GO

--1. Quản lý tài khoản
--1.1. Thêm tài khoản
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertAccount')
    DROP PROC USP_InsertAccount
GO

CREATE PROC USP_InsertAccount
@userName VARCHAR(30), @displayName NVARCHAR(50), @role INT
AS
BEGIN
    INSERT INTO dbo.TaiKhoan
    (
        userName,
        displayName,
        passWord,
        role
    )
    VALUES
    (   @userName, -- userName - varchar(30)
        @displayName, -- displayName - nvarchar(50)
        '1551321171111548020413130351851605666202196', -- passWord - varchar(50)
        @role   -- role - int
        )
END
GO
--1.2. Login
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_Login')
    DROP PROC USP_Login
GO

CREATE PROC USP_Login
@userName VARCHAR(30), @passWord VARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE userName = @userName AND passWord = @passWord
END
GO
--1.3. Cập nhập thông tin tài khoản
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateAccount')
    DROP PROC USP_UpdateAccount
GO

CREATE PROC USP_UpdateAccount
@userName VARCHAR(30), @displayName NVARCHAR(50), @passWord VARCHAR(50), @role INT
AS
BEGIN
    UPDATE dbo.TaiKhoan SET displayName = @displayName, passWord = @passWord, role = @role WHERE userName = @userName
END
GO
--1.4. Xoá tài khoản
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteAccount')
    DROP PROC USP_DeleteAccount
GO

CREATE PROC USP_DeleteAccount
@userName VARCHAR(30)
AS
BEGIN
    UPDATE dbo.TaiKhoan SET role = -1 WHERE userName = @userName
END
GO

--1.5. GetAccountList
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetAccountList')
    DROP PROC USP_GetAccountList
GO

CREATE PROC USP_GetAccountList
AS
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE role NOT LIKE -1
END
GO

--1.6. SreachUserByName
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_SreachUserByName')
    DROP PROC USP_SreachUserByName
GO

CREATE PROC USP_SreachUserByName
@name NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE displayName LIKE N'%'+@name+'%'
END
GO

--1.7. ResetPassword
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_ResetPassword')
    DROP PROC USP_ResetPassword
GO

CREATE PROC USP_ResetPassword
@userName VARCHAR(30)
AS
BEGIN
    UPDATE dbo.TaiKhoan SET passWord = N'1551321171111548020413130351851605666202196' WHERE userName = @userName
END
GO

--1.8. Cập nhập phân quyền tài khoản
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateRoleAccount')
    DROP PROC USP_UpdateRoleAccount
GO

CREATE PROC USP_UpdateRoleAccount
@userName VARCHAR(30), @displayName NVARCHAR(50), @role INT
AS
BEGIN
    UPDATE dbo.TaiKhoan SET displayName = @displayName, role = @role WHERE userName = @userName
END
GO

--2. Quản lý danh mục món ăn
--2.1. Thêm danh mục món mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertDanhMucMon')
    DROP PROC USP_InsertDanhMucMon
GO

CREATE PROC USP_InsertDanhMucMon
@tenDanhMucMon NVARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.DanhMucMon
    (
        tenDanhMucMon
    )
    VALUES
    (@tenDanhMucMon -- tenDanhMucMon - nvarchar(50)
        )
END
GO
--2.2. Cập nhật danh mục món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateDanhMucMon')
    DROP PROC USP_UpdateDanhMucMon
GO

CREATE PROC USP_UpdateDanhMucMon
@maDanhMucMon INT,@tenDanhMucMon NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.DanhMucMon SET tenDanhMucMon = @tenDanhMucMon WHERE maDanhMucMon = @maDanhMucMon
END
GO
--2.3. Xoá danh mục món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteDanhMucMon')
    DROP PROC USP_DeleteDanhMucMon
GO

CREATE PROC USP_DeleteDanhMucMon
@maDanhMucMon INT
AS
BEGIN
    DELETE FROM dbo.DanhMucMon WHERE maDanhMucMon = @maDanhMucMon
END
GO

--14. Quản lý bàn
--14.1. Thêm danh mục món mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListBan')
    DROP PROC USP_GetListBan
GO

CREATE PROC USP_GetListBan
AS
BEGIN
    SELECT * FROM dbo.Ban
END
GO

--15. Quản lý phân quyền
--15.1. Lấy danh sách phân quyền
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListRole')
    DROP PROC USP_GetListRole
GO

CREATE PROC USP_GetListRole
AS
BEGIN
    SELECT * FROM dbo.PhanQuyen WHERE role>0
END
GO

--15.2. Lấy phân quyền theo mã phân quyền
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetRoleByID')
    DROP PROC USP_GetRoleByID
GO

CREATE PROC USP_GetRoleByID
@role INT
AS
BEGIN
    SELECT * FROM dbo.PhanQuyen WHERE role = @role
END
GO

--15.3. Cập nhật cài đặt phân quyền
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateRoleSetting')
    DROP PROC USP_UpdateRoleSetting
GO

CREATE PROC USP_UpdateRoleSetting
@role INT, @quyenBan BIT, @quyenNhanVien BIT, @quyenKhachHang BIT, @quyenVoucher BIT, @quyenThongKe BIT, @quyenKho BIT
AS
BEGIN
    UPDATE dbo.PhanQuyen 
    SET quyenBan = @quyenBan, 
        quyenNhanVien = @quyenNhanVien,
        quyenKhachHang = @quyenKhachHang,
        quyenVoucher = @quyenVoucher,
        quyenThongKe = @quyenThongKe,
        quyenKho = @quyenKho
    WHERE role = @role
END
GO


-- script insert data
USE quanlynhahang
GO

INSERT INTO dbo.PhanQuyen
(
    role,
    nameRole,
    quyenBan,
    quyenNhanVien,
    quyenKhachHang,
    quyenVoucher,
    quyenThongKe,
    quyenKho,
    quyenThietLap
)
VALUES
(   1,    -- role - int
    N'Ông chủ',  -- nameRole - nvarchar(20)
    1, -- quyenBan - bit
    1, -- quyenNhanVien - bit
    1, -- quyenKhachHang - bit
    1, -- quyenVoucher - bit
    1, -- quyenThongKe - bit
    1, -- quyenKho - bit
    0  -- quyenThietLap - bit
    ),
(   2,    -- role - int
    N'Quản trị viên',  -- nameRole - nvarchar(20)
    0, -- quyenBan - bit
    0, -- quyenNhanVien - bit
    0, -- quyenKhachHang - bit
    0, -- quyenVoucher - bit
    0, -- quyenThongKe - bit
    0, -- quyenKho - bit
    1  -- quyenThietLap - bit
    ),
(   3,    -- role - int
    N'Quản kho',  -- nameRole - nvarchar(20)
    0, -- quyenBan - bit
    0, -- quyenNhanVien - bit
    0, -- quyenKhachHang - bit
    0, -- quyenVoucher - bit
    1, -- quyenThongKe - bit
    1, -- quyenKho - bit
    0  -- quyenThietLap - bit
    ),
(   4,    -- role - int
    N'Thu Ngân',  -- nameRole - nvarchar(20)
    1, -- quyenBan - bit
    0, -- quyenNhanVien - bit
    1, -- quyenKhachHang - bit
    1, -- quyenVoucher - bit
    1, -- quyenThongKe - bit
    0, -- quyenKho - bit
    0  -- quyenThietLap - bit
    ),
(   5,    -- role - int
    N'Phục vụ',  -- nameRole - nvarchar(20)
    1, -- quyenBan - bit
    0, -- quyenNhanVien - bit
    1, -- quyenKhachHang - bit
    0, -- quyenVoucher - bit
    1, -- quyenThongKe - bit
    0, -- quyenKho - bit
    0  -- quyenThietLap - bit
    ),
(   -1,    -- role - int
    N'Vô hiệu hoá',  -- nameRole - nvarchar(20)
    0, -- quyenBan - bit
    0, -- quyenNhanVien - bit
    0, -- quyenKhachHang - bit
    0, -- quyenVoucher - bit
    0, -- quyenThongKe - bit
    0, -- quyenKho - bit
    0  -- quyenThietLap - bit
    )
GO

INSERT INTO dbo.TaiKhoan
(
    userName,
    displayName,
    passWord,
    role
)
VALUES
(   'admin',  -- userName - varchar(30)
    N'Ông chủ', -- displayName - nvarchar(50)
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    1    -- role - int
    ),
(   'quantrivien',  -- userName - varchar(30)
    N'Quản trị viên', -- displayName - nvarchar(50)
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    2    -- role - int
    ),
(   'quankho',  -- userName - varchar(30)
    N'Quản kho', -- displayName - nvarchar(50)
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    3    -- role - int
    ),
(   'thungan',  -- userName - varchar(30)
    N'Thu ngân xinh đẹp', -- displayName - nvarchar(50)
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    4    -- role - int
    ),
(   'phucvu',  -- userName - varchar(30)
    N'Tiểu nhị', -- displayName - nvarchar(50)
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    5    -- role - int
    )
GO

