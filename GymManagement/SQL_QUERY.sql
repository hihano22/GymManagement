/***Database name = gym1 ***/
CREATE TABLE [dbo].[TaiKhoan] (
[TenTaiKhoan] NCHAR (24) NOT NULL,
[MatKhau]     NCHAR (24) NOT NULL,
[Email]       NCHAR (26) NOT NULL,
PRIMARY KEY CLUSTERED ([TenTaiKhoan] ASC)
);
/*****************/
CREATE TABLE [dbo].[HOIVIEN](
[MAHOCVIEN] [int] IDENTITY(1,1) NOT NULL,
[TENHOCVIEN] [nvarchar](50) NOT NULL,
[DIACHI] [nvarchar](100) NOT NULL,
[SDT] [int] NOT NULL,
[SONGAYTAP] [int] NOT NULL,
[NGAYDANGKY] [date] NOT NULL,
[NGAYHETHAN] [date] NOT NULL,
[GOITAP] [nvarchar](50) NOT NULL,
[GIOITINH] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
[MASP] [int] IDENTITY(1,1) NOT NULL,
[TEN] [nvarchar](50) NOT NULL,
[LOAI] [nvarchar](50) NOT NULL,
[NGAYNHAP] [date] NOT NULL,
[SOLUONG] [int] NOT NULL,
[DONGIA] [int] NOT NULL,
[TRONGLUONG] [real] NOT NULL,
[HANGSANXUAT] [nvarchar](50) NOT NULL,
[TINHTRANG] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
[MATB] [int] IDENTITY(1,1) NOT NULL,
[TenTB] [nvarchar](50) NOT NULL,
[LoaiTB] [nvarchar](50) NOT NULL,
[NgayNhap] [date] NOT NULL,
[SoLuong] [int] NOT NULL,
[DonGia] [int] NOT NULL,
[TrongLuong] [real] NOT NULL,
[HangSanXuat] [nvarchar](50) NOT NULL,
[TinhTrang] [nvarchar](50) NOT NULL,
[GhiChu] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HOIVIEN] ON

INSERT [dbo].[HOIVIEN] ([MAHOCVIEN], [TENHOCVIEN], [DIACHI], [SDT], [SONGAYTAP], [NGAYDANGKY], [NGAYHETHAN], [GOITAP], [GIOITINH]) VALUES (1, N'Nguyễn Văn Huy', N'Thái Bình', 326654564, 30, CAST(N'2022-11-16' AS Date), CAST(N'2022-12-16' AS Date), N'VIP', N'Nam')
INSERT [dbo].[HOIVIEN] ([MAHOCVIEN], [TENHOCVIEN], [DIACHI], [SDT], [SONGAYTAP], [NGAYDANGKY], [NGAYHETHAN], [GOITAP], [GIOITINH]) VALUES (2, N'Nguyễn Văn Hảo', N'Thái Nguyên', 326654564, 30, CAST(N'2022-11-16' AS Date), CAST(N'2022-12-16' AS Date), N'VIP', N'Nam')
INSERT [dbo].[HOIVIEN] ([MAHOCVIEN], [TENHOCVIEN], [DIACHI], [SDT], [SONGAYTAP], [NGAYDANGKY], [NGAYHETHAN], [GOITAP], [GIOITINH]) VALUES (6, N'Bùi Trung Hiếu', N'Bắc Giang', 326654564, 30, CAST(N'2022-11-16' AS Date), CAST(N'2022-12-16' AS Date), N'Thường', N'Nam')
INSERT [dbo].[HOIVIEN] ([MAHOCVIEN], [TENHOCVIEN], [DIACHI], [SDT], [SONGAYTAP], [NGAYDANGKY], [NGAYHETHAN], [GOITAP], [GIOITINH]) VALUES (7, N'Ninh Khắc Quốc Dũng', N'Nam Định', 326654564, 30, CAST(N'2022-11-16' AS Date), CAST(N'2022-12-16' AS Date), N'Thường', N'Nam')
INSERT [dbo].[HOIVIEN] ([MAHOCVIEN], [TENHOCVIEN], [DIACHI], [SDT], [SONGAYTAP], [NGAYDANGKY], [NGAYHETHAN], [GOITAP], [GIOITINH]) VALUES (8, N'Nguyễn Văn A', N'Hà Nội', 326654564, 30, CAST(N'2022-11-16' AS Date), CAST(N'2022-12-16' AS Date), N'Thường', N'Nam')
SET IDENTITY_INSERT [dbo].[HOIVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] ON

INSERT [dbo].[SANPHAM] ([MASP], [TEN], [LOAI], [NGAYNHAP], [SOLUONG], [DONGIA], [TRONGLUONG], [HANGSANXUAT], [TINHTRANG]) VALUES (2, N'Sữa tăng cơ Levro Iso Whey - 66 lần dùng', N'Whey', CAST(N'2022-11-21' AS Date), 10, 1590, 2, N'Kevin Levrone', N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [TEN], [LOAI], [NGAYNHAP], [SOLUONG], [DONGIA], [TRONGLUONG], [HANGSANXUAT], [TINHTRANG]) VALUES (4, N'Clear Whey Applied Nutrition', N'Whey', CAST(N'2022-11-21' AS Date), 10, 1590, 25, N'APPLIED NUTRITION', N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [TEN], [LOAI], [NGAYNHAP], [SOLUONG], [DONGIA], [TRONGLUONG], [HANGSANXUAT], [TINHTRANG]) VALUES (5, N'Sữa Tăng Cơ ISO 100 - 5lbs', N'Mass', CAST(N'2022-11-21' AS Date), 10, 1590, 2.3, N'DYMATIZE', N'Còn hàng')
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
GO
SET IDENTITY_INSERT [dbo].[ThietBi] ON

INSERT [dbo].[ThietBi] ([MATB], [TenTB], [LoaiTB], [NgayNhap], [SoLuong], [DonGia], [TrongLuong], [HangSanXuat], [TinhTrang], [GhiChu]) VALUES (3, N'Giàn CROSSFIT', N'Máy', CAST(N'2022-11-21' AS Date), 3, 20000, 100, N' công ty TNHH sản xuất cơ khí HOÀNG THỊNH', N'Mới', NULL)
INSERT [dbo].[ThietBi] ([MATB], [TenTB], [LoaiTB], [NgayNhap], [SoLuong], [DonGia], [TrongLuong], [HangSanXuat], [TinhTrang], [GhiChu]) VALUES (4, N'Tạ tay cao su', N'Tạ đơn', CAST(N'2022-11-21' AS Date), 20, 59000, 100, N' công ty TNHH sản xuất cơ khí HOÀNG THỊNH', N'Mới', NULL)
SET IDENTITY_INSERT [dbo].[ThietBi] OFF
GO