USE [QuanLyKyTucXa]
GO
/****** Object:  Table [dbo].[Day]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Day](
	[maday] [nchar](10) NOT NULL,
	[tenday] [nvarchar](50) NULL,
	[quanly] [nvarchar](50) NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED 
(
	[maday] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[makyluat] [int] IDENTITY(1,1) NOT NULL,
	[masv] [nchar](10) NULL,
	[kyluat] [nvarchar](50) NULL,
	[ngaykyluat] [date] NULL,
	[tienphat] [money] NULL,
 CONSTRAINT [PK_KyLuat] PRIMARY KEY CLUSTERED 
(
	[makyluat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[manguoidung] [int] IDENTITY(1,1) NOT NULL,
	[manv] [nchar](10) NULL,
	[tendangnhap] [nchar](30) NULL,
	[matkhau] [nchar](25) NULL,
	[quyen] [nchar](10) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[manguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[manv] [nchar](10) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [nchar](15) NULL,
	[hesoluong] [float] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[maphong] [nchar](10) NOT NULL,
	[tenphong] [nvarchar](50) NULL,
	[sosv] [int] NULL,
	[sosvtoida] [int] NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[loaiphong] [nvarchar](50) NULL,
	[xeploai] [nvarchar](50) NULL,
	[day] [nchar](10) NULL,
	[chisocu] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[masv] [nchar](10) NOT NULL,
	[tensv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[quequan] [nvarchar](50) NULL,
	[khoa] [nchar](10) NULL,
	[lop] [nvarchar](50) NULL,
	[maphong] [nchar](10) NULL,
	[loaiuutien] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVienDangKy]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVienDangKy](
	[masvdky] [nchar](10) NOT NULL,
	[tensv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[quequan] [nvarchar](50) NULL,
	[khoa] [nchar](10) NULL,
	[lop] [nvarchar](50) NULL,
	[maphong] [nchar](10) NULL,
	[loaiuutien] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVienDangKy] PRIMARY KEY CLUSTERED 
(
	[masvdky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[maphong] [nchar](10) NOT NULL,
	[tenthietbi] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[tinhtrang] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TienDien]    Script Date: 6/9/2021 9:53:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienDien](
	[mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[maphong] [nchar](10) NULL,
	[ngaylap] [date] NULL,
	[sodientieuthu] [int] NULL,
	[tongtien] [money] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TienDien] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Day] ([maday], [tenday], [quanly], [trangthai]) VALUES (N'd1        ', N'Dãy 1', N'Thái Long', N'Bình thường')
INSERT [dbo].[Day] ([maday], [tenday], [quanly], [trangthai]) VALUES (N'd2        ', N'Dãy 2', N'Thái Long', N'Bình thường')
GO
SET IDENTITY_INSERT [dbo].[KyLuat] ON 

INSERT [dbo].[KyLuat] ([makyluat], [masv], [kyluat], [ngaykyluat], [tienphat]) VALUES (1, N'sv01      ', N'Dập cầu dao ký túc xá', CAST(N'2021-06-01' AS Date), 100000.0000)
INSERT [dbo].[KyLuat] ([makyluat], [masv], [kyluat], [ngaykyluat], [tienphat]) VALUES (2, N'sv02      ', N'Đánh nhau', CAST(N'2021-05-31' AS Date), 50000.0000)
SET IDENTITY_INSERT [dbo].[KyLuat] OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([manguoidung], [manv], [tendangnhap], [matkhau], [quyen]) VALUES (1, N'nv01      ', N'admin                         ', N'admin                    ', N'Admin     ')
INSERT [dbo].[NguoiDung] ([manguoidung], [manv], [tendangnhap], [matkhau], [quyen]) VALUES (2, N'nv02      ', N'long                          ', N'long                     ', N'User      ')
INSERT [dbo].[NguoiDung] ([manguoidung], [manv], [tendangnhap], [matkhau], [quyen]) VALUES (3, N'nv01      ', N'Admin                         ', N'123                      ', N'Admin     ')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
INSERT [dbo].[NhanVien] ([manv], [tennv], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [hesoluong]) VALUES (N'nv01      ', N'Phạm Hiếu', N'Nam', CAST(N'2000-05-16' AS Date), N'Hà Nội', N'091131213      ', 101)
INSERT [dbo].[NhanVien] ([manv], [tennv], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [hesoluong]) VALUES (N'nv02      ', N'Thái Long', N'Nam', CAST(N'2001-05-18' AS Date), N'Hải Phòng', N'09122134       ', 56)
INSERT [dbo].[NhanVien] ([manv], [tennv], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [hesoluong]) VALUES (N'nv03      ', N'Huyền Thanh', N'Nữ', CAST(N'2001-02-07' AS Date), N'Bắc Ninh', N'091221343      ', 55)
INSERT [dbo].[NhanVien] ([manv], [tennv], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [hesoluong]) VALUES (N'nv04      ', N'Lê Độ', N'Nam', CAST(N'2000-06-07' AS Date), N'Thanh Hóa', N'091221345      ', 100)
GO
INSERT [dbo].[Phong] ([maphong], [tenphong], [sosv], [sosvtoida], [tinhtrang], [loaiphong], [xeploai], [day], [chisocu]) VALUES (N'p101      ', N'Phòng 101', 4, 5, N'Thiếu', N'Nam', N'Thường', N'd1        ', 20)
INSERT [dbo].[Phong] ([maphong], [tenphong], [sosv], [sosvtoida], [tinhtrang], [loaiphong], [xeploai], [day], [chisocu]) VALUES (N'p102      ', N'Phòng 102', 3, 3, N'Đủ', N'Nam', N'Vip', N'd1        ', 15)
INSERT [dbo].[Phong] ([maphong], [tenphong], [sosv], [sosvtoida], [tinhtrang], [loaiphong], [xeploai], [day], [chisocu]) VALUES (N'p103      ', N'Phòng 103', 3, 5, N'Thiếu', N'Nữ', N'Thường', N'd2        ', 0)
GO
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv01      ', N'Nguyễn Hùng', N'Nam', CAST(N'2021-05-26' AS Date), N'Hà Nội', N'K13       ', N'CNTT1', N'p101      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv02      ', N'Chung An', N'Nam', CAST(N'2000-05-26' AS Date), N'Hải Phòng', N'K11       ', N'CNTT2', N'p101      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv03      ', N'Trung Anh', N'Nam', CAST(N'2000-07-03' AS Date), N'Nam Định', N'K12       ', N'CNTT3', N'p102      ', N'Gia đình thương binh liệt sĩ')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv04      ', N'Khánh Ly', N'Nữ', CAST(N'2000-03-14' AS Date), N'Bình Thuận', N'K13       ', N'CNTT4', N'p103      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv05      ', N'Thu Lăng', N'Nữ', CAST(N'2000-03-15' AS Date), N'Bình Dương', N'K13       ', N'CNTT5', N'p103      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv06      ', N'Exodia', N'Nữ', CAST(N'2001-02-14' AS Date), N'Mexico', N'K13       ', N'CNTT6', N'p103      ', N'Du học sinh')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv08      ', N'Phúc Bồ', N'Nam', CAST(N'2000-06-02' AS Date), N'Tây Nguyên', N'K11       ', N'KHMT1', N'p101      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv09      ', N'Minh Quân', N'Nam', CAST(N'2000-06-02' AS Date), N'Hạ Long', N'K10       ', N'CNTT1', N'p101      ', N'Bình thường')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv10      ', N'Lam Hồ', N'Nam', CAST(N'2000-06-02' AS Date), N'Cao Bằng', N'K11       ', N'KHMT2', N'p102      ', N'Du học sinh')
INSERT [dbo].[SinhVien] ([masv], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv12      ', N'Đắc Phương', N'Nam', CAST(N'2000-06-21' AS Date), N'Ninh Bình', N'K12       ', N'KHMT3', N'p102      ', N'Bình thường')
GO
INSERT [dbo].[SinhVienDangKy] ([masvdky], [tensv], [gioitinh], [ngaysinh], [quequan], [khoa], [lop], [maphong], [loaiuutien]) VALUES (N'sv11      ', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', N'K12       ', N'CNTT2', N'p101      ', N'Bình thường')
GO
INSERT [dbo].[ThietBi] ([maphong], [tenthietbi], [soluong], [tinhtrang]) VALUES (N'p101      ', N'Giường', 5, N'')
INSERT [dbo].[ThietBi] ([maphong], [tenthietbi], [soluong], [tinhtrang]) VALUES (N'p101      ', N'Quạt trần', 2, N'')
GO
SET IDENTITY_INSERT [dbo].[TienDien] ON 

INSERT [dbo].[TienDien] ([mahoadon], [maphong], [ngaylap], [sodientieuthu], [tongtien], [trangthai]) VALUES (2, N'p101      ', CAST(N'2021-06-01' AS Date), 10, 30000.0000, N'Chưa thanh toán')
INSERT [dbo].[TienDien] ([mahoadon], [maphong], [ngaylap], [sodientieuthu], [tongtien], [trangthai]) VALUES (3, N'p101      ', CAST(N'2021-06-01' AS Date), 10, 30000.0000, N'Ðã thanh toán')
INSERT [dbo].[TienDien] ([mahoadon], [maphong], [ngaylap], [sodientieuthu], [tongtien], [trangthai]) VALUES (4, N'p102      ', CAST(N'2021-05-01' AS Date), 15, 45000.0000, N'Chưa thanh toán')
SET IDENTITY_INSERT [dbo].[TienDien] OFF
GO
ALTER TABLE [dbo].[KyLuat]  WITH CHECK ADD  CONSTRAINT [FK_KyLuat_SinhVien] FOREIGN KEY([masv])
REFERENCES [dbo].[SinhVien] ([masv])
GO
ALTER TABLE [dbo].[KyLuat] CHECK CONSTRAINT [FK_KyLuat_SinhVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_NhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_Day] FOREIGN KEY([day])
REFERENCES [dbo].[Day] ([maday])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_Day]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[Phong] ([maphong])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Phong]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_Phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[Phong] ([maphong])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_Phong]
GO
ALTER TABLE [dbo].[TienDien]  WITH CHECK ADD  CONSTRAINT [FK_TienDien_Phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[Phong] ([maphong])
GO
ALTER TABLE [dbo].[TienDien] CHECK CONSTRAINT [FK_TienDien_Phong]
GO
