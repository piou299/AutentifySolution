USE [master]
GO
/****** Object:  Database [RamsesAuthentity]    Script Date: 24/10/2021 21:37:23 ******/
CREATE DATABASE [RamsesAuthentity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RamsesAuthentity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RamsesAuthentity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RamsesAuthentity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RamsesAuthentity_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RamsesAuthentity] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RamsesAuthentity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RamsesAuthentity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET ARITHABORT OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RamsesAuthentity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RamsesAuthentity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RamsesAuthentity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RamsesAuthentity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RamsesAuthentity] SET  MULTI_USER 
GO
ALTER DATABASE [RamsesAuthentity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RamsesAuthentity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RamsesAuthentity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RamsesAuthentity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RamsesAuthentity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RamsesAuthentity] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RamsesAuthentity] SET QUERY_STORE = OFF
GO
USE [RamsesAuthentity]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24/10/2021 21:37:23 ******/
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
/****** Object:  Table [dbo].[Agences]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agences](
	[AgenceId] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
	[Adresse] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[Image] [nvarchar](max) NULL,
	[VilleId] [int] NOT NULL,
	[SocieteId] [int] NOT NULL,
 CONSTRAINT [PK_Agences] PRIMARY KEY CLUSTERED 
(
	[AgenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Connexions]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Connexions](
	[ConnexionId] [int] IDENTITY(1,1) NOT NULL,
	[UtilisateurId] [int] NOT NULL,
	[DateHeure] [datetime2](7) NULL,
 CONSTRAINT [PK_Connexions] PRIMARY KEY CLUSTERED 
(
	[ConnexionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departements]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departements](
	[DepartementId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[DateEnregistremnt] [datetime2](7) NULL,
	[RegionId] [int] NOT NULL,
 CONSTRAINT [PK_Departements] PRIMARY KEY CLUSTERED 
(
	[DepartementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exercices]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exercices](
	[ExerciceId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[DateDebut] [datetime2](7) NULL,
	[DateFin] [datetime2](7) NULL,
	[Observation] [nvarchar](max) NOT NULL,
	[TauxTVA] [float] NULL,
	[Etat] [int] NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[AgenceId] [int] NOT NULL,
 CONSTRAINT [PK_Exercices] PRIMARY KEY CLUSTERED 
(
	[ExerciceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JourFeries]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JourFeries](
	[JourFeriesId] [int] IDENTITY(1,1) NOT NULL,
	[Jour] [int] NOT NULL,
	[Mois] [int] NOT NULL,
	[Frequence] [nvarchar](max) NOT NULL,
	[JourFerie] [nvarchar](max) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[Commentaire] [nvarchar](max) NULL,
 CONSTRAINT [PK_JourFeries] PRIMARY KEY CLUSTERED 
(
	[JourFeriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Langues]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Langues](
	[LangueId] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[Icone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Langues] PRIMARY KEY CLUSTERED 
(
	[LangueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monnaies]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monnaies](
	[MonnaieId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Suffixe] [nvarchar](max) NOT NULL,
	[Reference] [nvarchar](max) NOT NULL,
	[Parite] [nvarchar](max) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
 CONSTRAINT [PK_Monnaies] PRIMARY KEY CLUSTERED 
(
	[MonnaieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partenaires]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partenaires](
	[PartenaireId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Adresse] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[PaysId] [int] NOT NULL,
	[TypePartenaireId] [int] NOT NULL,
	[DateEnregistrement] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Partenaires] PRIMARY KEY CLUSTERED 
(
	[PartenaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passwords]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passwords](
	[PasswordId] [int] IDENTITY(1,1) NOT NULL,
	[Pass] [nvarchar](max) NOT NULL,
	[Etat] [int] NULL,
	[UtilisateurId] [int] NOT NULL,
 CONSTRAINT [PK_Passwords] PRIMARY KEY CLUSTERED 
(
	[PasswordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pays]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pays](
	[PaysId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[NomPays] [nvarchar](max) NOT NULL,
	[Indicatif] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pays] PRIMARY KEY CLUSTERED 
(
	[PaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periodes]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodes](
	[PeriodeId] [int] IDENTITY(1,1) NOT NULL,
	[DateDebut] [datetime2](7) NULL,
	[DateFin] [datetime2](7) NULL,
	[Etat] [int] NULL,
	[NumeroMois] [int] NOT NULL,
	[ExerciceId] [int] NOT NULL,
 CONSTRAINT [PK_Periodes] PRIMARY KEY CLUSTERED 
(
	[PeriodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnes]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnes](
	[PersonneId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](20) NOT NULL,
	[Prenom] [nvarchar](20) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Sexe] [int] NULL,
	[DateNaissance] [datetime2](7) NULL,
	[LieuNaissance] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
	[DateEnregistrement] [datetime2](7) NULL,
 CONSTRAINT [PK_Personnes] PRIMARY KEY CLUSTERED 
(
	[PersonneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[RegionId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[PaysId] [int] NOT NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocieteJourFeries]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocieteJourFeries](
	[SocieteJourFeriesId] [int] IDENTITY(1,1) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[SocieteId] [int] NOT NULL,
	[JourFeriesId] [int] NOT NULL,
	[MonnaieId] [int] NULL,
 CONSTRAINT [PK_SocieteJourFeries] PRIMARY KEY CLUSTERED 
(
	[SocieteJourFeriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocieteMonnaies]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocieteMonnaies](
	[SocieteMonnaieId] [int] IDENTITY(1,1) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[SocieteId] [int] NOT NULL,
	[MonnaieId] [int] NOT NULL,
 CONSTRAINT [PK_SocieteMonnaies] PRIMARY KEY CLUSTERED 
(
	[SocieteMonnaieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocietePartenaires]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocietePartenaires](
	[SocietePartenaireId] [int] IDENTITY(1,1) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[SocieteId] [int] NOT NULL,
	[PartenaireId] [int] NOT NULL,
 CONSTRAINT [PK_SocietePartenaires] PRIMARY KEY CLUSTERED 
(
	[SocietePartenaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Societes]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Societes](
	[SocieteId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Sigle] [nvarchar](max) NOT NULL,
	[DateCreation] [datetime2](7) NULL,
	[Adresse] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[Logo] [nvarchar](max) NULL,
	[DateEnregistrement] [datetime2](7) NULL,
 CONSTRAINT [PK_Societes] PRIMARY KEY CLUSTERED 
(
	[SocieteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypePartenaires]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypePartenaires](
	[TypePartenaireId] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TypePartenaires] PRIMARY KEY CLUSTERED 
(
	[TypePartenaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserRoleId] [int] IDENTITY(1,1) NOT NULL,
	[DateEnregistrement] [datetime2](7) NULL,
	[UtilisateurId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateurs]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateurs](
	[UtilisateurId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Etat] [int] NULL,
	[AgenceId] [int] NOT NULL,
	[PersonneId] [int] NOT NULL,
	[LangueId] [int] NOT NULL,
 CONSTRAINT [PK_Utilisateurs] PRIMARY KEY CLUSTERED 
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Villes]    Script Date: 24/10/2021 21:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Villes](
	[VilleId] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[RegionId] [int] NOT NULL,
 CONSTRAINT [PK_Villes] PRIMARY KEY CLUSTERED 
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210218173506_Db-Migration', N'5.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210218183257_Pays', N'5.0.3')
GO
SET IDENTITY_INSERT [dbo].[Agences] ON 

INSERT [dbo].[Agences] ([AgenceId], [Libelle], [Adresse], [Email], [DateCreation], [DateEnregistrement], [Image], [VilleId], [SocieteId]) VALUES (2, N'PH', N'4004 BONANJO', N'brissoh1@gmail.com', CAST(N'2021-03-09T17:55:13.1109663' AS DateTime2), CAST(N'2021-03-09T17:55:13.1112516' AS DateTime2), N'IMG_1615308913111_PH.png', 1, 9)
INSERT [dbo].[Agences] ([AgenceId], [Libelle], [Adresse], [Email], [DateCreation], [DateEnregistrement], [Image], [VilleId], [SocieteId]) VALUES (1002, N'PH', N'4004 BONANJO', N'brissoh1@gmail.com', CAST(N'2021-03-12T11:55:45.7144876' AS DateTime2), CAST(N'2021-03-12T11:55:45.7147369' AS DateTime2), NULL, 1, 9)
SET IDENTITY_INSERT [dbo].[Agences] OFF
GO
SET IDENTITY_INSERT [dbo].[Langues] ON 

INSERT [dbo].[Langues] ([LangueId], [Libelle], [DateEnregistrement], [Icone]) VALUES (7, N'Français', CAST(N'2021-03-05T17:27:20.8933474' AS DateTime2), N'IMG_1614961640895_FRANÇAIS.png')
INSERT [dbo].[Langues] ([LangueId], [Libelle], [DateEnregistrement], [Icone]) VALUES (8, N'Anglais', CAST(N'2021-03-05T17:27:35.7725299' AS DateTime2), N'IMG_1614961655772_ANGLAIS.png')
SET IDENTITY_INSERT [dbo].[Langues] OFF
GO
SET IDENTITY_INSERT [dbo].[Pays] ON 

INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (1, N'AF', N'Afghanistan', N'+93', N'AF.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (2, N'AL', N'Albanie', N'+355', N'AL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (3, N'AQ', N'Antarctique', N'+6721', N'AQ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (4, N'DZ', N'Algérie', N'+213	', N'DZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (5, N'AS', N'Samoa Américaines', N'+1 684', N'AS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (6, N'AD', N'Andorre', N'+376	', N'AD.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (7, N'AO', N'Angola', N'+244', N'AO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (8, N'AG', N'Antigua-et-Barbuda', N'+1 268', N'AG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (9, N'AZ', N'Azerbaïdjan', N'+994	', N'AZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (10, N'AR', N'Argentine', N'+54', N'AR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (11, N'AU', N'Australie', N'+61', N'AU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (12, N'AT', N'Autriche', N'+43', N'AT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (13, N'BS', N'Bahamas', N'+1 242', N'BS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (14, N'BH', N'Bahreïn', N'+973', N'BH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (15, N'BD', N'Bangladesh', N'+880', N'BD.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (16, N'AM', N'Arménie', N'+374	', N'AM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (17, N'BB', N'Barbade', N'+1 246', N'BB.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (18, N'BE', N'Belgique', N'+32', N'BE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (19, N'BM', N'Bermudes', N'+1 441', N'BM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (20, N'BT', N'Bhoutan', N'+975', N'BT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (21, N'BO', N'Bolivie', N'+591', N'BO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (22, N'BA', N'Bosnie-Herzégovine', N'+387', N'BA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (23, N'BW', N'Botswana', N'+267', N'BW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (24, N'BV', N'Île Bouvet', N'+00 ', N'BV.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (25, N'BR', N'Brésil', N'+55', N'BR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (26, N'BZ', N'Belize', N'+501', N'BZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (27, N'IO', N'Territoire Britannique de l''Océan Indien', N'+246', N'IO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (28, N'SB', N'Îles Salomon', N'+677', N'SB.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (29, N'VG', N'Îles Vierges Britanniques', N'+1', N'VG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (30, N'BN', N'Brunéi Darussalam', N'+673', N'BN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (31, N'BG', N'Bulgarie', N'+359', N'BG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (32, N'MM', N'Myanmar', N'+95', N'MM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (33, N'BI', N'Burundi', N'+257', N'BI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (34, N'BY', N'Bélarus', N'+375', N'BY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (35, N'KH', N'Cambodge', N'+855', N'KH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (36, N'CM', N'Cameroun', N'+237', N'CM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (37, N'CA', N'Canada', N'+1 581', N'CA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (38, N'CV', N'Cap-vert', N'+238', N'CV.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (39, N'KY', N'Îles Caïmanes', N'+345', N'KY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (40, N'RCA', N'République Centrafricaine', N'+236', N'RCA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (41, N'LK', N'Sri Lanka', N'+94', N'LK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (42, N'TD', N'Tchad', N'+235', N'TD.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (43, N'CL', N'Chili', N'+56', N'CL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (44, N'CN', N'Chine', N'+86', N'CN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (45, N'TW', N'Taïwan', N'+886', N'TW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (46, N'CX', N'Île Christmas', N'+61', N'CX.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (47, N'CC', N'Îles Cocos (Keeling)', N'+0061', N'CC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (48, N'CO', N'Colombie', N'+57', N'CO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (49, N'KM', N'Comores', N'+269', N'KM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (50, N'YT', N'Mayotte', N'+262', N'YT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (51, N'RC', N'République du Congo', N'+242', N'RC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (52, N'RDC', N'République Démocratique du Congo', N'+243', N'RDC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (53, N'CK', N'Îles Cook', N'+682', N'CK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (54, N'CR', N'Costa Rica', N'+506', N'CR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (55, N'HR', N'Croatie', N'+385', N'HR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (56, N'CU', N'Cuba', NULL, N'CU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (57, N'CY', N'Chypre', NULL, N'CY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (58, N'CZ', N'République Tchèque', NULL, N'CZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (59, N'BJ', N'Bénin', NULL, N'BJ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (60, N'DK', N'Danemark', NULL, N'DK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (61, N'DM', N'Dominique', NULL, N'DM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (62, N'DO', N'République Dominicaine', NULL, N'DO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (63, N'EC', N'Équateur', NULL, N'EC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (64, N'SV', N'El Salvador', NULL, N'SV.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (65, N'GQ', N'Guinée Équatoriale', NULL, N'GQ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (66, N'ET', N'Éthiopie', NULL, N'ET.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (67, N'ER', N'Érythrée', NULL, N'ER.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (68, N'EE', N'Estonie', NULL, N'EE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (69, N'FO', N'Îles Féroé', NULL, N'FO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (70, N'FK', N'Îles (malvinas) Falkland', NULL, N'FK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (71, N'GS', N'Géorgie du Sud et les Îles Sandwich du Sud', NULL, N'GS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (72, N'FJ', N'Fidji', NULL, N'FJ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (73, N'FI', N'Finlande', NULL, N'FI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (74, N'AX', N'Îles Åland', NULL, N'AX.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (75, N'FR', N'France', NULL, N'FR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (76, N'GF', N'Guyane Française', NULL, N'GF.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (77, N'PF', N'Polynésie Française', NULL, N'PF.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (78, N'TF', N'Terres Australes Françaises', NULL, N'TF.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (79, N'DJ', N'Djibouti', NULL, N'DJ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (80, N'GA', N'Gabon', NULL, N'GA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (81, N'GE', N'Géorgie', NULL, N'GE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (82, N'GM', N'Gambie', NULL, N'GM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (83, N'PS', N'Territoire Palestinien Occupé', NULL, N'PS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (84, N'DE', N'Allemagne', NULL, N'DE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (85, N'GH', N'Ghana', NULL, N'GH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (86, N'GI', N'Gibraltar', NULL, N'GI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (87, N'KI', N'Kiribati', NULL, N'KI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (88, N'GR', N'Grèce', NULL, N'GR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (89, N'GL', N'Groenland', NULL, N'GL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (90, N'GD', N'Grenade', NULL, N'GD.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (91, N'GP', N'Guadeloupe', NULL, N'GP.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (92, N'GU', N'Guam', NULL, N'GU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (93, N'GT', N'Guatemala', NULL, N'GT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (94, N'GN', N'Guinée', NULL, N'GN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (95, N'GY', N'Guyana', NULL, N'GY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (96, N'HT', N'Haïti', NULL, N'HT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (97, N'HM', N'Îles Heard et Mcdonald', NULL, N'HM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (98, N'VA', N'Saint-Siège (état de la Cité du Vatican)', NULL, N'VA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (99, N'HN', N'Honduras', NULL, N'HN.PNG')
GO
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (100, N'HK', N'Hong-Kong', NULL, N'HK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (101, N'HU', N'Hongrie', NULL, N'HU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (102, N'IS', N'Islande', NULL, N'IS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (103, N'IN', N'Inde', NULL, N'IN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (104, N'ID', N'Indonésie', NULL, N'ID.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (105, N'IR', N'République Islamique d''Iran', NULL, N'IR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (106, N'IQ', N'Iraq', NULL, N'IQ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (107, N'IE', N'Irlande', NULL, N'IE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (108, N'IL', N'Israël', NULL, N'IL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (109, N'IT', N'Italie', NULL, N'IT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (110, N'CI', N'Côte d''Ivoire', NULL, N'CI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (111, N'JM', N'Jamaïque', NULL, N'JM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (112, N'JP', N'Japon', NULL, N'JP.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (113, N'KZ', N'Kazakhstan', NULL, N'KZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (114, N'JO', N'Jordanie', NULL, N'JO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (115, N'KE', N'Kenya', NULL, N'KE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (116, N'KP', N'République Populaire Démocratique de Corée', NULL, N'KP.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (117, N'KR', N'République de Corée', NULL, N'KR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (118, N'KW', N'Koweït', NULL, N'KW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (119, N'KG', N'Kirghizistan', NULL, N'KG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (120, N'LA', N'République Démocratique Populaire Lao', NULL, N'LA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (121, N'LB', N'Liban', NULL, N'LB.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (122, N'LS', N'Lesotho', NULL, N'LS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (123, N'LV', N'Lettonie', NULL, N'LV.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (124, N'LR', N'Libéria', NULL, N'LR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (125, N'LY', N'Jamahiriya Arabe Libyenne', NULL, N'LY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (126, N'LI', N'Liechtenstein', NULL, N'LI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (127, N'LT', N'Lituanie', NULL, N'LT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (128, N'LU', N'Luxembourg', NULL, N'LU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (129, N'MO', N'Macao', NULL, N'MO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (130, N'MG', N'Madagascar', NULL, N'MG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (131, N'MW', N'Malawi', NULL, N'MW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (132, N'MY', N'Malaisie', NULL, N'MY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (133, N'MV', N'Maldives', NULL, N'MV.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (134, N'ML', N'Mali', NULL, N'ML.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (135, N'MT', N'Malte', NULL, N'MT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (136, N'MQ', N'Martinique', NULL, N'MQ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (137, N'MR', N'Mauritanie', NULL, N'MR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (138, N'MU', N'Maurice', NULL, N'MU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (139, N'MX', N'Mexique', NULL, N'MX.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (140, N'MC', N'Monaco', NULL, N'MC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (141, N'MN', N'Mongolie', NULL, N'MN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (142, N'MD', N'République de Moldova', NULL, N'MD.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (143, N'MS', N'Montserrat', NULL, N'MS.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (144, N'MA', N'Maroc', NULL, N'MA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (145, N'MZ', N'Mozambique', NULL, N'MZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (146, N'OM', N'Oman', NULL, N'OM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (147, N'NA', N'Namibie', NULL, N'NA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (148, N'NR', N'Nauru', NULL, N'NR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (149, N'NP', N'Népal', NULL, N'NP.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (150, N'NL', N'Pays-Bas', NULL, N'NL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (151, N'AN', N'Antilles Néerlandaises', NULL, N'AN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (152, N'AW', N'Aruba', NULL, N'AW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (153, N'NC', N'Nouvelle-Calédonie', NULL, N'NC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (154, N'VU', N'Vanuatu', NULL, N'VU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (155, N'NZ', N'Nouvelle-Zélande', NULL, N'NZ.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (156, N'NI', N'Nicaragua', NULL, N'NI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (157, N'NE', N'Niger', NULL, N'NE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (158, N'NG', N'Nigéria', NULL, N'NG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (159, N'NU', N'Niué', NULL, N'NU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (160, N'NF', N'Île Norfolk', NULL, N'NF.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (161, N'NO', N'Norvège', NULL, N'NO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (162, N'MP', N'Îles Mariannes du Nord', NULL, N'MP.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (163, N'UM', N'Îles Mineures Éloignées des États-Unis', NULL, N'UM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (164, N'FM', N'États Fédérés de Micronésie', NULL, N'FM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (165, N'MH', N'Îles Marshall', NULL, N'MH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (166, N'PW', N'Palaos', NULL, N'PW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (167, N'PK', N'Pakistan', NULL, N'PK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (168, N'PA', N'Panama', NULL, N'PA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (169, N'PG', N'Papouasie-Nouvelle-Guinée', NULL, N'PG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (170, N'PY', N'Paraguay', NULL, N'PY.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (171, N'PE', N'Pérou', NULL, N'PE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (172, N'PH', N'Philippines', NULL, N'PH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (173, N'PN', N'Pitcairn', NULL, N'PN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (174, N'PL', N'Pologne', NULL, N'PL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (175, N'PT', N'Portugal', NULL, N'PT.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (176, N'GW', N'Guinée-Bissau', NULL, N'GW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (177, N'TL', N'Timor-Leste', NULL, N'TL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (178, N'PR', N'Porto Rico', NULL, N'PR.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (179, N'QA', N'Qatar', NULL, N'QA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (180, N'RE', N'Réunion', NULL, N'RE.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (181, N'RO', N'Roumanie', NULL, N'RO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (182, N'RU', N'Fédération de Russie', NULL, N'RU.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (183, N'RW', N'Rwanda', NULL, N'RW.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (184, N'SH', N'Sainte-Hélène', NULL, N'SH.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (185, N'KN', N'Saint-Kitts-et-Nevis', NULL, N'KN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (186, N'AI', N'Anguilla', NULL, N'AI.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (187, N'LC', N'Sainte-Lucie', NULL, N'LC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (188, N'PM', N'Saint-Pierre-et-Miquelon', NULL, N'PM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (189, N'VC', N'Saint-Vincent-et-les Grenadines', NULL, N'VC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (190, N'SM', N'Saint-Marin', NULL, N'SM.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (191, N'ST', N'Sao Tomé-et-Principe', NULL, N'ST.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (192, N'SA', N'Arabie Saoudite', NULL, N'SA.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (193, N'SN', N'Sénégal', NULL, N'SN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (194, N'SC', N'Seychelles', NULL, N'SC.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (195, N'SL', N'Sierra Leone', NULL, N'SL.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (196, N'SG', N'Singapour', NULL, N'SG.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (197, N'SK', N'Slovaquie', NULL, N'SK.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (198, N'VN', N'Viet Nam', NULL, N'VN.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (199, N'SI', N'Slovénie', NULL, N'SI.PNG')
GO
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (200, N'SO', N'Somalie', NULL, N'SO.PNG')
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (201, N'ZA', N'Afrique du Sud', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (202, N'ZW', N'Zimbabwe', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (203, N'ES', N'Espagne', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (204, N'EH', N'Sahara Occidental', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (205, N'SD', N'Soudan', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (206, N'SR', N'Suriname', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (207, N'SJ', N'Svalbard etÎle Jan Mayen', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (208, N'SZ', N'Swaziland', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (209, N'SE', N'Suède', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (210, N'CH', N'Suisse', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (211, N'SY', N'République Arabe Syrienne', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (212, N'TJ', N'Tadjikistan', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (213, N'TH', N'Thaïlande', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (214, N'TG', N'Togo', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (215, N'TK', N'Tokelau', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (216, N'TO', N'Tonga', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (217, N'TT', N'Trinité-et-Tobago', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (218, N'AE', N'Émirats Arabes Unis', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (219, N'TN', N'Tunisie', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (220, N'TR', N'Turquie', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (221, N'TM', N'Turkménistan', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (222, N'TC', N'Îles Turks et Caïques', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (223, N'TV', N'Tuvalu', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (224, N'UG', N'Ouganda', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (225, N'UA', N'Ukraine', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (226, N'MK', N'L''ex-République Yougoslave de Macédoine', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (227, N'EG', N'Égypte', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (228, N'GB', N'Royaume-Uni', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (229, N'IM', N'Île de Man', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (230, N'TZ', N'République-Unie de Tanzanie', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (231, N'US', N'États-Unis', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (232, N'VI', N'Îles Vierges des États-Unis', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (233, N'BF', N'Burkina Faso', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (234, N'UY', N'Uruguay', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (235, N'UZ', N'Ouzbékistan', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (236, N'VE', N'Venezuela', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (237, N'WF', N'Wallis et Futuna', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (238, N'WS', N'Samoa', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (239, N'YE', N'Yémen', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (240, N'CS', N'Serbie-et-Monténégro', NULL, NULL)
INSERT [dbo].[Pays] ([PaysId], [Code], [NomPays], [Indicatif], [Logo]) VALUES (241, N'ZM', N'Zambie', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Pays] OFF
GO
SET IDENTITY_INSERT [dbo].[Personnes] ON 

INSERT [dbo].[Personnes] ([PersonneId], [Nom], [Prenom], [Telephone], [Email], [Sexe], [DateNaissance], [LieuNaissance], [Photo], [DateEnregistrement]) VALUES (1, N'NENDA', N'SOH', N'+237694767718', N'brissoh1@gmail.com', 0, CAST(N'2021-03-18T15:34:37.4438058' AS DateTime2), N'Bandjoun', N'IMG_1616078077444_NENDA.jpg', CAST(N'2021-03-18T15:34:37.4440160' AS DateTime2))
INSERT [dbo].[Personnes] ([PersonneId], [Nom], [Prenom], [Telephone], [Email], [Sexe], [DateNaissance], [LieuNaissance], [Photo], [DateEnregistrement]) VALUES (2, N'NENDA', N'SOH', N'+237694767718', N'brissoh1@gmail.com', 0, CAST(N'2021-03-18T15:38:37.4241729' AS DateTime2), N'Bandjoun', N'IMG_1616078317424_NENDA.jpg', CAST(N'2021-03-18T15:38:37.4244041' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Personnes] OFF
GO
SET IDENTITY_INSERT [dbo].[Regions] ON 

INSERT [dbo].[Regions] ([RegionId], [Nom], [DateEnregistrement], [PaysId]) VALUES (5, N'Ouest', CAST(N'2021-03-04T16:57:48.0672598' AS DateTime2), 36)
INSERT [dbo].[Regions] ([RegionId], [Nom], [DateEnregistrement], [PaysId]) VALUES (6, N'Centre', CAST(N'2021-03-04T18:58:03.2481382' AS DateTime2), 36)
INSERT [dbo].[Regions] ([RegionId], [Nom], [DateEnregistrement], [PaysId]) VALUES (14, N'Leonnel', CAST(N'2021-03-04T22:05:18.3681805' AS DateTime2), 18)
SET IDENTITY_INSERT [dbo].[Regions] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [Libelle]) VALUES (1, N'Administrateur')
INSERT [dbo].[Roles] ([RoleId], [Libelle]) VALUES (2, N'Utilisateur')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Societes] ON 

INSERT [dbo].[Societes] ([SocieteId], [Nom], [Sigle], [DateCreation], [Adresse], [Email], [Telephone], [Logo], [DateEnregistrement]) VALUES (9, N'Sécurité électronique', N'SECEL', CAST(N'2021-03-08T16:35:43.4718085' AS DateTime2), N'BP : 104', N'info@secelgroup.com', N'+33694399157', N'IMG_1615217497791_SÉCURITÉ ÉLECTRONIQUE.png', CAST(N'2021-03-08T16:35:43.4718157' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Societes] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([UserRoleId], [DateEnregistrement], [UtilisateurId], [RoleId]) VALUES (1, CAST(N'2021-03-18T15:38:38.0882952' AS DateTime2), 3, 1)
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[Utilisateurs] ON 

INSERT [dbo].[Utilisateurs] ([UtilisateurId], [Login], [Etat], [AgenceId], [PersonneId], [LangueId]) VALUES (3, N'Hn', NULL, 2, 2, 7)
SET IDENTITY_INSERT [dbo].[Utilisateurs] OFF
GO
SET IDENTITY_INSERT [dbo].[Villes] ON 

INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (1, N'Douala', 6)
INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (2, N'Youndé', 5)
INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (3, N'Youndé 2', 5)
INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (4, N'Youndé 22', 5)
INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (5, N'Youndé 22', 5)
INSERT [dbo].[Villes] ([VilleId], [Nom], [RegionId]) VALUES (6, N'Youndé 25', 6)
SET IDENTITY_INSERT [dbo].[Villes] OFF
GO
/****** Object:  Index [IX_Agences_SocieteId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Agences_SocieteId] ON [dbo].[Agences]
(
	[SocieteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Agences_VilleId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Agences_VilleId] ON [dbo].[Agences]
(
	[VilleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Connexions_UtilisateurId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Connexions_UtilisateurId] ON [dbo].[Connexions]
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Departements_RegionId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Departements_RegionId] ON [dbo].[Departements]
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exercices_AgenceId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Exercices_AgenceId] ON [dbo].[Exercices]
(
	[AgenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Partenaires_PaysId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Partenaires_PaysId] ON [dbo].[Partenaires]
(
	[PaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Partenaires_TypePartenaireId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Partenaires_TypePartenaireId] ON [dbo].[Partenaires]
(
	[TypePartenaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Passwords_UtilisateurId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Passwords_UtilisateurId] ON [dbo].[Passwords]
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Periodes_ExerciceId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Periodes_ExerciceId] ON [dbo].[Periodes]
(
	[ExerciceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Regions_PaysId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Regions_PaysId] ON [dbo].[Regions]
(
	[PaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocieteJourFeries_JourFeriesId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocieteJourFeries_JourFeriesId] ON [dbo].[SocieteJourFeries]
(
	[JourFeriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocieteJourFeries_MonnaieId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocieteJourFeries_MonnaieId] ON [dbo].[SocieteJourFeries]
(
	[MonnaieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocieteJourFeries_SocieteId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocieteJourFeries_SocieteId] ON [dbo].[SocieteJourFeries]
(
	[SocieteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocieteMonnaies_MonnaieId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocieteMonnaies_MonnaieId] ON [dbo].[SocieteMonnaies]
(
	[MonnaieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocieteMonnaies_SocieteId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocieteMonnaies_SocieteId] ON [dbo].[SocieteMonnaies]
(
	[SocieteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocietePartenaires_PartenaireId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocietePartenaires_PartenaireId] ON [dbo].[SocietePartenaires]
(
	[PartenaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SocietePartenaires_SocieteId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_SocietePartenaires_SocieteId] ON [dbo].[SocietePartenaires]
(
	[SocieteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoles_UtilisateurId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_UtilisateurId] ON [dbo].[UserRoles]
(
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Utilisateurs_AgenceId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Utilisateurs_AgenceId] ON [dbo].[Utilisateurs]
(
	[AgenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Utilisateurs_LangueId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Utilisateurs_LangueId] ON [dbo].[Utilisateurs]
(
	[LangueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Utilisateurs_PersonneId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Utilisateurs_PersonneId] ON [dbo].[Utilisateurs]
(
	[PersonneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Villes_RegionId]    Script Date: 24/10/2021 21:37:25 ******/
CREATE NONCLUSTERED INDEX [IX_Villes_RegionId] ON [dbo].[Villes]
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agences]  WITH CHECK ADD  CONSTRAINT [FK_Agences_Societes_SocieteId] FOREIGN KEY([SocieteId])
REFERENCES [dbo].[Societes] ([SocieteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Agences] CHECK CONSTRAINT [FK_Agences_Societes_SocieteId]
GO
ALTER TABLE [dbo].[Agences]  WITH CHECK ADD  CONSTRAINT [FK_Agences_Villes_VilleId] FOREIGN KEY([VilleId])
REFERENCES [dbo].[Villes] ([VilleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Agences] CHECK CONSTRAINT [FK_Agences_Villes_VilleId]
GO
ALTER TABLE [dbo].[Connexions]  WITH CHECK ADD  CONSTRAINT [FK_Connexions_Utilisateurs_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateurs] ([UtilisateurId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Connexions] CHECK CONSTRAINT [FK_Connexions_Utilisateurs_UtilisateurId]
GO
ALTER TABLE [dbo].[Departements]  WITH CHECK ADD  CONSTRAINT [FK_Departements_Regions_RegionId] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Regions] ([RegionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departements] CHECK CONSTRAINT [FK_Departements_Regions_RegionId]
GO
ALTER TABLE [dbo].[Exercices]  WITH CHECK ADD  CONSTRAINT [FK_Exercices_Agences_AgenceId] FOREIGN KEY([AgenceId])
REFERENCES [dbo].[Agences] ([AgenceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exercices] CHECK CONSTRAINT [FK_Exercices_Agences_AgenceId]
GO
ALTER TABLE [dbo].[Partenaires]  WITH CHECK ADD  CONSTRAINT [FK_Partenaires_Pays_PaysId] FOREIGN KEY([PaysId])
REFERENCES [dbo].[Pays] ([PaysId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Partenaires] CHECK CONSTRAINT [FK_Partenaires_Pays_PaysId]
GO
ALTER TABLE [dbo].[Partenaires]  WITH CHECK ADD  CONSTRAINT [FK_Partenaires_TypePartenaires_TypePartenaireId] FOREIGN KEY([TypePartenaireId])
REFERENCES [dbo].[TypePartenaires] ([TypePartenaireId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Partenaires] CHECK CONSTRAINT [FK_Partenaires_TypePartenaires_TypePartenaireId]
GO
ALTER TABLE [dbo].[Passwords]  WITH CHECK ADD  CONSTRAINT [FK_Passwords_Utilisateurs_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateurs] ([UtilisateurId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Passwords] CHECK CONSTRAINT [FK_Passwords_Utilisateurs_UtilisateurId]
GO
ALTER TABLE [dbo].[Periodes]  WITH CHECK ADD  CONSTRAINT [FK_Periodes_Exercices_ExerciceId] FOREIGN KEY([ExerciceId])
REFERENCES [dbo].[Exercices] ([ExerciceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Periodes] CHECK CONSTRAINT [FK_Periodes_Exercices_ExerciceId]
GO
ALTER TABLE [dbo].[Regions]  WITH CHECK ADD  CONSTRAINT [FK_Regions_Pays_PaysId] FOREIGN KEY([PaysId])
REFERENCES [dbo].[Pays] ([PaysId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Regions] CHECK CONSTRAINT [FK_Regions_Pays_PaysId]
GO
ALTER TABLE [dbo].[SocieteJourFeries]  WITH CHECK ADD  CONSTRAINT [FK_SocieteJourFeries_JourFeries_JourFeriesId] FOREIGN KEY([JourFeriesId])
REFERENCES [dbo].[JourFeries] ([JourFeriesId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocieteJourFeries] CHECK CONSTRAINT [FK_SocieteJourFeries_JourFeries_JourFeriesId]
GO
ALTER TABLE [dbo].[SocieteJourFeries]  WITH CHECK ADD  CONSTRAINT [FK_SocieteJourFeries_Monnaies_MonnaieId] FOREIGN KEY([MonnaieId])
REFERENCES [dbo].[Monnaies] ([MonnaieId])
GO
ALTER TABLE [dbo].[SocieteJourFeries] CHECK CONSTRAINT [FK_SocieteJourFeries_Monnaies_MonnaieId]
GO
ALTER TABLE [dbo].[SocieteJourFeries]  WITH CHECK ADD  CONSTRAINT [FK_SocieteJourFeries_Societes_SocieteId] FOREIGN KEY([SocieteId])
REFERENCES [dbo].[Societes] ([SocieteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocieteJourFeries] CHECK CONSTRAINT [FK_SocieteJourFeries_Societes_SocieteId]
GO
ALTER TABLE [dbo].[SocieteMonnaies]  WITH CHECK ADD  CONSTRAINT [FK_SocieteMonnaies_Monnaies_MonnaieId] FOREIGN KEY([MonnaieId])
REFERENCES [dbo].[Monnaies] ([MonnaieId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocieteMonnaies] CHECK CONSTRAINT [FK_SocieteMonnaies_Monnaies_MonnaieId]
GO
ALTER TABLE [dbo].[SocieteMonnaies]  WITH CHECK ADD  CONSTRAINT [FK_SocieteMonnaies_Societes_SocieteId] FOREIGN KEY([SocieteId])
REFERENCES [dbo].[Societes] ([SocieteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocieteMonnaies] CHECK CONSTRAINT [FK_SocieteMonnaies_Societes_SocieteId]
GO
ALTER TABLE [dbo].[SocietePartenaires]  WITH CHECK ADD  CONSTRAINT [FK_SocietePartenaires_Partenaires_PartenaireId] FOREIGN KEY([PartenaireId])
REFERENCES [dbo].[Partenaires] ([PartenaireId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocietePartenaires] CHECK CONSTRAINT [FK_SocietePartenaires_Partenaires_PartenaireId]
GO
ALTER TABLE [dbo].[SocietePartenaires]  WITH CHECK ADD  CONSTRAINT [FK_SocietePartenaires_Societes_SocieteId] FOREIGN KEY([SocieteId])
REFERENCES [dbo].[Societes] ([SocieteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocietePartenaires] CHECK CONSTRAINT [FK_SocietePartenaires_Societes_SocieteId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Utilisateurs_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateurs] ([UtilisateurId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Utilisateurs_UtilisateurId]
GO
ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateurs_Agences_AgenceId] FOREIGN KEY([AgenceId])
REFERENCES [dbo].[Agences] ([AgenceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [FK_Utilisateurs_Agences_AgenceId]
GO
ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateurs_Langues_LangueId] FOREIGN KEY([LangueId])
REFERENCES [dbo].[Langues] ([LangueId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [FK_Utilisateurs_Langues_LangueId]
GO
ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateurs_Personnes_PersonneId] FOREIGN KEY([PersonneId])
REFERENCES [dbo].[Personnes] ([PersonneId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [FK_Utilisateurs_Personnes_PersonneId]
GO
ALTER TABLE [dbo].[Villes]  WITH CHECK ADD  CONSTRAINT [FK_Villes_Regions_RegionId] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Regions] ([RegionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Villes] CHECK CONSTRAINT [FK_Villes_Regions_RegionId]
GO
USE [master]
GO
ALTER DATABASE [RamsesAuthentity] SET  READ_WRITE 
GO
