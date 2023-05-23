	CREATE TABLE [dbo].[Zone](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[regionID] [int] NOT NULL,
	[ZoneName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Zone] ON 

INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (1, 1, N'GUWAHATI - ULUBARI')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (2, 1, N'KOLKATA - RO')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (3, 1, N'HOWRAH')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (4, 1, N'JORHAT')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (5, 1, N'DURGAPUR')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (6, 3, N'AGRA')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (8, 3, N'ALLAHABAD')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (9, 3, N'VARANASI')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (10, 3, N'MORADABAD')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (11, 7, N'CUDDAPAH')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (12, 7, N'HUBLI')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (13, 7, N'HOSPET')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (14, 7, N'VIJAYAWADA')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (15, 7, N'WARANGAL')
INSERT [dbo].[Zone] ([id], [regionID], [ZoneName]) VALUES (16, 7, N'HUBLI')
SET IDENTITY_INSERT [dbo].[Zone] OFF