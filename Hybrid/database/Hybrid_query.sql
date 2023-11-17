CREATE DATABASE hybrid;

use hybrid;

CREATE TABLE nhomquyen(
	manhomquyen INT PRIMARY KEY,
	ten NVARCHAR(50)
)

CREATE TABLE taikhoan(
	matk uniqueidentifier PRIMARY KEY,
	manhomquyen INT,
	hoten NVARCHAR(255),
	email NVARCHAR(255),
	matkhau NVARCHAR(255),
	sodienthoai NVARCHAR(15),
	anhdaidien NVARCHAR(255),
	FOREIGN KEY (manhomquyen) REFERENCES nhomquyen(manhomquyen)
)

-- cài đặt khóa chính taikhoan
ALTER TABLE taikhoan
ADD CONSTRAINT defaultUUID DEFAULT NEWID() FOR matk;

CREATE TABLE lophoc(
	malophoc uniqueidentifier PRIMARY KEY,
	ten NVARCHAR(255),
	mota NVARCHAR(500),
	trangthai TINYINT,
	magiangvien uniqueidentifier,
	FOREIGN KEY (magiangvien) REFERENCES taikhoan(matk)
)

ALTER TABLE lophoc
ADD CONSTRAINT defaultLophocUUID DEFAULT NEWID() FOR malophoc;

CREATE TABLE thamgialophoc(
	malophoc uniqueidentifier,
	mataikhoan uniqueidentifier,
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc),
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk)
)

CREATE TABLE nhomchat(
	manhomchat uniqueidentifier PRIMARY KEY,
	malophoc uniqueidentifier,
	ten NVARCHAR(255),
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE nhomchat
ADD CONSTRAINT defaultNhomChatUUID DEFAULT NEWID() FOR malophoc;

CREATE TABLE tinnhan(
	matinnhan uniqueidentifier PRIMARY KEY,
	manhomchat uniqueidentifier,
	mataikhoan uniqueidentifier,
	noidung NVARCHAR(300) ,
	thoigiangui DATETIME,
	antinnhan TINYINT,
	FOREIGN KEY (manhomchat) REFERENCES nhomchat(manhomchat),
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk)
)
ALTER TABLE tinnhan
ADD CONSTRAINT defaultTinNhantUUID DEFAULT NEWID() FOR matinnhan;

CREATE TABLE chuong(
	machuong uniqueidentifier PRIMARY KEY,
	malophoc uniqueidentifier,
	ten NVARCHAR(100),
	thoigiantao DATETIME,
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE chuong
ADD CONSTRAINT defaultChuongUUID DEFAULT NEWID() FOR machuong;

CREATE TABLE hoclieu(
	mahoclieu uniqueidentifier PRIMARY KEY,
	machuong uniqueidentifier,
	tieude NVARCHAR(100),
	noidung NVARCHAR(300),
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE hoclieu
ADD CONSTRAINT defaultHocLieuUUID DEFAULT NEWID() FOR mahoclieu;

CREATE TABLE filehoclieu(
	mahoclieu uniqueidentifier,
	link NVARCHAR(255),
	FOREIGN KEY (mahoclieu) REFERENCES hoclieu(mahoclieu)
)

CREATE TABLE banbe(
	mabanbe uniqueidentifier PRIMARY KEY,
	manguoiketban uniqueidentifier,
	manguoiduocketban uniqueidentifier,
	thoigianketban DATETIME,
	trangthai TINYINT,
	FOREIGN KEY (manguoiketban) REFERENCES taikhoan(matk),
	FOREIGN KEY (manguoiduocketban) REFERENCES taikhoan(matk),
)

ALTER TABLE banbe
ADD CONSTRAINT defaultBanbeUUID DEFAULT NEWID() FOR mabanbe;

CREATE TABLE tinnhanbanbe(
	matinnhan uniqueidentifier PRIMARY KEY,
	mabanbe uniqueidentifier,
	manguoigui uniqueidentifier,
	manguoinhan uniqueidentifier,
	noidung NVARCHAR(300),
	thoigiangui DATETIME,
	trangthai TINYINT,
	FOREIGN KEY (mabanbe) REFERENCES banbe(mabanbe),
	FOREIGN KEY (manguoigui) REFERENCES taikhoan(matk),
	FOREIGN KEY (manguoinhan) REFERENCES taikhoan(matk),
)

ALTER TABLE tinnhanbanbe
ADD CONSTRAINT defaultTinhanbbUUID DEFAULT NEWID() FOR matinnhan;

CREATE TABLE baitap(
	mabaitap uniqueidentifier PRIMARY KEY,
	machuong uniqueidentifier ,
	tieude NVARCHAR(100),
	noidung NVARCHAR(300),
	thoigiantao DATETIME,
	thoihan DATETIME,
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE baitap
ADD CONSTRAINT defaultBaitapUUID DEFAULT NEWID() FOR mabaitap;

CREATE TABLE dapanbaitap(
	madapan  uniqueidentifier PRIMARY KEY,
	mabaitap uniqueidentifier,
	noidung NVARCHAR(300),
	xemdapan TINYINT,
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

ALTER TABLE dapanbaitap
ADD CONSTRAINT defaultDapanUUID DEFAULT NEWID() FOR madapan;

CREATE TABLE filedapanbaitap(
	madapan  uniqueidentifier,
	link NVARCHAR(100),
	FOREIGN KEY (madapan) REFERENCES dapanbaitap(madapan)
)

CREATE TABLE filebaitap(
	mabaitap  uniqueidentifier,
	link NVARCHAR(100),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

CREATE TABLE bailambaitap(
	mabailam uniqueidentifier PRIMARY KEY,
	mataikhoan uniqueidentifier,
	mabaitap uniqueidentifier,
	noidung NVARCHAR(500),
	thoigiannopbai DATETIME,
	nhanxet NVARCHAR(200),
	diem int,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

ALTER TABLE bailambaitap
ADD CONSTRAINT defaultBailamnUUID DEFAULT NEWID() FOR mabailam;

CREATE TABLE filebailambaitap(
	mabailam  uniqueidentifier,
	link NVARCHAR(100),
	FOREIGN KEY (mabailam) REFERENCES bailambaitap(mabailam)
)

CREATE TABLE dekiemtra(
	madekiemtra uniqueidentifier PRIMARY KEY, 
	machuong uniqueidentifier,
	tieude NVARCHAR(50),
	mota NVARCHAR(200),
	thoigianbatdau DATETIME,
	thoigianketthuc DATETIME,
	xemdiem TINYINT,
	xemdapan TINYINT,
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE dekiemtra
ADD CONSTRAINT defaultDektUUID DEFAULT NEWID() FOR madekiemtra;

CREATE TABLE cauhoi(
	macauhoi uniqueidentifier PRIMARY KEY, 
	mataikhoan uniqueidentifier,
	noidung NVARCHAR(300),
	giaithich NVARCHAR(300),
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk)
)

ALTER TABLE cauhoi
ADD CONSTRAINT defaultCauhoiUUID DEFAULT NEWID() FOR macauhoi;

CREATE TABLE cautraloi(
	macautraloi uniqueidentifier PRIMARY KEY, 
	macauhoi uniqueidentifier ,
	noidung NVARCHAR(300),
	lacautraloidung TINYINT,
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi)
)

ALTER TABLE cautraloi
ADD CONSTRAINT defaultCautlUUID DEFAULT NEWID() FOR macautraloi;

CREATE TABLE chitietbaikiemtra(
	madekiemtra uniqueidentifier, 
	macauhoi uniqueidentifier, 
	FOREIGN KEY (madekiemtra) REFERENCES dekiemtra(madekiemtra),
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi)
)

CREATE TABLE bailamkiemtra(
	mabailam  uniqueidentifier PRIMARY KEY,
	mataikhoan uniqueidentifier ,
	diem int,
	thoigianbatdaulam DATETIME,
	thoigiannop DATETIME,
	socaudung int,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk)
)

ALTER TABLE bailamkiemtra
ADD CONSTRAINT defaultBailamktUUID DEFAULT NEWID() FOR mabailam;

CREATE TABLE chitietbailamkiemtra(
	mabailamkt uniqueidentifier ,
	macauhoi uniqueidentifier ,
	dapanchon uniqueidentifier,
	FOREIGN KEY (mabailamkt) REFERENCES bailamkiemtra(mabailam),
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi),
	FOREIGN KEY (dapanchon) REFERENCES cautraloi(macautraloi)
)
ALTER TABLE dekiemtra ADD thoigiantao DATETIME
ALTER TABLE dekiemtra ADD troncauhoi TINYINT 
ALTER TABLE baitap ADD dahoanthanh TINYINT
ALTER TABLE dekiemtra ADD dahoanthanh TINYINT 

ALTER TABLE dekiemtra DROP COLUMN mota 

ALTER TABLE taikhoan ADD CONSTRAINT taikhoan_cons_uniq UNIQUE (email)
ALTER TABLE cauhoi ADD trangthai TINYINT

UPDATE cauhoi SET trangthai=1
ALTER TABLE chitietbaikiemtra ADD thutu TINYINT
ALTER TABLE dekiemtra ADD daxoa TINYINT
UPDATE dekiemtra SET daxoa=0

ALTER TABLE chuong ADD daxoa TINYINT
UPDATE chuong SET daxoa=0

ALTER TABLE lophoc ADD daxoa TINYINT
UPDATE lophoc SET daxoa=0

use hybrid
ALTER TABLE lophoc DROP COLUMN trangthai