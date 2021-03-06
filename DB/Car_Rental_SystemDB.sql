USE [master]
GO
/****** Object:  Database [Car_Rental_SystemDB]    Script Date: 2015-07-28 02:25:15 ******/
CREATE DATABASE [Car_Rental_SystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Car_Rental_SystemDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Car_Rental_SystemDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Car_Rental_SystemDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Car_Rental_SystemDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Car_Rental_SystemDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Car_Rental_SystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Car_Rental_SystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Car_Rental_SystemDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Car_Rental_SystemDB]
GO
/****** Object:  Table [dbo].[t_admin]    Script Date: 2015-07-28 02:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_admin](
	[id] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_billing_information]    Script Date: 2015-07-28 02:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_billing_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[total_cost] [varchar](50) NOT NULL,
	[advance] [varchar](50) NOT NULL,
	[due] [varchar](50) NOT NULL,
	[billing_date] [varchar](50) NOT NULL,
	[booking_id] [int] NULL,
	[customer_id] [int] NULL,
 CONSTRAINT [PK_t_billing_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_booking_details]    Script Date: 2015-07-28 02:25:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_booking_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[destination] [varchar](50) NOT NULL,
	[distance] [varchar](50) NULL,
	[date] [varchar](50) NOT NULL,
	[time] [varchar](50) NOT NULL,
	[vehicle_id] [int] NULL,
 CONSTRAINT [PK_t_booking_details1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_customer_information]    Script Date: 2015-07-28 02:25:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_customer_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[phone_no] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_customer_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_rental_information]    Script Date: 2015-07-28 02:25:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_rental_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reg_no] [varchar](50) NOT NULL,
	[rent_date] [varchar](50) NOT NULL,
	[destination] [varchar](50) NOT NULL,
	[total_cost] [varchar](50) NOT NULL,
	[cost] [varchar](50) NOT NULL,
	[profit] [varchar](50) NOT NULL,
	[commission] [varchar](50) NOT NULL,
	[payment_status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_rental_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_vehicle_information]    Script Date: 2015-07-28 02:25:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_vehicle_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reg_no] [varchar](50) NOT NULL,
	[owner_name] [varchar](50) NOT NULL,
	[deal_percent] [int] NOT NULL,
	[driver_name] [varchar](50) NOT NULL,
	[vehicle_model] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_t_vehicle_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_admin] ([id], [password]) VALUES (N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[t_billing_information] ON 

INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (1, N'4200', N'2000', N'2200', N'14/04/2015', 3, 2)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (2, N'3900', N'1500', N'2400', N'23/04/2015', 5, 3)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (3, N'6000', N'2000', N'4000', N'25/04/2015', 6, 4)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (4, N'4500', N'2200', N'2300', N'30/04/2015', 7, 5)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (5, N'2000', N'1000', N'1000', N'20/04/2015', 8, 6)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (6, N'2000', N'1000', N'1000', N'20/05/2015', 8, 6)
INSERT [dbo].[t_billing_information] ([id], [total_cost], [advance], [due], [billing_date], [booking_id], [customer_id]) VALUES (1004, N'2000', N'1000', N'1000', N'06/05/2015', 1007, 1005)
SET IDENTITY_INSERT [dbo].[t_billing_information] OFF
SET IDENTITY_INSERT [dbo].[t_booking_details] ON 

INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (3, N'Tongi', N'20', N'15/04/2015', N'12 am', 8)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (4, N'wqw', N'123', N'12/04/15', N'12 am', 8)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (5, N'Comilla', N'110', N'23/04/2015', N'12 pm', 8)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (6, N'Faridpur', N'127', N'25/04/2015', N'10 Am', 9)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (7, N'Moymonsing', N'110', N'30/04/2015', N'10am', 13)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (8, N'Airport', N'30', N'20/05/2015', N'12 am', 14)
INSERT [dbo].[t_booking_details] ([id], [destination], [distance], [date], [time], [vehicle_id]) VALUES (1007, N'dhaka', N'50', N'06 May 2015', N'4pm', 13)
SET IDENTITY_INSERT [dbo].[t_booking_details] OFF
SET IDENTITY_INSERT [dbo].[t_customer_information] ON 

INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (2, N'Masum Billah', N'Tongi', N'1611724356')
INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (3, N'Kyum', N'Jatrabari', N'123456789')
INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (4, N'Rahim Islam', N'27/2 Rampura,Dhaka', N'1911928274')
INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (5, N'Estiak Hasan', N'11 No Sector, Uttara', N'01911222222')
INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (6, N'Tasfiqur Rahman', N'2, West Hazipara, D.I.T Road Dhaka-1219', N'01611928274')
INSERT [dbo].[t_customer_information] ([id], [name], [address], [phone_no]) VALUES (1005, N'abir', N'Mirbagh', N'01711420420')
SET IDENTITY_INSERT [dbo].[t_customer_information] OFF
SET IDENTITY_INSERT [dbo].[t_rental_information] ON 

INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (1, N'DHA-Ta-1234324', N'14/04/2015', N'wqwqw', N'5000', N'3000', N'2000', N'240', N'Paid')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (2, N'FRP-101112', N'12/06/2015', N'asa', N'2500', N'1500', N'1000', N'100', N'Due')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (3, N'DHM-Cha-132054', N'12/03/2015', N'Faridpur', N'6000', N'200', N'5800', N'580', N'Paid')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (4, N'DHM-Cha-132054', N'16/03/2015', N'Faridpur', N'6000', N'200', N'5800', N'580', N'Paid')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (5, N'DHM-Ka-123423', N'23/04/2015', N'Comilla', N'3900', N'1500', N'2400', N'240', N'Paid')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (6, N'DHM-Cha-132054', N'25/04/2015', N'Faridpur', N'6000', N'3000', N'3000', N'300', N'Paid')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (7, N'CHM-Ka-778654', N'30/04/2015', N'Moymonsing', N'4500', N'2000', N'2500', N'250', N'Due')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (8, N'DHM-Ka-123423', N'20/05/2025', N'Pabna', N'7000', N'4000', N'3000', N'300', N'Due')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (9, N'DHM-Ka-123423', N'20/05/2015', N'Airprot', N'2500', N'1500', N'1000', N'100', N'Due')
INSERT [dbo].[t_rental_information] ([id], [reg_no], [rent_date], [destination], [total_cost], [cost], [profit], [commission], [payment_status]) VALUES (1007, N'DHM-Ka-123423', N'06 May 2015', N'faridpur', N'2000', N'500', N'1500', N'150', N'Due')
SET IDENTITY_INSERT [dbo].[t_rental_information] OFF
SET IDENTITY_INSERT [dbo].[t_vehicle_information] ON 

INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (8, N'DHM-Ka-123423', N'Kyum', 10, N'Korim', N'Noah', N'Active')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (9, N'DHM-Cha-132054', N'Md.Jashim Uddin', 10, N'Kader', N'Noah-2004', N'Quiet')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (10, N'DHM-Ta-112304', N'Musfiqur Rahman', 10, N'Arjun', N'Toyota-2006', N'Active')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (11, N'DHM-Cha', N'Md. Kader', 10, N'Abdul', N'Noah-2006', N'Quiet')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (12, N'DHM-Cha-234564', N'Rahim', 12, N'Kader', N'Noah', N'Quiet')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (13, N'CHM-Ka-778654', N'Abdullah', 10, N'Zakir', N'Haige', N'Active')
INSERT [dbo].[t_vehicle_information] ([id], [reg_no], [owner_name], [deal_percent], [driver_name], [vehicle_model], [status]) VALUES (14, N'DHM-Ka 263423', N'Abdur Rhman', 12, N'Rayhan', N'Noah-2006', N'Quiet')
SET IDENTITY_INSERT [dbo].[t_vehicle_information] OFF
ALTER TABLE [dbo].[t_billing_information]  WITH CHECK ADD  CONSTRAINT [FK_t_billing_information_t_booking_details] FOREIGN KEY([booking_id])
REFERENCES [dbo].[t_booking_details] ([id])
GO
ALTER TABLE [dbo].[t_billing_information] CHECK CONSTRAINT [FK_t_billing_information_t_booking_details]
GO
ALTER TABLE [dbo].[t_billing_information]  WITH CHECK ADD  CONSTRAINT [FK_t_billing_information_t_customer_information] FOREIGN KEY([customer_id])
REFERENCES [dbo].[t_customer_information] ([id])
GO
ALTER TABLE [dbo].[t_billing_information] CHECK CONSTRAINT [FK_t_billing_information_t_customer_information]
GO
ALTER TABLE [dbo].[t_booking_details]  WITH CHECK ADD  CONSTRAINT [FK_t_booking_details_t_vehicle_information] FOREIGN KEY([vehicle_id])
REFERENCES [dbo].[t_vehicle_information] ([id])
GO
ALTER TABLE [dbo].[t_booking_details] CHECK CONSTRAINT [FK_t_booking_details_t_vehicle_information]
GO
USE [master]
GO
ALTER DATABASE [Car_Rental_SystemDB] SET  READ_WRITE 
GO
