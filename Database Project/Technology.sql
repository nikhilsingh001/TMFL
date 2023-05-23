CREATE TABLE [dbo].[Technology](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TechnologyName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Technology] ON 

INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (1, N'DotNet')
INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (2, N'Java')
INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (3, N'C#')
INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (4, N'PHP')
INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (5, N'Python')
INSERT [dbo].[Technology] ([id], [TechnologyName]) VALUES (6, N'SQL')
SET IDENTITY_INSERT [dbo].[Technology] OFF