--drop database [InternetShop]
--create database [InternetShop]
use [InternetShop]
Go
create table Product(
	Barcode nvarchar(32) primary key not null
	,Model nvarchar(128)
	,Size nvarchar(16)
	,Color nvarchar(64)
	,PriceS decimal default 0
	,PriceL decimal default 0
	,Brand nvarchar(64)
	,Gender nvarchar(128)
	,Seasion nvarchar(128)
	,[Image] nvarchar(256)
	,[Description] nvarchar(max)
)
Go
create table Brand(
	Id int identity(1,2) primary key
	,Name nvarchar(128)
	,[Description] nvarchar(max)
	,[Address] nvarchar(256)
	,Country nvarchar(128)
)
Go
create table Warehouse(
	Barcode nvarchar(32) primary key
	,Quantity int default 0
	,IsPromotion bit default 0
	,PricePromotion decimal default 0
	,PercentPromotion int default 0
	,IsSale bit default 0
	,StartSale datetime
	,EndSale datetime
	,IsHot bit default 0
	,IsNew bit default 0
	,IsVisible bit default 1 --1: Cho phép show sản phẩm. 0: Không đc phép
	,DateCreate datetime
	,LastUpdate datetime
)
Go
create table Customer(
	Id int identity(1,1) primary key
	,FullName nvarchar(128)
	,[Address] nvarchar(256)
	,[Email] nvarchar(64)
	,[Phone] nvarchar(32)
)
Go
create table Billing(
	Id int identity(1,1) primary key
	,CustomerId int
	,BillNumber nvarchar(64)
	,BillDate datetime
	,FromDate datetime
	,ToDate datetime
	,[Status] int --0: Chưa xác nhận, 1: Đã xác nhận, 2: Chưa thanh toán, 3: Đang thanh toán, 4: Đã thanh toán, 5: Hủy đơn hàng
	,BillTo nvarchar(128)
	,[Month] int
	,[Year] int
	,VATRate int
	,VAT decimal
	,Total decimal
	,Note nvarchar(max)
	,LastUpdate datetime
	,CreateBy nvarchar(128)
)
Go
create table BillProduct(
	Id int identity(1,1) primary key
	,BillNumber nvarchar(64)
	,Barcode nvarchar(32)
	,BillFeeId int
)
Go
create table BillFee(
	Id int identity(1,10) primary key
	,Name nvarchar(32)
	,Fee decimal
	,Unit nvarchar(64)
)
Go
create table ConfigWebsite(
	Id int identity(1,1) primary key
	,[Page] nvarchar(32)
	,[Title] nvarchar(64)
	,[Content] nvarchar(max)
	,[LastUpdate] datetime
	,[UpdateBy] nvarchar(64)
)
Go
create table BillHistory(
	Id int identity(1,1) primary key
	,BillNumber nvarchar(64)
	,[Date] datetime
)
