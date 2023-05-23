CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[Emp_name] [varchar](100) NOT NULL,
	[DesignationId] [int] NOT NULL,
	[Mobil_No] [int] NOT NULL,
	[Email_Id] [varchar](50) NOT NULL,
	[Regionid] [int] NOT NULL,
	[Zoneid] [int] NOT NULL,
	[Branchid] [int] NOT NULL,
	[Gender] [varchar](100) NOT NULL,
	[Date_of_Birth] [date] NOT NULL,
	[Emp_Address] [varchar](5000) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]