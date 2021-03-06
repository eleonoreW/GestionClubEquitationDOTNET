USE [master]
GO
/****** Object:  Database [BDClubEquitation]    Script Date: 15/04/2019 10:47:30 ******/
CREATE DATABASE [BDClubEquitation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDClubEquitation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDClubEquitation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDClubEquitation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDClubEquitation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDClubEquitation] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDClubEquitation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDClubEquitation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDClubEquitation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDClubEquitation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDClubEquitation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDClubEquitation] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDClubEquitation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDClubEquitation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDClubEquitation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDClubEquitation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDClubEquitation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDClubEquitation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDClubEquitation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDClubEquitation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDClubEquitation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDClubEquitation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDClubEquitation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDClubEquitation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDClubEquitation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDClubEquitation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDClubEquitation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDClubEquitation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDClubEquitation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDClubEquitation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDClubEquitation] SET  MULTI_USER 
GO
ALTER DATABASE [BDClubEquitation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDClubEquitation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDClubEquitation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDClubEquitation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDClubEquitation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDClubEquitation] SET QUERY_STORE = OFF
GO
USE [BDClubEquitation]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/04/2019 10:47:30 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Activite]    Script Date: 15/04/2019 10:47:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activite](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProfesseurID] [nvarchar](450) NOT NULL,
	[LieuID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[Nom] [varchar](255) NULL,
	[Commentaire] [varchar](255) NULL,
	[Details] [varchar](255) NULL,
	[Date] [date] NOT NULL,
	[Duree] [int] NOT NULL,
	[Capacite] [int] NOT NULL,
	[EstActive] [bit] NOT NULL,
	[SearchString] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15/04/2019 10:47:31 ******/
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
	[Nom] [nvarchar](max) NULL,
	[Prenom] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 15/04/2019 10:47:31 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cheval]    Script Date: 15/04/2019 10:47:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cheval](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProprietaireID] [nvarchar](450) NOT NULL,
	[RaceID] [int] NOT NULL,
	[Nom] [varchar](255) NOT NULL,
	[DateNaissance] [date] NOT NULL,
	[Descriptif] [varchar](255) NULL,
	[Commentaire] [varchar](255) NULL,
	[NbHeureMaxSemaine] [int] NOT NULL,
	[Taille] [int] NOT NULL,
	[SearchString] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cheval_Activite]    Script Date: 15/04/2019 10:47:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cheval_Activite](
	[ChevalID] [int] NOT NULL,
	[ActiviteID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ChevalID] ASC,
	[ActiviteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubEquitationUser]    Script Date: 15/04/2019 10:47:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubEquitationUser](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[NormalizedUserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[NormalizedEmail] [nvarchar](max) NULL,
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
	[Prenom] [nvarchar](max) NULL,
	[Nom] [nvarchar](max) NULL,
 CONSTRAINT [PK_ClubEquitationUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lieu]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
	[Capacite] [int] NOT NULL,
	[Descriptif] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Race]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Race](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[NbPersonne] [int] NOT NULL,
	[EstActive] [bit] NOT NULL,
	[UtilisateurID] [nvarchar](450) NOT NULL,
	[ActiviteID] [int] NOT NULL,
	[SearchString] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](255) NULL,
	[Descriptif] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP PROCEDURE IF EXISTS [dbo].[Cheval_UpdateSearchString]
GO
DROP PROCEDURE IF EXISTS [dbo].[Activite_UpdateSearchString]
GO
DROP TRIGGER IF EXISTS [dbo].[Activite_Trigger_Update]
GO
DROP TRIGGER IF EXISTS [dbo].[Cheval_Trigger_Update]
GO
CREATE PROCEDURE [dbo].[Cheval_UpdateSearchString]
    @ID INTEGER
AS
BEGIN
    UPDATE Cheval SET  
	Cheval.SearchString = Cheval.Nom + ' ' + Cheval.Descriptif + ' ' + Cheval.Commentaire + ' ' + Race.Nom + ' ' + AspNetUsers.UserName
	FROM Cheval 
	INNER JOIN Race ON Cheval.RaceID = Race.ID
	INNER JOIN AspNetUsers ON Cheval.ProprietaireID = AspNetUsers.Id
	WHERE Cheval.ID = @ID 
END
GO

CREATE PROCEDURE [dbo].[Activite_UpdateSearchString]
    @ID INTEGER
AS
BEGIN
    UPDATE Activite SET  
	Activite.SearchString = Activite.Nom + ' ' + Activite.Commentaire + ' ' + Lieu.Nom +' ' + Type.Nom + ' ' + AspNetUsers.UserName + ' ' + Activite.Details
	FROM Activite 
	INNER JOIN AspNetUsers ON Activite.ProfesseurID = AspNetUsers.Id
	INNER JOIN Lieu ON Activite.LieuID = Lieu.ID
	INNER JOIN Type ON Activite.TypeID = Type.ID
	WHERE Activite.ID = @ID 
END
GO



CREATE TRIGGER [dbo].[Activite_Trigger_Update]
	ON Activite
	AFTER  INSERT, UPDATE
AS
BEGIN
DECLARE @ID int
	set @ID =(SELECT ID FROM Inserted)
	EXEC [dbo].[Activite_UpdateSearchString] @ID
END
GO

CREATE TRIGGER [dbo].[Cheval_Trigger_Update]
	ON Cheval
	AFTER  INSERT, UPDATE
AS
BEGIN
DECLARE @ID int
	set @ID =(SELECT ID FROM Inserted)
	EXEC [dbo].[Cheval_UpdateSearchString] @ID
END
GO






INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190414175054_CreateIdentitySchema', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190414175552_EditIdentitySchema', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190414190241_EditIdentitySchema3', N'2.1.8-servicing-32085')
SET IDENTITY_INSERT [dbo].[Activite] ON 

INSERT [dbo].[Activite] ([ID], [ProfesseurID], [LieuID], [TypeID], [Nom], [Commentaire], [Details], [Date], [Duree], [Capacite], [EstActive], [SearchString]) VALUES (1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 8, 2, N'Promenade au bord de l''eau', N'Tout c''est bien passé', N'RDV au centre equestre', CAST(N'2019-01-05' AS Date), 5, 4, 1, N'Promenade au bord de l''eau Tout c''est bien passé Pré Ouest Promenade au bord de l''eau Mathieu RDV au centre equestre')
INSERT [dbo].[Activite] ([ID], [ProfesseurID], [LieuID], [TypeID], [Nom], [Commentaire], [Details], [Date], [Duree], [Capacite], [EstActive], [SearchString]) VALUES (2, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 6, 1, N'Randonnée en forêt', N'', N'Prévoir un K-Way', CAST(N'2019-05-10' AS Date), 4, 3, 1, N'Randonnée en forêt  Forêt Secteur Nord Randonnée Mathieu Prévoir un K-Way')
INSERT [dbo].[Activite] ([ID], [ProfesseurID], [LieuID], [TypeID], [Nom], [Commentaire], [Details], [Date], [Duree], [Capacite], [EstActive], [SearchString]) VALUES (3, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 4, 4, N'Cours pour galop 5', N'', N'Prevoir le matériel necessaire', CAST(N'2019-04-04' AS Date), 6, 10, 1, N'Cours pour galop 5  Manège B Cours galop Mathieu Prevoir le matériel necessaire')
SET IDENTITY_INSERT [dbo].[Activite] OFF
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nom], [Prenom]) VALUES (N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', N'Mathieu', N'MATHIEU', N'aa@mail.com', N'AA@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEPRg5xw6WjUmYtUwXLvTYU/NVX/x0FcUNmZ12jKpTLESZ8NJewxTmFw0baIY4y/6/Q==', N'K6EJWUWME7GCMJMU5PMTYAWIEV26ABC6', N'6f428322-3692-4a8c-a785-e7b118e645a5', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nom], [Prenom]) VALUES (N'0c06e160-a849-47f9-b3cb-3aaa225a87ed', N'Guillaume', N'GUILLAUME', N'qwery@ewrwrw', N'QWERY@EWRWRW', 0, N'AQAAAAEAACcQAAAAEPRg5xw6WjUmYtUwXLvTYU/NVX/x0FcUNmZ12jKpTLESZ8NJewxTmFw0baIY4y/6/Q==', N'ZNM4MNKOJXHPJ37TQIDQZEUSO3JEDHBC', N'95631874-c7c7-4a33-96ea-41f82efa5da4', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nom], [Prenom]) VALUES (N'5bc4f71a-f6d6-4d5a-8166-75510ed7cf2a', N'Madeleine', N'MADELEINE', N'bonjour@mail.com', N'BONJOUR@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEPRg5xw6WjUmYtUwXLvTYU/NVX/x0FcUNmZ12jKpTLESZ8NJewxTmFw0baIY4y/6/Q==', N'ZQI5GS5SZZP64AURBCSUG5XXDMCW3HKG', N'0103bc91-6a23-47cf-a473-fcdec0a54c54', NULL, 0, 0, NULL, 1, 0, NULL, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nom], [Prenom]) VALUES (N'e77207b0-7d95-4cc4-9e50-9f429619acdf', N'Eleonore', N'ELEONORE', N'eleo@mail', N'ELEO@MAIL', 0, N'AQAAAAEAACcQAAAAEPRg5xw6WjUmYtUwXLvTYU/NVX/x0FcUNmZ12jKpTLESZ8NJewxTmFw0baIY4y/6/Q==', N'MQE67CNX63WTI25UKFAO6GFSBA2BBTFO', N'3769c559-af67-4620-9f5b-8d6c067276db', NULL, 0, 0, NULL, 1, 0, NULL, NULL)

SET IDENTITY_INSERT [dbo].[Cheval] ON 

INSERT [dbo].[Cheval] ([ID], [ProprietaireID], [RaceID], [Nom], [DateNaissance], [Descriptif], [Commentaire], [NbHeureMaxSemaine], [Taille], [SearchString]) VALUES (1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2, N'Crêpe', CAST(N'2014-06-08' AS Date), N'Aime le sucre', N'Boiteux', 6, 160, N'Crêpe Aime le sucre Boiteux Shetland Mathieu')
INSERT [dbo].[Cheval] ([ID], [ProprietaireID], [RaceID], [Nom], [DateNaissance], [Descriptif], [Commentaire], [NbHeureMaxSemaine], [Taille], [SearchString]) VALUES (2, N'5bc4f71a-f6d6-4d5a-8166-75510ed7cf2a', 1, N'Brownie', CAST(N'2001-09-05' AS Date), N'Aime les carottes', N'Aimable', 5, 170, N'Brownie Aime les carottes Aimable Appaloosa Madeleine')
INSERT [dbo].[Cheval] ([ID], [ProprietaireID], [RaceID], [Nom], [DateNaissance], [Descriptif], [Commentaire], [NbHeureMaxSemaine], [Taille], [SearchString]) VALUES (3, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 3, N'Cookie', CAST(N'2016-11-03' AS Date), N'Aime les graines', N'Pas sympa :(', 15, 175, N'Cookie Aime les graines Pas sympa :( Curly Mathieu')
INSERT [dbo].[Cheval] ([ID], [ProprietaireID], [RaceID], [Nom], [DateNaissance], [Descriptif], [Commentaire], [NbHeureMaxSemaine], [Taille], [SearchString]) VALUES (4, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 4, N'Pepito', CAST(N'2018-10-15' AS Date), N'Aime la viande', N'Sale', 15, 165, N'Pepito Aime la viande Sale Akhal-Teke Mathieu')
SET IDENTITY_INSERT [dbo].[Cheval] OFF
INSERT [dbo].[Cheval_Activite] ([ChevalID], [ActiviteID]) VALUES (1, 1)
INSERT [dbo].[Cheval_Activite] ([ChevalID], [ActiviteID]) VALUES (2, 1)
INSERT [dbo].[Cheval_Activite] ([ChevalID], [ActiviteID]) VALUES (3, 1)
SET IDENTITY_INSERT [dbo].[Lieu] ON 

INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (1, N'Pré Nord', 2, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (2, N'Pré-Jean', 4, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (3, N'Manège A', 8, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (4, N'Manège B', 6, N'Priorité aux poneys')
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (5, N'Forêt Secteur Ouest', 5, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (6, N'Forêt Secteur Nord', 7, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (7, N'Rivière', 6, NULL)
INSERT [dbo].[Lieu] ([ID], [Nom], [Capacite], [Descriptif]) VALUES (8, N'Pré Ouest', 4, NULL)
SET IDENTITY_INSERT [dbo].[Lieu] OFF
SET IDENTITY_INSERT [dbo].[Race] ON 

INSERT [dbo].[Race] ([ID], [Nom]) VALUES (4, N'Akhal-Teke')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (5, N'Andalou')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (7, N'Anglo-Arabe')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (1, N'Appaloosa')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (6, N'Camarguais')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (3, N'Curly')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (10, N'Furioso')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (8, N'Hackney')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (9, N'Hanovrien')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (11, N'Hunter')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (12, N'Morgan')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (13, N'Mustang')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (2, N'Shetland')
INSERT [dbo].[Race] ([ID], [Nom]) VALUES (14, N'Trotteur')
SET IDENTITY_INSERT [dbo].[Race] OFF
SET IDENTITY_INSERT [dbo].[Reservation] ON 

INSERT [dbo].[Reservation] ([ID], [Date], [NbPersonne], [EstActive], [UtilisateurID], [ActiviteID], [SearchString]) VALUES (1, CAST(N'2019-03-10' AS Date), 2, 1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2, N'')
INSERT [dbo].[Reservation] ([ID], [Date], [NbPersonne], [EstActive], [UtilisateurID], [ActiviteID], [SearchString]) VALUES (2, CAST(N'2019-02-15' AS Date), 1, 1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 2, N'')
INSERT [dbo].[Reservation] ([ID], [Date], [NbPersonne], [EstActive], [UtilisateurID], [ActiviteID], [SearchString]) VALUES (3, CAST(N'2019-04-12' AS Date), 2, 1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 1, N'')
INSERT [dbo].[Reservation] ([ID], [Date], [NbPersonne], [EstActive], [UtilisateurID], [ActiviteID], [SearchString]) VALUES (4, CAST(N'2019-05-01' AS Date), 1, 1, N'0277aaa9-d512-4555-bfc9-96eb2d993d0e', 3, N'')
SET IDENTITY_INSERT [dbo].[Reservation] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Nom]) VALUES (1, N'Administrateur')
INSERT [dbo].[Role] ([ID], [Nom]) VALUES (3, N'Client')
INSERT [dbo].[Role] ([ID], [Nom]) VALUES (2, N'Professeur')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([ID], [Nom], [Descriptif]) VALUES (1, N'Randonnée', N'Rando en forêt avec les fées')
INSERT [dbo].[Type] ([ID], [Nom], [Descriptif]) VALUES (2, N'Promenade au bord de l''eau', N'Attention ça glisse')
INSERT [dbo].[Type] ([ID], [Nom], [Descriptif]) VALUES (3, N'AquaPoney', N'Eh salut les filles, bienvenue au cours d''aquaponey !')
INSERT [dbo].[Type] ([ID], [Nom], [Descriptif]) VALUES (4, N'Cours galop', N'Cours pour passer les galops')
SET IDENTITY_INSERT [dbo].[Type] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 15/04/2019 10:47:32 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 15/04/2019 10:47:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 15/04/2019 10:47:32 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 15/04/2019 10:47:32 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 15/04/2019 10:47:32 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 15/04/2019 10:47:32 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 15/04/2019 10:47:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cheval__C7D1C61E05777C3D]    Script Date: 15/04/2019 10:47:32 ******/
ALTER TABLE [dbo].[Cheval] ADD UNIQUE NONCLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Lieu__C7D1C61E7C283730]    Script Date: 15/04/2019 10:47:32 ******/
ALTER TABLE [dbo].[Lieu] ADD UNIQUE NONCLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Race__C7D1C61E2E0162C8]    Script Date: 15/04/2019 10:47:32 ******/
ALTER TABLE [dbo].[Race] ADD UNIQUE NONCLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQUE_ROLE_NAME]    Script Date: 15/04/2019 10:47:32 ******/
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [UNIQUE_ROLE_NAME] UNIQUE NONCLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Type__C7D1C61E9F4EFB2C]    Script Date: 15/04/2019 10:47:32 ******/
ALTER TABLE [dbo].[Type] ADD UNIQUE NONCLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activite] ADD  DEFAULT ('') FOR [SearchString]
GO
ALTER TABLE [dbo].[Cheval] ADD  DEFAULT ('') FOR [SearchString]
GO
ALTER TABLE [dbo].[Reservation] ADD  DEFAULT ('') FOR [SearchString]
GO
ALTER TABLE [dbo].[Activite]  WITH CHECK ADD  CONSTRAINT [Activite_FK_Lieu] FOREIGN KEY([LieuID])
REFERENCES [dbo].[Lieu] ([ID])
GO
ALTER TABLE [dbo].[Activite] CHECK CONSTRAINT [Activite_FK_Lieu]
GO
ALTER TABLE [dbo].[Activite]  WITH CHECK ADD  CONSTRAINT [Activite_FK_Professeur] FOREIGN KEY([ProfesseurID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Activite] CHECK CONSTRAINT [Activite_FK_Professeur]
GO
ALTER TABLE [dbo].[Activite]  WITH CHECK ADD  CONSTRAINT [Activite_FK_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([ID])
GO
ALTER TABLE [dbo].[Activite] CHECK CONSTRAINT [Activite_FK_Type]
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
ALTER TABLE [dbo].[Cheval]  WITH CHECK ADD  CONSTRAINT [Cheval_FK_Proprietaire] FOREIGN KEY([ProprietaireID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Cheval] CHECK CONSTRAINT [Cheval_FK_Proprietaire]
GO
ALTER TABLE [dbo].[Cheval]  WITH CHECK ADD  CONSTRAINT [Cheval_FK_Race] FOREIGN KEY([RaceID])
REFERENCES [dbo].[Race] ([ID])
GO
ALTER TABLE [dbo].[Cheval] CHECK CONSTRAINT [Cheval_FK_Race]
GO
ALTER TABLE [dbo].[Cheval_Activite]  WITH CHECK ADD  CONSTRAINT [ChevalActivite_FK_Activite] FOREIGN KEY([ActiviteID])
REFERENCES [dbo].[Activite] ([ID])
GO
ALTER TABLE [dbo].[Cheval_Activite] CHECK CONSTRAINT [ChevalActivite_FK_Activite]
GO
ALTER TABLE [dbo].[Cheval_Activite]  WITH CHECK ADD  CONSTRAINT [ChevalActivite_FK_Cheval] FOREIGN KEY([ChevalID])
REFERENCES [dbo].[Cheval] ([ID])
GO
ALTER TABLE [dbo].[Cheval_Activite] CHECK CONSTRAINT [ChevalActivite_FK_Cheval]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [Reservation_FK_Activite] FOREIGN KEY([ActiviteID])
REFERENCES [dbo].[Activite] ([ID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [Reservation_FK_Activite]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [Reservation_FK_Utilisateur] FOREIGN KEY([UtilisateurID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [Reservation_FK_Utilisateur]
GO
/****** Object:  StoredProcedure [dbo].[Activite_UpdateSearchString]    Script Date: 15/04/2019 10:47:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO