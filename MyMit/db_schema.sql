USE [master]
GO
/****** Object:  Database [MyMit]    Script Date: 5/19/2020 9:37:59 PM ******/
CREATE DATABASE [MyMit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyMit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyMit.mdf' , SIZE = 131072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [FILE] 
( NAME = N'MyMit_file', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyMit_file.ndf' , SIZE = 262144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 262144KB )
 LOG ON 
( NAME = N'MyMit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyMit_log.ldf' , SIZE = 65536KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyMit] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyMit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyMit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyMit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyMit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyMit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyMit] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyMit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyMit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyMit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyMit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyMit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyMit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyMit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyMit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyMit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyMit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyMit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyMit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyMit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyMit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyMit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyMit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyMit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyMit] SET RECOVERY FULL 
GO
ALTER DATABASE [MyMit] SET  MULTI_USER 
GO
ALTER DATABASE [MyMit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyMit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyMit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyMit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyMit] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyMit', N'ON'
GO
ALTER DATABASE [MyMit] SET QUERY_STORE = OFF
GO
USE [MyMit]
GO
/****** Object:  User [mymit]    Script Date: 5/19/2020 9:38:00 PM ******/
CREATE USER [mymit] FOR LOGIN [mymit] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mymit]
GO
/****** Object:  Table [dbo].[MeetingType]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_MeetingType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vMeetingTypes]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vMeetingTypes]
AS
	SELECT id, name FROM [dbo].[MeetingType] WHERE name = 'Sem Categoria'
	UNION ALL
	SELECT id, name FROM [dbo].[MeetingType] WHERE name <> 'Sem Categoria'
GO
/****** Object:  Table [dbo].[MeetingFile]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingFile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[FileContent] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_MeetingFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [FILE]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IDProfilePicture] [int] NULL,
	[Name] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Password] [varchar](512) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vUserInformation]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vUserInformation]
as
SELECT u.[Id]
      ,u.[IDProfilePicture]
      ,u.[Name]
      ,u.[Email]
      ,u.[Password]
      ,u.[IsAdmin]
	  ,f.[FileContent] as ProfilePicture
  FROM [dbo].[User] u
  INNER JOIN [dbo].[MeetingFile] f
  ON u.IDProfilePicture=f.Id
GO
/****** Object:  UserDefinedFunction [dbo].[SplitInts]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SplitInts]  
(  
   @List      VARCHAR(MAX),  
   @Delimiter VARCHAR(255)  
)  
RETURNS TABLE  
AS  
  RETURN ( SELECT Item = CONVERT(INT, Item) FROM  
      ( SELECT Item = x.i.value('(./text())[1]', 'varchar(max)')  
        FROM ( SELECT [XML] = CONVERT(XML, '<i>'  
        + REPLACE(@List, @Delimiter, '</i><i>') + '</i>').query('.')  
          ) AS a CROSS APPLY [XML].nodes('i') AS x(i) ) AS y  
      WHERE Item IS NOT NULL  
  );
GO
/****** Object:  Table [dbo].[Meeting]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meeting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDType] [int] NOT NULL,
	[IDOwner] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[durationMinutes] [int] NOT NULL,
	[Subject] [varchar](255) NOT NULL,
	[AgendaDescription] [varchar](max) NULL,
	[MeetingMinutes] [varchar](max) NULL,
	[AudioFile] [int] NULL,
	[AudioTranscription] [varchar](max) NULL,
	[SignatureFile] [int] NULL,
 CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeetingInvite]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingInvite](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMeeting] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[Attended] [bit] NULL,
 CONSTRAINT [PK_MeetingInvite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTask]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTask](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMeeting] [int] NOT NULL,
	[IdOwner] [int] NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[Deadline] [datetime] NOT NULL,
 CONSTRAINT [PK_UserTask] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex-20200510-194719]    Script Date: 5/19/2020 9:38:00 PM ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20200510-194719] ON [dbo].[Meeting]
(
	[StartTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [NonClusteredIndex-20200430-224203]    Script Date: 5/19/2020 9:38:00 PM ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20200430-224203] ON [dbo].[MeetingType]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MeetingInvite] ADD  CONSTRAINT [DF_MeetingInvite_Attended]  DEFAULT ((0)) FOR [Attended]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_MeetingFile] FOREIGN KEY([AudioFile])
REFERENCES [dbo].[MeetingFile] ([Id])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_MeetingFile]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_MeetingFile1] FOREIGN KEY([SignatureFile])
REFERENCES [dbo].[MeetingFile] ([Id])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_MeetingFile1]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_MeetingType] FOREIGN KEY([IDType])
REFERENCES [dbo].[MeetingType] ([Id])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_MeetingType]
GO
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_User] FOREIGN KEY([IDOwner])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_MeetingFile] FOREIGN KEY([IDProfilePicture])
REFERENCES [dbo].[MeetingFile] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_MeetingFile]
GO
ALTER TABLE [dbo].[UserTask]  WITH CHECK ADD  CONSTRAINT [FK_UserTask_Meeting] FOREIGN KEY([IdMeeting])
REFERENCES [dbo].[Meeting] ([ID])
GO
ALTER TABLE [dbo].[UserTask] CHECK CONSTRAINT [FK_UserTask_Meeting]
GO
ALTER TABLE [dbo].[UserTask]  WITH CHECK ADD  CONSTRAINT [FK_UserTask_User] FOREIGN KEY([IdOwner])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserTask] CHECK CONSTRAINT [FK_UserTask_User]
GO
/****** Object:  StoredProcedure [dbo].[addMeeting]    Script Date: 5/19/2020 9:38:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[addMeeting]
(
 @idType int, 
 @idOwner int, 
 @startday VarChar(32), 
 @duration int, 
 @subject VarChar(255), 
 @agenda VarChar(max),
 @inviteList VarChar(max)
)
AS

	/* Inserindo reuniao */
	INSERT INTO [dbo].[Meeting] ([IDType],[IDOwner],[StartTime],[DurationMinutes],[Subject],[AgendaDescription]) 
	VALUES (@idType, @idOwner, convert(datetime, @startday, 120), @duration, @subject, @agenda)

	/* Insere dados dos convidados */
	INSERT INTO [dbo].[MeetingInvite]
           ([IdMeeting]
           ,[IdUser])
	SELECT * FROM
	(
	SELECT ID as IdMeeting FROM [dbo].[Meeting] 
	WHERE id = SCOPE_IDENTITY()
	) T1
	JOIN
	(
	SELECT Item AS IsUser FROM dbo.SplitInts(@inviteList, ',')
	) T2
	ON 1=1
	
GO
USE [master]
GO
ALTER DATABASE [MyMit] SET  READ_WRITE 
GO
