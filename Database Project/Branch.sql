CREATE TABLE [dbo].[Branch](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](50) NOT NULL,
	[zoneid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Branch] ON 

INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (1, N'BERHAMPORE', 5)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (2, N'BIRBHUM', 5)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (3, N'AGARTALA', 1)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (4, N'BARPETA', 1)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (5, N'ARAMBAGH', 3)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (6, N'BANDERDAWA', 4)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (7, N'AAMTALA', 2)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (8, N'AGRA', 6)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (9, N'ALLAHABAD', 8)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (10, N'BAREILLY', 9)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (11, N'AZAMGARH', 10)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (12, N'ANANTHAPUR', 11)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (13, N'BELGAUM', 12)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (14, N'BELLARY', 13)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (15, N'BHIMAVARAM', 14)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (16, N'BHONGIR', 15)
INSERT [dbo].[Branch] ([id], [BranchName], [zoneid]) VALUES (17, N'BIJAPUR', 16)
SET IDENTITY_INSERT [dbo].[Branch] OFF