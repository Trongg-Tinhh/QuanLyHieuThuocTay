create database QuanLyHieuThuocTay
use QuanLyHieuThuocTay

use master
drop database QuanLyHieuThuocTay
----------------------------------------------------------------
drop table NhaSanXuat
create table NhaSanXuat(
	maNSX	INT IDENTITY(100,1) PRIMARY KEY,
	tenNSX	nvarchar(200) not null
)
--insert NhaSanXuat
insert into NhaSanXuat (tenNSX)
values (N'Công ty Trách nhiệm Hữu Hạn Hasan-Dermapharm')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Trách nhiệm Hữu hạn US Pharma USA - Việt Nam')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Cổ phần Dược phẩm Đạt Vi Phú')
insert into NhaSanXuat (tenNSX)
values (N'AstraZeneca UK Ltd')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Cổ phần Pymepharco')
insert into NhaSanXuat (tenNSX)
values (N'Công Ty Cổ Phần Dược Danapha')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Cổ phần Dược phẩm OPC')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Laboratoires Mayoly Spindler')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Liên doanh Meyer – BPC')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Dược phẩm OPV')
insert into NhaSanXuat (tenNSX)
values (N'Công ty Cổ phần Sinh học Dược phẩm Ba Đình')
insert into NhaSanXuat (tenNSX)
values (N'Young Chemical Co.,Ltd')
insert into NhaSanXuat (tenNSX)
values (N'Công Ty Tnhh Công Nghệ Cao Su Việt Nam')

SELECT * FROM NhaSanXuat
----------------------------------------------------------------------------------------------------------------

create table LoaiSanPham(
	maLoai		char(10) primary key,
	tenLoai		nvarchar(30) not null
)
--insert LoaiSanPham
insert into LoaiSanPham (maLoai,tenLoai)
values ('TGD',N'Thuốc giảm đau')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TKS',N'Thuốc kháng sinh')
insert into LoaiSanPham (maLoai,tenLoai)
values ('CDM',N'Thuốc chống đông máu')
insert into LoaiSanPham (maLoai,tenLoai)
values ('CTC',N'Thuốc chống trầm cảm')
insert into LoaiSanPham (maLoai,tenLoai)
values ('CUT',N'Thuốc chống ung thư')
insert into LoaiSanPham (maLoai,tenLoai)
values ('DTD',N'Thuốc trị đái tháo đường')
insert into LoaiSanPham (maLoai,tenLoai)
values ('CDK',N'Thuốc chống động kinh')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TAT',N'Thuốc an thần')
insert into LoaiSanPham (maLoai,tenLoai)
values ('CCT',N'Thuốc chống co thắt')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TKV',N'Thuốc kháng virus')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TTM',N'Thuốc tim mạch')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TTC',N'Thuốc trầm cảm')
insert into LoaiSanPham (maLoai,tenLoai)
values ('TTT',N'Thuốc tránh thai')
insert into LoaiSanPham (maLoai,tenLoai)
values ('BYT',N'Băng y tế')
insert into LoaiSanPham (maLoai,tenLoai)
values ('KTR',N'Khẩu trang y tế')

SELECT * FROM LoaiSanPham

-----------------------------------------------------------------------------------------------------------------
DROP TABLE BangGia
DROP TABLE ChiTietHoaDon
DROP TABLE SanPham

create table SanPham(
	maSP			char(10) primary key,
	tenSP			nvarchar(40) not null,
	maLoai			char(10),
	maNSX			int,
	thanhPhanChinh	nvarchar(50) not null,
	doTuoi			nvarchar(50) ,
	congDung		nvarchar(200) not null,
	donViTinh		nvarchar(10) not null,
	soLuong			int not null 
						check (soLuong >= 0),
	moTa			nvarchar(200),

	foreign key (maNSX) 
		references NhaSanXuat(maNSX)
			on update cascade
			on delete no action,

	foreign key (maLoai) 
		references LoaiSanPham(maLoai)
			on update cascade
			on delete no action
)
--insert SanPham
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('001TGD001',N'Thuốc Efferhasan 250Mg Hasan','TGD',100,N'Paracetamol',N'Trên 6 tuổi',N'Đau nửa đầu, Nhức đầu',N'Viên',24,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('002TKS001',N'Thuốc Kháng Sinh Vizicin 125Mg Hasan','TKS',100,N'Azithromycin',N'Trên 6 tháng tuổi ',N'Viêm phổi, Viêm amidan',N'Viên',16,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('003CDM002',N'Thuốc Clopidogrel 75Mg Mv','CDM',101,N'Clopidogrel',N'Trên 18 tuổi',N'Nhồi máu cơ tim, Đột quy',N'Viên',32,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('004CTC003',N'Thuốc Diouf 10Mg Davi','CTC',102,N'Escitalopram',N'Trên 12 tuổi',N'Trầm cảm, Lo âu',N'Viên',09,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('005CUT004',N'Thuốc Nolvadex-D Astrazeneca','CUT',103,N'Tamoxifen',N'Trên 18 tuổi',N'Ung thư vú',N'Viên',26,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('006DTD005',N'Thuốc Diaprid 2 Pymepharco','DTD',104,N'Glimepiride',N'Trên 18 tuổi',N'Tiểu đường type 2',N'Viên',30,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('007CDK006',N'Thuốc Dalekine 500Mg Danapha','CDK',105,N'Valproat natri',N'Trên 18 tuổi',N'Động kinh, Tiền sử co giật, Co giật',N'Viên',12,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('008TAT007',N'Viên An Thần Mimosa','TAT',106,N'Bình vôi, Vông nem lá',N'Trên 18 tuổi',N'Rối loạn giấc ngủ, Suy nhược thần kinh',N'Viên',04,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('009CGT008',N'Thuốc Meteospasmyl','CCT',107,N'Trimebutin',N'Trên 2 tuổi',N'Rối loạn tiêu hóa, Táo bón, Đầy hơiu',N'Viên',06,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('010TKV009',N'Thuốc Acyclovir Meyer 800Mg','TKV',108,N'Tenofovir disoproxil',N'Trên 18 tuổi',N'Viêm gan B, HIV/AIDS',N'Viên',20,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('011TTM010',N'Thuốc Tim Mạch Nisten Ivabradin 5Mg','TTM',109,N'Ivabradine',N'Trên 18 tuổi',N'Cơn đau thắt ngực, Bệnh mạch vành',N'Viên',10,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('012TTC011',N'Trinopast','TTC',110,N'Pregabalin',N'Trên 18 tuổi',N'Bệnh TK ngoại biên, Zona thần kinh',N'Viên',27,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('013TTT012',N'Thuốc Tránh Thai Pro Avalo Babiophar','TTT',111,'Levonorgestrel',N'Trên 18 tuổi','Tránh thai','Viên','26','')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('014BTY013',N'Băng Gạc Vô Trùng 9 Cm X 25 Cm','BYT',112,N'',N'',N'Bảo vệ vết thương, đẩy nhanh tiến trình hồi phục',N'Viên',30,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('015KTR013',N'Khẩu Trang Y Tế 3 Lớp Naturecare 50 Cái','KTR',112,N'',N'',N'Kháng khuẩn, lọc không khí, chống giọt bắn',N'Viên',30,N'')

SELECT * FROM SanPham

---------------------------------------------------------------------------------------------------------------------

DROP TABLE BangGia
create table BangGia(
	maSP		char(10),
	ngay		date not null,
	donGia		decimal(18,3) not null 
					check (DonGia > 0.0),

	primary key(maSP,ngay),

	foreign key (maSP) 
		references SanPham(maSP)
			on update cascade
			on delete no action
)


--insert BangGia
insert into BangGia(maSP, ngay, donGia)
values ('001TGD001','2022/07/21',3000)
insert into BangGia(maSP, ngay, donGia)
values ('002TKS001','2022/07/20',2500)
insert into BangGia(maSP, ngay, donGia)
values ('003CDM002','2022/07/20',2000)
insert into BangGia(maSP, ngay, donGia)
values ('004CTC003','2022/07/20',4000)
insert into BangGia(maSP, ngay, donGia)
values ('005CUT004','2022/07/20',1200)
insert into BangGia(maSP, ngay, donGia)
values ('006DTD005','2022/07/20',3500)
insert into BangGia(maSP, ngay, donGia)
values ('007CDK006','2022/07/20',2000)
insert into BangGia(maSP, ngay, donGia)
values ('008TAT007','2022/07/20',2000)
insert into BangGia(maSP, ngay, donGia)
values ('009CGT008','2022/07/20',5000)
insert into BangGia(maSP, ngay, donGia)
values ('010TKV009','2022/07/20',1000)
insert into BangGia(maSP, ngay, donGia)
values ('011TTM010','2022/07/20',1500)
insert into BangGia(maSP, ngay, donGia)
values ('012TTC011','2022/07/20',2000)
insert into BangGia(maSP, ngay, donGia)
values ('013TTT012','2022/07/20',2200)
insert into BangGia(maSP, ngay, donGia)
values ('014BTY013','2022/07/20',11000)
insert into BangGia(maSP, ngay, donGia)
values ('015KTR013','2022/07/20',50000)

SELECT * FROM SanPham
SELECT * FROM BangGia
--------------------------------------------------------------------------------------------
DROP TABLE ChiTietHoaDon
DROP TABLE HoaDon
DROP TABLE TaiKhoan
create table TaiKhoan
(
	maTaiKhoan		INT IDENTITY(100,1) PRIMARY KEY,
	tenDangNhap		varchar(30) not null,
	matKhau			varchar(30) not null 
						check (len(matKhau) >= 8),
	tenNhanVien		nvarchar(30) not null,
	SDT				char(10)
						check(len(SDT)=10),
	CCCD			char(12)
						check(len(CCCD)=12),
	vaiTro			bit default 0 -- 0 la nhan vien, 1 la admin
)
--insert TaiKhoan
INSERT INTO dbo.TaiKhoan(tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
VALUES('trongtinh','trongtinh123',N'Trọng Tính','0839035423','123456789000',0)
INSERT INTO dbo.TaiKhoan(tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
VALUES('admin','admin123',N'A D M I N','0123456789','001234567890',1)
insert into TaiKhoan(tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('Admin',	'admin@123',	N'Quản trị viên',	'0253452753',	'077161531651',	1)
insert into TaiKhoan(tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('letrongtinh12',	'trongtinh12',	N'Lê Trọng Tính',	'0772623581',	'077123654789','0')
insert into TaiKhoan(tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('caotruongtoan21',	'truongtoan21',	N'Cao Trường Toàn',	'0355123876',	'659126518610',	'0')

SELECT * FROM dbo.TaiKhoan

-----------------------------------------------------------------------------------------------------------------------

create table HoaDon(
	maHD			INT IDENTITY(100000,10) PRIMARY KEY,
	tenKhach		nvarchar(30),
	ngayBan			date not null,
	SDT				char(10),
	maTaiKhoan		int,
	thanhTien		decimal(18,3) not null 
						check (thanhTien >= 0),
	foreign key (maTaiKhoan) 
		references TaiKhoan(maTaiKhoan)
			on update cascade
			on delete no action

)

--inser HoaDon
insert into HoaDon(tenKhach, ngayBan,SDT,maTaiKhoan,thanhTien)
values (N'Lê Văn Lâm','2022/07/25','0254121472',103,78000)
insert into HoaDon(tenKhach,ngayBan,SDT,maTaiKhoan,thanhTien)
values (N'Lê Thị Thùy Dung','2022/07/29','377812512',104,137500)

SELECT * FROM HoaDon
----------------------------------------------------------------------------------------------------------------------------

create table ChiTietHoaDon
(
	maHD	int,
	maSP	char(10) not null,
	soLuong		int not null
					check (soLuong > 0),
	donGia		decimal(18,3) not null
					check (DonGia >= 0),

	primary key(maHD,maSP),

	foreign key (maHD) 
		references HoaDon(maHD)
		on update cascade
			on delete no action,

	foreign key(maSP) 
		references SanPham(maSP)
			on update cascade
			on delete no action
)

--insert CTHD
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100000,	'001TGD001',	10,	3000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100000,	'011TTM010',	10,	1500)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100000,	'014BTY013',	3,	11000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100010,	'007CDK006',	10,	2000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100010,	'006DTD005',	5,	3500)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100010,	'009CGT008',	10,	5000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values (100010,	'015KTR013',	1,	50000)


SELECT * FROM ChiTietHoaDon
--------DSSP-------------------------------------------------------
SELECT	sp.maSP AS [Mã sản phẩm],
		sp.tenSP AS [Tên sản phẩm],
		sp.maLoai,l.tenLoai AS [Tên loại],
		sp.congDung AS [Công dụng],
		sp.thanhPhanChinh AS [Thành phần chính],
		sp.doTuoi AS[Độ tuổi],
		sp.soLuong AS [Số lượng],
		sp.donViTinh AS [Đợn vị tính],
		sp.maNSX,nsx.tenNSX AS[Tên nhà sản xuất],
		sp.moTa AS[Mô tả]
FROM dbo.SanPham sp, dbo.LoaiSanPham l, dbo.NhaSanXuat nsx
WHERE sp.maLoai=l.maLoai AND sp.maNSX=nsx.maNSX

SELECT * FROM dbo.HOADON
SELECT * FROM dbo.TaiKhoan
--------DSHD-----------------------------------------------
SELECT hd.maHD as[Mã hóa đơn], hd.tenKhach as[Tên khách hàng],hd.SDT, hd.ngayBan as[Ngày bán],hd.thanhTien as[Thành tiền],tk.tenNhanVien as[Tên nhân viên]
FROM dbo.HoaDon hd, dbo.TaiKhoan tk
WHERE hd.maTaiKhoan=tk.maTaiKhoan