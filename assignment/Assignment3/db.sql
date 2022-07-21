USE [FStore]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 7/21/2022 10:59:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 7/21/2022 10:59:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/21/2022 10:59:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/21/2022 10:59:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Members] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'a@gmail.com', N'Company 5', N'City 5', N'Country 5', N'a')
INSERT [dbo].[Members] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'Email 6', N'Company 6', N'City 6', N'Country 6', N'6')
INSERT [dbo].[Members] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (7, N'Email 7', N'Company 7', N'City 7', N'Country 7', N'gggg')
INSERT [dbo].[Members] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (8, N'Email 8', N'Company 8', N'City 8', N'ffsdf', N'8')
INSERT [dbo].[Members] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (9, N'Email 9', N'Company 9', N'City 9', N'Country 9', N'9')
GO
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (6, 15, 60.0000, 6, 7)
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (7, 16, 70.0000, 7, 8)
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (8, 17, 80.0000, 8, 9)
GO
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6, 6, CAST(N'2022-06-30T15:26:06.303' AS DateTime), CAST(N'2022-07-05T15:26:06.303' AS DateTime), CAST(N'2022-07-04T15:26:06.303' AS DateTime), 600.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (7, 7, CAST(N'2022-06-30T15:26:06.303' AS DateTime), CAST(N'2022-07-05T15:26:06.303' AS DateTime), CAST(N'2022-07-04T15:26:06.303' AS DateTime), 700.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (8, 8, CAST(N'2022-06-30T15:26:06.303' AS DateTime), CAST(N'2022-07-05T15:26:06.303' AS DateTime), CAST(N'2022-07-04T15:26:06.303' AS DateTime), 800.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (14, 5, CAST(N'2022-06-30T15:27:27.023' AS DateTime), CAST(N'2022-07-10T15:27:27.023' AS DateTime), CAST(N'2022-07-11T15:27:27.023' AS DateTime), 2800.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (15, 6, CAST(N'2022-06-30T15:27:27.023' AS DateTime), CAST(N'2022-07-10T15:27:27.023' AS DateTime), CAST(N'2022-07-11T15:27:27.023' AS DateTime), 3000.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (16, 7, CAST(N'2022-06-30T15:27:27.023' AS DateTime), CAST(N'2022-07-10T15:27:27.023' AS DateTime), CAST(N'2022-07-11T15:27:27.023' AS DateTime), 3200.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (17, 8, CAST(N'2022-06-30T15:27:27.023' AS DateTime), CAST(N'2022-07-10T15:27:27.023' AS DateTime), CAST(N'2022-07-11T15:27:27.023' AS DateTime), 3400.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (24, 5, CAST(N'2022-06-30T15:28:25.133' AS DateTime), CAST(N'2022-08-30T15:28:25.133' AS DateTime), CAST(N'2022-07-30T15:28:25.133' AS DateTime), 480.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (25, 6, CAST(N'2022-06-30T15:28:25.133' AS DateTime), CAST(N'2022-08-30T15:28:25.133' AS DateTime), CAST(N'2022-07-30T15:28:25.133' AS DateTime), 500.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (26, 7, CAST(N'2022-06-30T15:28:25.133' AS DateTime), CAST(N'2022-08-30T15:28:25.133' AS DateTime), CAST(N'2022-07-30T15:28:25.133' AS DateTime), 520.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (27, 8, CAST(N'2022-06-30T15:28:25.133' AS DateTime), CAST(N'2022-08-30T15:28:25.133' AS DateTime), CAST(N'2022-07-30T15:28:25.133' AS DateTime), 540.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (28, 9, CAST(N'2022-06-30T15:28:25.133' AS DateTime), CAST(N'2022-08-30T15:28:25.133' AS DateTime), CAST(N'2022-07-30T15:28:25.133' AS DateTime), 560.0000)
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (12, 12, N'Product 12', N'10', 120.0000, 7)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (13, 13, N'Product 13', N'11', 130.0000, 8)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (14, 14, N'Product 14', N'12', 140.0000, 9)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (15, 15, N'Product 15', N'13', 150.0000, 10)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (16, 16, N'Product 16', N'14', 160.0000, 11)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (17, 17, N'Product 17', N'15', 170.0000, 12)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (18, 18, N'Product 18', N'16', 180.0000, 13)
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (19, 19, N'Product 19', N'17', 190.0000, 14)
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([MemberId])
GO
