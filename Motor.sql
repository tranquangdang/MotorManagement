drop table tblOrderInvoiceDetail, tblOrderInvoice 
drop table tblMotor

set dateformat dmy;

create table tblMotor
(
	ProductID char(5) primary key,
	Model nvarchar(100),
	Brand nvarchar(50),
	Category nvarchar(50),
	CylinderCapacity float,
	Price money,
	Quantity int,
)
go

--select Model from tblMotor where Model like N'%j%' order by 'Model' asc

create table tblOrderInvoice
(
	OrderID char(5) primary key,
	OrderDate datetime,
	CustName nvarchar(50),
	TelNo char(10),
	IDC nchar(20),
	Address nvarchar(100),
	TotalMoney money default 0,
)
go

create table tblOrderInvoiceDetail
(
	OrderID char(5) foreign key references tblOrderInvoice(OrderID),
	ProductID char(5) foreign key references tblMotor(ProductID),
	primary key (OrderID, ProductID),
	QtyOrdered int,
	Amount money,
)
go
--Insert
create trigger trgInsert_OrderInvoiceDetail
on tblOrderInvoiceDetail
after insert
as
begin
	declare @counter int, @i money
	--a. Tăng/giảm số lượng ở bảng tblMotor
	update tblMotor
	set Quantity = Quantity - i.QtyOrdered
	from inserted as i
	where
		tblMotor.ProductID = i.ProductID
	--b. Cập nhật cột thành tiền bảng tblOrderInvoiceDetail
	update tblOrderInvoiceDetail
	set Amount = tblOrderInvoiceDetail.QtyOrdered * Price
	from tblMotor as p, inserted as i
	where
		p.ProductID = i.ProductID and
		tblOrderInvoiceDetail.OrderID = i.OrderID and
		tblOrderInvoiceDetail.ProductID = i.ProductID
end
go
--Delete
create trigger trgDelete_OrderInvoiceDetail
on tblOrderInvoiceDetail
after delete
as
begin
	--Tăng/giảm số lượng ở bảng tblMotor
	update tblMotor
	set Quantity = Quantity + d.QtyOrdered
	from deleted as d
	where
		tblMotor.ProductID = d.ProductID
	--Cập nhật cột thành tiền bảng tblOrderInvoiceDetail
	update tblOrderInvoiceDetail
	set Amount = tblOrderInvoiceDetail.QtyOrdered * Price
	from tblMotor as p, deleted as d
	where
		p.ProductID = d.ProductID and
		tblOrderInvoiceDetail.OrderID = d.OrderID and
		tblOrderInvoiceDetail.ProductID = d.ProductID
end
go

--Cập nhật cột tổng tiền ở bảng tblOrderInvoice
CREATE TRIGGER trg_TotalMoney
   ON  tblOrderInvoiceDetail
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
    UPDATE tblOrderInvoice
	set TotalMoney = (select sum(Amount) from tblOrderInvoiceDetail where tblOrderInvoice.OrderID = tblOrderInvoiceDetail.OrderID)
END
GO

insert into tblMotor
values	('M0001', N'SH 300CC', N'Honda', N'Xe tay ga', 279, 270500000, 100),
		('M0002', N'CB650R', N'Honda', N'Xe mô tô', 649, 245990000, 100),
		('M0003', N'LIBERTY', N'Piaggo', N'Xe tay ga', 124.5, 58500000, 100),
		('M0004', N'EXCITER 150', N'Yamaha', N'Xe thể thao', 150, 48999000, 100),
		('M0005', N'JUPITER FI', N'Yamaha', N'Xe số', 114, 28000000, 100),
		('M0006', N'SH MODE 125', N'Honda', N'Xe tay ga', 124.8, 53890000, 100),
		('M0007', N'WINNER X', N'Honda', N'Xe thể thao', 149.1, 45990000, 100),
		('M0008', N'BLADE', N'Honda', N'Xe số', 109.1, 18800000, 100),
		('M0009', N'WAVE ALPHA', N'Honda', N'Xe số', 109.1, 17790000, 100),
		('M0010', N'WAVE RSX FI', N'Honda', N'Xe số', 109.2, 21690000, 100),
		('M0011', N'PCX 150', N'Honda', N'Xe tay ga', 149.9, 56490000, 100),
		('M0012', N'VISION', N'Honda', N'Xe tay ga', 108.2, 30790000, 100),
		('M0013', N'Janus', N'Yamaha', N'Xe tay ga', 125, 31990000, 100),
		('M0014', N'SIRIUS FI', N'Yamaha', N'Xe số', 115, 23190000, 100),
		('M0015', N'GRANDE', N'Yamaha', N'Xe tay ga', 125, 50000000, 100),
		('M0016', N'REBEL 500', N'HONDA', N'Xe thể thao', 471, 180000000, 100),
		('M0017', N'BMW R1200 GSA', N'BMW', N'Xe thể thao', 1170, 659000000, 100),
		('M0018', N'KAWASAKI Z1000', N'KAWASAKI', N'Xe thể thao', 1043, 412000000, 100),
		('M0019', N'BMW S1000R', N'BMW', N'Xe thể thao', 999, 529000000, 100),
		('M0020', N'KAWASAKI Z900', N'KAWASAKI', N'Xe tay côn', 948, 288000000, 100)
go

insert into tblOrderInvoice
values	('O0001', N'09/07/2020 07:13:50', N'Lâm Văn Hùng', '0905267382', '201748373', N'09 Lê Quang Sung, TP Tam Kỳ, tỉnh Quảng Nam', default),
		('O0002', N'14/07/2020 12:03:50', N'Nguyễn Hồng An', '0326783459', '201819371', N'140 Lê Đình Dương, quận Hải Châu, Hải Châu, Đà Nẵng', default),
		('O0003', N'15/07/2020 09:23:55', N'Đỗ Mai Chi', '0905749372', '139472819', N'58 Hoàng Diệu, TT. Vĩnh Điện, Điện Bàn, Quảng Nam', default),
		('O0004', N'21/07/2020 15:34:53', N'Trần Công Chí', '0937465833', '108374859', N'53 Lý Thái Tông, Thanh Khê Tây, Thanh Khê, Đà Nẵng, Việt Nam', default),
		('O0005', N'29/07/2020 20:08:15', N'Võ Sĩ Hùng', '0351758927', '1183989812', N'5 Nguyễn Tri Phương, Thạc Gián, Thanh Khê, Đà Nẵng', default),
		('O0006', N'02/08/2020 15:14:23', N'Châu Minh Thảo', '0873864834', '201839382', N'82 Trần Quốc Toản, quận Hải Châu, Đà Nẵng', default),
		('O0007', N'13/08/2020 19:25:35', N'Bùi Trúc Linh', '0905847591', '11721089912', N'96 Tân Thới Hiệp 13, Quận 12, Hồ Chí Minh', default),
		('O0008', N'24/08/2020 10:35:03', N'Trương Ngọc Nga', '0968428418', '101921324', N'Ngõ 268 Đê la Thành, Thổ Quan, Đống Đa, Hà Nội', default),
		('O0009', N'25/08/2020 16:28:37', N'Nguyễn Đình Long', '0321847372', '123128772', N'136 Nguyễn An Ninh, Đồng Tâm, Hai Bà Trưng, Hà Nội', default)
go

insert into tblOrderInvoiceDetail
values	('O0001','M0001', 3, null),
		('O0001','M0002', 1, null),
		('O0002','M0003', 2, null),
		('O0002','M0004', 1, null),
		('O0003','M0005', 1, null),
		('O0003','M0006', 3, null),
		('O0004','M0007', 7, null),
		('O0004','M0011', 1, null),
		('O0004','M0012', 1, null),
		('O0005','M0008', 1, null),
		('O0006','M0009', 3, null),
		('O0007','M0010', 4, null),
		('O0008','M0012', 1, null),
		('O0008','M0014', 1, null),
		('O0008','M0007', 2, null),
		('O0008','M0005', 1, null),
		('O0009','M0018', 6, null)
go
--select * from tblOrderInvoice
select m.ProductID, Model, Price, QtyOrdered, Amount from tblOrderInvoiceDetail as o, tblMotor as m, tblOrderInvoice as oi  
where oi.OrderID = 'O0001' and o.ProductID = m.ProductID and o.OrderID = oi.OrderID

select * from tblOrderInvoice as oi where OrderID = 'O0001'
select * from tblOrderInvoiceDetail
--select Amount from tblOrderInvoiceDetail as oi where ProductID = 'M0011' and oi.OrderID = 'O0004'
delete from tblOrderInvoiceDetail where OrderID = 'O0004' and ProductID = 'M0007'