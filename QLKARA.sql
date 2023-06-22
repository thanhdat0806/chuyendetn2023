create database [DB_QLKaraoke]
dROP DATABASE [DB_QLKaraoke]
USE [DB_QLKaraoke]
GO
/****** Object:  Trigger [trigTinhTien]     ******/
DROP TRIGGER [dbo].[trigTinhTien]
GO
/****** Object:  Trigger [trg_NhapHang]     ******/
DROP TRIGGER [dbo].[trg_NhapHang]
GO
/****** Object:  Trigger [trg_Oder]     ******/
DROP TRIGGER [dbo].[trg_Oder]
GO
/****** Object:  Trigger [trg_CapNhatODER]     ******/
DROP TRIGGER [dbo].[trg_CapNhatODER]
GO
/****** Object:  Trigger [tongtiendv]     ******/
DROP TRIGGER [dbo].[tongtiendv]
GO
ALTER TABLE [dbo].[THUEPHONG] DROP CONSTRAINT [FK_TP_PHONGHAT]
GO
ALTER TABLE [dbo].[THUEPHONG] DROP CONSTRAINT [FK_TP_KHACHHANG]
GO
ALTER TABLE [dbo].[ThongKe] DROP CONSTRAINT [FK_ThongKe_NHANVIEN]
GO
ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FK_PhieuNhap_NHANVIEN]
GO
ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HOADON] DROP CONSTRAINT [FK_HD_THUEPHONG]
GO
ALTER TABLE [dbo].[ChiTietNhap] DROP CONSTRAINT [FK_ChiTietNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietNhap] DROP CONSTRAINT [FK_ChiTietNhap_DICHVU]
GO
ALTER TABLE [dbo].[CHITIETDICHVU] DROP CONSTRAINT [FK_DV_CTDV]
GO
ALTER TABLE [dbo].[CHITIETDICHVU] DROP CONSTRAINT [FK_CTDV_TP]
GO
/****** Object:  View [dbo].[View_Test]   ******/
DROP VIEW [dbo].[View_Test]
GO
/****** Object:  UserDefinedFunction [dbo].[View_DS_DichVu]   ******/
DROP FUNCTION [dbo].[View_DS_DichVu]
GO
/****** Object:  Table [dbo].[THUEPHONG]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[THUEPHONG]') AND type in (N'U'))
DROP TABLE [dbo].[THUEPHONG]
GO
/****** Object:  Table [dbo].[ThongKe]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongKe]') AND type in (N'U'))
DROP TABLE [dbo].[ThongKe]
GO
/****** Object:  Table [dbo].[PHONGHAT]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PHONGHAT]') AND type in (N'U'))
DROP TABLE [dbo].[PHONGHAT]
GO
/****** Object:  Table [dbo].[PhieuNhap]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhap]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhap]
GO
/****** Object:  Table [dbo].[NHANVIEN]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHANVIEN]') AND type in (N'U'))
DROP TABLE [dbo].[NHANVIEN]
GO
/****** Object:  Table [dbo].[NhaCungCap]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhaCungCap]') AND type in (N'U'))
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[KHACHHANG]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KHACHHANG]') AND type in (N'U'))
DROP TABLE [dbo].[KHACHHANG]
GO
/****** Object:  Table [dbo].[HOADON]    ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADON]') AND type in (N'U'))
DROP TABLE [dbo].[HOADON]
GO
/****** Object:  Table [dbo].[DICHVU]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DICHVU]') AND type in (N'U'))
DROP TABLE [dbo].[DICHVU]
GO
/****** Object:  Table [dbo].[ChiTietNhap]     ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietNhap]') AND type in (N'U'))
DROP TABLE [dbo].[ChiTietNhap]
GO
/****** Object:  Table [dbo].[CHITIETDICHVU]    ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CHITIETDICHVU]') AND type in (N'U'))
DROP TABLE [dbo].[CHITIETDICHVU]
GO
/****** Object:  Table [dbo].[CHITIETDICHVU]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDICHVU](
	[MaDV] [varchar](15) NOT NULL,
	[MaTP] [varchar](45) NOT NULL,
	[MaPH] [varchar](45) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[Note] [nvarchar](45) NULL,
 CONSTRAINT [PK_CHITIET] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC,
	[MaTP] ASC,
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhap]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[MaPhieuNhap] [varchar](15) NOT NULL,
	[MaDV] [varchar](15) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [varchar](15) NOT NULL,
	[TenDV] [nvarchar](45) NULL,
	[DonGia] [float] NULL,
	[DonViTinh] [nvarchar](45) NULL,
	[SLTon] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](45) NOT NULL,
	[MaTP] [varchar](45) NOT NULL,
	[MaPH] [varchar](45) NOT NULL,
	[TinhTrang] [nvarchar](45) NULL,
	[TongTien] [float] NULL,
	[MaNV] [varchar](15) NULL,
	[TGThanhToan] [date] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[SDT_KH] [int] NOT NULL,
	[TenKH] [nvarchar](45) NULL,
	[LoaiKH] [varchar](15) NULL,
	[DiaChi] [nvarchar](45) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[SDT_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](15) NOT NULL,
	[TenNCC] [nvarchar](45) NULL,
	[DiaChi] [nvarchar](45) NULL,
	[SDT] [nvarchar](45) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](15) NOT NULL,
	[Pass] [varchar](15) NOT NULL,
	[TenNV] [nvarchar](45) NULL,
	[DiaChi] [nvarchar](45) NULL,
	[SDT] [nvarchar](45) NULL,
	[ChucVu] [nvarchar](45) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](15) NOT NULL,
	[MaNV] [varchar](15) NOT NULL,
	[MaNCC] [varchar](15) NOT NULL,
	[ThanhTien] [float] NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_PhieuNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGHAT]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGHAT](
	[MaPH] [varchar](45) NOT NULL,
	[TenPH] [nvarchar](45) NULL,
	[GiaCaoDiem] [float] NULL,
	[GiaBinhThuong] [float] NULL,
	[TinhTrang] [nvarchar](45) NULL,
 CONSTRAINT [PK_PHONGHAT] PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongKe]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKe](
	[MaNV] [varchar](15) NOT NULL,
	[MaThongKe] [varchar](15) NOT NULL,
	[NgayLap] [datetime] NULL,
	[DanhThu] [float] NULL,
 CONSTRAINT [PK_ThongKe] PRIMARY KEY CLUSTERED 
(
	[MaThongKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUEPHONG]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUEPHONG](
	[MaTP] [varchar](45) NOT NULL,
	[MaPH] [varchar](45) NOT NULL,
	[MaNV] [varchar](15) NOT NULL,
	[SDT_KH] [int] NOT NULL,
	[GioVao] [time](7) NULL,
	[GioRa] [time](7) NULL,
	[TinhTrang] [nvarchar](45) NULL,
	[NgayVao] [date] NULL,
 CONSTRAINT [PK_THUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaTP] ASC,
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_1', N'Coca', 20, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_10', N'Bia Tiger', 35, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_2', N'Bí đao', 20, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_3', N'Bia Heineken', 40, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_4', N'Nước Cam', 20, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_5', N'Nước Lọc', 15, N'Chai', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_6', N'Pepsi', 20, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_7', N'RedBull', 20, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_8', N'Bia Sài Gòn', 30, N'Lon', 100)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DonGia], [DonViTinh], [SLTon]) VALUES (N'DV_9', N'Sting', 20, N'Lon', 100)
GO
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (1, N'1', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (3, N'3', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (4, N'4', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (11, N'1', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (12, N'2', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (44, N'1', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (3123, N'33333333', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (33123, N'1', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (33213, N'dinh cao', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (468486, N'Nguyễn Thành Đạt', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (999464, N'Lê Trung Vĩnh', N'0', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (1318788, N'Trần Đình Tuyển', N'1', NULL)
INSERT [dbo].[KHACHHANG] ([SDT_KH], [TenKH], [LoaiKH], [DiaChi]) VALUES (84791804, N'Võ Văn Tú', N'1', NULL)
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC_1', N'Nha Cung Cap Bia', N'Tầng trệt, 354 Bạch Mai', N'1221321237')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC_2', N'Nha Cung Cap Nuoc Ngot', N'57 Hai Bà Trưng, Q, Hoàn Kiếm', N'7851458545')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC_3', N'Nha Cung Cap Do An', N'36 Lương Ngọc Quyến, Q. Hoàn Kiếm', N'2131231231')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [Pass], [TenNV], [DiaChi], [SDT],[ChucVu]) VALUES (N'NV_1', N'1', N'Nguyen Thanh Dat', N'asdasda', N'1',N'1')
INSERT [dbo].[NHANVIEN] ([MaNV], [Pass], [TenNV], [DiaChi], [SDT],[ChucVu]) VALUES (N'NV_2', N'1', N'Tran Dinh Tuyen', N'asda', N'2',N'2')
INSERT [dbo].[NHANVIEN] ([MaNV], [Pass], [TenNV], [DiaChi], [SDT],[ChucVu]) VALUES (N'NV_3', N'1', N'Le Trung Vinh', N'asdsad', N'3',N'2')
INSERT [dbo].[NHANVIEN] ([MaNV], [Pass], [TenNV], [DiaChi], [SDT],[ChucVu]) VALUES (N'NV_4', N'1', N'Ta Nguyen Phong Thai', N'asdsad', N'4',N'3')
GO
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_1', N'Phòng 01_Vip', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_10', N'Phòng 10_Vip', 500, 400, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_2', N'Phòng 02', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_3', N'Phòng 03', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_4', N'Phòng 04', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_5', N'Phòng 05', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_6', N'Phòng 06', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_7', N'Phòng 07', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_8', N'Phòng 08', 300, 250, N'Phòng Trống')
INSERT [dbo].[PHONGHAT] ([MaPH], [TenPH], [GiaCaoDiem], [GiaBinhThuong], [TinhTrang]) VALUES (N'PH_9', N'Phòng 09', 500, 400, N'Phòng Trống')
GO
/****** Object:  UserDefinedFunction [dbo].[View_DS_DichVu]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[View_DS_DichVu]
(	
	@minday nvarchar(15),@maxday nvarchar(15)
)
RETURNS TABLE
AS
RETURN
(
	select DICHVU.TenDV,CHITIETDICHVU.MaDV,SUM(CHITIETDICHVU.ThanhTien)as tongtien,SUM(CHITIETDICHVU.SoLuong) as sl
	from CHITIETDICHVU,THUEPHONG,DICHVU
	where CHITIETDICHVU.MaTP = THUEPHONG.MaTP
	and CHITIETDICHVU.MaPH = THUEPHONG.MaPH
	and DICHVU.MaDV =  CHITIETDICHVU.MaDV
	and THUEPHONG.NgayVao <= @maxday
	and THUEPHONG.NgayVao >= @minday
	group by DICHVU.TenDV,CHITIETDICHVU.MaDV
)
GO
/****** Object:  View [dbo].[View_Test]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Test] AS

	select KHACHHANG.TenKH,PHONGHAT.TenPH,DICHVU.TenDV,CHITIETDICHVU.DonGia,CHITIETDICHVU.SoLuong,CHITIETDICHVU.ThanhTien
	from THUEPHONG,KHACHHANG,PHONGHAT,CHITIETDICHVU,DICHVU
	where THUEPHONG.SDT_KH = KHACHHANG.SDT_KH 
	and PHONGHAT.MaPH = THUEPHONG.MaPH 
	and CHITIETDICHVU.MaPH = THUEPHONG.MaPH
	and DICHVU.MaDV= CHITIETDICHVU.MaDV
GO
ALTER TABLE [dbo].[CHITIETDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CTDV_TP] FOREIGN KEY([MaTP], [MaPH])
REFERENCES [dbo].[THUEPHONG] ([MaTP], [MaPH])
GO
ALTER TABLE [dbo].[CHITIETDICHVU] CHECK CONSTRAINT [FK_CTDV_TP]
GO
ALTER TABLE [dbo].[CHITIETDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_DV_CTDV] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[CHITIETDICHVU] CHECK CONSTRAINT [FK_DV_CTDV]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_DICHVU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_DICHVU]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_THUEPHONG] FOREIGN KEY([MaTP], [MaPH])
REFERENCES [dbo].[THUEPHONG] ([MaTP], [MaPH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_THUEPHONG]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NHANVIEN]
GO
ALTER TABLE [dbo].[ThongKe]  WITH CHECK ADD  CONSTRAINT [FK_ThongKe_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[ThongKe] CHECK CONSTRAINT [FK_ThongKe_NHANVIEN]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_TP_KHACHHANG] FOREIGN KEY([SDT_KH])
REFERENCES [dbo].[KHACHHANG] ([SDT_KH])
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_TP_KHACHHANG]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_TP_PHONGHAT] FOREIGN KEY([MaPH])
REFERENCES [dbo].[PHONGHAT] ([MaPH])
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_TP_PHONGHAT]
GO
/****** Object:  Trigger [dbo].[tongtiendv]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger  [dbo].[tongtiendv]
    on [dbo].[CHITIETDICHVU]
    for insert, update
    as
    if update(soluong)
    begin
    	update 
    		ChiTietDichVu
    	set 
    		thanhtien = I.SoLuong * CTHD.DonGia
    	from 
    		inserted I,
    		ChiTietDichVu CTHD
    	where 
    		(CTHD.MaDV = I.MaDV)	
			and     		(CTHD.MaTP = I.MaTP)	
			   and 		(CTHD.MaPH = I.MaPH)	


    end
GO
ALTER TABLE [dbo].[CHITIETDICHVU] ENABLE TRIGGER [tongtiendv]
GO
/****** Object:  Trigger [dbo].[trg_CapNhatODER]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trg_CapNhatODER] on [dbo].[CHITIETDICHVU] after update AS
BEGIN
   UPDATE DICHVU SET SLTon = SLTon -
	   (SELECT SoLuong FROM inserted WHERE MaDV = DICHVU.MaDV) +
	   (SELECT SoLuong FROM deleted WHERE MaDV = DICHVU.MaDV)
   FROM DICHVU 
   JOIN deleted ON DICHVU.MaDV = deleted.MaDV
end

GO
ALTER TABLE [dbo].[CHITIETDICHVU] ENABLE TRIGGER [trg_CapNhatODER]
GO
/****** Object:  Trigger [dbo].[trg_Oder]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trg_Oder] ON [dbo].[CHITIETDICHVU] AFTER INSERT AS 
BEGIN
	UPDATE DICHVU
	SET SLTon = SLTon - (
		SELECT SoLuong
		FROM inserted
		WHERE MaDV = DICHVU.MaDV
	)
	FROM DICHVU
	JOIN inserted ON DICHVU.MaDV = inserted.MaDV
END

GO
ALTER TABLE [dbo].[CHITIETDICHVU] ENABLE TRIGGER [trg_Oder]
GO
/****** Object:  Trigger [dbo].[trg_NhapHang]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trg_NhapHang] ON [dbo].[ChiTietNhap] AFTER INSERT AS 
BEGIN
	UPDATE DICHVU
	SET SLTon = SLTon + (
		SELECT SoLuong
		FROM inserted
		WHERE MaDV = DICHVU.MaDV
	)
	FROM DICHVU
	JOIN inserted ON DICHVU.MaDV = inserted.MaDV
END

GO
ALTER TABLE [dbo].[ChiTietNhap] ENABLE TRIGGER [trg_NhapHang]
GO
/****** Object:  Trigger [dbo].[trigTinhTien]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trigTinhTien] on [dbo].[ChiTietNhap]
after insert,update 
as
	update chitietnhap set ThanhTien=c.SoLuong*c.DonGia from inserted i,chitietnhap c where c.MaDV=i.MaDV 

GO
ALTER TABLE [dbo].[ChiTietNhap] ENABLE TRIGGER [trigTinhTien]
GO