USE [master]
GO

/****** Object:  Database [FlamingSoftHR]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE DATABASE [FlamingSoftHR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlamingSoftHR', FILENAME = N'/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FlamingSoftHR_log', FILENAME = N'/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FlamingSoftHR] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlamingSoftHR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FlamingSoftHR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET ARITHABORT OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FlamingSoftHR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlamingSoftHR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FlamingSoftHR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FlamingSoftHR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlamingSoftHR] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [FlamingSoftHR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FlamingSoftHR] SET  MULTI_USER 
GO
ALTER DATABASE [FlamingSoftHR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FlamingSoftHR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FlamingSoftHR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FlamingSoftHR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FlamingSoftHR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FlamingSoftHR] SET QUERY_STORE = OFF
GO
USE [FlamingSoftHR]
GO

/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021-06-30 9:54:40 AM ******/
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

/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[DeviceCodes]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceCodes](
	[UserCode] [nvarchar](200) NOT NULL,
	[DeviceCode] [nvarchar](200) NOT NULL,
	[SubjectId] [nvarchar](200) NULL,
	[SessionId] [nvarchar](100) NULL,
	[ClientId] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[Expiration] [datetime2](7) NOT NULL,
	[Data] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DeviceCodes] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PersistedGrants]    Script Date: 2021-06-30 9:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersistedGrants](
	[Key] [nvarchar](200) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[SubjectId] [nvarchar](200) NULL,
	[SessionId] [nvarchar](100) NULL,
	[ClientId] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[Expiration] [datetime2](7) NULL,
	[ConsumedTime] [datetime2](7) NULL,
	[Data] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PersistedGrants] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.7')
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [RoleNameIndex]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [EmailIndex]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [UserNameIndex]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_DeviceCodes_DeviceCode]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DeviceCodes_DeviceCode] ON [dbo].[DeviceCodes]
(
	[DeviceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

/****** Object:  Index [IX_DeviceCodes_Expiration]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_DeviceCodes_Expiration] ON [dbo].[DeviceCodes]
(
	[Expiration] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

/****** Object:  Index [IX_PersistedGrants_Expiration]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PersistedGrants_Expiration] ON [dbo].[PersistedGrants]
(
	[Expiration] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_PersistedGrants_SubjectId_ClientId_Type]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PersistedGrants_SubjectId_ClientId_Type] ON [dbo].[PersistedGrants]
(
	[SubjectId] ASC,
	[ClientId] ASC,
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO

/****** Object:  Index [IX_PersistedGrants_SubjectId_SessionId_Type]    Script Date: 2021-06-30 9:54:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_PersistedGrants_SubjectId_SessionId_Type] ON [dbo].[PersistedGrants]
(
	[SubjectId] ASC,
	[SessionId] ASC,
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [FlamingSoftHR] SET  READ_WRITE 
GO

/**** Solution Tables ****/
CREATE TABLE dbo.Department (
    Id INT IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(200) NOT NULL,
    CONSTRAINT PK_Departments PRIMARY KEY(Id),
    CONSTRAINT U_Name UNIQUE([Name])
)
GO

CREATE TABLE dbo.EmployeeType (
    Id INT IDENTITY(1,1) NOT NULL,
    [Description] NVARCHAR(200) NOT NULL,
    CONSTRAINT PK_EmployeeType PRIMARY KEY(Id),
    CONSTRAINT U_Description UNIQUE([Description])
)
GO

CREATE TABLE dbo.LoggedTimeType (
    Id INT IDENTITY(1,1) NOT NULL,
    [Description] NVARCHAR(200) NOT NULL,
    CONSTRAINT PK_LoggedTimeType PRIMARY KEY(Id),
    CONSTRAINT U_Description_LoggedTimeType UNIQUE([Description])
)
GO

CREATE TABLE dbo.Employee (
    Id INT IDENTITY(100000,1) NOT NULL,
    UserId NVARCHAR(450) NULL,
    EmployeeTypeId INT NOT NULL,
    FirstName NVARCHAR(200) NOT NULL,
    MiddleName NVARCHAR(200),
    LastName NVARCHAR(200) NOT NULL,
	Salary DECIMAL(15,2) NOT NULL,
	JobId INT NOT NULL,
    CONSTRAINT PK_Employee PRIMARY KEY(Id),
    CONSTRAINT FK_Employee_To_AspNetUser 
        FOREIGN KEY(UserId) 
        REFERENCES dbo.AspNetUsers(Id) 
        ON DELETE CASCADE,
    CONSTRAINT FK_Employee_To_EmployeeType 
        FOREIGN KEY(EmployeeTypeId) 
        REFERENCES dbo.EmployeeType(Id) 
        ON DELETE CASCADE,  
	CONSTRAINT FK_Employee_To_Job
        FOREIGN KEY(JobId) 
        REFERENCES dbo.Job(Id) 
        ON DELETE CASCADE    
)
GO

ALTER TABLE dbo.Employee 
ALTER COLUMN UserId NVARCHAR(450) NULL;
GO

DROP TABLE LoggedTime

CREATE TABLE dbo.LoggedTime (
    Id INT IDENTITY(1,1) NOT NULL,
    DateLogged DATETIME2 NOT NULL,
    [Hours] DECIMAL(4,2) NOT NULL,
    WeekNumber INT NOT NULL,
    EmployeeId INT NOT NULL,
    LogTypeId INT NOT NULL,
    CONSTRAINT PK_LoggedTime PRIMARY KEY(Id),
    CONSTRAINT FK_LoggedTime_To_Employee 
        FOREIGN KEY(EmployeeId) 
        REFERENCES dbo.Employee(Id) 
        ON DELETE CASCADE,
    CONSTRAINT FK_LoggedTime_To_LoggedTimeType 
        FOREIGN KEY(LogTypeId) 
        REFERENCES dbo.LoggedTimeType(Id) 
        ON DELETE CASCADE,      
    CONSTRAINT CHK_Hours CHECK ([Hours] >= 0.00 AND [Hours] <= 12.00)
)
GO

CREATE TABLE dbo.Job (
    Id INT IDENTITY(1,1) NOT NULL,
    [Description] NVARCHAR(500) NOT NULL,
	MinSalary DECIMAL(15,2) NOT NULL,
	MaxSalary DECIMAL(15,2) NOT NULL,
	DepartmentId INT NOT NULL,
    CONSTRAINT PK_Position PRIMARY KEY(Id),
	CONSTRAINT FK_Job_To_Department
        FOREIGN KEY(DepartmentId) 
        REFERENCES dbo.Department(Id) 
        ON DELETE CASCADE,
	CONSTRAINT U_Description_Job UNIQUE([Description])
)
GO

/**** Populating the Database ****/

/**** Department ****/
INSERT INTO 
		dbo.Department(
			[Name]
		) 
VALUES 
		('IT'),
		('HR'),
		('Payroll'),
		('Marketing');

/**** Employee Type ****/
INSERT INTO dbo.EmployeeType([Description]) VALUES ('Contract'), ('Permanent');

/**** Logged Time Type ****/
INSERT INTO 
		dbo.LoggedTimeType(
			[Description]
		) 
VALUES
		('Sick'),
		('Vacation'),
		('Regular');

/**** Job ****/
INSERT INTO 
		dbo.Job(
			[Description],MinSalary,MaxSalary,DepartmentId
		) 
VALUES
		('Database Administrator',10000.00,200000.00,1),
		('Software Engineer',80000.00,18000.00,1),
		('Recruiter',2000.00,10000.00,2),
		('HR Specialist',4000.00,15000.00,2),
		('Payroll Specialist',4000.00,15000.00,3),
		('Payroll Manager',10000.00,30000.00,3),
		('Communications Manager',5000.00,12000.00,4),
		('Content Marketing Specialist',8000.00,15000.00,4);

/**** Employee ****/
INSERT INTO 
		dbo.Employee(
			UserId,EmployeeTypeId,First_Name,Middle_Name,Last_Name, Salary, JobId
		) 
VALUES 
		(NULL,2,'Carlos','Antonio','Nuila',10000.00,2),
		(NULL,2,'Diana',NULL,'Hernandez',15000.00,4),
		(NULL,1,'John',NULL,'Buckeridge',3000.00,3),
		(NULL,1,'Sarah','Madelyne','Cameron',6000.00,5),
		(NULL,2,'Billie','Evelyn','Smith',5000.00,3);

/**** Logged TIme ****/
INSERT INTO 
		dbo.LoggedTime(
			DateLogged,[Hours],WeekNumber,EmployeeId, LogTypeId
		) 
VALUES
		('2021-09-14 00:00:00',7.00,37,100000,3),
		('2021-09-13 00:00:00',7.00,37,100000,3),
		('2021-09-11 00:00:00',8.00,36,100000,3),
		('2021-09-10 00:00:00',8.00,36,100000,3),
		('2021-09-09 00:00:00',8.00,36,100000,3),
		('2021-09-08 00:00:00',8.00,36,100000,3),
		('2021-09-07 00:00:00',8.00,36,100000,3),
		('2021-09-06 00:00:00',8.00,36,100000,3),
		('2021-09-03 00:00:00',0.00,35,100000,1),
		('2021-09-02 00:00:00',0.00,35,100000,1),
		('2021-09-01 00:00:00',8.00,35,100000,3),
		('2021-08-31 00:00:00',0.00,35,100000,2),
		('2021-08-30 00:00:00',0.00,35,100000,2);

SELECT * FROM loggedtime

UPDATE Employee SET UserId= '2d1b0b3d-b7cb-44c4-97b0-94702ade474b' WHERE Employee.id = 100000 