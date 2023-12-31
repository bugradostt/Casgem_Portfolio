USE [CasgemPortfolio]
GO
/****** Object:  Table [dbo].[TblAdmin]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAdmin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](20) NULL,
	[AdminUserName] [nvarchar](35) NULL,
	[AdminPassword] [nvarchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblContact]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblContact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[ContactTel] [nvarchar](20) NULL,
	[ContactMail] [nvarchar](35) NULL,
	[ContactAdress] [nvarchar](500) NULL,
	[ContactMaps] [nvarchar](1500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDepartment]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDepartment](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEmployee]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEmployee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](70) NULL,
	[EmployeeSurname] [nvarchar](70) NULL,
	[EmployeeCity] [nvarchar](50) NULL,
	[EmployeeSalary] [decimal](18, 2) NULL,
	[EmployeeDepartment] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEmployeeCount]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEmployeeCount](
	[StaffCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblFeature]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblFeature](
	[FeatureId] [int] IDENTITY(1,1) NOT NULL,
	[FeatureTitle] [nvarchar](100) NULL,
	[FeatureDescription] [nvarchar](1000) NULL,
	[FeatureImageUrl] [nvarchar](1000) NULL,
	[FeatureIJobs] [nchar](1000) NULL,
 CONSTRAINT [PK__TblFeatu__82230BC9E43A788F] PRIMARY KEY CLUSTERED 
(
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblMessage]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblMessage](
	[MessageId] [int] IDENTITY(1,1) NOT NULL,
	[NameSurname] [nvarchar](100) NULL,
	[SenderMail] [nvarchar](100) NULL,
	[MessageSubject] [nvarchar](150) NULL,
	[Content] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblProject]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblProject](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](150) NULL,
	[ProjectDescription] [nvarchar](150) NULL,
	[ProjectUrl] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblReference]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblReference](
	[ReferenceId] [int] IDENTITY(1,1) NOT NULL,
	[ReferenceImgUrl] [nvarchar](1000) NULL,
	[ReferenceNameSurname] [nvarchar](150) NULL,
	[ReferenceBusinessName] [nvarchar](150) NULL,
	[ReferenceDescription] [nvarchar](1550) NULL,
 CONSTRAINT [PK__TblRefer__E1A99A19D960CFC9] PRIMARY KEY CLUSTERED 
(
	[ReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblResume]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblResume](
	[ResumeId] [int] IDENTITY(1,1) NOT NULL,
	[ResumeTitle1] [nvarchar](150) NULL,
	[ResumeTitle2] [nvarchar](150) NULL,
	[ResumeDescription] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ResumeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblService]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblService](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceTitle] [nvarchar](100) NULL,
	[ServiceIcon] [nvarchar](100) NULL,
	[ServiceNumber] [char](2) NULL,
	[ServiceContent] [nvarchar](1000) NULL,
 CONSTRAINT [PK_TblService] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSocialMedia]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSocialMedia](
	[SocialMediaId] [int] IDENTITY(1,1) NOT NULL,
	[SocialMediaUrl] [nvarchar](300) NULL,
	[SocialMediaName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SocialMediaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblWhoAmI]    Script Date: 16.07.2023 21:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblWhoAmI](
	[WhoAmIId] [int] IDENTITY(1,1) NOT NULL,
	[WhoAmIImgUrl] [nvarchar](1150) NULL,
	[WhoAmITitle] [nvarchar](150) NULL,
	[WhoAmIJobs] [nvarchar](350) NULL,
	[WhoAmIDescription] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[WhoAmIId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_TblEmployee_TblDepartment] FOREIGN KEY([EmployeeDepartment])
REFERENCES [dbo].[TblDepartment] ([DepartmentId])
GO
ALTER TABLE [dbo].[TblEmployee] CHECK CONSTRAINT [FK_TblEmployee_TblDepartment]
GO
