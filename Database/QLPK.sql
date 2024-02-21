
/****** Object:  Database [QLPhongKham]    Script Date: 15/07/2017 9:57:17 SA ******/
CREATE DATABASE [QLPhongKham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPhongKham', FILENAME = N'D:\CODE\HKTet_Year4\PTPM_UngDung\Project\Database\QLPhongKham.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLPhongKham_log', FILENAME = N'D:\CODE\HKTet_Year4\PTPM_UngDung\Project\Database\QLPhongKham_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLPhongKham] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPhongKham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPhongKham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPhongKham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPhongKham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPhongKham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPhongKham] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPhongKham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLPhongKham] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLPhongKham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPhongKham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPhongKham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPhongKham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPhongKham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPhongKham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPhongKham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPhongKham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPhongKham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLPhongKham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPhongKham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPhongKham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPhongKham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPhongKham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPhongKham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPhongKham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPhongKham] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLPhongKham] SET  MULTI_USER 
GO
ALTER DATABASE [QLPhongKham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPhongKham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPhongKham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPhongKham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLPhongKham]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [char](5) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaHD] [char](5) NOT NULL,
	[MaToa] [char](5) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ID_CTTT] [char](5) NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaToa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietToaThuoc]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietToaThuoc](
	[MaToa] [char](5) NOT NULL,
	[MaThuoc] [char](5) NOT NULL,
	[SoLuong] [nvarchar](50) NULL,
	[CachDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietToaThuoc] PRIMARY KEY CLUSTERED 
(
	[MaToa] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonThuoc]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonThuoc](
	[MaHD] [char](5) NOT NULL,
	[MaToa] [char](5) NULL,
	[NgayBan] [date] NULL,
	[TienThuoc] [int] NULL,
 CONSTRAINT [PK_HoaDonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuKham](
	[MaPK] [char](5) NOT NULL,
	[MaBN] [char](5) NULL,
	[NgayKham] [date] NULL,
	[STT] [int] NULL,
	[TrieuChung] [nvarchar](50) NULL,
	[ChuanDoan] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuKham] PRIMARY KEY CLUSTERED 
(
	[MaPK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ToaThuoc]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ToaThuoc](
	[MaToa] [char](5) NOT NULL,
	[MaPK] [char](5) NULL,
	[BacSiKeToa] [nvarchar](50) NULL,
	[NgayKeToa] [date] NULL,
 CONSTRAINT [PK_ToaThuoc] PRIMARY KEY CLUSTERED 
(
	[MaToa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 15/07/2017 9:57:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [char](5) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[NSX] [date] NULL,
	[HSD] [date] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'bn1  ', N' Lê Hoàng Phúc', N'Nam', CAST(0x611E0B00 AS Date), N'Nha Trang', N'01868825482    ')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'bn2  ', N'Lê Hoàng Ngọc Ấn', N'Nam', CAST(0xF41E0B00 AS Date), N'Khánh Hòa', N'01668118011    ')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'bn3  ', N'Lê Trịnh Thiên Thạch', N'Nam', CAST(0xCE1E0B00 AS Date), N'Lâm Đồng', N'0905052054     ')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'bn4  ', N'Phạm Thị Thảo Ly', N'Nữ', CAST(0x041F0B00 AS Date), N'Nha Trang', N'0923469423     ')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'bn5  ', N'Đặng Minh Châu', N'Nữ', CAST(0xFA3C0B00 AS Date), N'Mỹ Tho', N'9876543210     ')
INSERT [dbo].[ChiTietToaThuoc] ([MaToa], [MaThuoc], [SoLuong], [CachDung]) VALUES (N'tt1  ', N'th1  ', N'10', N'Uống')
INSERT [dbo].[ChiTietToaThuoc] ([MaToa], [MaThuoc], [SoLuong], [CachDung]) VALUES (N'tt2  ', N'th2  ', N'1', N'bôi ngoài da')
INSERT [dbo].[ChiTietToaThuoc] ([MaToa], [MaThuoc], [SoLuong], [CachDung]) VALUES (N'tt3  ', N'th4  ', N'5', N'hòa tan với nước')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk1  ', N'bn5  ', CAST(0xFA3C0B00 AS Date), 1, N'đau bụng', N'ngộ độc thức ăn')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk2  ', N'bn4  ', CAST(0xFA3C0B00 AS Date), 2, N'nóng lạnh trong người', N'cảm cúm')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk3  ', N'bn2  ', CAST(0xFA3C0B00 AS Date), 3, N'khớp ngón tay khó cử động', N'viêm khớp')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk4  ', N'bn5  ', CAST(0xFA3C0B00 AS Date), 4, N'abc', N'xvz')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk5  ', N'bn1  ', CAST(0xFA3C0B00 AS Date), 5, N'abc', N'abc')
INSERT [dbo].[PhieuKham] ([MaPK], [MaBN], [NgayKham], [STT], [TrieuChung], [ChuanDoan]) VALUES (N'pk6  ', N'bn3  ', CAST(0xFB3C0B00 AS Date), 1, N'abc', N'abc')
INSERT [dbo].[ToaThuoc] ([MaToa], [MaPK], [BacSiKeToa], [NgayKeToa]) VALUES (N'tt1  ', N'pk1  ', N'Lưu Diệp Phi', CAST(0x193D0B00 AS Date))
INSERT [dbo].[ToaThuoc] ([MaToa], [MaPK], [BacSiKeToa], [NgayKeToa]) VALUES (N'tt2  ', N'pk2  ', N'Hồng Kim Bảo', CAST(0xFB3C0B00 AS Date))
INSERT [dbo].[ToaThuoc] ([MaToa], [MaPK], [BacSiKeToa], [NgayKeToa]) VALUES (N'tt3  ', N'pk4  ', N'ntx', CAST(0xFB3C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NSX], [HSD]) VALUES (N'th1  ', N'Tetracycline', N'viên nang', 5000, CAST(0x193D0B00 AS Date), CAST(0x573D0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NSX], [HSD]) VALUES (N'th2  ', N'Metrogyl Denta', N'gel', 50000, CAST(0x193D0B00 AS Date), CAST(0x193D0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NSX], [HSD]) VALUES (N'th3  ', N'Timolol', N'dung dịch', 15000, CAST(0xFB3C0B00 AS Date), CAST(0x0C3E0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NSX], [HSD]) VALUES (N'th4  ', N'aspirin', N'viên sủi', 5000, CAST(0xFB3C0B00 AS Date), CAST(0x893E0B00 AS Date))
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDonThuoc] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonThuoc] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HoaDonThuoc]
GO
ALTER TABLE [dbo].[ChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietToaThuoc_ToaThuoc] FOREIGN KEY([MaToa])
REFERENCES [dbo].[ToaThuoc] ([MaToa])
GO
ALTER TABLE [dbo].[ChiTietToaThuoc] CHECK CONSTRAINT [FK_ChiTietToaThuoc_ToaThuoc]
GO
ALTER TABLE [dbo].[ChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietToaThuoc_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietToaThuoc] CHECK CONSTRAINT [FK_ChiTietToaThuoc_Thuoc]
GO
ALTER TABLE [dbo].[HoaDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonThuoc_ToaThuoc] FOREIGN KEY([MaToa])
REFERENCES [dbo].[ToaThuoc] ([MaToa])
GO
ALTER TABLE [dbo].[HoaDonThuoc] CHECK CONSTRAINT [FK_HoaDonThuoc_ToaThuoc]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_BenhNhan]
GO
ALTER TABLE [dbo].[ToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ToaThuoc_PhieuKham] FOREIGN KEY([MaPK])
REFERENCES [dbo].[PhieuKham] ([MaPK])
GO
ALTER TABLE [dbo].[ToaThuoc] CHECK CONSTRAINT [FK_ToaThuoc_PhieuKham]
GO
USE [master]
GO
ALTER DATABASE [QLPhongKham] SET  READ_WRITE 
GO