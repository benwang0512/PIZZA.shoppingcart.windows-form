USE [pizza]
GO
/****** Object:  Table [dbo].[member]    Script Date: 2022/11/3 下午 02:05:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[ID] [int] IDENTITY(101,1) NOT NULL,
	[手機號碼] [nvarchar](20) NOT NULL,
	[用戶名稱] [nvarchar](20) NOT NULL,
	[密碼] [nvarchar](20) NOT NULL,
	[職稱] [int] NOT NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pizza起司]    Script Date: 2022/11/3 下午 02:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pizza起司](
	[ID] [int] IDENTITY(101,1) NOT NULL,
	[商品名稱] [nvarchar](50) NULL,
	[商品價錢] [int] NULL,
	[上架日期] [date] NOT NULL,
	[是否供應] [bit] NOT NULL,
	[image] [nvarchar](100) NULL,
 CONSTRAINT [PK_pizza起司] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pizza菜單]    Script Date: 2022/11/3 下午 02:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pizza菜單](
	[ID] [int] IDENTITY(101,1) NOT NULL,
	[商品名稱] [nvarchar](50) NULL,
	[商品價錢] [int] NULL,
	[上架日期] [date] NOT NULL,
	[是否供應] [bit] NOT NULL,
	[產品類別] [nvarchar](10) NULL,
	[image] [nvarchar](100) NULL,
 CONSTRAINT [PK_pizza菜單] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pizza餅皮]    Script Date: 2022/11/3 下午 02:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pizza餅皮](
	[ID] [int] IDENTITY(101,1) NOT NULL,
	[商品名稱] [nvarchar](50) NULL,
	[商品價錢] [int] NULL,
	[上架日期] [date] NOT NULL,
	[是否供應] [bit] NOT NULL,
	[image] [nvarchar](100) NULL,
 CONSTRAINT [PK_pizza餅皮] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[訂單資料表]    Script Date: 2022/11/3 下午 02:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單資料表](
	[訂單編號] [int] IDENTITY(10001,1) NOT NULL,
	[會員ID] [int] NOT NULL,
	[訂購人姓名] [nvarchar](10) NOT NULL,
	[訂購人電話] [nvarchar](20) NOT NULL,
	[外帶 or 外送] [nvarchar](5) NOT NULL,
	[取餐時間] [datetime] NOT NULL,
	[外送地址] [nvarchar](100) NOT NULL,
	[商品總價] [int] NOT NULL,
	[訂購時間] [datetime] NOT NULL,
 CONSTRAINT [PK_訂單資料表1] PRIMARY KEY CLUSTERED 
(
	[訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[訂單資料細節]    Script Date: 2022/11/3 下午 02:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單資料細節](
	[產品細節ID] [int] IDENTITY(10001,1) NOT NULL,
	[訂單編號] [int] NOT NULL,
	[商品名稱] [nvarchar](50) NOT NULL,
	[起司] [nvarchar](10) NOT NULL,
	[餅皮] [nvarchar](10) NOT NULL,
	[商品單價] [int] NOT NULL,
 CONSTRAINT [PK_訂單資料細節] PRIMARY KEY CLUSTERED 
(
	[產品細節ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[member] ON 

INSERT [dbo].[member] ([ID], [手機號碼], [用戶名稱], [密碼], [職稱]) VALUES (101, N'0', N'訪客', N'0', 0)
INSERT [dbo].[member] ([ID], [手機號碼], [用戶名稱], [密碼], [職稱]) VALUES (102, N'1', N'王淳方', N'1', 100)
INSERT [dbo].[member] ([ID], [手機號碼], [用戶名稱], [密碼], [職稱]) VALUES (103, N'2', N'盧冠佑', N'2', 10)
INSERT [dbo].[member] ([ID], [手機號碼], [用戶名稱], [密碼], [職稱]) VALUES (104, N'3', N'謝子祥', N'3', 1)
SET IDENTITY_INSERT [dbo].[member] OFF
GO
SET IDENTITY_INSERT [dbo].[pizza起司] ON 

INSERT [dbo].[pizza起司] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (101, N'原味', 0, CAST(N'2022-10-19' AS Date), 1, NULL)
INSERT [dbo].[pizza起司] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (102, N'雙倍起司', 50, CAST(N'2022-10-19' AS Date), 1, NULL)
INSERT [dbo].[pizza起司] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (103, N'起司三重奏', 100, CAST(N'2022-10-19' AS Date), 1, NULL)
SET IDENTITY_INSERT [dbo].[pizza起司] OFF
GO
SET IDENTITY_INSERT [dbo].[pizza菜單] ON 

INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (101, N'臘腸起司', 470, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'臘腸起司.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (102, N'燻雞絲蘑菇', 470, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'燻雞絲蘑菇.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (103, N'鳳梨鮮蝦', 470, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'鳳梨鮮蝦.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (104, N'原味海鮮', 470, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'原味海鮮.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (105, N'煙燻黃金總匯', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'煙燻黃金總匯.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (106, N'和風章魚燒', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'和風章魚燒.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (107, N'泡菜燒肉', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'泡菜燒肉.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (108, N'黃金和風雞', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'黃金和風雞.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (109, N'超級總會', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'超級總會.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (110, N'海陸大亨', 550, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'海陸大亨.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (111, N'壽喜雪花牛', 600, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'壽喜雪花牛.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (112, N'白醬海鮮', 600, CAST(N'2022-10-19' AS Date), 1, N'主餐', N'白醬海鮮.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (115, N'韓式唐楊雞', 150, CAST(N'2022-10-19' AS Date), 1, N'配餐', N'韓式唐楊雞.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (116, N'PK原味拼盤', 300, CAST(N'2022-10-19' AS Date), 1, N'配餐', N'原味拼盤.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (117, N'PK烤雞拼盤', 350, CAST(N'2022-10-19' AS Date), 1, N'配餐', N'烤雞拼盤.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (118, N'PK海陸拼盤', 350, CAST(N'2022-10-19' AS Date), 1, N'配餐', N'海陸拼盤.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (119, N'麻糬QQ球', 50, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'麻糬QQ球.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (120, N'巧克力起司', 55, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'巧克力起司.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (121, N'巧克力起司塔6顆', 300, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'巧克力起司塔6顆.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (122, N'熔岩起司蛋糕', 550, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'熔岩起司蛋糕.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (123, N'百事可樂 1.25L', 40, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'百事可樂 1.25L.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (124, N'七喜 1.25L', 40, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'七喜 1.25L.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (125, N'美粒果1.25ml', 50, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'美粒果1.25ml.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (126, N'原翠綠茶1.25L', 50, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'原翠綠茶1.25L.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (127, N'MOREF氣泡水1.25L', 50, CAST(N'2022-10-25' AS Date), 1, N'甜點飲料', N'MOREF氣泡水1.25L.png')
INSERT [dbo].[pizza菜單] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [產品類別], [image]) VALUES (128, N'香蕉', 1000, CAST(N'2022-11-01' AS Date), 0, N'甜點飲料', N'202211012144561190.PNG')
SET IDENTITY_INSERT [dbo].[pizza菜單] OFF
GO
SET IDENTITY_INSERT [dbo].[pizza餅皮] ON 

INSERT [dbo].[pizza餅皮] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (101, N'鬆厚餅皮', 0, CAST(N'2022-10-19' AS Date), 1, NULL)
INSERT [dbo].[pizza餅皮] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (102, N'薄脆餅皮', 0, CAST(N'2022-10-19' AS Date), 1, NULL)
INSERT [dbo].[pizza餅皮] ([ID], [商品名稱], [商品價錢], [上架日期], [是否供應], [image]) VALUES (103, N'芝心餅皮', 50, CAST(N'2022-10-19' AS Date), 1, NULL)
SET IDENTITY_INSERT [dbo].[pizza餅皮] OFF
GO
ALTER TABLE [dbo].[member] ADD  CONSTRAINT [DF_member_職稱]  DEFAULT ((1)) FOR [職稱]
GO
ALTER TABLE [dbo].[pizza起司] ADD  CONSTRAINT [DF_pizza起司_上架日期]  DEFAULT (getdate()) FOR [上架日期]
GO
ALTER TABLE [dbo].[pizza起司] ADD  CONSTRAINT [DF_pizza起司_是否供應]  DEFAULT ((1)) FOR [是否供應]
GO
ALTER TABLE [dbo].[pizza菜單] ADD  CONSTRAINT [DF_pizza菜單_上架日期]  DEFAULT (getdate()) FOR [上架日期]
GO
ALTER TABLE [dbo].[pizza菜單] ADD  CONSTRAINT [DF_pizza菜單_是否供應]  DEFAULT ((1)) FOR [是否供應]
GO
ALTER TABLE [dbo].[pizza餅皮] ADD  CONSTRAINT [DF_pizza餅皮_上架日期]  DEFAULT (getdate()) FOR [上架日期]
GO
ALTER TABLE [dbo].[pizza餅皮] ADD  CONSTRAINT [DF_pizza餅皮_是否供應]  DEFAULT ((1)) FOR [是否供應]
GO
ALTER TABLE [dbo].[訂單資料表] ADD  CONSTRAINT [DF_訂單資料表_外送地址]  DEFAULT (N'無') FOR [外送地址]
GO
ALTER TABLE [dbo].[訂單資料表] ADD  CONSTRAINT [DF_訂單資料表_訂購時間]  DEFAULT (getdate()) FOR [訂購時間]
GO
ALTER TABLE [dbo].[訂單資料表]  WITH CHECK ADD  CONSTRAINT [FK__訂單資料表1__ID__619B8048] FOREIGN KEY([會員ID])
REFERENCES [dbo].[member] ([ID])
GO
ALTER TABLE [dbo].[訂單資料表] CHECK CONSTRAINT [FK__訂單資料表1__ID__619B8048]
GO
ALTER TABLE [dbo].[訂單資料細節]  WITH CHECK ADD  CONSTRAINT [FK_訂單資料細節_訂單資料表] FOREIGN KEY([訂單編號])
REFERENCES [dbo].[訂單資料表] ([訂單編號])
GO
ALTER TABLE [dbo].[訂單資料細節] CHECK CONSTRAINT [FK_訂單資料細節_訂單資料表]
GO
