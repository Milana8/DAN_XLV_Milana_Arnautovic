CREATE DATABASE DAN_XLV
 IF DB_ID('DAN_XLV') IS NULL
CREATE DATABASE DAN_XLV;
GO
USE DAN_XLV;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblProducts')

drop table tblProducts;


Create table tblProducts(
 ID int IDENTITY(1,1) Primary key not null, --Primary key
 ProductName nvarchar (50) not null,
 ProductKey nvarchar (50)  not null unique,
 Quantity int,
 Price int,	
 Stored bit,
);

 INSERT INTO tblProducts values ('Product1', 'key1', 20, 500, 1);
 INSERT INTO tblProducts values('Product2','key2',20,700,0);
 


