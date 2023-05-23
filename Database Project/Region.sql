CREATE TABLE [dbo].[Region](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegionName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Region] ON 

INSERT [dbo].[Region] ([id], [RegionName]) VALUES (1, N'EAST-1')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (2, N'EAST-2')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (3, N'NORTH-1')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (4, N'NORTH-2')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (5, N'WEST-1')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (6, N'WEST-2')
INSERT [dbo].[Region] ([id], [RegionName]) VALUES (7, N'SOUTH-1')
SET IDENTITY_INSERT [dbo].[Region] OFF