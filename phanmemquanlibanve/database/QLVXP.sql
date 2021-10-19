use QL_RapChieuPhim
go 
create table NhanVien
(
   MaNv VARCHAR(5) primary  key,
   TenNv nvarchar(35) not null,
   CMND varchar(12) not null,
   NgaySinh datetime not null,
   Diachi nvarchar(35),
   SDT varchar(10),
   ChucVu nvarchar(10),
)
GO 

create table TaiKhoan
(
	UserName varchar(10) not null ,
	MatKhau varchar(13) not null ,
	LoaiTK int not null default 2 , --1:admin || 2: bán vé 
	MaNv VARCHAR(5)  not null ,
	foreign  key  (MaNv) references dbo.nhanvien(MaNv),
)
GO

CREATE TABLE LoaiMH(
	IDMH CHAR(4) PRIMARY KEY NOT NULL ,
	TenMH  NCHAR(10) NOT NULL,

)
GO	

CREATE TABLE PhongChieu
(
	MaPhong VARCHAR(5) PRIMARY KEY NOT NULL,
	TenPhong NCHAR(6) NOT NULL,	
	SoGhe INT  NOT NULL,
	DienTich FLOAT NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1 ,--0 : Không Hoạt động ||  1: hoạt động
	IDMH CHAR(4) NOT NULL ,
	FOREIGN KEY (IDMH) REFERENCES dbo.LoaiMH(IDMH),	
)
GO	

CREATE TABLE TheLoai
(
	MaTL VARCHAR(10) PRIMARY KEY,
	TenTL NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(100)
)		
GO
--ALTER TABLE dbo.TheLoai ALTER COLUMN TenTL NVARCHAR(10)

CREATE TABLE Phim (
	MaPhim VARCHAR(5) PRIMARY KEY  NOT NULL,
	MaTL  VARCHAR(10)  NOT NULL,
	TenPhim NVARCHAR(30) NOT NULL,
	DaoDien NVARCHAR(30) ,
	NgaySX DATETIME	NOT NULL,
	ThoiLuong FLOAT NOT NULL,
	NgayKhoiChieu DATE ,
	NgayKetThuc  DATE,
	NoiDung NVARCHAR(200),
	Anh IMAGE ,

	FOREIGN KEY (MaTL) REFERENCES  dbo.TheLoai(MaTL),	
	
)
GO	

CREATE TABLE DinhDangPhim(
	ID VARCHAR(15) PRIMARY KEY NOT NULL,
	MaPhim VARCHAR(5),
	IDMH CHAR(4),

	FOREIGN KEY (MaPhim) REFERENCES dbo.Phim(MaPhim),
	FOREIGN KEY (IDMH) REFERENCES dbo.LoaiMH(IDMH),
)
GO



CREATE TABLE LichChieu(
	MaLC VARCHAR(5) PRIMARY KEY NOT NULL,
	NgayChieu DATETIME NOT NULL,
	GioChieu  TIME  NOT NULL,
	MaPhong VARCHAR(5) NOT NULL,
	MaPhim VARCHAR(5),
	ID  VARCHAR(15),
	GiaVe MONEY DEFAULT 0,

	FOREIGN KEY (ID) REFERENCES dbo.DinhDangPhim(ID),
	FOREIGN KEY (MaPhong) REFERENCES dbo.PhongChieu(MaPhong),
	FOREIGN KEY (MaPhim) REFERENCES dbo.Phim(MaPhim),
	
	--CONSTRAINT  PK_LichChieu UNIQUE (MaLC,NgayChieu,GioChieu,MaPhong,MaPhim),
)
GO

CREATE TABLE ThanhVien(
	MaThe VARCHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(35) NOT NULL,
	SDT VARCHAR(13) NOT NULL,
	NgayLap DATETIME ,
	NgayHH DATETIME,		
)
GO

CREATE	TABLE KhuyenMai(
	MaKM  VARCHAR(5) PRIMARY KEY ,
	TenKM NVARCHAR(20) NOT NULL , --  thẻ thành viên || học sinh - Sinh viên || khách vãng lai 
	TiSuatKM FLOAT ,
	MaThe VARCHAR(10),
	FOREIGN KEY (MaThe) REFERENCES dbo.ThanhVien(MaThe),
	)
GO

CREATE TABLE Ve(
	MaVe INT IDENTITY(1,1) PRIMARY KEY,
	MaLC VARCHAR(5)  NOT NULL,
	LoaiVe INT DEFAULT 1 NOT NULL, --  1 : khách vãng lai  || 2: Thẻ Thành Viên || 3: HS_SV
	GheNgoi CHAR(2) NOT NULL,
	MaKM VARCHAR(5) ,

	CONSTRAINT PK_Ve UNIQUE (MaVe,MaKM),
	FOREIGN KEY (MaKM)	REFERENCES dbo.KhuyenMai(MaKM),
	FOREIGN KEY (MaLC)	REFERENCES dbo.LichChieu(MaLC),

)
GO



DROP TABLE dbo.NhanVien
DROP TABLE dbo.TaiKhoan
DROP TABLE  dbo.LoaiMH
DROP TABLE dbo.PhongChieu
DROP TABLE dbo.TheLoai
DROP TABLE dbo.Phim
DROP TABLE dbo.DinhDangPhim
DROP  TABLE dbo.LichChieu
DROP TABLE dbo.ThanhVien
DROP TABLE dbo.KhuyenMai
DROP TABLE dbo.Ve
DROP TRIGGER INSERT_CheckDateLichChieu
GO	

--Trigger 
-- // done
CREATE TRIGGER	INSERT_CheckDateLichChieu
ON dbo.LichChieu
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @ID VARCHAR(15), @NgayChieu DATETIME, @NgayKhoiChieu DATE, @NgayKetThuc DATE

	SELECT @ID = ID, @NgayChieu = CONVERT(DATE, NgayChieu) from INSERTED

	SELECT @NgayKhoiChieu = P.NgayKhoiChieu, @NgayKetThuc = P.NgayKetThuc
	FROM dbo.Phim P, dbo.DinhDangPhim DD
	WHERE @ID = DD.ID AND DD.MaPhim = p.MaPhim

	IF ( @NgayChieu > @NgayKetThuc or @NgayChieu < @NgayKhoiChieu)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Lịch Chiếu lớn hơn hoặc bằng Ngày Khởi Chiếu và nhỏ hơn hoặc bằng Ngày Kết Thúc',16,1)
		Return
    END
END
GO

-- done
CREATE TRIGGER Check_TheThanhVien
ON dbo.ThanhVien
FOR INSERT,UPDATE
AS
BEGIN	
	DECLARE @NgayLap DATETIME , @NgayHH DATETIME

	SELECT @NgayLap = NgayLap ,@NgayHH = NgayHH FROM Inserted
	SELECT @NgayLap = TV.NgayLap,@NgayHH = TV.NgayHH  FROM dbo.ThanhVien TV
	IF(@NgayLap < @NgayHH )
		BEGIN
		    ROLLBACK TRAN
			RAISERROR('Ngày làm thẻ phải lớn hơn ngày hết hạn',16,1)
		END

END
GO 



-- "? // done
CREATE TRIGGER UTG_CheckTimeLichChieu
ON dbo.LichChieu
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @count INT = 0, @count2 INT = 0, @GioChieu TIME, @MaPhong VARCHAR(5), @ID VARCHAR(15)

	SELECT @MaPhong = MaPhong, @GioChieu = GioChieu, @ID = Inserted.ID from INSERTED

	SELECT @count = COUNT(*)
	FROM dbo.LichChieu LC, dbo.DinhDangPhim DD, dbo.Phim P
	WHERE LC.MaPhong = @MaPhong AND LC.MaPhim = DD.MaPhim AND DD.MaPhim = P.MaPhim AND (@GioChieu >= LC.GioChieu AND @GioChieu <= DATEADD(MINUTE, P.ThoiLuong, LC.GioChieu))

	SELECT @count2 = COUNT(*)
	FROM dbo.LichChieu LC, dbo.DinhDangPhim DD, dbo.Phim P
	WHERE @MaPhong = LC.MaPhong AND @ID = DD.ID AND DD.MaPhim = P.MaPhim AND (LC.GioChieu >= @GioChieu AND LC.GioChieu <= DATEADD(MINUTE, P.ThoiLuong, @GioChieu))

	IF (@count > 1 OR @count2 > 1)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Thời Gian Chiếu đã trùng với một lịch chiếu khác cùng Phòng Chiếu',16,1)
		Return
	END
END
GO

--Stored Procedures  // done 
--TÀI KHOẢN (Đổi mật khẩu & đăng nhập)
CREATE PROC USP_UpdatePasswordForAccount
@UseName NVARCHAR(10), @MatKhau VARCHAR(13), @newPass VARCHAR(13)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.TaiKhoan WHERE UserName = @UserName AND MatKhau = @MatKhau

	IF (@isRightPass = 1)
	BEGIN
		UPDATE dbo.TaiKhoan SET MatKhau = @newPass WHERE UserName = @UseName
    END
END
GO

-- done
CREATE PROC USP_Login
@UserName NVARCHAR(10), @MatKhau VARCHAR(13)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE UserName = @UserName AND MatKhau = @MatKhau
END
GO


-- done
--TÀI KHOẢN (frmAdmin)
CREATE PROC USP_GetAccountList
AS
BEGIN
	SELECT TK.UserName AS [Username], TK.LoaiTK AS [Loại tài khoản], NV.MaNv AS [Mã nhân viên], NV.TenNv AS [Tên nhân viên]
	FROM dbo.TaiKhoan TK, dbo.NhanVien NV
	WHERE NV.MaNv = TK.MaNv
END
GO



-- done
CREATE PROC USP_InsertAccount
@UserName NVARCHAR(10), @loaiTK INT, @MaNv VARCHAR(5)
AS
BEGIN
	INSERT dbo.TaiKhoan ( UserName, MatKhau, LoaiTK, MaNv )
	VALUES ( @UserName, '1111111111111', @loaiTK, @MaNv )
END
GO



-- done 
CREATE PROC USP_UpdateAccount
@UserName NVARCHAR(10), @loaiTK INT
AS
BEGIN
	UPDATE dbo.TaiKhoan 
	SET LoaiTK = @loaiTK
	WHERE UserName = @UserName
END
GO


-- done
CREATE PROC USP_ResetPasswordtAccount
@username NVARCHAR(10)
AS
BEGIN
	UPDATE dbo.TaiKhoan 
	SET MatKhau = '1111111111111' 
	WHERE UserName = @UserName
END
GO


-- done
CREATE PROC USP_SearchAccount
@TenNv NVARCHAR(35)
AS
BEGIN
	SELECT TK.UserName AS [Username], TK.LoaiTK AS [Loại tài khoản], NV.MaNv AS [Mã nhân viên], NV.TenNv AS [Tên nhân viên]
	FROM dbo.TaiKhoan TK, dbo.NhanVien NV
	WHERE NV.MaNv = TK.MaNv AND dbo.fuConvertToUnsign1(NV.TenNv) LIKE N'%' + dbo.fuConvertToUnsign1(@TenNv) + N'%'
END
GO



-- done 
--DOANH THU
CREATE PROC USP_GetRevenueByMovieAndDate
@MaPhim VARCHAR(5), @fromDate date, @toDate date
AS
BEGIN
	SELECT P.TenPhim AS [Tên phim], CONVERT(DATE, LC.NgayChieu) AS [Ngày chiếu], CONVERT(TIME(0),LC.GioChieu) AS [Giờ chiếu], COUNT(V.MaVe) AS [Số vé đã bán], SUM(TienBanVe) AS [Tiền vé]
	FROM dbo.Ve AS V, dbo.LichChieu AS LC, dbo.DinhDangPhim AS DDP, Phim AS P
	WHERE V.MaLC = LC.MaLC AND LC.ID = DDP.ID AND DDP.MaPhim = P.MaPhim AND  P.MaPhim = @MaPhim AND LC.NgayChieu >= @fromDate AND LC.NgayChieu <= @toDate
	GROUP BY LC.ID, P.TenPhim, LC.NgayChieu
END
GO

 --DROP  FUNCTION [fuConvertToUnsign1]
-- done
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(500) )
RETURNS NVARCHAR(500) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = ''
RETURN @strInput DECLARE @RT NVARCHAR(400) DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO


-- done
CREATE PROC USP_GetReportRevenueByMovieAndDate
@MaPhim VARCHAR(5), @fromDate date, @toDate date
AS
BEGIN
	SELECT P.TenPhim AS N'Tên Phim', CONVERT(DATE, LC.NgayChieu) AS N'Ngày Chiếu', LC.GioChieu AS N'Giờ Chiếu', COUNT(V.MaVe) AS N'Số Vé Đã Bán ', SUM(LC.GiaVe) AS N'Tiền Bán Vé'
	FROM dbo.Ve AS V, dbo.LichChieu AS LC, dbo.DinhDangPhim AS DDP, Phim AS P
	WHERE V.MaLC = LC.MaLC AND LC.ID = DDP.ID AND DDP.MaPhim = P.MaPhim AND  P.MaPhim = @MaPhim AND LC.NgayChieu >= @fromDate AND LC.NgayChieu <= @toDate
	GROUP BY LC.ID, P.TenPhim, LC.NgayChieu, LC.GioChieu
END
GO


--  done
--THỂ LOẠI
CREATE PROC USP_InsertTheLoai
@MaTL VARCHAR(10), @TenTL NVARCHAR(10), @moTa NVARCHAR(100)
AS
BEGIN
	INSERT dbo.TheLoai (MaTL, TenTL, MoTa)
	VALUES  (@MaTL, @TenTL, @moTa)
END
GO


-- done
--LOẠI MÀN HÌNH
CREATE PROC USP_InsertScreenType
@IDMH VARCHAR(4), @TenMH NVARCHAR(10)
AS
BEGIN
	INSERT dbo.LoaiMH
	(
	    IDMH,
	    TenMH
	)
	VALUES  (@IDMH, @TenMH)
END
GO


-- done
--PHIM
CREATE PROC USP_GetMovie
AS
BEGIN
	SELECT MaPhim AS [Mã phim], TenPhim AS [Tên phim], NoiDung AS [Mô tả], ThoiLuong AS [Thời lượng], NgayKhoiChieu AS [Ngày khởi chiếu], NgayKetThuc AS [Ngày kết thúc], NgaySX AS [Ngày Sản xuất], DaoDien AS [Đạo diễn], Anh AS [Áp Phích]
	FROM dbo.Phim
END
GO

--  done
CREATE PROC USP_InsertMovie
@id VARCHAR(5), @tenPhim NVARCHAR(30), @moTa NVARCHAR(100), @thoiLuong FLOAT, @ngayKhoiChieu DATE, @ngayKetThuc DATE, @daoDien NVARCHAR(35), @NgaySx DATETIME, @anh IMAGE
AS
BEGIN
	INSERT dbo.Phim (MaPhim , TenPhim , NoiDung , ThoiLuong , NgayKhoiChieu , NgayKetThuc , NgaySX , DaoDien , Anh)
	VALUES (@id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc ,  @daoDien , @NgaySx, @anh)
END
GO


--   done
CREATE PROC USP_UpdateMovie
@id VARCHAR(5), @tenPhim NVARCHAR(30), @moTa NVARCHAR(100), @thoiLuong FLOAT, @ngayKhoiChieu DATE, @ngayKetThuc DATE, @daoDien NVARCHAR(35), @NgaySx DATETIME, @anh IMAGE
AS
BEGIN
	UPDATE dbo.Phim SET TenPhim = @tenPhim, NoiDung = @moTa, ThoiLuong = @thoiLuong, NgayKhoiChieu = @ngayKhoiChieu, NgayKetThuc = @ngayKetThuc, DaoDien = @daoDien, NgaySX = @NgaySx, Anh = @anh WHERE MaPhim = @id
END
GO

-- done
--ĐỊNH DẠNG PHIM
CREATE PROC USP_GetListFormatMovie
AS
BEGIN
	SELECT DD.ID AS [Mã định dạng], P.MaPhim AS [Mã phim], P.TenPhim AS [Tên phim], MH.IDMH AS [Mã MH], MH.TenMH AS [Tên MH]
	FROM dbo.DinhDangPhim DD, Phim P, dbo.LoaiMH MH
	WHERE DD.MaPhim = P.MaPhim AND DD.IDMH = MH.IDMH
END
GO


--  done
CREATE PROC USP_InsertFormatMovie
@id VARCHAR(15), @idPhim VARCHAR(5), @idLoaiManHinh VARCHAR(4)
AS
BEGIN
	INSERT dbo.DinhDangPhim ( ID, MaPhim, IDMH )
	VALUES  ( @id, @idPhim, @idLoaiManHinh )
END
GO


-- done
--LỊCH CHIẾU
CREATE PROC USP_GetListShowTimesByFormatMovie
@id varchar(5), @Date time
AS
BEGIN
	select LC.MaLC, pc.TenPhong, p.TenPhim, LC.GioChieu, d.ID as idDinhDang, LC.GiaVe
	from Phim p ,DinhDangPhim d, LichChieu LC, PhongChieu pc
	where p.MaPhim = d.MaPhim and d.ID = LC.ID and LC.MaPhong = pc.MaPhong
	and d.ID = @id AND	 @Date = lc.GioChieu
	order by LC.GioChieu
END
GO


-- done
CREATE PROC USP_GetShowtime
AS
BEGIN
	SELECT LC.MaLC AS [Mã lịch chiếu], LC.MaPhong AS [Mã phòng], P.TenPhim AS [Tên phim], MH.TenMH AS [Màn hình], LC.GioChieu AS [Thời gian chiếu], LC.GiaVe AS [Giá vé]
	FROM dbo.LichChieu AS LC, dbo.DinhDangPhim AS DD, Phim AS P, dbo.LoaiMH AS MH
	WHERE LC.ID = DD.ID AND DD.MaPhim = P.MaPhim AND DD.IDMH = MH.IDMH
END
GO


--done
CREATE PROC USP_InsertShowtime
@MaLC VARCHAR(5), @idPhong VARCHAR(5), @ID VARCHAR(15), @thoiGianChieu DATETIME, @giaVe MONEY
AS
BEGIN
	INSERT dbo.LichChieu ( MaLC , MaPhong , ID, GioChieu  , GiaVe  )
	VALUES  ( @MaLC , @idPhong , @ID, @thoiGianChieu  , @giaVe  )
END
GO


-- done
CREATE PROC USP_UpdateShowtime
@MaLC VARCHAR(5), @MaPhong VARCHAR(5), @ID VARCHAR(15), @GioChieu DATETIME, @GiaVe MONEY
AS
BEGIN
	UPDATE dbo.LichChieu 
	SET MaPhong = @MaPhong, ID = @ID, GioChieu = @GioChieu , GiaVe = @GiaVe
	WHERE @MaLC = MaLC
END
GO


--done
CREATE PROC USP_SearchShowtimeByMovieName
@tenPhim NVARCHAR(50)
AS
BEGIN
	SELECT LC.id AS [Mã lịch chiếu], LC.MaPhong AS [Mã phòng], P.TenPhim AS [Tên phim], MH.TenMH AS [Màn hình], LC.GioChieu AS [Thời gian chiếu], LC.GiaVe AS [Giá vé]
	FROM dbo.LichChieu AS LC, dbo.DinhDangPhim AS DD, Phim AS P, dbo.LoaiMH AS MH
	WHERE LC.ID = DD.ID AND DD.MaPhim = P.MaPhim AND DD.IDMH = MH.IDMH AND dbo.fuConvertToUnsign1(P.TenPhim) LIKE N'%' + dbo.fuConvertToUnsign1(@tenPhim) + N'%'
END
GO



-- done
CREATE PROC USP_GetAllListShowTimes
AS
BEGIN
	select lc.MaLC, pc.TenPhong, p.TenPhim, lc.GioChieu, d.ID as idDinhDang, lc.GiaVe
	from Phim p ,DinhDangPhim d, LichChieu lc, PhongChieu pc
	where p.MaPhim = d.MaPhim and d.ID = lc.ID and lc.MaPhong = pc.MaPhong
	order by lc.GioChieu
END
GO



--NHÂN VIÊN

-- done
CREATE PROC USP_GetStaff
AS
BEGIN
	SELECT MaNv AS [Mã nhân viên], TenNv AS [Họ tên], NgaySinh AS [Ngày sinh], Diachi AS [Địa chỉ], SDT AS [SĐT], CMND AS [CMND],ChucVu AS [Chức Vụ]
	FROM dbo.NhanVien
END
GO


--done
CREATE PROC USP_InsertStaff
@idStaff VARCHAR(10), @hoTen NVARCHAR(35), @ngaySinh date, @diaChi NVARCHAR(35), @sdt VARCHAR(13), @cmnd VARCHAR(12), @chucvu NVARCHAR(10)
AS
BEGIN
	INSERT dbo.NhanVien (MaNv, TenNv, NgaySinh, DiaChi, SDT, CMND,ChucVu)
	VALUES (@idStaff, @hoTen, @ngaySinh, @diaChi, @sdt, @cmnd,@chucvu)
END
GO


-- done
CREATE PROC USP_SearchStaff
@hoTen NVARCHAR(35)
AS
BEGIN
	SELECT MaNv AS [Mã nhân viên], TenNv AS [Họ tên], NgaySinh AS [Ngày sinh], DiaChi AS [Địa chỉ], SDT AS [SĐT], CMND AS [CMND] ,ChucVu AS[Chức Vụ]
	FROM dbo.NhanVien
	WHERE dbo.fuConvertToUnsign1(TenNv) LIKE N'%' + dbo.fuConvertToUnsign1(@hoTen) + N'%'
END
GO


--PHÒNG CHIẾU
-- done
CREATE PROC USP_GetCinema
AS
BEGIN
	SELECT PC.MaPhong AS [Mã phòng], TenPhong AS [Tên phòng], TenMH AS [Tên màn hình], PC.SoGhe AS [Số chỗ ngồi], PC.TinhTrang AS [Tình Trạng],PC.DienTich AS [Diện Tích] 
	FROM dbo.PhongChieu AS PC, dbo.LoaiMH AS MH
	WHERE PC.IDMH = MH.IDMH
END
GO


-- done
CREATE PROC USP_InsertCinema
@MaPhong VARCHAR(5), @tenPhong NVARCHAR(6), @idMH CHAR(4), @SoGhe INT, @tinhTrang INT,@DienTich FLOAT
AS
BEGIN
	INSERT dbo.PhongChieu ( MaPhong , TenPhong , IDMH , SoGhe , TinhTrang ,DienTich)
	VALUES (@MaPhong , @tenPhong , @idMH , @SoGhe , @tinhTrang ,@DienTich )
END
GO


--VÉ
-- dont

--DROP PROC USP_InsertTicketByShowTimes

CREATE PROC USP_InsertTicketByShowTimes
@MaLC VARCHAR(5), @GheNgoi VARCHAR(2)
AS
BEGIN
	INSERT INTO dbo.Ve
	(
		MaLC,
		GheNgoi
		
	)
	VALUES
	(
		@MaLC,
		@GheNgoi

	)
END
GO


DROP PROC USP_DeleteTicketsByShowTimes

CREATE PROC USP_DeleteTicketsByShowTimes
@idlichChieu VARCHAR(5)
AS
BEGIN
	DELETE FROM dbo.Ve
	WHERE MaLC = @idlichChieu
END
GO