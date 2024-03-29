USE [master]
GO

/****** Object:  Database [Ansoft]    Script Date: 12/24/2013 17:43:27 ******/
CREATE DATABASE [Ansoft] ON  PRIMARY 
( NAME = N'Ansoft', FILENAME = N'D:\个人项目\Ansoft.Education\Ansoft.Education.DB\Ansoft.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Ansoft_log', FILENAME = N'D:\个人项目\Ansoft.Education\Ansoft.Education.DB\Ansoft_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Ansoft] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ansoft].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Ansoft] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Ansoft] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Ansoft] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Ansoft] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Ansoft] SET ARITHABORT OFF 
GO

ALTER DATABASE [Ansoft] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Ansoft] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Ansoft] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Ansoft] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Ansoft] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Ansoft] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Ansoft] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Ansoft] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Ansoft] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Ansoft] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Ansoft] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Ansoft] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Ansoft] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Ansoft] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Ansoft] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Ansoft] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Ansoft] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Ansoft] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Ansoft] SET  READ_WRITE 
GO

ALTER DATABASE [Ansoft] SET RECOVERY FULL 
GO

ALTER DATABASE [Ansoft] SET  MULTI_USER 
GO

ALTER DATABASE [Ansoft] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Ansoft] SET DB_CHAINING OFF 
GO

