CREATE TABLE [dbo].[Designation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DesignationName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Designation] ON 

INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (1, N'BOM')
INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (2, N'ZOM')
INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (3, N'RLM')
INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (4, N'Admin')
INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (5, N'ZLM')
INSERT [dbo].[Designation] ([id], [DesignationName]) VALUES (6, N'ZLO')
SET IDENTITY_INSERT [dbo].[Designation] OFF