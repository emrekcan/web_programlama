USE [master]
GO
/****** Object:  Database [Forum]    Script Date: 13.12.2020 19:33:35 ******/
CREATE DATABASE [Forum]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Forum', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.EMRE\MSSQL\DATA\Forum.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Forum_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.EMRE\MSSQL\DATA\Forum_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Forum] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Forum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Forum] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Forum] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Forum] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Forum] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Forum] SET ARITHABORT OFF 
GO
ALTER DATABASE [Forum] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Forum] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Forum] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Forum] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Forum] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Forum] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Forum] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Forum] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Forum] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Forum] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Forum] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Forum] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Forum] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Forum] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Forum] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Forum] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Forum] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Forum] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Forum] SET  MULTI_USER 
GO
ALTER DATABASE [Forum] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Forum] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Forum] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Forum] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Forum] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Forum] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Forum] SET QUERY_STORE = OFF
GO
USE [Forum]
GO
/****** Object:  Table [dbo].[etiket]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[etiket](
	[id] [int] NOT NULL,
	[title] [varchar](50) NOT NULL,
	[metaTitle] [varchar](50) NOT NULL,
	[urlTitle] [varchar](50) NOT NULL,
 CONSTRAINT [PK_etiket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kategori]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategori](
	[id] [int] NOT NULL,
	[title] [varchar](50) NULL,
	[urlTitle] [varchar](50) NULL,
	[metaTitle] [varchar](50) NULL,
 CONSTRAINT [PK_kategori] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[id] [int] NOT NULL,
	[yetkiID] [int] NOT NULL,
	[isim] [varchar](50) NOT NULL,
	[soyisim] [varchar](50) NOT NULL,
	[kullaniciadi] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[passwordHash] [varchar](32) NOT NULL,
	[kayitTarihi] [datetime] NOT NULL,
	[sonGirisTarihi] [datetime] NOT NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[yazarID] [int] NOT NULL,
	[yorumID] [int] NOT NULL,
	[kategoriID] [int] NULL,
	[title] [varchar](50) NOT NULL,
	[urlTitle] [varchar](100) NOT NULL,
	[image] [image] NULL,
	[olusturmaTarihi] [datetime] NOT NULL,
	[guncellemeTarihi] [datetime] NULL,
	[icerik] [text] NOT NULL,
 CONSTRAINT [PK_post] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post_comment]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_comment](
	[id] [int] NOT NULL,
	[postID] [int] NOT NULL,
	[image] [image] NULL,
	[olusturmaTarihi] [datetime] NOT NULL,
	[guncellemeTarihi] [datetime] NULL,
	[icerik] [text] NULL,
	[metatitle] [varchar](50) NULL,
 CONSTRAINT [PK_post_comment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post_etiket]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_etiket](
	[postId] [int] NULL,
	[tagId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post_kategori]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_kategori](
	[postId] [int] NULL,
	[kategoriId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post_meta]    Script Date: 13.12.2020 19:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_meta](
	[id] [int] NOT NULL,
	[postId] [int] NULL,
	[key] [varchar](50) NULL,
	[content] [text] NULL,
 CONSTRAINT [PK_post_meta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[kategori]  WITH CHECK ADD  CONSTRAINT [FK_kategori_kategori] FOREIGN KEY([id])
REFERENCES [dbo].[kategori] ([id])
GO
ALTER TABLE [dbo].[kategori] CHECK CONSTRAINT [FK_kategori_kategori]
GO
ALTER TABLE [dbo].[post]  WITH CHECK ADD  CONSTRAINT [FK_post_kullanici] FOREIGN KEY([yazarID])
REFERENCES [dbo].[kullanici] ([id])
GO
ALTER TABLE [dbo].[post] CHECK CONSTRAINT [FK_post_kullanici]
GO
ALTER TABLE [dbo].[post]  WITH CHECK ADD  CONSTRAINT [FK_post_post] FOREIGN KEY([id])
REFERENCES [dbo].[post] ([id])
GO
ALTER TABLE [dbo].[post] CHECK CONSTRAINT [FK_post_post]
GO
ALTER TABLE [dbo].[post_comment]  WITH CHECK ADD  CONSTRAINT [FK_post_comment_post] FOREIGN KEY([postID])
REFERENCES [dbo].[post] ([id])
GO
ALTER TABLE [dbo].[post_comment] CHECK CONSTRAINT [FK_post_comment_post]
GO
ALTER TABLE [dbo].[post_comment]  WITH CHECK ADD  CONSTRAINT [FK_post_comment_post_comment] FOREIGN KEY([id])
REFERENCES [dbo].[post_comment] ([id])
GO
ALTER TABLE [dbo].[post_comment] CHECK CONSTRAINT [FK_post_comment_post_comment]
GO
ALTER TABLE [dbo].[post_etiket]  WITH CHECK ADD  CONSTRAINT [FK_post_etiket_etiket] FOREIGN KEY([tagId])
REFERENCES [dbo].[etiket] ([id])
GO
ALTER TABLE [dbo].[post_etiket] CHECK CONSTRAINT [FK_post_etiket_etiket]
GO
ALTER TABLE [dbo].[post_etiket]  WITH CHECK ADD  CONSTRAINT [FK_post_etiket_post] FOREIGN KEY([postId])
REFERENCES [dbo].[post] ([id])
GO
ALTER TABLE [dbo].[post_etiket] CHECK CONSTRAINT [FK_post_etiket_post]
GO
ALTER TABLE [dbo].[post_kategori]  WITH CHECK ADD  CONSTRAINT [FK_post_kategori_kategori] FOREIGN KEY([postId])
REFERENCES [dbo].[kategori] ([id])
GO
ALTER TABLE [dbo].[post_kategori] CHECK CONSTRAINT [FK_post_kategori_kategori]
GO
ALTER TABLE [dbo].[post_kategori]  WITH CHECK ADD  CONSTRAINT [FK_post_kategori_post] FOREIGN KEY([postId])
REFERENCES [dbo].[post] ([id])
GO
ALTER TABLE [dbo].[post_kategori] CHECK CONSTRAINT [FK_post_kategori_post]
GO
ALTER TABLE [dbo].[post_meta]  WITH CHECK ADD  CONSTRAINT [FK_post_meta_post] FOREIGN KEY([postId])
REFERENCES [dbo].[post] ([id])
GO
ALTER TABLE [dbo].[post_meta] CHECK CONSTRAINT [FK_post_meta_post]
GO
USE [master]
GO
ALTER DATABASE [Forum] SET  READ_WRITE 
GO
