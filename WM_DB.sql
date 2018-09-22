create database WM_Assignment;

use WM_Assignment 
go

IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL 
  DROP TABLE dbo.Product; 

create table dbo.Product
(
ID int identity(1,1) primary key,
Name nvarchar(50) not null,
Description nvarchar(150),
Category nvarchar(50),
Manufacturer nvarchar(50),
Supplier nvarchar(50),
Price decimal(15,2) not null
)
;

select *
from Product;

insert into Product
select 'iPad Pro 10.5', '512GB', 'Tablet', 'Apple', 'KNB International', 900 union
select 'Apple iPhone X', '256GB', 'Mobile phone', 'Apple', 'KNB International', 1100 union
select 'Galaxy S9 Plus Dual SIM', '256GB', 'Mobile phone', 'Samsung', 'KNB International', 800 union
select 'Galaxy Note 9 Dual SIM', '128GB', 'Mobile phone', 'Samsung', 'KNB International', 950 union
select 'Google Pixel XL', '128GB', 'Mobile phone', 'HTC', 'KNB International', 770 union
select 'G7 ThinQ Dual SIM', '64GB', 'Mobile phone', 'LG', 'KNB International', 600 union
select 'Galaxy Tab S2', '9.7 (2016) Wifi 32GB', 'Tablet', 'Samsung', 'KNB International', 350 union
select '43uk6200', 'UHD, webos4, black', 'TV', 'LG', 'KNB International', 300 union
select '43uk6300', 'UHD, webos4, black', 'TV', 'LG', 'KNB International', 390 union
select '43uk6500', 'UHD, webos4, silver', 'TV', 'LG', 'KNB International', 420 union
select '43uk6950', 'UHD, webos4, titan, magic remote', 'TV', 'LG', 'KNB International', 460 union
select 'UTP Cable', 'cat. 5e network cable, 20m', 'Cables and Adapters', 'Hama', 'KNB International', 8.99 union
select 'RF Cable', '75dB, 1.5m', 'Cables and Adapters', 'Hama', 'KNB International', 0.5 union
select 'HDMI Cable', 'HDMI-HDMI 2m', 'Cables and Adapters', 'Hama', 'KNB International', 4.99 union
select 'Adapter USB Type C - HDMI', 'black', 'Cables and Adapters', 'Hama', 'KNB International', 35 union
select 'iPad Pro 10.5', '512GB', 'Tablet', 'Apple', 'Global Trade Ltd.', 1100 union
select 'Apple iPhone X', '256GB', 'Mobile phone', 'Apple', 'Global Trade Ltd.', 1200 union
select 'Galaxy S9 Plus Dual SIM', '256GB', 'Mobile phone', 'Samsung', 'Global Trade Ltd.', 750 union
select 'Galaxy Note 9 Dual SIM', '128GB', 'Mobile phone', 'Samsung', 'Global Trade Ltd.', 880 union
select 'Google Pixel XL', '128GB', 'Mobile phone', 'HTC', 'Global Trade Ltd.', 950 union
select 'G7 ThinQ Dual SIM', '64GB', 'Mobile phone', 'LG', 'Global Trade Ltd.', 560 union
select 'Galaxy Tab S2', '9.7 (2016) Wifi 32GB', 'Tablet', 'Samsung', 'Global Trade Ltd.', 300 union
select '43uk6300', 'UHD, webos4, black', 'TV', 'LG', 'Global Trade Ltd.', 450 union
select '43uk6400', 'UHD, webos4, havana brown', 'TV', 'LG', 'Global Trade Ltd.', 380 union
select '43uk6950', 'UHD, webos4, titan, magic remote', 'TV', 'LG', 'Global Trade Ltd.', 520 union
select 'UTP Cable', 'cat. 5e network cable, 20m', 'Cables and Adapters', 'Hama', 'Global Trade Ltd.', 11 union
select 'RF Cable', '75dB, 1.5m', 'Cables and Adapters', 'Hama', 'Global Trade Ltd.', 0.99 union
select 'HDMI Cable', 'HDMI-HDMI 2m', 'Cables and Adapters', 'Hama', 'Global Trade Ltd.', 4.6 union
select 'Adapter USB Type C - HDMI', 'black', 'Cables and Adapters', 'Hama', 'Global Trade Ltd.', 40 union
select 'iPad Pro 10.5', '512GB', 'Tablet', 'Apple', 'EL Tech S&S', 1099.99 union
select 'Apple iPhone X', '256GB', 'Mobile phone', 'Apple', 'EL Tech S&S', 1130 union
select 'Galaxy S9 Plus Dual SIM', '256GB', 'Mobile phone', 'Samsung', 'EL Tech S&S', 700 union
select 'Galaxy Note 9 Dual SIM', '128GB', 'Mobile phone', 'Samsung', 'EL Tech S&S', 830 union
select 'Google Pixel XL', '128GB', 'Mobile phone', 'HTC', 'EL Tech S&S', 950 union
select 'G7 ThinQ Dual SIM', '64GB', 'Mobile phone', 'LG', 'EL Tech S&S', 580 union
select 'Galaxy Tab S2', '9.7 (2016) Wifi 32GB', 'Tablet', 'Samsung', 'EL Tech S&S', 290 union
select '43uk6300', 'UHD, webos4, black', 'TV', 'LG', 'EL Tech S&S', 450 union
select '43uk6400', 'UHD, webos4, havana brown', 'TV', 'LG', 'EL Tech S&S', 350 union
select '43uk6950', 'UHD, webos4, titan, magic remote', 'TV', 'LG', 'EL Tech S&S', 500 union
select 'UTP Cable', 'cat. 5e network cable, 20m', 'Cables and Adapters', 'Hama', 'EL Tech S&S', 9.5 union
select 'RF Cable', '75dB, 1.5m', 'Cables and Adapters', 'Hama', 'EL Tech S&S', 1 union
select 'HDMI Cable', 'HDMI-HDMI 2m', 'Cables and Adapters', 'Hama', 'EL Tech S&S', 5 union
select 'Adapter USB Type C - HDMI', 'black', 'Cables and Adapters', 'Hama', 'EL Tech S&S', 40