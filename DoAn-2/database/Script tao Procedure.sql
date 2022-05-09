USE quanlynhahang
GO

--Function convertUnicodeToUnsign
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'fuConvertToUnsign')
	DROP FUNCTION [fuConvertToUnsign]
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
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
@userName VARCHAR(30), @maNhanVien INT, @role INT
AS
BEGIN
    INSERT INTO dbo.TaiKhoan
    (
        userName,
		maNhanVien,
        passWord,
        role
    )
    VALUES
    (   @userName, -- userName - varchar(30)
        @maNhanVien, -- maNV - int
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
    SELECT * FROM dbo.TaiKhoan WHERE userName = @userName AND passWord = @passWord AND role NOT LIKE -1
END
GO

--1.3. Cập nhập thông tin tài khoản
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateAccount')
	DROP PROC USP_UpdateAccount
GO

CREATE PROC USP_UpdateAccount
@userName VARCHAR(30), @maNhanVien int, @passWord VARCHAR(50), @role INT
AS
BEGIN
    UPDATE dbo.TaiKhoan SET maNhanVien = @maNhanVien, passWord = @passWord, role = @role WHERE userName = @userName
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
    SELECT userName,
           hoTen,
           nameRole 
	FROM dbo.TaiKhoan 
	INNER JOIN dbo.NhanVien ON NhanVien.maNhanVien = TaiKhoan.maNhanVien
	INNER JOIN dbo.PhanQuyen ON PhanQuyen.role = TaiKhoan.role
	WHERE TaiKhoan.role NOT LIKE -1
END
GO

--1.6. GetAccountByUserName
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetAccountByUserName')
	DROP PROC USP_GetAccountByUserName
GO

CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(50)
AS
BEGIN
    SELECT userName,
		   dbo.TaiKhoan.maNhanVien,
           hoTen AS displayName,
           passWord,
           role
	FROM dbo.TaiKhoan 
	INNER JOIN dbo.NhanVien ON dbo.NhanVien.maNhanVien = dbo.TaiKhoan.maNhanVien
	WHERE userName = @userName
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
@userName VARCHAR(30), @maNhanVien INT, @role INT
AS
BEGIN
    UPDATE dbo.TaiKhoan SET maNhanVien = @maNhanVien, role = @role WHERE userName = @userName
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
    UPDATE dbo.DanhMucMon SET xoa = 1 WHERE maDanhMucMon = @maDanhMucMon
END
GO

--2.4. Lấy danh sách danh mục món
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListDanhMucMon')
	DROP PROC USP_GetListDanhMucMon
GO

CREATE PROC USP_GetListDanhMucMon
AS
BEGIN
    SELECT maDanhMucMon,
           tenDanhMucMon
	FROM dbo.DanhMucMon WHERE xoa = 0
END
GO

--2.5. Lấy thông tin danh mục món theo tên danh mục món
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetDanhMucMonByName')
     DROP PROC USP_GetDanhMucMonByName
GO

CREATE PROC USP_GetDanhMucMonByName
@tenDanhMucMon NVARCHAR(50)
AS
BEGIN
    SELECT maDanhMucMon,
           tenDanhMucMon
    FROM dbo.DanhMucMon WHERE xoa = 0 AND tenDanhMucMon = @tenDanhMucMon
END
GO

--3. Quản lý món ăn
--3.1. Thêm món mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertMonAn')
	DROP PROC USP_InsertMonAn
GO

CREATE PROC USP_InsertMonAn
@tenMonAn NVARCHAR(50), @gia INT, @maDanhMucMon INT
AS
BEGIN
    INSERT INTO dbo.MonAn
    (
        tenMonAn,
        gia,
        maDanhMucMon
    )
    VALUES
    (   @tenMonAn, -- tenMonAn - nvarchar(50)
        @gia,   -- gia - int
        @maDanhMucMon    -- maDanhMucMon - int
        )
END
GO

--3.2. Cập nhật món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateMonAn')
	DROP PROC USP_UpdateMonAn
GO

CREATE PROC USP_UpdateMonAn
@maMonAn INT, @tenMonAn NVARCHAR(50), @gia INT, @maDanhMuc int
AS
BEGIN
    UPDATE dbo.MonAn SET tenMonAn = @tenMonAn, gia = @gia, maDanhMucMon = @maDanhMuc WHERE maMonAn = @maMonAn
END
GO

--3.3. Xoá món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteMonAn')
	DROP PROC USP_DeleteMonAn
GO

CREATE PROC USP_DeleteMonAn
@maMonAn INT
AS
BEGIN
    UPDATE dbo.MonAn SET xoa = 1 WHERE maMonAn = @maMonAn
END
GO

--3.4. Tìm kiếm món ăn theo tên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetMonAnByName')
	DROP PROC USP_GetMonAnByName
GO

CREATE PROC USP_GetMonAnByName
@tenMonAn NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.MonAn WHERE tenMonAn = @tenMonAn AND xoa = 0
END
GO

--3.5. Liệt kê danh sách món ăn theo danh mục món
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListMonAnByMaDanhMuc')
	DROP PROC USP_GetListMonAnByMaDanhMuc
GO

CREATE PROC USP_GetListMonAnByMaDanhMuc
@maDanhMucMon INT
AS
BEGIN
    SELECT maMonAn,
           tenMonAn,
           gia,
           maDanhMucMon
	FROM dbo.MonAn WHERE maDanhMucMon = @maDanhMucMon AND xoa = 0 
END
GO

--3.8. Liệt kê danh sách món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListMonAn')
	DROP PROC USP_GetListMonAn
GO

CREATE PROC USP_GetListMonAn
AS
BEGIN
    SELECT maMonAn,
           tenMonAn,
           gia,
           tenDanhMucMon
	FROM dbo.MonAn 
	INNER JOIN dbo.DanhMucMon ON DanhMucMon.maDanhMucMon = MonAn.maDanhMucMon
	WHERE MonAn.xoa = 0
END
GO

--4. Quản lý thực phẩm
--4.1. Thêm thực phẩm mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertThucPham')
     DROP PROC USP_InsertThucPham
GO

CREATE PROC USP_InsertThucPham
@tenThucPham NVARCHAR(50), @donViTinh NVARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.ThucPham
    (
        tenThucPham,
        donViTinh
    )
    VALUES
    (   @tenThucPham, -- tenThucPham - nvarchar(50)
        @donViTinh -- donViTinh - nvarchar(50)
        )
END
GO

--4.2. Cập nhật thông tin thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateThucPham')
     DROP PROC USP_UpdateThucPham
GO

CREATE PROC USP_UpdateThucPham
@maThucPham INT, @tenThucPham NVARCHAR(50), @donViTinh NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.ThucPham SET tenThucPham = @tenThucPham, donViTinh = @donViTinh WHERE maThucPham = @maThucPham
END
GO

--4.3. Xoá thông tin thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteThucPham')
     DROP PROC USP_DeleteThucPham
GO

CREATE PROC USP_DeleteThucPham
@maThucPham INT
AS
BEGIN
    UPDATE dbo.ThucPham SET xoa = 1 WHERE maThucPham = @maThucPham
END
GO

--4.4. Tìm kiếm thông tin thực phẩm theo tên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_SearchThucPham')
     DROP PROC USP_SearchThucPham
GO

CREATE PROC USP_SearchThucPham
@textSearch NVARCHAR(50)
AS
BEGIN
    SELECT maThucPham,
           tenThucPham,
           donViTinh,
           tonKho
    FROM dbo.ThucPham WHERE (dbo.fuConvertToUnsign(tenThucPham) LIKE '%'+dbo.fuConvertToUnsign(@textSearch)+'%') AND xoa = 0
END
GO

--4.6. Lấy danh sách thông tin thực phẩm theo mã món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListThucPhamByMaMonAn')
     DROP PROC USP_GetListThucPhamByMaMonAn
GO

CREATE PROC USP_GetListThucPhamByMaMonAn
@maMonAn INT
AS
BEGIN
    SELECT tenThucPham,
		   soLuong,	
           donViTinh
    FROM dbo.ChiTietMonAn
	INNER JOIN dbo.ThucPham ON ThucPham.maThucPham = ChiTietMonAn.maThucPham
	WHERE maMonAn = @maMonAn
END
GO

--4.9. Lấy danh sách thông tin thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListThucPham')
     DROP PROC USP_GetListThucPham
GO

CREATE PROC USP_GetListThucPham
AS
BEGIN
    SELECT maThucPham,
           tenThucPham,
           donViTinh,
           tonKho
    FROM dbo.ThucPham WHERE xoa = 0
END
GO

--4.10. Lấy thông tin thực phẩm theo tên thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetThucPhamByName')
     DROP PROC USP_GetThucPhamByName
GO

CREATE PROC USP_GetThucPhamByName
@tenThucPham NVARCHAR(50)
AS
BEGIN
    SELECT maThucPham,
           tenThucPham,
           donViTinh,
           tonKho
    FROM dbo.ThucPham WHERE xoa = 0 AND tenThucPham = @tenThucPham
END
GO

--4.11. Lấy danh sách đơn vị tính
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListUnit')
     DROP PROC USP_GetListUnit
GO

CREATE PROC USP_GetListUnit
AS
BEGIN
    SELECT donViTinh FROM dbo.ThucPham
	GROUP BY donViTinh
END
GO

--4.12. Cập nhật số lượng thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateSoLuongThucPham')
     DROP PROC USP_UpdateSoLuongThucPham
GO

CREATE PROC USP_UpdateSoLuongThucPham
@maThucPham INT, @soLuong INT 
AS
BEGIN
    UPDATE dbo.ThucPham SET tonKho -= @soLuong WHERE maThucPham = @maThucPham
END
GO

--4.13. Lấy thông tin thực phẩm theo mã thực phẩm
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetThucPhamByMaThucPham')
     DROP PROC USP_GetThucPhamByMaThucPham
GO

CREATE PROC USP_GetThucPhamByMaThucPham
@maThucPham INT
AS
BEGIN
    SELECT * FROM dbo.ThucPham WHERE maThucPham = @maThucPham AND xoa = 0
END
GO

--5. Quản lý nhà cung cấp
--5.1. Thêm nhà cung cấp mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertNhaCungCap')
     DROP PROC USP_InsertNhaCungCap
GO

CREATE PROC USP_InsertNhaCungCap
@tenNhaCungCap NVARCHAR(50), @diaChi NVARCHAR(200), @sdt VARCHAR(15), @email VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.NhaCungCap
    (
        tenNhaCungCap,
        diaChi,
        sdt,
        email
    )
    VALUES
    (   N'', -- tenNhaCungCap - nvarchar(50)
        N'', -- diaChi - nvarchar(200)
        '',  -- sdt - varchar(15)
        ''  -- email - varchar(50)
        )
END
GO

--5.2. Cập nhật thông tin nhà cung cấp
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateNhaCungCap')
     DROP PROC USP_UpdateNhaCungCap
GO

CREATE PROC USP_UpdateNhaCungCap
@maNhaCungCap INT, @tenNhaCungCap NVARCHAR(50), @diaChi NVARCHAR(200), @sdt VARCHAR(15), @email VARCHAR(50)
AS
BEGIN
    UPDATE dbo.NhaCungCap SET tenNhaCungCap = @tenNhaCungCap, diaChi = @diaChi, sdt = @sdt, email = @email WHERE maNhaCungCap = @maNhaCungCap
END
GO

--5.3. Xoá thông tin nhà cung cấp
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteNhaCungCap')
     DROP PROC USP_DeleteNhaCungCap
GO

CREATE PROC USP_DeleteNhaCungCap
@maNhaCungCap INT
AS
BEGIN
    UPDATE dbo.NhaCungCap SET xoa = 1 WHERE maNhaCungCap = @maNhaCungCap
END
GO

--5.5. Lấy danh sách nhà cung cấp
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListNhaCungCap')
     DROP PROC USP_GetListNhaCungCap
GO

CREATE PROC USP_GetListNhaCungCap
AS
BEGIN
    SELECT maNhaCungCap,
           tenNhaCungCap,
           diaChi,
           sdt,
           email
    FROM dbo.NhaCungCap WHERE xoa = 0
END
GO

--5.6. Tìm kiếm thông tin nhà cung cấp theo tên hoặc sđt
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_SearchNhaCungCap')
     DROP PROC USP_SearchNhaCungCap
GO

CREATE PROC USP_SearchNhaCungCap
@textSearch NVARCHAR(50)
AS
BEGIN
    SELECT maNhaCungCap,
           tenNhaCungCap,
           diaChi,
           sdt,
           email
	FROM dbo.NhaCungCap WHERE ((sdt LIKE '%'+@textSearch+'%') OR (dbo.fuConvertToUnsign(tenNhaCungCap) LIKE '%'+dbo.fuConvertToUnsign(@textSearch)+'%')) AND xoa = 0
END
GO

--6. Quản lý phiếu nhập
--6.1. Thêm phiếu nhập mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertPhieuNhap')
     DROP PROC USP_InsertPhieuNhap
GO

CREATE PROC USP_InsertPhieuNhap
@maNhaCungCap INT, @ngayNhap DATE
AS
BEGIN
    INSERT INTO dbo.PhieuNhap
    (
        maNhaCungCap,
        ngayNhap,
		tongTien
    )
    VALUES
    (   @maNhaCungCap,         -- maNhaCungCap - int
        @ngayNhap, -- ngayNhap - date
		0 -- tongTien - int
        )
END
GO

--6.2. Cập nhật thông tin phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdatePhieuNhap')
     DROP PROC USP_UpdatePhieuNhap
GO

CREATE PROC USP_UpdatePhieuNhap
@maPhieuNhap INT, @maNhaCungCap INT, @ngayNhap DATE
AS
BEGIN
    UPDATE dbo.PhieuNhap SET maNhaCungCap = @maNhaCungCap, ngayNhap = @ngayNhap WHERE maPhieuNhap = @maPhieuNhap
END
GO

--6.3. Xoá thông tin phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeletePhieuNhap')
     DROP PROC USP_DeletePhieuNhap
GO

CREATE PROC USP_DeletePhieuNhap
@maPhieuNhap INT
AS
BEGIN
    UPDATE dbo.PhieuNhap SET xoa = 1 WHERE maPhieuNhap = @maPhieuNhap
END
GO

--6.6. Lấy danh sách phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListPhieuNhap')
     DROP PROC USP_GetListPhieuNhap
GO

CREATE PROC USP_GetListPhieuNhap
AS
BEGIN
    SELECT maPhieuNhap,
           tenNhaCungCap,
           ngayNhap,
           tongTien
	FROM dbo.PhieuNhap 
	INNER JOIN dbo.NhaCungCap ON NhaCungCap.maNhaCungCap = PhieuNhap.maNhaCungCap
	WHERE PhieuNhap.xoa = 0
END
GO

--6.7. Cập nhật tổng tiền phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateTongTienPhieuNhap')
     DROP PROC USP_UpdateTongTienPhieuNhap
GO

CREATE PROC USP_UpdateTongTienPhieuNhap
@maPhieuNhap INT, @tongTien INT 
AS
BEGIN
    UPDATE dbo.PhieuNhap SET tongTien = @tongTien WHERE maPhieuNhap = @maPhieuNhap
END
GO

--7. Quản lý chi tiết món ăn
--7.1. Thêm chi tiết món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertChiTietMonAn')
	DROP PROC USP_InsertChiTietMonAn
GO

CREATE PROC USP_InsertChiTietMonAn
@maMonAn INT, @maThucPham INT, @soLuong INT 
AS
BEGIN
	INSERT INTO dbo.ChiTietMonAn
	(
		maMonAn,
		maThucPham,
		soLuong
	)
	VALUES
	(   @maMonAn, -- maMonAn - int
		@maThucPham, -- maThucPham - int
		@soLuong  -- soLuong - int
		)
END
GO

--7.2. Cập nhật chi tiết món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateChiTietMonAn')
	DROP PROC USP_UpdateChiTietMonAn
GO

CREATE PROC USP_UpdateChiTietMonAn
@maMonAn INT, @maThucPham INT, @soLuong INT 
AS
BEGIN
	UPDATE dbo.ChiTietMonAn SET soLuong = @soLuong WHERE maMonAn = @maMonAn AND maThucPham = @maThucPham
END
GO

--7.4. Lấy thông tin chi tiết món ăn theo mã món ăn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListThucPhamByMaMonAn')
	DROP PROC USP_GetListThucPhamByMaMonAn
GO

CREATE PROC USP_GetListThucPhamByMaMonAn
@maMonAn INT
AS
BEGIN
    SELECT ThucPham.maThucPham,
		   tenThucPham,
           soLuong,
           donViTinh
	FROM dbo.ChiTietMonAn
	INNER JOIN dbo.ThucPham ON ThucPham.maThucPham = ChiTietMonAn.maThucPham
	WHERE maMonAn = @maMonAn
END
GO

--7.5. Kiểm tra thực phẩm có trong món ăn chưa
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_CheckThucPhamTrongMonAn')
	DROP PROC USP_CheckThucPhamTrongMonAn
GO

CREATE PROC USP_CheckThucPhamTrongMonAn
@maMonAn INT, @maThucPham INT 
AS
BEGIN
    SELECT * FROM dbo.ChiTietMonAn WHERE maMonAn = @maMonAn AND maThucPham = @maThucPham
END
GO

--8. Quản lý chi tiết phiếu nhập
--8.1. Thêm chi tiết phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertChiTietPhieuNhap')
    DROP PROC USP_InsertChiTietPhieuNhap
GO

CREATE PROC USP_InsertChiTietPhieuNhap
@maPhieuNhap INT, @maThucPham INT, @soLuong INT, @gia INT  
AS
BEGIN
    INSERT INTO dbo.ChiTietPhieuNhap
    (
        maPhieuNhap,
        maThucPham,
        soLuong,
        gia
    )
    VALUES
    (   @maPhieuNhap, -- maPhieuNhap - int
        @maThucPham, -- maThucPham - int
        @soLuong, -- soLuong - int
        @gia  -- gia - int
        )
END
GO

--8.2. Cập nhật chi tiết phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateChiTietPhieuNhap')
    DROP PROC USP_UpdateChiTietPhieuNhap
GO

CREATE PROC USP_UpdateChiTietPhieuNhap
@maPhieuNhap INT, @maThucPham INT, @soLuong INT, @gia INT
AS
BEGIN
    UPDATE dbo.ChiTietPhieuNhap SET soLuong = @soLuong, gia = @gia WHERE maPhieuNhap = @maPhieuNhap AND maThucPham = @maThucPham
END
GO

--8.4. Lấy thông tin chi tiết phiếu nhập theo mã phiếu nhập
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListThucPhamByMaPhieuNhap')
    DROP PROC USP_GetListThucPhamByMaPhieuNhap
GO

CREATE PROC USP_GetListThucPhamByMaPhieuNhap
@maPhieuNhap INT
AS
BEGIN
    SELECT ThucPham.maThucPham,
           tenThucPham,
           soLuong,
           donViTinh,
		   gia
    FROM dbo.ChiTietPhieuNhap
    INNER JOIN dbo.ThucPham ON ThucPham.maThucPham = ChiTietPhieuNhap.maThucPham
    WHERE maPhieuNhap = @maPhieuNhap
END
GO

--8.5. Kiểm tra thực phẩm có trong phiếu nhập chưa
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_CheckThucPhamTrongPhieuNhap')
    DROP PROC USP_CheckThucPhamTrongPhieuNhap
GO

CREATE PROC USP_CheckThucPhamTrongPhieuNhap
@maPhieuNhap INT, @maThucPham INT 
AS
BEGIN
    SELECT ThucPham.maThucPham,
           tenThucPham,
           soLuong,
		   donViTinh,
           gia 
	FROM dbo.ChiTietPhieuNhap 
	INNER JOIN dbo.ThucPham ON ThucPham.maThucPham = ChiTietPhieuNhap.maThucPham
	WHERE maPhieuNhap = @maPhieuNhap AND ChiTietPhieuNhap.maThucPham = @maThucPham
END
GO

--9. Quản lý khách hàng
--9.1. Thêm khách hàng mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertKhachHang')
	DROP PROC USP_InsertKhachHang
GO

CREATE PROC USP_InsertKhachHang
@hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(5), @sdt VARCHAR(15)
AS
BEGIN
    INSERT INTO dbo.KhachHang
    (
        hoTen,
        ngaySinh,
        gioiTinh,
        sdt,
        diemTichLuy
    )
    VALUES
    (   @hoTen,       -- hoTen - nvarchar(50)
        @ngaySinh, -- ngaySinh - date
        @gioiTinh,       -- gioiTinh - nvarchar(5)
        @sdt,        -- sdt - varchar(15)
        0          -- diemTichLuy - int
        )
END
GO

--9.2. Cập nhật thông tin khách hàng
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateKhachHang')
	DROP PROC USP_UpdateKhachHang
GO

CREATE PROC USP_UpdateKhachHang
@maKhachHang INT, @hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(5), @sdt VARCHAR(15)
AS
BEGIN
    UPDATE dbo.KhachHang SET hoTen = @hoTen, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, sdt = @sdt WHERE maKhachHang = @maKhachHang
END
GO

--9.3. Xoá thông tin khách hàng
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteKhachHang')
	DROP PROC USP_DeleteKhachHang
GO

CREATE PROC USP_DeleteKhachHang
@maKhachHang INT
AS
BEGIN
    UPDATE dbo.KhachHang SET xoa = 1 WHERE maKhachHang = @maKhachHang
END
GO

--9.4. Tìm kiếm thông tin khách hàng theo tên hoặc sđt
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_SearchKhachHang')
	DROP PROC USP_SearchKhachHang
GO

CREATE PROC USP_SearchKhachHang
@textSearch NVARCHAR(50)
AS
BEGIN
    SELECT maKhachHang,
           hoTen,
           ngaySinh,
           gioiTinh,
           sdt,
           diemTichLuy
	FROM dbo.KhachHang WHERE ((sdt LIKE '%'+@textSearch+'%') OR (dbo.fuConvertToUnsign(hoTen) LIKE '%'+dbo.fuConvertToUnsign(@textSearch)+'%')) AND xoa = 0 AND maKhachHang NOT LIKE 1
END
GO

--9.5. Lấy thông tin khách hàng theo mã khách hàng
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetKhachHangByID')
	DROP PROC USP_GetKhachHangByID
GO

CREATE PROC USP_GetKhachHangByID
@maKhachHang INT 
AS
BEGIN
    SELECT * FROM dbo.KhachHang WHERE maKhachHang = @maKhachHang AND xoa = 0
END
GO

--9.6. Lấy danh sách thông tin khách hàng
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListKhachHang')
	DROP PROC USP_GetListKhachHang
GO

CREATE PROC USP_GetListKhachHang
AS
BEGIN
    SELECT maKhachHang,
           hoTen,
           ngaySinh,
           gioiTinh,
           sdt,
           diemTichLuy
	FROM dbo.KhachHang WHERE xoa = 0 AND maKhachHang NOT LIKE 1
END
GO

--9.7. Lấy danh sách thông tin khách hàng cho ComboBox
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListKhachHangCmb')
	DROP PROC USP_GetListKhachHangCmb
GO

CREATE PROC USP_GetListKhachHangCmb
AS
BEGIN
    SELECT maKhachHang,
           CASE hoTen WHEN 'Khách vãng lai' THEN N'(Không có)'
		   ELSE hoTen END AS hoTen
	FROM dbo.KhachHang WHERE xoa = 0
END
GO

--10. Quản lý voucher
--10.1. Thêm voucher mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertVoucher')
	DROP PROC USP_InsertVoucher
GO

CREATE PROC USP_InsertVoucher
@ngayBatDau DATE, @ngayKetThuc DATE, @moTa NVARCHAR(300), @giaTri INT, @loai INT 
AS
BEGIN
    INSERT INTO dbo.Voucher
    (
        ngayBatDau,
        ngayKetThuc,
        moTa,
        giaTri,
        loai
    )
    VALUES
    (   @ngayBatDau, -- ngayBatDau - date
        @ngayKetThuc, -- ngayKetThuc - date
        @moTa,       -- moTa - nvarchar(300)
        @giaTri,         -- giaTri - int
        @loai         -- loai - int
        )
END
GO

--10.2. Cập nhật thông tin Voucher
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateVoucher')
	DROP PROC USP_UpdateVoucher
GO

CREATE PROC USP_UpdateVoucher
@maVoucher INT, @ngayBatDau DATE, @ngayKetThuc DATE, @moTa NVARCHAR(300), @giaTri INT, @loai INT 
AS
BEGIN
    UPDATE dbo.Voucher SET ngayBatDau = @ngayBatDau, ngayKetThuc = @ngayKetThuc, moTa = @moTa, giaTri = @giaTri, loai = @loai WHERE maVoucher = @maVoucher
END
GO

--10.3. Xoá thông tin voucher
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteVoucher')
	DROP PROC USP_DeleteVoucher
GO

CREATE PROC USP_DeleteVoucher
@maVoucher INT
AS
BEGIN
    UPDATE dbo.Voucher SET xoa = 1 WHERE maVoucher = @maVoucher
END
GO


--10.4. Lấy thông tin voucher theo mã voucher
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetVoucherByID')
	DROP PROC USP_GetVoucherByID
GO

CREATE PROC USP_GetVoucherByID
@maVoucher INT 
AS
BEGIN
    SELECT * FROM dbo.Voucher WHERE maVoucher = @maVoucher AND xoa = 0 AND ngayBatDau<=GETDATE() AND ngayKetThuc>=GETDATE()
END
GO

--10.5. Lấy danh sách thông tin voucher
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListVoucher')
	DROP PROC USP_GetListVoucher
GO

CREATE PROC USP_GetListVoucher
AS
BEGIN
    SELECT maVoucher,
           ngayBatDau,
           ngayKetThuc,
           moTa,
           giaTri,
           CASE WHEN loai = 1 THEN N'Tiền mặt'
				WHEN loai = 0 THEN N'Phần trăm'
			END AS 'loai'
	FROM dbo.Voucher WHERE xoa = 0 AND maVoucher NOT LIKE 1
END
GO

--10.6. Lấy danh sách thông tin voucher cho ComboBox
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListVoucherCmb')
	DROP PROC USP_GetListVoucherCmb
GO

CREATE PROC USP_GetListVoucherCmb
AS
BEGIN
    SELECT maVoucher,
           CASE moTa WHEN '' THEN N'(Không có)' ELSE moTa END AS moTa
	FROM dbo.Voucher WHERE xoa = 0
END
GO

--11. Quản lý nhân viên
--11.1. Thêm nhân viên mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertNhanVien')
     DROP PROC USP_InsertNhanVien
GO

CREATE PROC USP_InsertNhanVien
@hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(5), @chucVu NVARCHAR(50), @sdt VARCHAR(15), @cccd VARCHAR(15), @luong INT
AS
BEGIN
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
    (   @hoTen,       -- hoTen - nvarchar(50)
        @ngaySinh, -- ngaySinh - date
        @gioiTinh,       -- gioiTinh - nvarchar(5)
        @chucVu,       -- chucVu - nvarchar(50)
        @sdt,        -- sdt - varchar(15)
        @cccd,        -- cccd - varchar(15)
        @luong         -- luong - int
        )
END
GO

--11.2. Cập nhật thông tin nhân viên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateNhanVien')
     DROP PROC USP_UpdateNhanVien
GO

CREATE PROC USP_UpdateNhanVien
@maNhanVien INT, @hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(5), @chucVu NVARCHAR(50), @sdt VARCHAR(15), @cccd VARCHAR(15), @luong INT
AS
BEGIN
    UPDATE dbo.NhanVien SET hoTen = @hoTen, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, chucVu = @chucVu, sdt = @sdt, cccd = @cccd, luong = @luong WHERE maNhanVien = @maNhanVien
END
GO

--11.3. Xoá thông tin nhân viên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteNhanVien')
     DROP PROC USP_DeleteNhanVien
GO

CREATE PROC USP_DeleteNhanVien
@maNhanVien INT
AS
BEGIN
    UPDATE dbo.NhanVien SET xoa = 1 WHERE maNhanVien = @maNhanVien
END
GO

--11.4. Tìm kiếm thông tin nhân viên theo tên hoặc sđt
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_SearchNhanVien')
     DROP PROC USP_SearchNhanVien
GO

CREATE PROC USP_SearchNhanVien
@textSearch NVARCHAR(50)
AS
BEGIN
    SELECT maNhanVien,
           hoTen,
           ngaySinh,
           gioiTinh,
           chucVu,
           sdt,
           cccd,
           luong
	FROM dbo.NhanVien WHERE ((sdt LIKE '%'+@textSearch+'%') OR (dbo.fuConvertToUnsign(hoTen) LIKE '%'+dbo.fuConvertToUnsign(@textSearch)+'%')) AND xoa = 0
END
GO

--11.5. Lấy danh sách thông tin nhân viên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListNhanVien')
     DROP PROC USP_GetListNhanVien
GO

CREATE PROC USP_GetListNhanVien
AS
BEGIN
    SELECT maNhanVien,
           hoTen,
           ngaySinh,
           gioiTinh,
           chucVu,
           sdt,
           cccd,
           luong
	FROM dbo.NhanVien WHERE xoa = 0
END
GO

--11.6. Lấy thông tin nhân viên bằng mã nhân viên
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetNhanVienByID')
     DROP PROC USP_GetNhanVienByID
GO

CREATE PROC USP_GetNhanVienByID
@maNhanVien INT 
AS
BEGIN
    SELECT maNhanVien,
		   hoTen,
           ngaySinh,
           gioiTinh,
           chucVu,
           sdt,
           cccd,
           luong
	FROM dbo.NhanVien WHERE xoa = 0 AND maNhanVien = @maNhanVien
END
GO

--12. Quản lý hoá đơn
--12.1. Tạo hoá đơn mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_CreateHoaDon')
	DROP PROC USP_CreateHoaDon
GO

CREATE PROC USP_CreateHoaDon
@maNhanVien INT, @maBan INT
AS
BEGIN
    INSERT INTO dbo.HoaDon
    (
        maNhanVien,
        maBan
    )
    VALUES
    (   @maNhanVien,         -- maNhanVien - int
        @maBan         -- maBan - int
        );
	UPDATE dbo.Ban SET trangThai = 1 WHERE maBan = @maBan;
END
GO

--12.2. Cập nhật thông tin hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateHoaDon')
	DROP PROC USP_UpdateHoaDon
GO

CREATE PROC USP_UpdateHoaDon
@maHoaDon INT, @maNhanVien INT, @ngayTao DATETIME, @ngayThanhToan DATETIME
AS
BEGIN
    UPDATE dbo.HoaDon SET maNhanVien = @maNhanVien, ngayTao = @ngayTao, ngayThanhToan = @ngayThanhToan WHERE maHoaDon = @maHoaDon
END
GO

--12.3. Xoá hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_DeleteHoaDon')
	DROP PROC USP_DeleteHoaDon
GO

CREATE PROC USP_DeleteHoaDon
@maHoaDon INT
AS
BEGIN
    UPDATE dbo.HoaDon SET trangThai = -1 WHERE maHoaDon = @maHoaDon
END
GO

--12.4. Thanh toán hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_ThanhToanHoaDon')
	DROP PROC USP_ThanhToanHoaDon
GO

CREATE PROC USP_ThanhToanHoaDon
@maHoaDon INT, @maKhachHang INT, @diemCong INT, @diemTru INT, @tongTien INT, @maVoucher INT
AS
BEGIN
    UPDATE dbo.HoaDon SET maKhachHang = @maKhachHang, diemCong = @diemCong, diemTru = @diemTru, tongTien = @tongTien, maVoucher = @maVoucher, ngayThanhToan = GETDATE(), trangThai = 1 WHERE maHoaDon = @maHoaDon;
	UPDATE dbo.KhachHang SET diemTichLuy=diemTichLuy+@diemCong-@diemTru WHERE maKhachHang = @maKhachHang;
	UPDATE dbo.Ban SET trangThai = 0 WHERE maBan = (SELECT maBan FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon);
END
GO

--12.6. Lấy thông tin hoá đơn chưa thanh toán theo mã bàn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetHoaDonByMaBan')
	DROP PROC USP_GetHoaDonByMaBan
GO

CREATE PROC USP_GetHoaDonByMaBan
@maBan INT
AS
BEGIN
    SELECT * FROM dbo.HoaDon WHERE maBan = @maBan AND trangThai = 0
END
GO

--12.7. Chuyển hoá đơn sang bàn mới
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_ChuyenHoaDonSangBanMoi')
	DROP PROC USP_ChuyenHoaDonSangBanMoi
GO

CREATE PROC USP_ChuyenHoaDonSangBanMoi
@maHoaDon INT, @maBanMoi INT
AS
BEGIN
	UPDATE dbo.Ban SET trangThai = 0 WHERE maBan = (SELECT maBan FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon);
    UPDATE dbo.HoaDon SET maBan = @maBanMoi WHERE maHoaDon = @maHoaDon;
	UPDATE dbo.Ban SET trangThai = 1 WHERE maBan = @maBanMoi
END
GO

--12.8. Lấy tổng số tiền theo ngày trong 30 ngày để vẽ biểu đồ
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetHoaDon30Day')
	DROP PROC USP_GetHoaDon30Day
GO

CREATE PROC USP_GetHoaDon30Day
AS
BEGIN
	SELECT CONVERT(DATE,ngayThanhToan) AS [ngay],CONVERT(VARCHAR(5),ngayThanhToan,3) AS [Day], SUM(tongTien) AS [Sum]
	FROM dbo.HoaDon
	WHERE ngayThanhToan>DATEADD(DAY,-30,GETDATE()) AND ngayThanhToan<GETDATE()
	GROUP BY CONVERT(DATE,ngayThanhToan), CONVERT(VARCHAR(5),ngayThanhToan,3)
	ORDER BY CONVERT(DATE,ngayThanhToan)
END
GO

--12.9. Lấy danh sách thông tin hoá đơn theo khoản ngày
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListHoaDonByDateAndPage')
	DROP PROC USP_GetListHoaDonByDateAndPage
GO

CREATE PROC USP_GetListHoaDonByDateAndPage
@dateFrom DATE, @dateTo DATE, @page INT, @pageRows INT
AS
BEGIN
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1)*@pageRows
	SELECT TOP(@selectRows) *
	FROM (SELECT * FROM dbo.ListHoaDon WHERE ngayThanhToan >= @dateFrom AND ngayThanhToan <= @dateTo) AS ListHoaDon
	WHERE ListHoaDon.maHoaDon NOT IN (SELECT TOP(@exceptRows) ListHoaDon.maHoaDon FROM (SELECT * FROM dbo.ListHoaDon WHERE ngayThanhToan >= @dateFrom AND ngayThanhToan <= @dateTo) AS ListHoaDon)
END
GO
EXEC USP_GetListHoaDonByDateAndPage '2022-3-1' , '2022-6-1' , 1 , 1000
--12.10. Lấy số lượng hoá đơn theo khoảng ngày
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetNumHoaDonByDate')
	DROP PROC USP_GetNumHoaDonByDate
GO

CREATE PROC USP_GetNumHoaDonByDate
@dateFrom DATE, @dateTo DATE
AS
BEGIN
	SELECT COUNT(*) FROM dbo.HoaDon WHERE ngayThanhToan >= @dateFrom AND ngayThanhToan <= @dateTo
END
GO

--12.11. Lấy thông tin hoá đơn theo mã hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetHoaDonByMaHoaDon')
	DROP PROC USP_GetHoaDonByMaHoaDon
GO

CREATE PROC USP_GetHoaDonByMaHoaDon
@maHoaDon INT 
AS
BEGIN
	SELECT * FROM dbo.HoaDon WHERE maHoaDon = @maHoaDon
END
GO

--13. Quản lý chi tiết hoá đơn
--13.1. Thêm chi tiết hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_InsertChiTietHoaDon')
	DROP PROC USP_InsertChiTietHoaDon
GO

CREATE PROC USP_InsertChiTietHoaDon
@maHoaDon INT, @maMonAn INT, @soLuong INT 
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDon
	(
		maHoaDon,
		maMonAn,
		soLuong
	)
	VALUES
	(   @maHoaDon, -- maHoaDon - int
		@maMonAn, -- maMonAn - int
		@soLuong  -- soLuong - int
		)
END
GO

--13.2. Cập nhật chi tiết hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_UpdateChiTietHoaDon')
	DROP PROC USP_UpdateChiTietHoaDon
GO

CREATE PROC USP_UpdateChiTietHoaDon
@maHoaDon INT, @maMonAn INT, @soLuong INT 
AS
BEGIN
	DECLARE @soLuongOld INT
	SELECT @soLuongOld = soLuong FROM dbo.ChiTietHoaDon WHERE maHoaDon = @maHoaDon AND maMonAn = @maMonAn
	IF @soLuongOld + @soLuong > 0
		UPDATE dbo.ChiTietHoaDon SET soLuong += @soLuong WHERE maHoaDon = @maHoaDon AND maMonAn = @maMonAn
	ELSE 
		UPDATE dbo.ChiTietHoaDon SET soLuong = 0 WHERE maHoaDon = @maHoaDon AND maMonAn = @maMonAn
END
GO

--13.4. Lấy thông tin chi tiết hoá đơn theo mã bàn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListMonAnByMaBan')
	DROP PROC USP_GetListMonAnByMaBan
GO

CREATE PROC USP_GetListMonAnByMaBan
@maBan INT
AS
BEGIN
    SELECT tenMonAn,
           soLuong,
           gia
	FROM dbo.ChiTietHoaDon
	INNER JOIN dbo.HoaDon ON HoaDon.maHoaDon = ChiTietHoaDon.maHoaDon
	INNER JOIN dbo.MonAn ON MonAn.maMonAn = ChiTietHoaDon.maMonAn
	WHERE maBan = @maBan AND trangThai = 0
END
GO

--13.5. Kiểm tra món ăn có trong hoá đơn chưa
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_CheckMonAnTrongHoaDon')
	DROP PROC USP_CheckMonAnTrongHoaDon
GO

CREATE PROC USP_CheckMonAnTrongHoaDon
@maHoaDon INT, @maMonAn INT 
AS
BEGIN
    SELECT maHoaDon,
           tenMonAn,
           soLuong,
		   gia
	FROM dbo.ChiTietHoaDon 
	INNER JOIN dbo.MonAn ON MonAn.maMonAn = ChiTietHoaDon.maMonAn
	WHERE maHoaDon = @maHoaDon AND ChiTietHoaDon.maMonAn = @maMonAn
END
GO

--13.6. Lấy thông tin chi tiết hoá đơn theo mã hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListMonAnByMaHoaDon')
	DROP PROC USP_GetListMonAnByMaHoaDon
GO

CREATE PROC USP_GetListMonAnByMaHoaDon
@maHoaDon INT
AS
BEGIN
    SELECT tenMonAn,
           soLuong,
           gia
	FROM dbo.ChiTietHoaDon
	INNER JOIN dbo.HoaDon ON HoaDon.maHoaDon = ChiTietHoaDon.maHoaDon
	INNER JOIN dbo.MonAn ON MonAn.maMonAn = ChiTietHoaDon.maMonAn
	WHERE HoaDon.maHoaDon = @maHoaDon
END
GO

--14. Quản lý bàn
--14.1. Liệt kê danh sách bàn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListBan')
	DROP PROC USP_GetListBan
GO

CREATE PROC USP_GetListBan
AS
BEGIN
    SELECT * FROM dbo.Ban
END
GO

--14.2. Thay đổi số lượng bàn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_ChangeNumOfTable')
	DROP PROC USP_ChangeNumOfTable
GO

CREATE PROC USP_ChangeNumOfTable
@number INT
AS
BEGIN
    DELETE FROM dbo.Ban
	IF(@number>1)
	BEGIN
		DECLARE @i INT = 1
	    WHILE @i <= @number
		BEGIN
			INSERT INTO dbo.Ban
			(
				maBan,
				trangThai
			)
			VALUES
			(	@i,
				0  -- trangThai - int
				)
			SET @i = @i + 1
		END
	END
END
GO

--14.3. Liệt kê danh sách bàn trống
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListBanTrong')
	DROP PROC USP_GetListBanTrong
GO

CREATE PROC USP_GetListBanTrong
AS
BEGIN
    SELECT * FROM dbo.Ban WHERE trangThai = 0
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


