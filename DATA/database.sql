USE [master]
GO
/****** Object:  Database [HCG]    Script Date: 21/08/2021 9:17:41 CH ******/
CREATE DATABASE [HCG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HCG', FILENAME = N'E:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HCG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HCG_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HCG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HCG] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HCG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HCG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HCG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HCG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HCG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HCG] SET ARITHABORT OFF 
GO
ALTER DATABASE [HCG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HCG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HCG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HCG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HCG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HCG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HCG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HCG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HCG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HCG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HCG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HCG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HCG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HCG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HCG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HCG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HCG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HCG] SET RECOVERY FULL 
GO
ALTER DATABASE [HCG] SET  MULTI_USER 
GO
ALTER DATABASE [HCG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HCG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HCG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HCG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HCG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HCG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HCG', N'ON'
GO
ALTER DATABASE [HCG] SET QUERY_STORE = OFF
GO
USE [HCG]
GO
/****** Object:  Table [dbo].[tbl_eresult]    Script Date: 21/08/2021 9:17:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_eresult](
	[rid] [int] IDENTITY(1,1) NOT NULL,
	[rname] [nvarchar](100) NULL,
	[rinfo] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[rid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_event]    Script Date: 21/08/2021 9:17:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_event](
	[eid] [int] IDENTITY(1,1) NOT NULL,
	[ename] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_rule]    Script Date: 21/08/2021 9:17:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rule](
	[ruleid] [int] IDENTITY(1,1) NOT NULL,
	[ruleleft] [varchar](100) NULL,
	[ruleright] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ruleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_eresult] ON 

INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (1, N'Thủy đậu', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (2, N'Nấm da đầu', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (3, N'Lang ben', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (4, N'Bạch Biến', N'                                                                                                    ')
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (5, N'Mụn trứng cá', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (6, N'Hắc lào', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (7, N'Ghẻ', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (8, N'Nổi mề đay', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (9, N'Vảy nến', NULL)
INSERT [dbo].[tbl_eresult] ([rid], [rname], [rinfo]) VALUES (10, N'Ghẻ nước', NULL)
SET IDENTITY_INSERT [dbo].[tbl_eresult] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_event] ON 

INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (1, N'Da đầu ngứa')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (2, N'Mặt có đốm, mảng màu trắng')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (3, N'Tay chân có mụn nước')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (4, N'Da đầu có mụn nước')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (5, N'Da đầu có vết loét, mảng tròn')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (6, N'Ngứa khi ra nắng, đổ mồ hôi')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (7, N'Long trên vùng da màu trắng')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (8, N'Nổi mụn đầu đen hoặc trắng')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (9, N'Mụn nước tập trung ở rìa như đồng tiền')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (10, N'Có xuất hiện các luống ghẻ')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (11, N'Sốt nhẹ phát ban')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (12, N'Nổi đám mụn hồng hoặc xanh')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (13, N'Tay chân có đốm mảng màu trắng')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (14, N'Xuất hiện vảy màu trắng')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (15, N'Bề mặt có vảy mịn, cạo ra như phấn')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (16, N'Bề mặt trơn láng, không sung')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (17, N'Có mủ kèm theo nốt sần')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (18, N'Ngứa, nổi mẩn đỏ')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (19, N'Nhiễm trùng và ngứa')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (20, N'Mụn bị lở ra và có vảy')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (21, N'Tụ lại thành mảng và ngứa')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (22, N'Vùng bị bệnh thường nông')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (23, N'Có mùi lạ')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (24, N'Có các mụn mủ')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (25, N'Lớp vảy thường xám, dày và hay vỡ vụn ra khi chạm vào')
INSERT [dbo].[tbl_event] ([eid], [ename]) VALUES (26, N'Gặp ở lưng, ngực, cổ')
SET IDENTITY_INSERT [dbo].[tbl_event] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_rule] ON 

INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (1, N'e1^e4^e11^e20', N'r1')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (2, N'e1^e5^e14^e23', N'r2')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (4, N'e26^e7^e16', N'r4')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (5, N'e26^e8^e17', N'r5')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (6, N'e3^e9^e18', N'r6')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (7, N'e10^e19', N'r7')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (8, N'e25^e11^e20', N'r1')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (9, N'e3^e12^e21', N'r8')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (10, N'e3^e6^e13^e15', N'r3')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (11, N'e7^e13^e16', N'r4')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (12, N'e14^e22^e24', N'r9')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (13, N'e3^e10', N'e25')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (16, N'e2^e6', N'e26')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (17, N'e25', N'r10')
INSERT [dbo].[tbl_rule] ([ruleid], [ruleleft], [ruleright]) VALUES (18, N'e26', N'r3')
SET IDENTITY_INSERT [dbo].[tbl_rule] OFF
GO
USE [master]
GO
ALTER DATABASE [HCG] SET  READ_WRITE 
GO
