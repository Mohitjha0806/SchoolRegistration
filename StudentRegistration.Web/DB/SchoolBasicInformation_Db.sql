USE [StudentRegistration_Db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/16/2025 7:31:58 PM ******/
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
/****** Object:  Table [dbo].[SchoolBasicInformation]    Script Date: 1/16/2025 7:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolBasicInformation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UDISECode] [nvarchar](11) NULL,
	[SchoolNameEnglish] [varchar](50) NULL,
	[SchoolNameHindi] [nvarchar](50) NULL,
	[YearOfEstablishment] [int] NOT NULL,
	[Recognition] [date] NOT NULL,
	[SchoolBoard] [varchar](30) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_SchoolBasicInformation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
