﻿CREATE DATABASE [TestSessionDb] ON  PRIMARY 
( NAME = N'TestSessionDb', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TestSessionDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestSessionDb_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TestSessionDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestSessionDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
ALTER DATABASE [TestSessionDb] SET ANSI_NULL_DEFAULT OFF 
ALTER DATABASE [TestSessionDb] SET ANSI_NULLS OFF 
ALTER DATABASE [TestSessionDb] SET ANSI_PADDING OFF 
ALTER DATABASE [TestSessionDb] SET ANSI_WARNINGS OFF 
ALTER DATABASE [TestSessionDb] SET ARITHABORT OFF 
ALTER DATABASE [TestSessionDb] SET AUTO_CLOSE OFF 
ALTER DATABASE [TestSessionDb] SET AUTO_CREATE_STATISTICS ON 
ALTER DATABASE [TestSessionDb] SET AUTO_SHRINK OFF 
ALTER DATABASE [TestSessionDb] SET AUTO_UPDATE_STATISTICS ON 
ALTER DATABASE [TestSessionDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
ALTER DATABASE [TestSessionDb] SET CURSOR_DEFAULT  GLOBAL 
ALTER DATABASE [TestSessionDb] SET CONCAT_NULL_YIELDS_NULL OFF 
ALTER DATABASE [TestSessionDb] SET NUMERIC_ROUNDABORT OFF 
ALTER DATABASE [TestSessionDb] SET QUOTED_IDENTIFIER OFF 
ALTER DATABASE [TestSessionDb] SET RECURSIVE_TRIGGERS OFF 
ALTER DATABASE [TestSessionDb] SET  DISABLE_BROKER 
ALTER DATABASE [TestSessionDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
ALTER DATABASE [TestSessionDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
ALTER DATABASE [TestSessionDb] SET TRUSTWORTHY OFF 
ALTER DATABASE [TestSessionDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
ALTER DATABASE [TestSessionDb] SET PARAMETERIZATION SIMPLE 
ALTER DATABASE [TestSessionDb] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [TestSessionDb] SET HONOR_BROKER_PRIORITY OFF 
ALTER DATABASE [TestSessionDb] SET RECOVERY SIMPLE 
ALTER DATABASE [TestSessionDb] SET  MULTI_USER 
ALTER DATABASE [TestSessionDb] SET PAGE_VERIFY CHECKSUM  
ALTER DATABASE [TestSessionDb] SET DB_CHAINING OFF 
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[SetupGroup](
	[SetupGroupId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Key] [nvarchar](50) NOT NULL,
	[DisplayIndex] [int] NOT NULL,
 CONSTRAINT [PK_dbo.SetupGroup] PRIMARY KEY CLUSTERED 
(
	[SetupGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[SetupParameter](
	[SetupParameterId] [uniqueidentifier] NOT NULL,
	[SetupSubGroupId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Key] [nvarchar](50) NOT NULL,
	[DisplayIndex] [int] NOT NULL,
	[OriginalSuffix] [nvarchar](16) NOT NULL,
	[TranslatedSuffix] [nvarchar](16) NOT NULL,
	[IsTranslatable] [bit] NOT NULL,
	[VehicleSetupParameterModel_VehicleSetuParameterId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.SetupParameter] PRIMARY KEY CLUSTERED 
(
	[SetupParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[SetupSubGroup](
	[SetupSubGroupId] [uniqueidentifier] NOT NULL,
	[SetupGroupId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Key] [nvarchar](50) NOT NULL,
	[DisplayIndex] [int] NOT NULL,
 CONSTRAINT [PK_dbo.SetupSubGroup] PRIMARY KEY CLUSTERED 
(
	[SetupSubGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[TestSessionRun](
	[TestSessionRunId] [uniqueidentifier] NOT NULL,
	[ExportFile] [varchar](max) NULL,
	[SetupFile] [varbinary](max) NULL,
	[TelemetryFile] [varbinary](max) NULL,
	[Timestamp] [date] NOT NULL,
	[Notes] [varchar](1500) NULL,
 CONSTRAINT [PK_TestSessionRun] PRIMARY KEY CLUSTERED 
(
	[TestSessionRunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Vehicles](
	[VehicleId] [uniqueidentifier] NOT NULL,
	[CarId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.Vehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[VehicleSetupParameter](
	[VehicleSetuParameterId] [uniqueidentifier] NOT NULL,
	[VehicleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.VehicleSetupParameter] PRIMARY KEY CLUSTERED 
(
	[VehicleSetuParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING ON

CREATE UNIQUE NONCLUSTERED INDEX [IX_SetupGroup_Key] ON [dbo].[SetupGroup]
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
SET ANSI_PADDING ON

CREATE UNIQUE NONCLUSTERED INDEX [IX_SetupGroup_Name] ON [dbo].[SetupGroup]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [IX_SetupSubGroupId] ON [dbo].[SetupParameter]
(
	[SetupSubGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [IX_VehicleSetupParameterModel_VehicleSetuParameterId] ON [dbo].[SetupParameter]
(
	[VehicleSetupParameterModel_VehicleSetuParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [IX_SetupGroupId] ON [dbo].[SetupSubGroup]
(
	[SetupGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE UNIQUE NONCLUSTERED INDEX [IX_Vehicles_CarId] ON [dbo].[Vehicles]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX [IX_VehicleId] ON [dbo].[VehicleSetupParameter]
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
ALTER TABLE [dbo].[SetupGroup] ADD  DEFAULT (newsequentialid()) FOR [SetupGroupId]
ALTER TABLE [dbo].[SetupParameter] ADD  DEFAULT (newsequentialid()) FOR [SetupParameterId]
ALTER TABLE [dbo].[SetupSubGroup] ADD  DEFAULT (newsequentialid()) FOR [SetupSubGroupId]
ALTER TABLE [dbo].[TestSessionRun] ADD  CONSTRAINT [DF_TestSessionRun_TestSessionRunId]  DEFAULT (newid()) FOR [TestSessionRunId]
ALTER TABLE [dbo].[Vehicles] ADD  DEFAULT (newsequentialid()) FOR [VehicleId]
ALTER TABLE [dbo].[VehicleSetupParameter] ADD  DEFAULT (newsequentialid()) FOR [VehicleSetuParameterId]
ALTER TABLE [dbo].[SetupParameter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SetupParameter_dbo.SetupSubGroup_SetupSubGroupId] FOREIGN KEY([SetupSubGroupId])
REFERENCES [dbo].[SetupSubGroup] ([SetupSubGroupId])
ON DELETE CASCADE
ALTER TABLE [dbo].[SetupParameter] CHECK CONSTRAINT [FK_dbo.SetupParameter_dbo.SetupSubGroup_SetupSubGroupId]
ALTER TABLE [dbo].[SetupParameter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SetupParameter_dbo.VehicleSetupParameter_VehicleSetupParameterModel_VehicleSetuParameterId] FOREIGN KEY([VehicleSetupParameterModel_VehicleSetuParameterId])
REFERENCES [dbo].[VehicleSetupParameter] ([VehicleSetuParameterId])
ALTER TABLE [dbo].[SetupParameter] CHECK CONSTRAINT [FK_dbo.SetupParameter_dbo.VehicleSetupParameter_VehicleSetupParameterModel_VehicleSetuParameterId]
ALTER TABLE [dbo].[SetupSubGroup]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SetupSubGroup_dbo.SetupGroup_SetupGroupId] FOREIGN KEY([SetupGroupId])
REFERENCES [dbo].[SetupGroup] ([SetupGroupId])
ON DELETE CASCADE
ALTER TABLE [dbo].[SetupSubGroup] CHECK CONSTRAINT [FK_dbo.SetupSubGroup_dbo.SetupGroup_SetupGroupId]
ALTER TABLE [dbo].[VehicleSetupParameter]  WITH CHECK ADD  CONSTRAINT [FK_dbo.VehicleSetupParameter_dbo.Vehicles_VehicleId] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicles] ([VehicleId])
ON DELETE CASCADE
ALTER TABLE [dbo].[VehicleSetupParameter] CHECK CONSTRAINT [FK_dbo.VehicleSetupParameter_dbo.Vehicles_VehicleId]
ALTER DATABASE [TestSessionDb] SET  READ_WRITE 
