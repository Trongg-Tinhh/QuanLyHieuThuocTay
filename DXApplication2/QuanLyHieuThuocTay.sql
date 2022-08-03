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

create table SanPham(
	maSP			char(10) primary key,
	tenSP			nvarchar(40) not null,
	maLoai			char(10),
	maNSX			char(10),
	thanhPhanChinh	text not null,
	doTuoi			text ,
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

create table BangGia(
	maSP		char(10),
	ngay		date not null,
	donGia		decimal(18,4) not null 
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
	tenDangNhap		varchar(30) primary key,
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
	tenDangNhap		varchar(30),
	thanhTien		decimal(18,4) not null 
						check (thanhTien >= 0),
	foreign key (tenDangNhap) 
		references TaiKhoan(tenDangNhap)
			on update cascade
			on delete no action

)

create table ChiTietHoaDon
(
	maHD	char(10),
	maSP	char(10) not null,
	soLuong		int not null
					check (soLuong > 0),
	donGia		decimal(18,4) not null
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
    tenDangNhap,
    matKhau,
    tenNhanVien,
    SDT,
    CCCD,
    vaiTro
)
VALUES
(   'trongtinh',  -- tenDangNhap - varchar(30)
    'trongtinh123',  -- matKhau - varchar(30)
    N'Trọng Tính', -- tenNhanVien - nvarchar(30)
    '0839035423',  -- SDT - char(10)
    '123456789000',  -- CCCD - char(12)
    NULL -- vaiTro - bit
    )
	
INSERT INTO dbo.TaiKhoan
(
    tenDangNhap,
    matKhau,
    tenNhanVien,
    SDT,
    CCCD,
    vaiTro
)
VALUES
(   'admin',  -- tenDangNhap - varchar(30)
    'admin123',  -- matKhau - varchar(30)
    N'A D M I N', -- tenNhanVien - nvarchar(30)
    '0123456789',  -- SDT - char(10)
    '001234567890',  -- CCCD - char(12)
    1 -- vaiTro - bit
    )

	SELECT * FROM dbo.TaiKhoan