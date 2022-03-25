Create Table musteri(
	musteri_no int Not Null Primary Key,
	Ad_Soyad nvarchar(30) Not Null ,
	TCKN Decimal(11) NOT NULL,
	segment nvarchar(30) Not Null,
	grup nvarchar(30) ,
	durum nvarchar (10) Not Null,
)

Create Table kredi(
	Kredi_idVKN Decimal(11) NOT NULL Primary Key,
	musteri_no int NOT NULL Foreign Key References musteri(musteri_no),
	nace_anasektör_id nvarchar(2) Not Null ,
	urun_id nvarchar(2) Not Null,
	risk_turu nvarchar(10) Not Null,
	doviz_turu nvarchar(10)Not Null,
	gecikme_gün nvarchar (5) Not Null,
)

Create Table cekilen(
	musteri_no int NOT NULL Foreign Key References musteri(musteri_no),
	miktar money Not Null,
	sube_id nvarchar(6) Not Null,
    tarih date Not Null,
)

Create Table sube(
	sube_id nvarchar(6) Not Null Primary Key,
	sube_adi Nvarchar(100) Not Null,
)

Create Table nace_anasektör(
	nace_anasektör_id int Not Null identity(1,1) Primary Key,
	nace_anasektör_ad nvarchar(100) Not Null,
)

Create Table urun(
	urun_id int Not Null identity(1,1) Primary Key ,
	urun_ad nvarchar(100) Not Null,
)

Create Table risk(
	risk_turu int Not Null  Primary Key,
	risk_adý nvarchar(10)Not Null,
)

Create Table doviz(
	doviz_turu int Not Null  Primary Key,
	doviz_adý nvarchar(10)Not Null,
)

Create Table durum(
	durum_id int Not Null Primary Key,
	durum_ad nvarchar(20) Not Null,
)
Drop table durum

Insert Into nace_anasektör values (1,'Bilgi Ve Ýletiþim')
Insert Into nace_anasektör values (2,'Diðer Hizmet Faaliyetleri')
Insert Into nace_anasektör values (3,'Eðitim')
Insert Into nace_anasektör values (4,'Elektrik,Gaz,Buhar ve Ýklimlendirme Üretimi Ve Daðýtýmý')
Insert Into nace_anasektör values (5,'Finans Ve Sigorta Faaliyetleri')
Insert Into nace_anasektör values (6,'Gayrimenkul Faaliyetleri')
Insert Into nace_anasektör values (7,'Ýdari Ve Destek Hizmet Faaliyetleri ')
Insert Into nace_anasektör values (8,'Ýmalat')
Insert Into nace_anasektör values (9,'Ýnsan Saðlýðý Ve Sosyal Hizmet Faaliyetleri')
Insert Into nace_anasektör values (10,'Ýnþaat')
Insert Into nace_anasektör values (11,'Kamu Yönetimi Ve Savunma; Zorunlu Sosyal Güvenlik')
Insert Into nace_anasektör values (12,'Konaklama Ve Yiyecek Hizmeti Faaliyetleri')
Insert Into nace_anasektör values (13,'Kültür,Sanat, Eðlence, Dinlance Ve Spor')
Insert Into nace_anasektör values (14,'Madencilik Ve Taþ Ocakçýlýðý')
Insert Into nace_anasektör values (15,'Mesleki, Bilimsel Ve Teknik Faaliyetler')
Insert Into nace_anasektör values (16,'Su Temini; Kanalizasyon,Atýk Yönetimi Ve Ýyileþtirme Faaliyetleri')
Insert Into nace_anasektör values (17,'Tarým,Ormancýlýk Ve Balýkçýlýk')
Insert Into nace_anasektör values (18,'Toptan Ve Perakende Ticaret;Motorlu Taþýtlarýn Ve Motorsikletlerin Onarýmý')
Insert Into nace_anasektör values (19,'Ulaþtýrma Ve Depolama')

Insert Into urun values (1,'Araç Binek 2.El')
Insert Into urun values (2,'Araç Binek Yeni')
Insert Into urun values (3,'Araç Ticari 2.El')
Insert Into urun values (4,'Araç Ticari Yeni')
Insert Into urun values (5,'Arsa')
Insert Into urun values (6,'Çek Ödeme Destek')
Insert Into urun values (7,'Eðitim Finansmaný')
Insert Into urun values (8,'Ev/Ofis Gerekçeleri')
Insert Into urun values (9,'Gemi Finansmaný')
Insert Into urun values (10,'Ýhtiyaç Desteði Finansmaný')
Insert Into urun values (11,'Ýþletme Gayrimenkul')
Insert Into urun values (12,'Ýþletme Makine Techizat Kredileri')
Insert Into urun values (13,'Ýþyeri 2.El')
Insert Into urun values (14,'Ýthalat Akredifi')
Insert Into urun values (15,'Konut 2.El')
Insert Into urun values (16,'Konut BÝP')
Insert Into urun values (17,'Konut DÝP')
Insert Into urun values (18,'Makine Ve Teçhizat 2.El-FKR')
Insert Into urun values (19,'Makine Ve Teçhizat Yeni-FKR')
Insert Into urun values (20,'Makine/Teçhizat 2.El')
Insert Into urun values (21,'Tüketici Teverruk Diðer')

Insert into risk values(1,'Nakdi')
Insert into risk values(2,'Gayrinakdi')
Insert into risk values(3,'Takip')

Insert into doviz values(1,'TL')
Insert into doviz values(2,'Dolar')
Insert into doviz values(3,'Euro')

Insert into durum values(1,'Canlý Kredi')
Insert into durum values(2,'Yakýn Ýzleme')
Insert into durum values(3,'Takip')

Select*From nace_anasektör
Select*From urun
Select*From risk
Select*From doviz
Select*From durum
