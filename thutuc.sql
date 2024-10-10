use QuanLyTraSuaDB2;
GO
/*=====================================================================================================*/

-- TẠO THỦ TỤC CHO DONHANG

--SELECT DONHANG.MADH FROM DONHANG
CREATE PROCEDURE LAY_MADH_TU_DH_DONHANG 
AS 
BEGIN
    SELECT DONHANG.MADH FROM DONHANG
END;
GO
CREATE PROCEDURE InsertDonHang(
	@madh char(6),
    @makh char(6),
    @manv char(6),
    @ngaydonhang date
	)
AS
BEGIN
    INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH)
    VALUES (@madh, @makh, @manv, @ngaydonhang);
END;
GO
CREATE PROCEDURE DeleteDonHang
    @madh char(6)
AS
BEGIN
    DELETE FROM DONHANG WHERE MADH = @madh;
END;

GO
CREATE PROCEDURE UpdateDonHang(
	@madhsua char(6),
    @makh char(6),
    @manv char(6),
    @ngaydonhang date)
AS
BEGIN
    UPDATE DONHANG
    SET MAKH = @makh,
		MANV = @manv,
		NGAYDH = @ngaydonhang
	WHERE MADH = @madhsua
END;
GO
-- end thủ tục DONHANG
/*=====================================================================================================*/
/*form KhachHang*/

--TẠO THỦ TỤC CHO KHACH
GO
CREATE PROCEDURE LAY_MAKH_TU_KH_KHACH 
AS 
BEGIN
    SELECT KHACH.MAKH FROM KHACH 
END;
GO
CREATE PROCEDURE InsertKhach(
	@makh char(6),
	@hoten nvarchar(50),
	@sodienthoai nvarchar(20),
	@email nvarchar(50),
	@diachi nvarchar(100)
	)
AS
BEGIN
    INSERT INTO KHACH(MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
    VALUES (@makh, @hoten, @sodienthoai, @email, @diachi);
END;
GO
CREATE PROCEDURE DeleteKhach
    @makh char(6)
AS
BEGIN
    DELETE FROM KHACH WHERE MAKH = @makh;
END;
GO
CREATE PROCEDURE UpdateKhach
(
	@makhsua char(6),
	@hoten nvarchar(50),
	@sodienthoai nvarchar(20),
	@email nvarchar(50),
	@diachi nvarchar(100)
)
AS
BEGIN
    UPDATE KHACH
    SET HOTEN = @hoten,
		SODIENTHOAI = @sodienthoai,
		EMAIL = @email,
		DIACHI = @diachi
	WHERE MAKH = @makhsua
END;
/*
SELECT * FROM DONHANG dh 
WHERE dh.MADH IN (	SELECT DONHANG.MADH 
					FROM DONHANG JOIN KHACH k ON k.MAKH = DONHANG.MAKH 
					WHERE k.MAKH IN ('{makh}')
*/
GO
CREATE PROCEDURE LayDonHangTheoKhachHang(
    @makh char(6)
)
AS
BEGIN
    SELECT * 
    FROM DONHANG 
    WHERE DONHANG.MADH IN (
						SELECT DONHANG.MADH 
						FROM DONHANG, KHACH
						WHERE DONHANG.MAKH = KHACH.MAKH
						AND KHACH.MAKH = @makh)
END
GO

SELECT * 
    FROM DONHANG 
    WHERE DONHANG.MADH IN (
						SELECT DONHANG.MADH 
						FROM DONHANG, KHACH
						WHERE DONHANG.MAKH = KHACH.MAKH
						AND KHACH.MAKH = 'KH0001')
/*NhanVien*/
--SELECT NHANVIEN.MANV FROM NHANVIEN
GO
-- end thủ tục KHACH
/*=====================================================================================================*/
/*form NhanVien*/

-- TẠO THỦ TỤC CHO NHANVIEN

CREATE PROCEDURE LAY_MANV_TU_NV_NHANVIEN 
AS 
BEGIN
    SELECT NHANVIEN.MANV FROM NHANVIEN 
END;
GO
CREATE PROCEDURE InsertNhanVien(
	@manv char(6),
	@hoten nvarchar(50),
	@gioitinh nchar(3),
	@diachi nvarchar(50),
	@sodienthoai char(20)
	)
AS
BEGIN
	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI)
	VALUES (@manv, @hoten, @gioitinh, @diachi, @sodienthoai)
END
GO
CREATE PROCEDURE DeleteNhanVien
    @manv char(6)
AS
BEGIN
    DELETE FROM NHANVIEN WHERE MANV = @manv;
END;
GO
CREATE PROCEDURE UpdateNhanVien
(
	@manvsua char(6),
	@hoten nvarchar(50),
	@sodienthoai char(20),
	@gioitinh nchar(3),
	@diachi nvarchar(50)
)
AS
BEGIN
    UPDATE NHANVIEN
    SET HOTEN = @hoten,
		SODIENTHOAI = @sodienthoai,
		GIOITINH = @gioitinh,
		DIACHI = @diachi
	WHERE MANV = @manvsua
END;
GO
-- end thủ tục NHANVIEN
/*=====================================================================================================*/
/*Cài đặt chức năng gọi thủ tục bên trong có chứa --cấu trúc rẽ nhánh, --cấu trúc lặp hoặc 
--các hàm có sẵn */
GO
SELECT SOLUONG_CON 
FROM KHONL 
WHERE MANL = 'NL0001'

--THỦ TỤC CÓ CHỨA CẤU TRÚC RẼ NHÁNH
SELECT COUNT(*)
FROM CONGTHUC, KHONL
WHERE CONGTHUC.MANL = KHONL.MANL
AND CONGTHUC.MASP = 'SP0001'
AND CONGTHUC.SOLUONG > KHONL.SOLUONG_CON;

SELECT * FROM CONGTHUC
SELECT * FROM KHONL

GO
CREATE PROCEDURE KTRA_TRANGTHAI_SP (@masp CHAR(6))
AS
	BEGIN
		DECLARE @NguyenLieuThieu INT = 0;

		SELECT @NguyenLieuThieu = COUNT(*)
		FROM CONGTHUC, KHONL
		WHERE CONGTHUC.MANL = KHONL.MANL
		AND CONGTHUC.MASP = @masp
		AND CONGTHUC.SOLUONG > KHONL.SOLUONG_CON;

		IF @NguyenLieuThieu > 0
		BEGIN
			UPDATE SANPHAM
			SET TRANGTHAI = N'Hết hàng'
			WHERE MASP = @MASP;
		END
		ELSE
		BEGIN
			UPDATE SANPHAM
			SET TRANGTHAI = N'Còn hàng'
			WHERE MASP = @MASP;
		END
	END
GO

EXEC KTRA_TRANGTHAI_SP @masp = 'SP0001'

UPDATE KHONL
SET SOLUONG_CON = 0
WHERE MANL = 'NL0001'

SELECT * FROM KHONL;
SELECT * FROM SANPHAM;
SELECT * FROM CONGTHUC;

--THỦ TỤC CÓ CHƯA CẤU TRÚC LẶP
----------------------------------------------------------------------------------
/*Form ChiTietDonHang*/
--TẠO THỦ TỤC CHO CHITIETDONHANG
GO
CREATE PROCEDURE LAY_MADH_MASP_TU_V_CHITIETDONHANG
AS 
BEGIN
    SELECT MADH, MASP FROM V_CHITIETDONHANG
END
--INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG) VALUES ('{madh}', '{masp}', '{manv}', '{soluong_num}');
GO
CREATE PROCEDURE InsertChiTietDonHang
    @madh char(6),
    @masp char(6),
	@manv char(6),
	@soluong_num INT
AS
BEGIN
    INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG) 
	VALUES (@madh, @masp, @manv, @soluong_num);
END;
GO
CREATE PROCEDURE DeleteChiTietDonHang
    @madh char(6),
	@masp char(6)
AS
BEGIN
    DELETE FROM CHITIETDONHANG WHERE MADH = @madh AND MASP = @masp
END;
GO
CREATE PROCEDURE UpdateChiTietDonHang
	@manv char(6),
	@soluong int,
	@madhsua char(6),
	@maspsua char(6)
AS
BEGIN
    UPDATE CHITIETDONHANG 
	SET MANV = @manv, SOLUONG = @soluong 
	WHERE MADH = @madhsua 
	AND MASP = @maspsua;
END;
GO