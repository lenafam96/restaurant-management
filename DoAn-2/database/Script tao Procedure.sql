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
    SELECT * FROM dbo.TaiKhoan WHERE role NOT LIKE -1
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
    SELECT * FROM dbo.DanhMucMon WHERE xoa = 0
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

--3.5. Liệt kê danh sách món ăn theo danh mục món
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_GetListMonAn')
	DROP PROC USP_GetListMonAn
GO

CREATE PROC USP_GetListMonAn
@maDanhMucMon INT
AS
BEGIN
    SELECT * FROM dbo.MonAn WHERE maDanhMucMon = @maDanhMucMon AND xoa = 0
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
    SELECT * FROM dbo.KhachHang WHERE ((sdt LIKE '%'+@textSearch+'%') OR (dbo.fuConvertToUnsign(hoTen) LIKE '%'+dbo.fuConvertToUnsign(@textSearch)+'%')) AND xoa = 0 AND maKhachHang NOT LIKE 1
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
    SELECT * FROM dbo.KhachHang WHERE xoa = 0 AND maKhachHang NOT LIKE 1
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

--9.2. Cập nhật thông tin Voucher
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

--9.3. Xoá thông tin voucher
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
    SELECT * FROM dbo.Voucher WHERE maVoucher = @maVoucher AND xoa = 0
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

--12.4. Thanh toán hoá đơn
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'USP_ThanhToanHoaDon')
	DROP PROC USP_ThanhToanHoaDon
GO

CREATE PROC USP_ThanhToanHoaDon
@maHoaDon INT, @maKhachHang INT, @diemCong INT, @diemTru INT, @tongTien INT, @maVoucher INT
AS
BEGIN
    UPDATE dbo.HoaDon SET maKhachHang = @maKhachHang, diemCong = diemCong, diemTru = @diemTru, tongTien = @tongTien, maVoucher = @maVoucher, ngayThanhToan = GETDATE(), trangThai = 1 WHERE maHoaDon = @maHoaDon;
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
    UPDATE dbo.ChiTietHoaDon SET soLuong += @soLuong WHERE maHoaDon = @maHoaDon AND maMonAn = @maMonAn
END
GO

--13.4. Lấy thông tin chi tiết hoá đơn theo mã hoá đơn
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
    SELECT * FROM dbo.ChiTietHoaDon WHERE maHoaDon = @maHoaDon AND maMonAn = @maMonAn
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


