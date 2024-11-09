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

create proc USP_InsertBill
@idTable int
as
begin
	INsert dbo.Bill
	values(
	GETDATE(),NULL,@idTable,0,0
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
select * from bill
select * from TableFood

exec UTP_chuyenban 3,4

