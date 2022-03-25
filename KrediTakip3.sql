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
	nace_anasekt�r_id nvarchar(2) Not Null ,
	urun_id nvarchar(2) Not Null,
	risk_turu nvarchar(10) Not Null,
	doviz_turu nvarchar(10)Not Null,
	gecikme_g�n nvarchar (5) Not Null,
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

Create Table nace_anasekt�r(
	nace_anasekt�r_id int Not Null identity(1,1) Primary Key,
	nace_anasekt�r_ad nvarchar(100) Not Null,
)

Create Table urun(
	urun_id int Not Null identity(1,1) Primary Key ,
	urun_ad nvarchar(100) Not Null,
)

Create Table risk(
	risk_turu int Not Null  Primary Key,
	risk_ad� nvarchar(10)Not Null,
)

Create Table doviz(
	doviz_turu int Not Null  Primary Key,
	doviz_ad� nvarchar(10)Not Null,
)

Create Table durum(
	durum_id int Not Null Primary Key,
	durum_ad nvarchar(20) Not Null,
)
Drop table durum

Insert Into nace_anasekt�r values (1,'Bilgi Ve �leti�im')
Insert Into nace_anasekt�r values (2,'Di�er Hizmet Faaliyetleri')
Insert Into nace_anasekt�r values (3,'E�itim')
Insert Into nace_anasekt�r values (4,'Elektrik,Gaz,Buhar ve �klimlendirme �retimi Ve Da��t�m�')
Insert Into nace_anasekt�r values (5,'Finans Ve Sigorta Faaliyetleri')
Insert Into nace_anasekt�r values (6,'Gayrimenkul Faaliyetleri')
Insert Into nace_anasekt�r values (7,'�dari Ve Destek Hizmet Faaliyetleri ')
Insert Into nace_anasekt�r values (8,'�malat')
Insert Into nace_anasekt�r values (9,'�nsan Sa�l��� Ve Sosyal Hizmet Faaliyetleri')
Insert Into nace_anasekt�r values (10,'�n�aat')
Insert Into nace_anasekt�r values (11,'Kamu Y�netimi Ve Savunma; Zorunlu Sosyal G�venlik')
Insert Into nace_anasekt�r values (12,'Konaklama Ve Yiyecek Hizmeti Faaliyetleri')
Insert Into nace_anasekt�r values (13,'K�lt�r,Sanat, E�lence, Dinlance Ve Spor')
Insert Into nace_anasekt�r values (14,'Madencilik Ve Ta� Ocak��l���')
Insert Into nace_anasekt�r values (15,'Mesleki, Bilimsel Ve Teknik Faaliyetler')
Insert Into nace_anasekt�r values (16,'Su Temini; Kanalizasyon,At�k Y�netimi Ve �yile�tirme Faaliyetleri')
Insert Into nace_anasekt�r values (17,'Tar�m,Ormanc�l�k Ve Bal�k��l�k')
Insert Into nace_anasekt�r values (18,'Toptan Ve Perakende Ticaret;Motorlu Ta��tlar�n Ve Motorsikletlerin Onar�m�')
Insert Into nace_anasekt�r values (19,'Ula�t�rma Ve Depolama')

Insert Into urun values (1,'Ara� Binek 2.El')
Insert Into urun values (2,'Ara� Binek Yeni')
Insert Into urun values (3,'Ara� Ticari 2.El')
Insert Into urun values (4,'Ara� Ticari Yeni')
Insert Into urun values (5,'Arsa')
Insert Into urun values (6,'�ek �deme Destek')
Insert Into urun values (7,'E�itim Finansman�')
Insert Into urun values (8,'Ev/Ofis Gerek�eleri')
Insert Into urun values (9,'Gemi Finansman�')
Insert Into urun values (10,'�htiya� Deste�i Finansman�')
Insert Into urun values (11,'��letme Gayrimenkul')
Insert Into urun values (12,'��letme Makine Techizat Kredileri')
Insert Into urun values (13,'��yeri 2.El')
Insert Into urun values (14,'�thalat Akredifi')
Insert Into urun values (15,'Konut 2.El')
Insert Into urun values (16,'Konut B�P')
Insert Into urun values (17,'Konut D�P')
Insert Into urun values (18,'Makine Ve Te�hizat 2.El-FKR')
Insert Into urun values (19,'Makine Ve Te�hizat Yeni-FKR')
Insert Into urun values (20,'Makine/Te�hizat 2.El')
Insert Into urun values (21,'T�ketici Teverruk Di�er')

Insert into risk values(1,'Nakdi')
Insert into risk values(2,'Gayrinakdi')
Insert into risk values(3,'Takip')

Insert into doviz values(1,'TL')
Insert into doviz values(2,'Dolar')
Insert into doviz values(3,'Euro')

Insert into durum values(1,'Canl� Kredi')
Insert into durum values(2,'Yak�n �zleme')
Insert into durum values(3,'Takip')

Select*From nace_anasekt�r
Select*From urun
Select*From risk
Select*From doviz
Select*From durum
