﻿	USE master
	/* CREATE DATABASE QuanLyTraSuaDB2;
	USE QuanLyTraSuaDB2; */

	CREATE DATABASE QuanLyTraSuaDB3;

	USE QuanLyTraSuaDB3;


	-- Bảng KHACH
	CREATE TABLE KHACH (
		MAKH CHAR(6) PRIMARY KEY,
		HOTEN NVARCHAR(50) NOT NULL,
		SODIENTHOAI NVARCHAR(20) NOT NULL,
		EMAIL NVARCHAR(50),
		DIACHI NVARCHAR(100)
	);

	SELECT * FROM KHACH





	/* -- Bảng SANPHAM
	CREATE TABLE SANPHAM (
		MASP CHAR(5) PRIMARY KEY,
		TENSP NVARCHAR(100) NOT NULL,
		MOTA NVARCHAR(255),
		GIA FLOAT NOT NULL
	);

	SELECT * FROM SANPHAM */

	-- Bảng NHANVIEN
	/* 	CREATE TABLE NHANVIEN (
		MANV CHAR(5) PRIMARY KEY,
		HOTEN NVARCHAR(100) NOT NULL,
		SODIENTHOAI NVARCHAR(20) NOT NULL,
		EMAIL NVARCHAR(100),
		CHUCVU NVARCHAR(100) NOT NULL
	); */

	CREATE TABLE NHANVIEN
	(	MANV CHAR(6) NOT NULL,
		MANQL CHAR(6) NULL,
		HOTEN NVARCHAR(50),
		GIOITINH NCHAR(3),
		DIACHI NVARCHAR(50),
		SODIENTHOAI CHAR(20),
		CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
		CONSTRAINT FK_MANQL_MANV FOREIGN KEY (MANQL) REFERENCES NHANVIEN(MANV)
	)

	SELECT * FROM NHANVIEN

	CREATE TABLE CALAM
	(
		MACA CHAR(6) NOT NULL,
		TENCA NVARCHAR(20),
		THOIGIANBATDAU TIME,
		THOIGIANKETTHUC TIME,
		CONSTRAINT PK_CALAM PRIMARY KEY (MACA)
	)

	SELECT * FROM CALAM


	CREATE TABLE CHAMCONG
	(
		MACC CHAR(6) NOT NULL,
		MANV CHAR(6) NOT NULL,
		MACA CHAR(6) NOT NULL,
		NGAYLAM DATE,
		TRANGTHAI NVARCHAR(10),
		CONSTRAINT PK_CHAMCONG PRIMARY KEY (MACC),
		CONSTRAINT FK_CHAMCONG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
		CONSTRAINT FK_CHAMCONG_CALAM FOREIGN KEY (MACA) REFERENCES CALAM (MACA)
	)

	SELECT * FROM CHAMCONG


	CREATE TABLE BANGLUONG
	(
		MABL CHAR(6) NOT NULL,
		MANV CHAR(6) NOT NULL,
		THANGNAM NVARCHAR(8),
		LUONG FLOAT,
		CONSTRAINT PK_BANGLUONG PRIMARY KEY (MABL),
		CONSTRAINT FK_BANGLUONG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV)
	)

	SELECT * FROM BANGLUONG
	

	------------------------------
	CREATE TABLE SANPHAM
	(
		MASP CHAR(6) NOT NULL,
		TENSP NVARCHAR(50),
		GIABAN MONEY,
		TRANGTHAI NVARCHAR(20),
		CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP)
	)

	SELECT * FROM SANPHAM


	CREATE TABLE NGUYENLIEU
	(
		MANL CHAR(6) NOT NULL,
		TENNL NVARCHAR(50),
		DVT NVARCHAR(20),
		CONSTRAINT PK_NGUYENLIEU PRIMARY KEY (MANL)
	)

	SELECT * FROM NGUYENLIEU


	CREATE TABLE CONGTHUC
	(
		MASP CHAR(6) NOT NULL,
		MANL CHAR(6) NOT NULL,
		SOLUONG FLOAT,
		CONSTRAINT PK_CONGTHUC PRIMARY KEY (MASP, MANL),
		CONSTRAINT FK_CONGTHUC_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
		CONSTRAINT FK_CONGTHUC_NGUYENLIEU FOREIGN KEY (MANL) REFERENCES NGUYENLIEU(MANL)
	)

	SELECT * FROM CONGTHUC

	CREATE TABLE KHONL
	(
		MANL CHAR(6) NOT NULL,
		SOLUONG_CON INT,
		MIN_SOLUONG INT,
		CONSTRAINT PK_KHONL PRIMARY KEY (MANL),
		CONSTRAINT FK_KHONL_NGUYENLIEU FOREIGN KEY (MANL) REFERENCES NGUYENLIEU (MANL)
	)

	SELECT * FROM KHONL


------------------------------
	-- Bảng DONHANG
	CREATE TABLE DONHANG (
		MADH CHAR(6) PRIMARY KEY,
		MAKH CHAR(6),
		MANV CHAR(6),
		NGAYDH DATE NOT NULL DEFAULT GETDATE(),
		TONGTIEN FLOAT,
		CONSTRAINT FK_DONHANG_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACH(MAKH),
		CONSTRAINT FK_DONHANG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
	);

	SELECT * FROM DONHANG

	-- Bảng CHITIETDONHANG
	CREATE TABLE CHITIETDONHANG (
		MADH CHAR(6),
		MASP CHAR(6),
		MANV CHAR(6),
		SOLUONG INT NOT NULL,
		GIA FLOAT,
		PRIMARY KEY (MADH, MASP),
		CONSTRAINT FK_CHITIETDH_DONHANG FOREIGN KEY (MADH) REFERENCES DONHANG(MADH),
		CONSTRAINT FK_CHITIETDH_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)
	);

	SELECT * FROM CHITIETDONHANG

	-- Bảng NHACUNGCAP
	/* CREATE TABLE NHACUNGCAP (
		MANCC CHAR(5) PRIMARY KEY,
		TENNCC NVARCHAR(100) NOT NULL,
		SODIENTHOAI NVARCHAR(20),
		EMAIL NVARCHAR(100),
		DIACHI NVARCHAR(255)
	);

	SELECT * FROM NHACUNGCAP */

	-- Bảng users
	CREATE TABLE Users (
		Id INT PRIMARY KEY IDENTITY(1,1),
		MANV CHAR(6),
		Username NVARCHAR(100) UNIQUE NOT NULL,
		PasswordHash VARBINARY(64) NOT NULL,
		PasswordSalt VARBINARY(128) NOT NULL,
		CreatedAt DATETIME DEFAULT GETDATE(),
		CONSTRAINT FK_USERS_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
	);

	SELECT * FROM Users

	-- Bảng KHO
	/* CREATE TABLE KHO (
		MA_KHO CHAR(5) PRIMARY KEY,
		MASP CHAR(5),
		MANCC CHAR(5),
		SOLUONG INT NOT NULL,
		NGAY_CAP_NHAT DATE NOT NULL DEFAULT GETDATE(),
		CONSTRAINT FK_KHO_SANPHAM FOREIGN KEY (MASP) 		REFERENCES SANPHAM(MASP),
		CONSTRAINT FK_KHO_NHACUNGCAP FOREIGN KEY (MANCC) 	REFERENCES NHACUNGCAP(MANCC)
	);

	SELECT * FROM KHO */
--=========
	/* 	-- Ràng buộc UNIQUE cho Email của KHACH
		ALTER TABLE KHACH
		ADD CONSTRAINT UQ_KHACH_EMAIL UNIQUE (EMAIL);

		-- Ràng buộc UNIQUE cho Email của NHANVIEN
		ALTER TABLE NHANVIEN
		ADD CONSTRAINT UQ_NHANVIEN_EMAIL UNIQUE (EMAIL);

		-- Ràng buộc CHECK cho giá sản phẩm (GIA) phải lớn hơn 0
		ALTER TABLE SANPHAM
		ADD CONSTRAINT CK_SANPHAM_GIA CHECK (GIA > 0);

		-- Ràng buộc CHECK cho số lượng tồn kho (SOLUONG) phải lớn hơn 	hoặc bằng 0
		ALTER TABLE KHO
		ADD CONSTRAINT CK_KHO_SOLUONG CHECK (SOLUONG >= 0);

		ALTER TABLE NHANVIEN
		ADD CONSTRAINT DF_NHANVIEN_CHUCVU
		DEFAULT N'Nhân viên' FOR CHUCVU;

		-----------------
		--UNIQUE
	-------------------------------------------------------------
		ALTER TABLE CALAM
		ADD CONSTRAINT UNI_TENCA UNIQUE (TENCA)
		--============
		INSERT INTO CALAM VALUES ('CL100', N'Ca 1', 6, 12)
		INSERT INTO CALAM VALUES ('CL200', N'Ca 1', 6, 12)
		-------------------------------------------------------------
		ALTER TABLE SANPHAM
		ADD CONSTRAINT UNI_TENSP UNIQUE (TENSP)
		--============

		-------------------------------------------------------------
		ALTER TABLE NGUYENLIEU
		ADD CONSTRAINT UNI_TENNL UNIQUE (TENNL)
		--============

		-------------------------------------------------------------
		-------------------------------------------------------------
		--DEFAULT
		-------------------------------------------------------------
		ALTER TABLE BANGLUONG
		ADD CONSTRAINT DF_LUONG DEFAULT N'CHƯA XÁC ĐỊNH' FOR LUONG
		-------------------------------------------------------------
		-------------------------------------------------------------
		--CHECK
		-------------------------------------------------------------
		ALTER TABLE NHANVIEN
		ADD CONSTRAINT CHK_GIOITINH CHECK (GIOITINH = N'Nữ' OR 	GIOITINH = N'Nam')
		--============
		INSERT INTO NHANVIEN VALUES ('NV001', N'Phùng Ngọc Hân', 	N'bd', N'TP HCM', N'0123456789');
		-------------------------------------------------------------
		ALTER TABLE BANGLUONG
		ADD CONSTRAINT CHK_LUONG CHECK (LUONG > 0)
		--============

		-------------------------------------------------------------
		ALTER TABLE SANPHAM
		ADD CONSTRAINT CHK_GIABAN CHECK (GIABAN > 0)
		--============

		-------------------------------------------------------------
		ALTER TABLE CONGTHUC
		ADD CONSTRAINT CHK_SOLUONG CHECK (SOLUONG > 0)
		--============

		-------------------------------------------------------------
		ALTER TABLE KHONL
		ADD CONSTRAINT CHK_SOLUONG_CON CHECK (SOLUONG_CON >= 0)
		--============

		-------------------------------------------------------------
		ALTER TABLE KHONL
		ADD CONSTRAINT CHK_MIN_SOLUONG CHECK (MIN_SOLUONG >= 0) */
--============


	-- nhập liệu cho các bảng
	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0011', N'Trần Bảo A', '0774526747', 'tranbaoa@gmail.com', N'123 Đường BCD, Quận Gò Vấp, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0001', N'Nguyễn Văn A', '0912345678', 'nguyenvana@gmail.com', N'123 Đường ABC, Quận 1, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0002', N'Trần Thị B', '0987654321', 'tranthib@gmail.com', N'456 Đường XYZ, Quận 2, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0003', N'Lê Văn C', '0901234567', 'levanc@gmail.com', N'789 Đường DEF, Quận 3, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0004', N'Phạm Thị D', '0934567890', 'phamthid@gmail.com', N'321 Đường GHI, Quận 4, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0005', N'Vũ Văn E', '0923456789', 'vuvane@gmail.com', N'654 Đường JKL, Quận 5, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0006', N'Hoàng Thị F', '0918765432', 'hoangthif@gmail.com', N'987 Đường MNO, Quận 6, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0007', N'Ngô Văn G', '0912349876', 'ngovang@gmail.com', N'111 Đường PQR, Quận 7, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0008', N'Phan Thị H', '0908765432', 'phanthih@gmail.com', N'222 Đường STU, Quận 8, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0009', N'Tô Văn I', '0932109876', 'tovanii@gmail.com', N'333 Đường VWX, Quận 9, TP.HCM');

	INSERT INTO KHACH (MAKH, HOTEN, SODIENTHOAI, EMAIL, DIACHI)
	VALUES ('KH0010', N'Đinh Thị J', '0945671234', 'dinhthij@gmail.com', N'444 Đường YZ, Quận 10, TP.HCM');

	SELECT * FROM KHACH

	-- nhập liệu cho sản phẩm
	/* INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP001', N'Trà sữa trân châu đường đen', N'Trà sữa với trân châu dai ngon và đường đen thơm ngon', 35000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP002', N'Trà sữa matcha', N'Trà sữa vị matcha thơm mát, kết hợp với trân châu trắng', 40000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP003', N'Trà đào cam sả', N'Trà trái cây với vị đào tươi mát, kết hợp với cam và sả', 45000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP004', N'Trà xanh sữa', N'Trà sữa vị trà xanh, thơm ngon và mát lạnh', 38000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP005', N'Trà sữa oolong', N'Trà sữa vị oolong đậm đà, kết hợp với trân châu hoàng kim', 42000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP006', N'Trà sữa socola', N'Trà sữa vị socola đậm đà, kết hợp với hạt trân châu mềm dẻo', 40000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP007', N'Trà sữa hạt dẻ', N'Trà sữa với vị hạt dẻ béo ngậy, thơm ngon', 43000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP008', N'Sữa tươi trân châu đường đen', N'Sữa tươi kết hợp với trân châu đường đen đặc biệt', 37000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP009', N'Trà sữa hồng trà', N'Trà sữa với hương vị hồng trà đậm đà, kết hợp với trân châu', 39000);

	INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA)
	VALUES ('SP010', N'Trà sữa dâu tây', N'Trà sữa vị dâu tây thơm mát, kết hợp với thạch Trài cây', 42000);

	SELECT * FROM SANPHAM */

	-- NHẬP LIỆU CHO NHÂN VIÊN
	/* INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV001', N'Phạm Văn K', '0912345678', 'phamvank@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV002', N'Nguyễn Thị L', '0987654321', 'nguyenthil@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV003', N'Trương Văn M', '0901234567', 'truongvanm@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV004', N'Đào Thị N', '0934567890', 'daothin@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV005', N'Lý Văn O', '0923456789', 'lyvano@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV006', N'Nguyễn Thị P', '0945678901', 'nguyenthp@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV007', N'Trần Văn Q', '0956789012', 'tranvanq@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV008', N'Lê Thị R', '0967890123', 'lethir@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV009', N'Võ Văn S', '0978901234', 'vovans@gmail.com', N'Nhân viên pha chế');

	INSERT INTO NHANVIEN (MANV, HOTEN, SODIENTHOAI, EMAIL, CHUCVU)
	VALUES ('NV010', N'Phạm Thị T', '0989012345', 'phamthit@gmail.com', N'Nhân viên pha chế'); */


	/* 	SELECT * FROM NHANVIEN */
	--------------
	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0001', N'Nguyễn Kim Yến', N'Nữ', N'TP. HCM', '0909123456');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0002', N'Trịnh Kim Oanh', N'Nữ', N'TP. HCM', '0912345678');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0003', N'Lê Lệ Yến', N'Nữ', N'TP. HCM', '0923456789');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0004', N'Nguyễn Văn Minh', N'Nam', N'TP. HCM', '0123456789');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0005', N'Huỳnh Ngọc Hân', N'Nữ', N'TP. HCM', '0987654321');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0006', N'Lam Bích Vân', N'Nữ', N'TP. HCM', '0987624321');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0007', N'Nguyễn Thanh Nam', N'Nam', N'TP. HCM', '0986911221');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0008', N'Lê Văn Khánh', N'Nam', N'TP. HCM', '0987734321');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0009', N'Chu Bảo Châu', N'Nữ', N'TP. HCM', '0997654341');

	INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, DIACHI, SODIENTHOAI) 
	VALUES ('NV0010', N'Trần Đình Trọng', N'Nam', N'TP. HCM', '0944234321');


	SELECT * FROM NHANVIEN;

	-- không liệt kê manql trong mệnh đề liệt kê cột, manql sẽ được thêm vào sau

	--CALAM(MACA, TENCA, THOIGIANBD, THOIGIANKT)
	INSERT INTO CALAM VALUES ('CL0001', N'Ca Sáng', '6:00:00', '12:00:00');
	INSERT INTO CALAM VALUES ('CL0002', N'Ca Chiều', '11:30:00', '18:00:00');
	INSERT INTO CALAM VALUES ('CL0003', N'Ca Tối', '17:30:00', '22:00:00');

	SELECT * FROM CALAM;

	SELECT FORMAT(GETDATE(), 'dd/MM/yyyy') AS FormattedDate;


	--CHAMCONG(MACC, MANV, MACA, NGAYLAM, TRANGTHAI)
	INSERT INTO CHAMCONG VALUES ('CC0001', 'NV0001', 'CL0001', '2024-08-22', N'có');
	INSERT INTO CHAMCONG VALUES ('CC0002', 'NV0002', 'CL0002', '2024-08-22', N'không');
	INSERT INTO CHAMCONG VALUES ('CC0003', 'NV0003', 'CL0003', '2024-08-22', N'không');
	INSERT INTO CHAMCONG VALUES ('CC0004', 'NV0004', 'CL0002', '2024-08-22', N'Có');
	INSERT INTO CHAMCONG VALUES ('CC0005', 'NV0005', 'CL0003', '2024-08-22', N'Có');

	SELECT * FROM CHAMCONG;

	--BANGLUONG(MABL, MANV, THANGNAM, LUONG)
	INSERT INTO BANGLUONG VALUES ('BL0001', 'NV0001', '08/2024', NULL);
	INSERT INTO BANGLUONG VALUES ('BL0002', 'NV0002', '08/2024', NULL);
	INSERT INTO BANGLUONG VALUES ('BL0003', 'NV0003', '08/2024', NULL);

	SELECT * FROM BANGLUONG;

	/*
	--QUẢN LÝ SẢN PHẨM
	*/
	--SANPHAM(MASP, TENSP, GIABAN, TRANGTHAI)
	INSERT INTO SANPHAM VALUES ('SP0001', N'Trà Sữa Trân châu', 28000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0002', N'Trà Sữa Matcha', 30000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0003', N'Trà Sữa Matcha', 30000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0004', N'Trà Đào', 28000, N'Hết hàng');
	INSERT INTO SANPHAM VALUES ('SP0005', N'Trà Vải', 28000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0006', N'Trà Sữa Trân châu Choco', 28000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0007', N'Trà Sữa Thái Xanh', 34000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0008', N'Trà Sữa Khoai Môn', 30000, N'Hết hàng');
	INSERT INTO SANPHAM VALUES ('SP0009', N'Trà Việt quất Boba', 28000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0010', N'Trà Atiso đỏ Boba', 28000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0011', N'Trà Xanh Sencha', 32000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0012', N'Trà Ô Long', 35000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0013', N'Trà Đen Assam', 30000, N'Hết hàng');
	INSERT INTO SANPHAM VALUES ('SP0014', N'Trà Trắng Bạch Mẫu Đơn', 45000, N'Còn hàng');
	INSERT INTO SANPHAM VALUES ('SP0015', N'Trà Hoa Cúc', 25000, N'Còn hàng');

	
	SELECT * FROM SANPHAM;

	--NGUYENLIEU(MANL, TENNL, DVT)
	INSERT INTO NGUYENLIEU VALUES ('NL0001', N'Trà Đen', N'gói');
	INSERT INTO NGUYENLIEU VALUES ('NL0002', N'Sữa Tươi', N'lít');
	INSERT INTO NGUYENLIEU VALUES ('NL0003', N'Sữa Đặc', N'lít');
	INSERT INTO NGUYENLIEU VALUES ('NL0004', N'Đường Nước', N'kg');

	SELECT * FROM NGUYENLIEU;

	--CONGTHUC(MASP, MANL, SOLUONG)
	INSERT INTO CONGTHUC VALUES ('SP0001', 'NL0001', 1);
	INSERT INTO CONGTHUC VALUES ('SP0001', 'NL0003', 0.04);
	INSERT INTO CONGTHUC VALUES ('SP0002', 'NL0001', 1);
	INSERT INTO CONGTHUC VALUES ('SP0002', 'NL0002', 0.4);
	INSERT INTO CONGTHUC VALUES ('SP0002', 'NL0003', 0.15);

	SELECT * FROM CONGTHUC;

	--KHONL(MANL, SOLUONG_CON, MIN_SOLUONG)

	INSERT INTO KHONL VALUES ('NL0001', 100, 20);
	INSERT INTO KHONL VALUES ('NL0002', 50, 10);
	INSERT INTO KHONL VALUES ('NL0003', 80, 15);

	SELECT * FROM KHONL;



	-- NHẬP LIỆU CHO ĐƠN HÀNG
	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0001', 'KH0003', 'NV0007', '2024-08-01', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0002', 'KH0007', 'NV0010', '2024-08-02', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0003', 'KH0001', 'NV0005', '2024-08-03', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0004', 'KH0005', 'NV0008', '2024-08-04', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0005', 'KH0010', 'NV0003', '2024-08-05', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0006', 'KH0002', 'NV0009', '2024-08-06', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0007', 'KH0006', 'NV0002', '2024-08-07', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0008', 'KH0009', 'NV0001', '2024-08-08', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0009', 'KH0004', 'NV0004', '2024-08-09', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0010', 'KH0008', 'NV0006', '2024-08-10', NULL);

	INSERT INTO DONHANG (MADH, MAKH, MANV, NGAYDH, TONGTIEN)
	VALUES ('DH0011', 'KH0008', 'NV0006', '2024-09-10', NULL);

	SELECT * FROM DONHANG

	-- NHẬP LIỆU CHO CHI TIẾT ĐƠN HÀNG
	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0001', 'SP0001', 'NV0007', 2, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0002', 'SP0003', 'NV0010', 1, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0003', 'SP0004', 'NV0005', 3, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0004', 'SP0002', 'NV0008', 1, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0005', 'SP0007', 'NV0003', 2, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0006', 'SP0005', 'NV0009', 4, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0007', 'SP0008', 'NV0002', 1, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0008', 'SP0009', 'NV0001', 3, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0009', 'SP0006', 'NV0004', 2, NULL);

	INSERT INTO CHITIETDONHANG (MADH, MASP, MANV, SOLUONG, GIA)
	VALUES ('DH0010', 'SP0010', 'NV0006', 5, NULL);

	SELECT * FROM CHITIETDONHANG

	-- NHẬP LIỆU CHO NHÀ CUNG CẤP
		/* INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC01', N'Trà Sữa Sài Gòn', '0901234567', 'trasuasaigon@gmail.com', N'123 Đường A, Quận 1, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC02', N'Thực Phẩm Trà Sữa', '0912345678', 'thucphamtrasua@gmail.com', N'456 Đường B, Quận 2, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC03', N'Nguyên Liệu Trà Sữa ABC', '0923456789', 'nguyenlieutrasuaabc@gmail.com', N'789 Đường C, Quận 3, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC04', N'Trà Sữa Xanh', '0934567890', 'trasuaxanh@gmail.com', N'101 Đường D, Quận 4, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC05', N'Sản Phẩm Trà Sữa GHI', '0945678901', 'sanphamtrasuaghi@gmail.com', N'202 Đường E, Quận 5, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC06', N'Nguyên Liệu Trà Sữa 123', '0956789012', 'nguyenlieutrasua123@gmail.com', N'303 Đường F, Quận 6, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC07', N'Trà Sữa Hưng Thịnh', '0967890123', 'trasuahungthinh@gmail.com', N'404 Đường G, Quận 7, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC08', N'Đại Lý Trà Sữa', '0978901234', 'dailyttrasua@gmail.com', N'505 Đường H, Quận 8, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC09', N'Trà Sữa Cao Cấp', '0989012345', 'trasuacaocap@gmail.com', N'606 Đường I, Quận 9, TP. HCM');

		INSERT INTO NHACUNGCAP (MANCC, TENNCC, SODIENTHOAI, EMAIL, DIACHI)
		VALUES ('NCC10', N'Sản Phẩm Trà Sữa Hiệu X', '0990123456', 'sanphamtrasuax@gmail.com', N'707 Đường J, Quận 10, TP. HCM');


		SELECT * FROM NHACUNGCAP */

	-- nhập liệu kho
	/* INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO01', 'SP001', 'NCC03', 75, '2024-07-25');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO02', 'SP007', 'NCC02', 200, '2024-07-30');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO03', 'SP005', 'NCC08', 130, '2024-07-20');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO04', 'SP010', 'NCC06', 90, '2024-07-15');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO05', 'SP002', 'NCC10', 160, '2024-07-05');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO06', 'SP003', 'NCC07', 85, '2024-06-20');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO07', 'SP006', 'NCC09', 190, '2024-06-25');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO08', 'SP008', 'NCC05', 145, '2024-06-30');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO09', 'SP009', 'NCC04', 110, '2024-07-02');

	INSERT INTO KHO (MA_KHO, MASP, MANCC, SOLUONG, NGAY_CAP_NHAT)
	VALUES ('KHO10', 'SP004', 'NCC01', 165, '2024-07-10');

	SELECT * FROM KHO */

	---	
	--Truy vấn lồng
	--Truy vấn lồng phân cấp: Tìm các khách hàng đã đặt hàng trong tháng hiện tại
	SELECT *
	FROM KHACH k
	WHERE k.MAKH NOT IN (
		SELECT MAKH
		FROM DONHANG dh
		WHERE dh.NGAYDH >= DATEADD(MONTH, -1, GETDATE())
	)

	--Truy vấn lồng tương quan


	--Tìm tất cả các đơn hàng đã được đặt bởi khách hàng có mã là KH0008
	SELECT *
	FROM DONHANG dh
	WHERE dh.MADH IN (
		SELECT DONHANG.MADH
		FROM DONHANG 
		JOIN KHACH k ON k.MAKH = DONHANG.MAKH
		WHERE k.MAKH IN ('KH0008')
	)

	--Tìm tất cả các khách hàng và số lượng đơn hàng của họ, bao gồm cả những khách hàng không có đơn hàng.
	select  k.MAKH, k.HOTEN, COUNT(dh.MADH) as 'Tổng đơn hàng'
	from KHACH k
	left join DONHANG dh ON k.MAKH = dh.MAKH
	group by k.MAKH, k.HOTEN

	--tìm các sản phẩm chưa được đặt hàng trong bất kỳ đơn hàng nào
	select s.MASP, S.TENSP
	from SANPHAM S
	where s.MASP not in (
		select distinct c.MASP
		from CHITIETDONHANG C
	)

	-- tìm các nhân viên chưa chấm công
	select NHANVIEN.MANV, CHAMCONG.MACC from CHAMCONG
	right join NHANVIEN on NHANVIEN.MANV = CHAMCONG.MANV

	-- select kiemtra CAC BANG DANG CO
	SELECT * FROM BANGLUONG
	SELECT * FROM CALAM
	SELECT * FROM CHAMCONG
	SELECT * FROM CHITIETDONHANG
	SELECT * FROM CONGTHUC
	SELECT * FROM DONHANG
	SELECT * FROM KHACH
	SELECT * FROM KHONL
	SELECT * FROM NGUYENLIEU
	SELECT * FROM NHANVIEN
	SELECT * FROM SANPHAM
	SELECT * FROM Users

	use QuanLyTraSuaDB2

	-- thủ tục
	SELECT name
FROM sys.procedures;

/* drop procedure XEM_BANG_SANPHAM
drop procedure XEM_BANG_NHANVIEN
drop procedure XEM_BANG_KHACH
drop procedure XEM_BANG_DONHANG
drop procedure XEM_BANG_CHITIETDONHANG
drop procedure XEM_VIEW_DONHANG
drop procedure XEM_VIEW_CHITIETDONHANG */
GO -- Batch separator để bắt đầu đoạn lệnh mới

-- Tạo các stored procedure
CREATE PROCEDURE XEM_BANG_SANPHAM 
AS 
BEGIN
    SELECT * FROM SANPHAM;
END;
GO

CREATE PROCEDURE XEM_BANG_NHANVIEN 
AS 
BEGIN
    SELECT * FROM NHANVIEN;
END;
GO

CREATE PROCEDURE XEM_BANG_KHACH 
AS 
BEGIN
    SELECT * FROM KHACH;
END;
GO

CREATE PROCEDURE XEM_BANG_DONHANG 
AS 
BEGIN
    SELECT * FROM DONHANG;
END;
GO

CREATE PROCEDURE XEM_BANG_CHITIETDONHANG 
AS 
BEGIN
    SELECT * FROM CHITIETDONHANG;
END;
GO

CREATE PROCEDURE XEM_VIEW_DONHANG 
AS 
BEGIN
    SELECT * FROM V_DONHANG;
END;
GO

CREATE PROCEDURE XEM_VIEW_CHITIETDONHANG 
AS 
BEGIN
    SELECT * FROM V_CHITIETDONHANG;
END;
GO
-- THỦ TỤC TRANG DANGNHAPSQL
CREATE PROCEDURE LAY_USER_ID (@Username NVARCHAR(50))
AS 
BEGIN
    SELECT UserID FROM Users_ID_Store WHERE Username = @Username
END;
GO


GO
CREATE PROCEDURE THEM_USER_MOI_DANGNHAPSQL (@Username NVARCHAR(50))
AS 
BEGIN
    INSERT INTO Users_ID_Store (Username) VALUES (@Username)
END;

GO

GO
CREATE PROCEDURE LOGIN_CHECK_QUERY_DANGNHAPSQL (@UserID INT)
AS 
BEGIN
    SELECT COUNT(*) FROM UserSessions WHERE UserID = @UserID
END;

GO
GO
CREATE PROCEDURE LOGIN_UPDATE_QUERY_DANGNHAPSQL (@UserID INT, @IsLoggedIn BIT)
AS 
BEGIN
    UPDATE UserSessions SET IsLoggedIn = @IsLoggedIn WHERE UserID = @UserID
END;
GO
GO
CREATE PROCEDURE LOGIN_INSERT_QUERY_DANGNHAPSQL (
    @SessionID uniqueidentifier,
    @UserID int,
    @LoginTime datetime,
    @IsLoggedIn bit)
AS
BEGIN
    INSERT INTO UserSessions (SessionID, UserID, LoginTime, IsLoggedIn)
    VALUES (@SessionID, @UserID, @LoginTime, @IsLoggedIn);
END;
GO

GO
CREATE PROCEDURE LOGOUT_UPDATE_QUERY_DANGNHAPSQL (@UserID INT, @IsLoggedIn BIT)
AS 
BEGIN
    UPDATE UserSessions SET IsLoggedIn = @IsLoggedIn WHERE UserID = @UserID
END;
GO
CREATE PROCEDURE IsUserLoggedIn_DANGNHAPSQL (@UserID INT)
AS 
BEGIN
    SELECT IsLoggedIn FROM UserSessions WHERE UserID = @UserID
END;

GO
CREATE PROCEDURE CreateLogin
    @username nvarchar(100),
    @password nvarchar(100)
AS
BEGIN
    DECLARE @sql nvarchar(4000);
    
    SET @sql = 'CREATE LOGIN [' + @username + '] WITH PASSWORD = ''' + @password + '''';
    
    EXEC sp_executesql @sql;
END;


GO
EXEC CreateLogin @username = 'new_user', @password = 'Password!';

GO

CREATE PROCEDURE CreateUserForLogin
    @username nvarchar(100),
    @loginname nvarchar(100)
AS
BEGIN

    DECLARE @sql nvarchar(4000);
    
    SET @sql = 'CREATE USER [' + @username + '] FOR LOGIN [' + @loginname + ']';
    
    EXEC sp_executesql @sql;
END;


GO
-- tạo thủ tục cho sản phẩm
CREATE PROCEDURE LAY_MASP_TU_SP_SANPHAM 
AS 
BEGIN
    SELECT SANPHAM.MASP FROM SANPHAM
END;

GO

CREATE PROCEDURE InsertSanPham
    @masp nvarchar(50),
    @tensp nvarchar(100),
    @giatien decimal(18, 2),
    @trangthai nvarchar(50)
AS
BEGIN
    INSERT INTO SANPHAM (MASP, TENSP, GIABAN, TRANGTHAI)
    VALUES (@masp, @tensp, @giatien, @trangthai);
END;

GO
CREATE PROCEDURE DeleteSanPham
    @masp nvarchar(50)
AS
BEGIN
    DELETE FROM SANPHAM WHERE MASP = @masp;
END;

GO
CREATE PROCEDURE UpdateSanPham
    @masp_sua nvarchar(50),
    @tensp nvarchar(100),
    @giatien decimal(18, 2),
    @trangthai nvarchar(50)
AS
BEGIN
    UPDATE SANPHAM
    SET TENSP = @tensp,
        GIABAN = @giatien,
        TRANGTHAI = @trangthai
    WHERE MASP = @masp_sua;
END;
GO
CREATE PROCEDURE SelectSanPhamByTen
    @tensp nvarchar(100)
AS
BEGIN
    SELECT * 
    FROM SANPHAM
    WHERE TENSP = @tensp;
END;
GO
CREATE PROCEDURE SelectSanPhamByMa
    @masp nvarchar(50)
AS
BEGIN
    SELECT * 
    FROM SANPHAM
    WHERE MASP = @masp;
END;

GO
CREATE PROCEDURE SelectDonHangByMaKhach
    @makh nvarchar(50)
AS
BEGIN
    SELECT * 
    FROM DONHANG dh 
    WHERE dh.MADH IN (
        SELECT DONHANG.MADH 
        FROM DONHANG 
        JOIN KHACH k ON k.MAKH = DONHANG.MAKH 
        WHERE k.MAKH = @makh
    );
END;
GO	
CREATE PROCEDURE SelectSanPhamNotInChiTietDonHang
AS
BEGIN
    SELECT s.MASP, s.TENSP 
    FROM SANPHAM s 
    WHERE s.MASP NOT IN (SELECT DISTINCT c.MASP FROM CHITIETDONHANG c);
END;
GO
-- end thủ tục sản phẩm



















	












