CREATE DATABASE hybrid;

use hybrid;

CREATE TABLE nhomquyen(
	manhomquyen INT PRIMARY KEY,
	ten varchar(50)
)

CREATE TABLE taikhoan(
	matk uniqueidentifier PRIMARY KEY,
	manhomquyen INT,
	hoten VARCHAR(255),
	email VARCHAR(255),
	matkhau VARCHAR(255),
	sodienthoai VARCHAR(15),
	anhdaidien VARCHAR(255),
	FOREIGN KEY (manhomquyen) REFERENCES nhomquyen(manhomquyen)
)

-- cài đặt khóa chính taikhoan
ALTER TABLE taikhoan
ADD CONSTRAINT defaultUUID DEFAULT NEWID() FOR matk;

CREATE TABLE lophoc(
	malophoc uniqueidentifier PRIMARY KEY,
	ten VARCHAR(255),
	mota VARCHAR(500),
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
	ten VARCHAR(255),
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE nhomchat
ADD CONSTRAINT defaultNhomChatUUID DEFAULT NEWID() FOR malophoc;

CREATE TABLE tinnhan(
	matinnhan uniqueidentifier PRIMARY KEY,
	manhomchat uniqueidentifier,
	mataikhoan uniqueidentifier,
	noidung VARCHAR(300) ,
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
	ten varchar(100),
	thoigiantao DATETIME,
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE chuong
ADD CONSTRAINT defaultChuongUUID DEFAULT NEWID() FOR machuong;

CREATE TABLE hoclieu(
	mahoclieu uniqueidentifier PRIMARY KEY,
	machuong uniqueidentifier,
	tieude varchar(100),
	noidung varchar(300),
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE hoclieu
ADD CONSTRAINT defaultHocLieuUUID DEFAULT NEWID() FOR mahoclieu;

CREATE TABLE filehoclieu(
	mahoclieu uniqueidentifier,
	link varchar(255),
	FOREIGN KEY (mahoclieu) REFERENCES hoclieu(mahoclieu)
)

CREATE TABLE banbe(
	mabanbe uniqueidentifier PRIMARY KEY,
	manguoiketban uniqueidentifier,
	manguoiduocketban uniqueidentifier,
	thoigianketban DATETIME,
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
	noidung varchar(300),
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
	tieude VARCHAR(100),
	noidung VARCHAR(300),
	thoigiantao DATETIME,
	thoihan DATETIME,
	FOREIGN KEY (machuong) REFERENCES taikhoan(matk)
)

ALTER TABLE baitap
ADD CONSTRAINT defaultBaitapUUID DEFAULT NEWID() FOR mabaitap;

CREATE TABLE dapanbaitap(
	madapan  uniqueidentifier PRIMARY KEY,
	mabaitap uniqueidentifier,
	noidung VARCHAR(300),
	xemdapan TINYINT,
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

ALTER TABLE dapanbaitap
ADD CONSTRAINT defaultDapanUUID DEFAULT NEWID() FOR madapan;

CREATE TABLE filedapanbaitap(
	madapan  uniqueidentifier,
	link VARCHAR(100),
	FOREIGN KEY (madapan) REFERENCES dapanbaitap(madapan)
)

CREATE TABLE filebaitap(
	mabaitap  uniqueidentifier,
	link VARCHAR(100),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

CREATE TABLE bailambaitap(
	mabailam uniqueidentifier PRIMARY KEY,
	mataikhoan uniqueidentifier,
	mabaitap uniqueidentifier,
	noidung VARCHAR(500),
	thoigiannopbai DATETIME,
	nhanxet VARCHAR(200),
	diem int,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(matk),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

ALTER TABLE bailambaitap
ADD CONSTRAINT defaultBailamnUUID DEFAULT NEWID() FOR mabailam;

CREATE TABLE filebailambaitap(
	mabailam  uniqueidentifier,
	link VARCHAR(100),
	FOREIGN KEY (mabailam) REFERENCES bailambaitap(mabailam)
)

CREATE TABLE dekiemtra(
	madekiemtra uniqueidentifier PRIMARY KEY, 
	machuong uniqueidentifier,
	tieude VARCHAR(50),
	mota VARCHAR(200),
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
	machuong uniqueidentifier,
	noidung VARCHAR(300),
	giaithich VARCHAR(300),
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE cauhoi
ADD CONSTRAINT defaultCauhoiUUID DEFAULT NEWID() FOR macauhoi;

CREATE TABLE cautraloi(
	macautraloi uniqueidentifier PRIMARY KEY, 
	macauhoi uniqueidentifier ,
	noidung VARCHAR(300),
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