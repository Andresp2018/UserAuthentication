USE [master]
GO
/****** Object:  Database [Backoffice]    Script Date: 17/02/2021 00:47:54 ******/
CREATE DATABASE [Backoffice]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Backoffice', FILENAME = N'C:\Users\Andre Pires\Backoffice.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Backoffice_log', FILENAME = N'C:\Users\Andre Pires\Backoffice_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Backoffice] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Backoffice].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Backoffice] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Backoffice] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Backoffice] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Backoffice] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Backoffice] SET ARITHABORT OFF 
GO
ALTER DATABASE [Backoffice] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Backoffice] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Backoffice] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Backoffice] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Backoffice] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Backoffice] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Backoffice] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Backoffice] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Backoffice] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Backoffice] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Backoffice] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Backoffice] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Backoffice] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Backoffice] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Backoffice] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Backoffice] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Backoffice] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Backoffice] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Backoffice] SET  MULTI_USER 
GO
ALTER DATABASE [Backoffice] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Backoffice] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Backoffice] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Backoffice] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Backoffice] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Backoffice] SET QUERY_STORE = OFF
GO
USE [Backoffice]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Backoffice]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[cod_perfil] [int] IDENTITY(1,1) NOT NULL,
	[perfil] [varchar](50) NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[cod_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilizador]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilizador](
	[id_utilizador] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[nome] [varchar](150) NULL,
	[ativo] [int] NULL,
	[cod_perfil] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([cod_perfil], [perfil]) VALUES (1, N'Administrador')
INSERT [dbo].[perfil] ([cod_perfil], [perfil]) VALUES (2, N'Moderador')
INSERT [dbo].[perfil] ([cod_perfil], [perfil]) VALUES (3, N'Editor')
INSERT [dbo].[perfil] ([cod_perfil], [perfil]) VALUES (4, N'Reader')
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
/****** Object:  StoredProcedure [dbo].[alterar_pw]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

--CREATE PROCEDURE [dbo].[login] 

CREATE   PROCEDURE [dbo].[alterar_pw] 
	@nome as varchar(50),
	@pw_atual as varchar(50),
	@pw_nova as varchar(50),
	@retorno int output
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   if exists (select  * from utilizador where nome = @nome and password = @pw_atual)
	begin
			
				UPDATE utilizador
				SET password = @pw_nova
				WHERE nome = @nome; 

				set @retorno = 1
		
		end

	else
		begin
			set @retorno = 0
		end
END
GO
/****** Object:  StoredProcedure [dbo].[inserir_utilizador]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ALTER PROCEDURE [dbo].[insert_utilizador]
--DROP PROCEDURE inserir_utilizador
CREATE PROCEDURE [dbo].[inserir_utilizador]

@email as varchar (50),
@pass varchar (50),
@nome as varchar (50),

@ativo as int,
@cod_perfil as int,
@retorno int output
AS
BEGIN
SET NOCOUNT ON;



if not exists (select * from utilizador where email = @email OR nome = @nome)
begin
insert into utilizador(email, password, nome, ativo,cod_perfil)

			   values (@email, @pass, @nome, @ativo, @cod_perfil)

set @retorno = 1
end
else
begin
set @retorno = 0
end
END
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

--CREATE PROCEDURE [dbo].[login] 

CREATE   PROCEDURE [dbo].[login] 
	@email as varchar(50),
	@pw as varchar(50),
	@retorno int output,
	@retorno_perfil varchar(30) output,
	@retorno_utilizador varchar(50) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   if exists (select  * from utilizador where email = @email and password = @pw and ativo = '1')
	begin
			set @retorno = 1
			set @retorno_perfil = (select perfil from perfil where cod_perfil = (select cod_perfil from utilizador where email = @email))
			set @retorno_utilizador = (select  nome from utilizador where email = @email and password = @pw)
		end

	else if exists (select * from utilizador where email = @email and password = @pw and ativo = '2')
		begin
			set @retorno = 2
			set @retorno_perfil = ''
		end

	else
		begin
			set @retorno = 0
			set @retorno_perfil = ''
		end
END
GO
/****** Object:  StoredProcedure [dbo].[recuperar_pw]    Script Date: 17/02/2021 00:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ALTER PROCEDURE [dbo].[insert_utilizador]
--DROP PROCEDURE inserir_utilizador
CREATE PROCEDURE [dbo].[recuperar_pw]

@email as varchar (50),

@retorno int output,
@retorno_password varchar (50) output

AS
BEGIN
SET NOCOUNT ON;



if exists (select email from utilizador where email = @email)
	begin
		set @retorno_password = (select password from utilizador where email = @email)
		set @retorno = 1
	end
else
	begin
	set @retorno = 0
	end
END
GO
USE [master]
GO
ALTER DATABASE [Backoffice] SET  READ_WRITE 
GO
