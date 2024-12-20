USE [master]
GO
/****** Object:  Database [quanlynhahang]    Script Date: 11/14/2024 4:52:40 PM ******/
CREATE DATABASE [quanlynhahang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlynhahang', FILENAME = N'D:\SQL2022\MSSQL16.SQLEXPRESS\MSSQL\DATA\quanlynhahang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quanlynhahang_log', FILENAME = N'D:\SQL2022\MSSQL16.SQLEXPRESS\MSSQL\DATA\quanlynhahang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [quanlynhahang] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlynhahang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlynhahang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlynhahang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlynhahang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlynhahang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlynhahang] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlynhahang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlynhahang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlynhahang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlynhahang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlynhahang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlynhahang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlynhahang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlynhahang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlynhahang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlynhahang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlynhahang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlynhahang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlynhahang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlynhahang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlynhahang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlynhahang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlynhahang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlynhahang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlynhahang] SET  MULTI_USER 
GO
ALTER DATABASE [quanlynhahang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlynhahang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlynhahang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlynhahang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quanlynhahang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quanlynhahang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [quanlynhahang] SET QUERY_STORE = ON
GO
ALTER DATABASE [quanlynhahang] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [quanlynhahang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Name] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Name], [UserName], [PassWord], [Type]) VALUES (N'Dương Quốc Bảo Tuấn', N'NV01', N'1', 0)
INSERT [dbo].[Account] ([Name], [UserName], [PassWord], [Type]) VALUES (N'Nguyễn Văn b', N'NV02', N'1', 1)
INSERT [dbo].[Account] ([Name], [UserName], [PassWord], [Type]) VALUES (N'test2', N'NV04', N'0', 1)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (31, CAST(N'2024-11-10' AS Date), CAST(N'2024-11-10' AS Date), 3, 1, 0, 100000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (32, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 1, 1, 0, 100000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (33, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 2, 1, 0, 100000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (34, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 2, 1, 0, 40000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (35, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 2, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (36, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 1, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (37, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-13' AS Date), 1, 1, 0, 50)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (38, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-11' AS Date), 2, 1, 0, 20000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (39, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-13' AS Date), 2, 1, 0, 99000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (40, CAST(N'2024-11-13' AS Date), NULL, 2, 0, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (41, CAST(N'2024-11-13' AS Date), NULL, 7, 0, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (42, CAST(N'2024-11-13' AS Date), NULL, 8, 0, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (43, CAST(N'2024-11-14' AS Date), NULL, 12, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (79, 1, 2, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (80, 31, 2, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (83, 32, 7, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (84, 32, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (87, 33, 2, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (88, 1, 7, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (89, 34, 7, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (96, 38, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (99, 1, 5, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (100, 39, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (101, 37, 18, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (102, 40, 2, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (103, 40, 18, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (104, 40, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (105, 41, 5, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (106, 41, 18, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (107, 1, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (108, 42, 8, 6)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Thịt xào chua ngọt', 1, 100000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Sườn chua ngọt', 1, 99000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Rau muống luộc', 1, 50000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Nước cola', 2, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'7 UP', 2, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Number 1', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'test', 1, 50)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'ĐỒ ĂN')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'ĐỒ UỐNG')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'tes5')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Bàn 0', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Bàn 1', N'Có người')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Bàn 2', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Bàn 3', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Bàn 4', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Bàn 5', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Bàn 6', N'Có người')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Bàn 7', N'Có người')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Bàn 8', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Bàn 9', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (11, N'Bàn 10', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (12, N'Bàn 11', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (13, N'Bàn 12', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (14, N'Bàn 14', N'Trống')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'BTuan') FOR [Name]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Bàn Chưa Có Tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_getlistbydate]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getlistbydate]
@checkin date, @checkout date
as
begin

select t.name as [Tên Bàn],b.totalPrice as [Tổng Tiền], DateCheckIn as [Ngày Vào],DateCheckOut as [Ngày Ra],discount as [Giảm Giá] from bill as b,TableFood as t 
where DateCheckIn >=@checkin and DateCheckOut <=@checkout and b.status =1
and t.id = b.idTable
end

GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_GetTableList]
as select * from dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBill]
@idTable int
as
begin
	INsert dbo.Bill
	values(
	GETDATE(),NULL,@idTable,0,0,0
	)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBillInfo]
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
GO
/****** Object:  StoredProcedure [dbo].[UTP_chuyenban]    Script Date: 11/14/2024 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UTP_chuyenban]
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

GO
USE [master]
GO
ALTER DATABASE [quanlynhahang] SET  READ_WRITE 
GO
