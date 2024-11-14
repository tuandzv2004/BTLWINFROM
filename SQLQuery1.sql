--food
--table
-- FoodCategory
-- account
-- bill
-- billinfo


create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn Chưa Có Tên',
	status nvarchar(100) not null default N'Trống'
)
GO
 create table Account
 (
	Name nvarchar(100) not null  default N'BTuan',
	UserName nvarchar(100) primary key,
	PassWord nvarchar(1000) not null default 0,
	Type Int not null default 0
 )
 GO

 create table FoodCategory
 (
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa Đặt Tên'
 )
 Go

 create table Food
 (
	id int identity primary key,
	name nvarchar(100) not null  default N'Chưa Đặt Tên',
	idCategory int not null,
	price float not null default 0
	
	foreign key (idCategory) references dbo.FoodCategory(id)

 )
 GO

 create table Bill
 (
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date,
	idTable int not null,
	status int not null default 0 -- 1: đã thanh toán 0 : chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id)

 )
 GO

 alter table BillInfo
 (
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)

)
Go

Select * from FoodCategory

select * from Food

alter proc USP_InsertBill
@idTable int
as
begin
	INsert dbo.Bill
	values(
	GETDATE(),NULL,@idTable,0,0,0
	)
end
go

alter proc USP_InsertBillInfo
@idBill int , @idFood int, @count int
as
begin
	declare @checkbillinfo int
	declare @foodcont int = 1

	select @checkbillinfo = id , @foodcont =count from BillInfo where idBill = @idBill and idFood = @idFood

	if(@checkbillinfo>0)
		begin
			declare @newcount int = @foodcont + @count
			if(@newcount>0)
				update BillInfo set count=@foodcont+@count where idFood=@idFood and idBill=@idBill
			else
				delete  BillInfo where idBill=@idBill and idFood=@idFood
		end

	else
	begin
	insert BillInfo
	(
	idBill,idFood,count
	)
	Values(
	@idBill,@idFood,@count
	)
	end
end
go
select max(id) from Bill

select * from Bill
select * from BillInfo
select * from TableFood


update dbo.Bill set status=1 where id=1

alter TRIGGER UTG_UpdateBillInfo
ON dbo. BillInfo FOR INSERT, UPDATE
AS
BEGIN
DECLARE @idBill INT

SELECT @idBill = idBill FROM Inserted

DECLARE @idTable INT

SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

declare @count int
select @count = COUNT(*) from dbo.BillInfo where idBill =@idBill
if(@count >0)
begin
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
end
else
begin
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
	
end
END
GO

ALTER TRIGGER UTG_UpdateBill
ON dbo. Bill FOR UPDATE
AS
BEGIN
DECLARE @idBill INT

SELECT @idBill = id FROM Inserted

DECLARE @idTable INT

SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

DECLARE @count int = 0

SELECT @count = COUNT (*) FROM dbo. Bill WHERE idTable = @idTable AND status = 0

IF (@count = 0)
UPDATE dbo.TableFood SET status = N'Trống' where id = @idTable

END
GO


delete BillInfo
delete Bill



alter table Bill
add discount int


update Bill set discount =0 

ALTER TABLE BillInfo
ADD CONSTRAINT FK_BillInfo_Bill
FOREIGN KEY (idBill) REFERENCES dbo.Bill(id);
GO


select * from BillInfo

create proc UTP_chuyenban
@idtable1 int, @idtable2 int
as
begin
	
	declare @idfirstbill int
	declare @idsecondbill int

	declare @isfirsttablemty int =1
	declare @issecondtablemty int =1

	select @idsecondbill = id from dbo.Bill where idTable =@idtable2 and status =0
	select @idfirstbill = id from dbo.Bill where idTable =@idtable1 and status =0

	if(@idfirstbill is null)
	begin
		insert dbo.Bill(
		DateCheckIn,
		DateCheckOut,
		idTable,
		status
		)
		values(
		GETDATE(),
		NULL,
		@idtable1,
		0
		)
		select @idfirstbill = max(id) from dbo.Bill where idTable = @idtable1 and status =0
	end

	select @isfirsttablemty = count(*) from dbo.BillInfo where idBill= @idfirstbill

	if(@idsecondbill is null)
		begin 
			insert dbo.Bill(
		DateCheckIn,
		DateCheckOut,
		idTable,
		status
		)
			values(
			GETDATE(),
			NULL,
			@idtable2,
			0
			)
		
			select @idsecondbill = max(id) from dbo.Bill where idTable = @idtable2 and status=0

		end

		select @issecondtablemty = count(*) from dbo.BillInfo where idBill = @idsecondbill

		select id into IDBillInfoTable from dbo.BillInfo where idBill = @idsecondbill
		
		update dbo.BillInfo set idBill = @idsecondbill where idBill = @idfirstbill

		update dbo.BillInfo set idBill = @idfirstbill where id in (select * from IDBillInfoTable)

		drop table IDBillInfoTable

		if(@isfirsttablemty =0)
			update dbo.TableFood set status=N'Trống' where id = @idtable2
		
		if(@issecondtablemty = 0)
			update dbo.TableFood set status= N'Trống' where id = @idtable1
end
go

alter table bill add totalPrice float

alter proc USP_getlistbydate
@checkin date, @checkout date
as
begin

select t.name as [Tên Bàn],b.totalPrice as [Tổng Tiền], DateCheckIn as [Ngày Vào],DateCheckOut as [Ngày Ra],discount as [Giảm Giá] from bill as b,TableFood as t 
where DateCheckIn >=@checkin and DateCheckOut <=@checkout and b.status =1
and t.id = b.idTable
end
go
select * from Bill

delete Bill


exec UTP_chuyenban 3,4

exec USP_getlistbydate '2024-11-10','2024-11-10'

select * from Food
select * from BillInfo

delete BillInfo


alter TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
DECLARE @idBillInfo INT
DECLARE @idBill INT
SELECT @idBillInfo = id, @idBill = Deleted. idBill FROM Deleted

DECLARE @idTable INT
SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

DECLARE @count INT = 0

SELECT @count = COUNT (*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

IF (@count = 0) UPDATE dbo. TableFood SET status = N'Trống' WHERE id = @idTable

END
GO

SELECT  COUNT (*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = 38  AND b.status = 0
select * from TableFood
select * from Bill
select * from BillInfo

select * from Account

select * from Bill
select * from BillInfo
select * from Food
select * from TableFood

select f.name , bf.count, f.price, (f.price*bf.count)*(100-b.discount)/100 as tong from BillInfo as bf join Bill as b on bf.idBill=b.id join Food as f on f.id = bf.idFood join TableFood tb on tb.id = b.idTable where  tb.id=7 and b.status =0

