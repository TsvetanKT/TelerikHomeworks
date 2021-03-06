USE [master]
GO
/****** Object:  Database [StudentSystemHW]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
CREATE DATABASE [StudentSystemHW]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentSystemHW', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StudentSystemHW.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentSystemHW_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\StudentSystemHW_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StudentSystemHW] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentSystemHW].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentSystemHW] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentSystemHW] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentSystemHW] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentSystemHW] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentSystemHW] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentSystemHW] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentSystemHW] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentSystemHW] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentSystemHW] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentSystemHW] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentSystemHW] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentSystemHW] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentSystemHW] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentSystemHW] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentSystemHW] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentSystemHW] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentSystemHW] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentSystemHW] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentSystemHW] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentSystemHW] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentSystemHW] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentSystemHW] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentSystemHW] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentSystemHW] SET  MULTI_USER 
GO
ALTER DATABASE [StudentSystemHW] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentSystemHW] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentSystemHW] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentSystemHW] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StudentSystemHW] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentSystemHW', N'ON'
GO
USE [StudentSystemHW]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departaments](
	[DepartamentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DepartamentsCourses]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartamentsCourses](
	[DepartamentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultieId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacultiesDepartaments](
	[FacultieId] [int] NOT NULL,
	[DepartamentId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfessorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProfessorsCurses]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorsCurses](
	[ProfessorId] [int] NOT NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorsInDepartaments]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorsInDepartaments](
	[DepartamentId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorTitles]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorTitles](
	[TitleId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FacultieId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentsInCourses]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsInCourses](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 24.8.2014 г. 02:18:51 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseId], [CourseName]) VALUES (1, N'Supromat')
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departaments] ON 

INSERT [dbo].[Departaments] ([DepartamentId], [Name]) VALUES (1, N'TMMM')
SET IDENTITY_INSERT [dbo].[Departaments] OFF
INSERT [dbo].[DepartamentsCourses] ([DepartamentId], [CourseId]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([FacultieId], [Name]) VALUES (1, N'MTT')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
INSERT [dbo].[FacultiesDepartaments] ([FacultieId], [DepartamentId]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([ProfessorId], [Name]) VALUES (1, N'Petkof')
SET IDENTITY_INSERT [dbo].[Professors] OFF
INSERT [dbo].[ProfessorsInDepartaments] ([DepartamentId], [ProfessorId]) VALUES (1, 1)
INSERT [dbo].[ProfessorTitles] ([TitleId], [ProfessorId]) VALUES (1, 1)
INSERT [dbo].[ProfessorTitles] ([TitleId], [ProfessorId]) VALUES (2, 1)
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [Name], [FacultieId]) VALUES (1, N'Koko', 1)
INSERT [dbo].[Students] ([StudentId], [Name], [FacultieId]) VALUES (2, N'Joko', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[StudentsInCourses] ([StudentId], [CourseId]) VALUES (1, 1)
INSERT [dbo].[StudentsInCourses] ([StudentId], [CourseId]) VALUES (2, 1)
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([TitleId], [TitleName]) VALUES (1, N'Profesor')
INSERT [dbo].[Titles] ([TitleId], [TitleName]) VALUES (2, N'Docent')
SET IDENTITY_INSERT [dbo].[Titles] OFF
ALTER TABLE [dbo].[DepartamentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentsCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[DepartamentsCourses] CHECK CONSTRAINT [FK_DepartamentsCourses_Courses]
GO
ALTER TABLE [dbo].[DepartamentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentsCourses_Departaments] FOREIGN KEY([DepartamentId])
REFERENCES [dbo].[Departaments] ([DepartamentId])
GO
ALTER TABLE [dbo].[DepartamentsCourses] CHECK CONSTRAINT [FK_DepartamentsCourses_Departaments]
GO
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Departaments] FOREIGN KEY([FacultieId])
REFERENCES [dbo].[Departaments] ([DepartamentId])
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Faculties] FOREIGN KEY([FacultieId])
REFERENCES [dbo].[Faculties] ([FacultieId])
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
ALTER TABLE [dbo].[ProfessorsCurses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsCurses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[ProfessorsCurses] CHECK CONSTRAINT [FK_ProfessorsCurses_Courses]
GO
ALTER TABLE [dbo].[ProfessorsCurses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsCurses_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([ProfessorId])
GO
ALTER TABLE [dbo].[ProfessorsCurses] CHECK CONSTRAINT [FK_ProfessorsCurses_Professors]
GO
ALTER TABLE [dbo].[ProfessorsInDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsInDepartaments_Departaments] FOREIGN KEY([DepartamentId])
REFERENCES [dbo].[Departaments] ([DepartamentId])
GO
ALTER TABLE [dbo].[ProfessorsInDepartaments] CHECK CONSTRAINT [FK_ProfessorsInDepartaments_Departaments]
GO
ALTER TABLE [dbo].[ProfessorsInDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorsInDepartaments_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([ProfessorId])
GO
ALTER TABLE [dbo].[ProfessorsInDepartaments] CHECK CONSTRAINT [FK_ProfessorsInDepartaments_Professors]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([ProfessorId])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Professors]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Titles] FOREIGN KEY([TitleId])
REFERENCES [dbo].[Titles] ([TitleId])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Titles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultieId])
REFERENCES [dbo].[Faculties] ([FacultieId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[StudentsInCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsInCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[StudentsInCourses] CHECK CONSTRAINT [FK_StudentsInCourses_Courses]
GO
ALTER TABLE [dbo].[StudentsInCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsInCourses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[StudentsInCourses] CHECK CONSTRAINT [FK_StudentsInCourses_Students]
GO
USE [master]
GO
ALTER DATABASE [StudentSystemHW] SET  READ_WRITE 
GO
