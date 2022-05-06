USE quanlynhahang
GO

--1. Insert cài đặt phân quyền tài khoản
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

--2. Insert Nhân viên
INSERT INTO dbo.NhanVien
(
    hoTen,
    ngaySinh,
    gioiTinh,
    chucVu,
    sdt,
    cccd,
    luong
)
VALUES
(   N'Nguyễn Tất Đạt',       -- hoTen - nvarchar(50)
    '2001-6-28', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    N'Quản lý',       -- chucVu - nvarchar(50)
    '0989026019',        -- sdt - varchar(15)
    '0342010008540',        -- cccd - varchar(15)
    9320000          -- luong - int
    ),
(   N'Phạm Ngọc Thái',       -- hoTen - nvarchar(50)
    '1999-12-3', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    N'Quản trị hệ thống',       -- chucVu - nvarchar(50)
    '0837041091',        -- sdt - varchar(15)
    '0340900008932',        -- cccd - varchar(15)
    12840000          -- luong - int
    ),
(   N'Thái Văn Sinh',       -- hoTen - nvarchar(50)
    '2000-9-20', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    N'Quản kho',       -- chucVu - nvarchar(50)
    '0356999793',        -- sdt - varchar(15)
    '0240980007322',        -- cccd - varchar(15)
    10730000          -- luong - int
    ),
(   N'Nguyễn Thùy Linh',       -- hoTen - nvarchar(50)
    '1997-6-17', -- ngaySinh - date
    N'Nữ',       -- gioiTinh - nvarchar(5)
    N'Thu ngân',       -- chucVu - nvarchar(50)
    '0356999793',        -- sdt - varchar(15)
    '0240980007322',        -- cccd - varchar(15)
    7520000          -- luong - int
    ),
(   N'Đặng Ngọc Ánh',       -- hoTen - nvarchar(50)
    '2002-2-15', -- ngaySinh - date
    N'Nữ',       -- gioiTinh - nvarchar(5)
    N'Phục vụ',       -- chucVu - nvarchar(50)
    '0987028059',        -- sdt - varchar(15)
    '0420100020734',        -- cccd - varchar(15)
    9320000          -- luong - int
    )
GO

--3. Insert tài khoản
INSERT INTO dbo.TaiKhoan
(
    userName,
    maNhanVien,
    passWord,
    role
)
VALUES
(   'admin',  -- userName - varchar(30)
    1, -- maNhanVien - int
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    1    -- role - int
    ),
(   'quantrivien',  -- userName - varchar(30)
    2, -- maNhanVien - int
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    2    -- role - int
    ),
(   'quankho',  -- userName - varchar(30)
    3, -- maNhanVien - int
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    3    -- role - int
    ),
(   'thungan',  -- userName - varchar(30)
    4, -- maNhanVien - int
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    4    -- role - int
    ),
(   'phucvu',  -- userName - varchar(30)
    5, -- maNhanVien - int
    '1551321171111548020413130351851605666202196',  -- passWord - varchar(50)
    5    -- role - int
    )
GO

--4. Insert bàn
EXEC USP_ChangeNumOfTable 15
GO


--5. Insert thực phẩm
INSERT INTO dbo.ThucPham
(
    tenThucPham,
    donViTinh,
    tonKho
)
VALUES
(   N'Thịt bò', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Khoai tây', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    20000    -- tonKho - int
    ),
(   N'Cà chua', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Tỏi', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Hành lá', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Cà rốt', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Gừng', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Rượu vang đỏ', -- tenThucPham - nvarchar(50)
    N'ml', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Hành tây', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Rau cần', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Tôm sú', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Sả', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Dừa xiêm', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Hành tím', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Xà lách', -- tenThucPham - nvarchar(50)
    N'cây', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Dưa leo', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Trứng gà', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Hành khô', -- tenThucPham - nvarchar(50)
    N'củ', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Đậu Hà Lan', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Dưa chuột', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Ngô', -- tenThucPham - nvarchar(50)
    N'bắp', -- donViTinh - nvarchar(50)
    100    -- tonKho - int
    ),
(   N'Trứng cút', -- tenThucPham - nvarchar(50)
    N'quả', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Nấm đông cô', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Phô mai sợi', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Xúc xích heo', -- tenThucPham - nvarchar(50)
    N'cái', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Xúc xích bò', -- tenThucPham - nvarchar(50)
    N'cái', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Thịt ba chỉ xông khói', -- tenThucPham - nvarchar(50)
    N'gram', -- donViTinh - nvarchar(50)
    10000    -- tonKho - int
    ),
(   N'Nước cốt chanh', -- tenThucPham - nvarchar(50)
    N'ml', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    ),
(   N'Rau mùi tây', -- tenThucPham - nvarchar(50)
    N'cây', -- donViTinh - nvarchar(50)
    1000    -- tonKho - int
    )
GO

-- 6. Insert Danh mục món
INSERT INTO dbo.DanhMucMon
(
    tenDanhMucMon
)
VALUES
(N'Bò' -- tenDanhMucMon - nvarchar(50)
    ),
(N'Tôm' -- tenDanhMucMon - nvarchar(50)
    ),
(N'Salad' -- tenDanhMucMon - nvarchar(50)
    )
GO

INSERT INTO dbo.MonAn
(
    tenMonAn,
    gia,
    maDanhMucMon
)
VALUES
(   N'Bò xào khoai tây', -- tenMonAn - nvarchar(50)
    250000,   -- gia - int
    1    -- maDanhMucMon - int
    ),
(   N'Bò xốt vang', -- tenMonAn - nvarchar(50)
    275000,   -- gia - int
    1    -- maDanhMucMon - int
    ),
(   N'Bò xào cần', -- tenMonAn - nvarchar(50)
    310000,   -- gia - int
    1    -- maDanhMucMon - int
    ),
(   N'Tôm hấp bia', -- tenMonAn - nvarchar(50)
    350000,   -- gia - int
    2    -- maDanhMucMon - int
    ),
(   N'Tôm hấm nước dừa', -- tenMonAn - nvarchar(50)
    350000,   -- gia - int
    2    -- maDanhMucMon - int
    ),
(   N'Tôm chiên trứng muối', -- tenMonAn - nvarchar(50)
    375000,   -- gia - int
    2    -- maDanhMucMon - int
    ),
(   N'Salad khoai tây', -- tenMonAn - nvarchar(50)
    50000,   -- gia - int
    3    -- maDanhMucMon - int
    ),
(   N'Khoai tây bọc trứng cút', -- tenMonAn - nvarchar(50)
    75000,   -- gia - int
    3    -- maDanhMucMon - int
    ),
(   N'Khoai tây nướng nhồi xúc xích', -- tenMonAn - nvarchar(50)
    80000,   -- gia - int
    3    -- maDanhMucMon - int
    )
GO

-- 7. Insert Nhà cung cấp
INSERT INTO dbo.NhaCungCap
(
    tenNhaCungCap,
    diaChi,
    sdt,
    email
)
VALUES
(   N'CP', -- tenNhaCungCap - nvarchar(50)
    N'Tầng Hầm 1(B1), Trung Tâm Lotte Hà Nội, Số 54Đường Liễu Giai, Phường Cống Vị, Quận Ba Đình, Hà Nội', -- diaChi - nvarchar(200)
    '0968722472',  -- sdt - varchar(15)
    'CPFoodVN@gmail.com'   -- email - varchar(50)
    ),
(   N'Rau quả Phú Hưng', -- tenNhaCungCap - nvarchar(50)
    N'69/12 Lê Sát, P. Tân Quý, Q. Tân Phú, Tp. HCM', -- diaChi - nvarchar(200)
    '0948176647',  -- sdt - varchar(15)
    'rauquaphuhung@gmail.com'   -- email - varchar(50)
    ),
(   N'Bảo Nguyên Food', -- tenNhaCungCap - nvarchar(50)
    N'58 Hồ Hân Nghiệp, P. Mỹ An, Q. Ngũ Hành Sơn, TP. Đà Nẵng', -- diaChi - nvarchar(200)
    '0912929605',  -- sdt - varchar(15)
    'BaoNguyenFood@gmail.com'   -- email - varchar(50)
    ),
(   N'Đông Nam Á', -- tenNhaCungCap - nvarchar(50)
    N'271 Bạch Đằng, Phường 15, Q. Bình Thạnh, TP. HCM', -- diaChi - nvarchar(200)
    '02862714859',  -- sdt - varchar(15)
    'khamdamdna@yahoo.com.vn'   -- email - varchar(50)
    ),
(   N'Thực Phẩm An Toàn Tân Việt', -- tenNhaCungCap - nvarchar(50)
    N'Công Ty TNHH Thực Phẩm An Toàn Tân Việt Khu Đô Thị Bắc Từ Sơn, Thị Xã Từ Sơn, Bắc Ninh', -- diaChi - nvarchar(200)
    '0988255794',  -- sdt - varchar(15)
    'tanviettp@gmail.com'   -- email - varchar(50)
    )
GO

-- 8. Insert Khách hàng vãng lai
INSERT INTO dbo.KhachHang
(
    hoTen,
    ngaySinh,
    gioiTinh,
    sdt,
    diemTichLuy
)
VALUES
-- 8.1. Khách hàng vãng lai
(   N'Khách vãng lai',       -- hoTen - nvarchar(50)
    '1900-1-1', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    '',        -- sdt - varchar(15)
    0          -- diemTichLuy - int
    ),
-- Khách hàng 
(   N'Bùi Hoàng Anh',       -- hoTen - nvarchar(50)
    '2001-1-6', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    '0123456789',        -- sdt - varchar(15)
    100          -- diemTichLuy - int
    ),
(   N'Nguyễn Mạnh Hùng',       -- hoTen - nvarchar(50)
    '2001-4-16', -- ngaySinh - date
    N'Nam',       -- gioiTinh - nvarchar(5)
    '0987654321',        -- sdt - varchar(15)
    50          -- diemTichLuy - int
    )
GO

-- 9. Insert Voucher

INSERT dbo.Voucher
(
    ngayBatDau,
    ngayKetThuc,
    moTa,
    giaTri,
    loai
)
VALUES
-- 9.1. Voucher không giá trị
(   '1900-1-1', -- ngayBatDau - date
    '1900-1-1', -- ngayKetThuc - date
    N'',       -- moTa - nvarchar(300)
    0,         -- giaTri - int
    0          -- loai - int
    ),
-- Voucher tiền mặt
(   '2022-1-1', -- ngayBatDau - date
    '2023-1-1', -- ngayKetThuc - date
    N'Voucher tiền mặt 500k',       -- moTa - nvarchar(300)
    500000,         -- giaTri - int
    1          -- loai - int
    ),
-- Voucher phần trăm
(   '2022-1-1', -- ngayBatDau - date
    '2023-1-1', -- ngayKetThuc - date
    N'Voucher giảm 50%',       -- moTa - nvarchar(300)
    50,         -- giaTri - int
    0          -- loai - int
    )
GO
