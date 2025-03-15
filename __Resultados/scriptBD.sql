USE [BD_TEST]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/03/2025 04:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 15/03/2025 04:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [varchar](50) NOT NULL,
	[DocType] [varchar](50) NULL,
	[DocNum] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[CustomerId] [varchar](20) NULL,
	[GivenName] [varchar](100) NULL,
	[FamilyName1] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 15/03/2025 04:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](100) NULL,
	[productTypeName] [varchar](100) NULL,
	[numeracioTerminal] [bigint] NULL,
	[soldAt] [date] NULL,
	[customerId] [varchar](10) NULL,
 CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1111111, N'FIBRA 1000 ADAMO', N'ftth', 933933933, CAST(N'2019-01-09' AS Date), N'11111')
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1111112, N'FIBRA 500 ADAMO', N'ftth', 933933934, CAST(N'2020-05-15' AS Date), N'22222')
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1111113, N'FIBRA 300 ADAMO', N'ftth', 933933935, CAST(N'2021-03-20' AS Date), N'33333')
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1111114, N'FIBRA 200 ADAMO', N'ftth', 933933936, CAST(N'2022-07-10' AS Date), N'44444')
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1111115, N'FIBRA 100 ADAMO', N'ftth', 933933937, CAST(N'2023-01-01' AS Date), N'55555')
GO
INSERT [dbo].[Product] ([id], [productName], [productTypeName], [numeracioTerminal], [soldAt], [customerId]) VALUES (1112112, N'FIBRA 165 ADAMO', N'ftth', 933933938, CAST(N'2023-01-15' AS Date), N'777777')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
