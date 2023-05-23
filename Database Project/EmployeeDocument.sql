﻿CREATE TABLE [dbo].[EmployeeDocument](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[DocumentName] [varchar](500) NOT NULL,
	[DocPath] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]