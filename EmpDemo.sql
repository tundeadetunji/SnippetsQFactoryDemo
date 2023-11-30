USE [EmpDemo]
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[empTitle] [nvarchar](255) NULL,
	[empName] [nvarchar](255) NULL,
	[empGender] [nvarchar](255) NULL,
	[empUsername] [nvarchar](255) NULL,
	[empPassword] [nvarchar](255) NULL,
) ON [PRIMARY]

GO