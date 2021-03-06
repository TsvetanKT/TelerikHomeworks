USE [master]
GO
/****** Object:  Database [AddressesHW2]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
CREATE DATABASE [AddressesHW2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdressesHW2', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AdressesHW2.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AdressesHW2_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AdressesHW2_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AddressesHW2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AddressesHW2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AddressesHW2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AddressesHW2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AddressesHW2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AddressesHW2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AddressesHW2] SET ARITHABORT OFF 
GO
ALTER DATABASE [AddressesHW2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AddressesHW2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AddressesHW2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AddressesHW2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AddressesHW2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AddressesHW2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AddressesHW2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AddressesHW2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AddressesHW2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AddressesHW2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AddressesHW2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AddressesHW2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AddressesHW2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AddressesHW2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AddressesHW2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AddressesHW2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AddressesHW2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AddressesHW2] SET RECOVERY FULL 
GO
ALTER DATABASE [AddressesHW2] SET  MULTI_USER 
GO
ALTER DATABASE [AddressesHW2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AddressesHW2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AddressesHW2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AddressesHW2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AddressesHW2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AddressesHW2', N'ON'
GO
USE [AddressesHW2]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [varchar](100) NOT NULL,
	[Town_Id] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Continent]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Continent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Continent_Id] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address_Id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Town]    Script Date: 24.8.2014 г. 02:09:07 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Town](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Country_Id] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [Address_Text], [Town_Id]) VALUES (1, N'Mladost 4, bl 1001', 1)
INSERT [dbo].[Address] ([Id], [Address_Text], [Town_Id]) VALUES (3, N'Metalurg street number 5', 2)
INSERT [dbo].[Address] ([Id], [Address_Text], [Town_Id]) VALUES (4, N'Makedonsko Devoiche N8', 3)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([Id], [Name]) VALUES (1, N'Asia')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (3, N'North America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (4, N'South America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (5, N'Antarctica')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (6, N'Europe')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (7, N'Australia')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [Continent_Id]) VALUES (1, N'Bulgaria', 6)
INSERT [dbo].[Country] ([Id], [Name], [Continent_Id]) VALUES (3, N'Macedonia', 6)
INSERT [dbo].[Country] ([Id], [Name], [Continent_Id]) VALUES (4, N'China', 1)
INSERT [dbo].[Country] ([Id], [Name], [Continent_Id]) VALUES (5, N'Canada', 3)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [First_Name], [Last_Name], [Address_Id]) VALUES (1, N'Joe', N'Cocker', 1)
INSERT [dbo].[Person] ([Id], [First_Name], [Last_Name], [Address_Id]) VALUES (5, N'Prpa', N'Sexa', 3)
INSERT [dbo].[Person] ([Id], [First_Name], [Last_Name], [Address_Id]) VALUES (6, N'Volodq', N'Stoqnov', 4)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([Id], [Name], [Country_Id]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Town] ([Id], [Name], [Country_Id]) VALUES (2, N'Pernik', 1)
INSERT [dbo].[Town] ([Id], [Name], [Country_Id]) VALUES (3, N'Skopie', 3)
INSERT [dbo].[Town] ([Id], [Name], [Country_Id]) VALUES (4, N'Beijing', 4)
INSERT [dbo].[Town] ([Id], [Name], [Country_Id]) VALUES (5, N'Montreal', 5)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([Town_Id])
REFERENCES [dbo].[Town] ([Id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent1] FOREIGN KEY([Continent_Id])
REFERENCES [dbo].[Continent] ([Id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent1]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([Address_Id])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([Country_Id])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [AddressesHW2] SET  READ_WRITE 
GO
