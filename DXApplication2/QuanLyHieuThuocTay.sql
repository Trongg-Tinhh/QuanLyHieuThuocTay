create database QuanLyHieuThuocTay
use QuanLyHieuThuocTay

use master
drop database QuanLyHieuThuocTay

create table NhaSanXuat(
	maNSX	char(10) primary key,
	tenNSX	nvarchar(200) not null
)

create table LoaiSanPham(
	maLoai		char(10) primary key,
	tenLoai		nvarchar(30) not null
)
DROP TABLE BangGia
DROP TABLE ChiTietHoaDon
DROP TABLE SanPham
create table SanPham(
	maSP			char(10) primary key,
	tenSP			nvarchar(40) not null,
	maLoai			char(10),
	maNSX			char(10),
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
DROP TABLE ChiTietHoaDon
DROP TABLE HoaDon
DROP TABLE TaiKhoan
create table TaiKhoan
(
	maTaiKhoan		varchar(10) primary key,
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

create table HoaDon(
	maHD			char(10) primary key,
	tenKhach		nvarchar(30),
	ngayBan			date not null,
	SDT				char(10),
	maTaiKhoan		varchar(10),
	thanhTien		decimal(18,3) not null 
						check (thanhTien >= 0),
	foreign key (maTaiKhoan) 
		references TaiKhoan(maTaiKhoan)
			on update cascade
			on delete no action

)

create table ChiTietHoaDon
(
	maHD	char(10),
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


INSERT INTO dbo.TaiKhoan
(
	maTaiKhoan,
    tenDangNhap,
    matKhau,
    tenNhanVien,
    SDT,
    CCCD,
    vaiTro
)
VALUES
(   
	'TK001',
	'trongtinh',  -- tenDangNhap - varchar(30)
    'trongtinh123',  -- matKhau - varchar(30)
    N'Trọng Tính', -- tenNhanVien - nvarchar(30)
    '0839035423',  -- SDT - char(10)
    '123456789000',  -- CCCD - char(12)
    0 -- vaiTro - bit
    )
	
INSERT INTO dbo.TaiKhoan
(
	maTaiKhoan,
    tenDangNhap,
    matKhau,
    tenNhanVien,
    SDT,
    CCCD,
    vaiTro
)
VALUES
(   
	'TK002',
	'admin',  -- tenDangNhap - varchar(30)
    'admin123',  -- matKhau - varchar(30)
    N'A D M I N', -- tenNhanVien - nvarchar(30)
    '0123456789',  -- SDT - char(10)
    '001234567890',  -- CCCD - char(12)
    1 -- vaiTro - bit
    )

--insert TaiKhoan
insert into TaiKhoan(maTaiKhoan,tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('TK003','Admin',	'admin@123',	N'Quản trị viên',	'0253452753',	'077161531651',	1)
insert into TaiKhoan(maTaiKhoan,tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('TK004','letrongtinh12',	'trongtinh12',	N'Lê Trọng Tính',	'0772623581',	'077123654789','0')
insert into TaiKhoan(maTaiKhoan,tenDangNhap,matKhau,tenNhanVien,SDT,CCCD,vaiTro)
values ('TK005','caotruongtoan21',	'truongtoan21',	N'Cao Trường Toàn',	'0355123876',	'659126518610',	'0')

	SELECT * FROM dbo.TaiKhoan



--insert NhaSanXuat
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX001',N'Công ty Trách nhiệm Hữu Hạn Hasan-Dermapharm')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX002',N'Công ty Trách nhiệm Hữu hạn US Pharma USA - Việt Nam')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX003',N'Công ty Cổ phần Dược phẩm Đạt Vi Phú')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX004',N'AstraZeneca UK Ltd')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX005',N'Công ty Cổ phần Pymepharco')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX006',N'Công Ty Cổ Phần Dược Danapha')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX007',N'Công ty Cổ phần Dược phẩm OPC')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX008',N'Công ty Laboratoires Mayoly Spindler')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX009',N'Công ty Liên doanh Meyer – BPC')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX010',N'Công ty Dược phẩm OPV')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX011',N'Công ty Cổ phần Sinh học Dược phẩm Ba Đình')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX012',N'Young Chemical Co.,Ltd')
insert into NhaSanXuat (maNSX, tenNSX)
values ('NSX013',N'Công Ty Tnhh Công Nghệ Cao Su Việt Nam')

SELECT * FROM NhaSanXuat


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


--insert SanPham

insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('001TGD001',N'Thuốc Efferhasan 250Mg Hasan','TGD','NSX001',N'Paracetamol',N'Trên 6 tuổi',N'Đau nửa đầu, Nhức đầu',N'Viên',24,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('002TKS001',N'Thuốc Kháng Sinh Vizicin 125Mg Hasan','TKS','NSX001',N'Azithromycin',N'Trên 6 tháng tuổi ',N'Viêm phổi, Viêm amidan',N'Viên',16,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('003CDM002',N'Thuốc Clopidogrel 75Mg Mv','CDM','NSX002',N'Clopidogrel',N'Trên 18 tuổi',N'Nhồi máu cơ tim, Đột quy',N'Viên',32,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('004CTC003',N'Thuốc Diouf 10Mg Davi','CTC','NSX003',N'Escitalopram',N'Trên 12 tuổi',N'Trầm cảm, Lo âu',N'Viên',09,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('005CUT004',N'Thuốc Nolvadex-D Astrazeneca','CUT','NSX004',N'Tamoxifen',N'Trên 18 tuổi',N'Ung thư vú',N'Viên',26,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('006DTD005',N'Thuốc Diaprid 2 Pymepharco','DTD','NSX005',N'Glimepiride',N'Trên 18 tuổi',N'Tiểu đường type 2',N'Viên',30,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('007CDK006',N'Thuốc Dalekine 500Mg Danapha','CDK','NSX006',N'Valproat natri',N'Trên 18 tuổi',N'Động kinh, Tiền sử co giật, Co giật',N'Viên',12,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('008TAT007',N'Viên An Thần Mimosa','TAT','NSX007',N'Bình vôi, Vông nem lá',N'Trên 18 tuổi',N'Rối loạn giấc ngủ, Suy nhược thần kinh',N'Viên',04,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('009CGT008',N'Thuốc Meteospasmyl','CCT','NSX008',N'Trimebutin',N'Trên 2 tuổi',N'Rối loạn tiêu hóa, Táo bón, Đầy hơiu',N'Viên',06,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('010TKV009',N'Thuốc Acyclovir Meyer 800Mg','TKV','NSX009',N'Tenofovir disoproxil',N'Trên 18 tuổi',N'Viêm gan B, HIV/AIDS',N'Viên',20,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('011TTM010',N'Thuốc Tim Mạch Nisten Ivabradin 5Mg','TTM','NSX010',N'Ivabradine',N'Trên 18 tuổi',N'Cơn đau thắt ngực, Bệnh mạch vành',N'Viên',10,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('012TTC011',N'Trinopast','TTC','NSX011',N'Pregabalin',N'Trên 18 tuổi',N'Bệnh TK ngoại biên, Zona thần kinh',N'Viên',27,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('013TTT012',N'Thuốc Tránh Thai Pro Avalo Babiophar','TTT','NSX012','Levonorgestrel','Trên 18 tuổi','Tránh thai','Viên','26','')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('014BTY013',N'Băng Gạc Vô Trùng 9 Cm X 25 Cm','BYT','NSX013',N'',N'',N'Bảo vệ vết thương, đẩy nhanh tiến trình hồi phục',N'Viên',30,N'')
insert into SanPham (maSP, tenSP, maLoai, maNSX, thanhPhanChinh, doTuoi, congDung, donViTinh, soLuong, moTa)
values ('015KTR013',N'Khẩu Trang Y Tế 3 Lớp Naturecare 50 Cái','KTR','NSX013',N'',N'',N'Kháng khuẩn, lọc không khí, chống giọt bắn',N'Viên',30,N'')

SELECT * FROM SanPham


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



--inser HoaDon
insert into HoaDon(maHD, tenKhach, ngayBan,	SDT, maTaiKhoan, thanhTien)
values ('HD001',N'Lê Văn Lâm',	'2022/07/25',	'0254121472',	'TK004',	'78000')
insert into HoaDon(maHD, tenKhach, ngayBan,	SDT, maTaiKhoan, thanhTien)
values ('HD002',N'Lê Thị Thùy Dung',	'2022/07/29',	'377812512',	'TK005',	'137500')

SELECT * FROM HoaDon



--insert CTHD
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD001',	'001TGD001',	10,	3000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD001',	'011TTM010',	10,	1500)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD001',	'014BTY013',	3,	11000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD002',	'007CDK006',	10,	2000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD002',	'006DTD005',	5,	3500)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD002',	'009CGT008',	10,	5000)
insert into ChiTietHoaDon(maHD,maSP,soLuong,donGia)
values ('HD002',	'015KTR013',	1,	50000)


SELECT * FROM ChiTietHoaDon