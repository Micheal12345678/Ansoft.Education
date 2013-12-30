
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2013 18:09:15
-- Generated from EDMX file: D:\个人项目\Ansoft.Education\Ansoft.Education.EF\Ansoft.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ansoft];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SourceCodes_SourceCodeType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Codes] DROP CONSTRAINT [FK_SourceCodes_SourceCodeType];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Codes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Codes];
GO
IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[Module]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Module];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Codes'
CREATE TABLE [dbo].[Codes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TypeId] int  NULL,
    [Name] varchar(50)  NULL,
    [CreateTime] datetime  NULL,
    [UpdateTime] datetime  NULL,
    [CreateUserName] varchar(50)  NULL,
    [Contents] varchar(max)  NULL
);
GO

-- Creating table 'Module'
CREATE TABLE [dbo].[Module] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NULL,
    [SortIndex] nchar(10)  NULL,
    [ParentId] int  NULL,
    [LevelCode] varchar(50)  NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Text] varchar(50)  NULL,
    [Action] varchar(50)  NULL,
    [Controller] varchar(50)  NULL,
    [Name] varchar(50)  NULL,
    [SortIndex] int  NULL,
    [ParentId] int  NULL,
    [LevelCode] varchar(50)  NULL,
    [LevelCount] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'Codes'
ALTER TABLE [dbo].[Codes]
ADD CONSTRAINT [PK_Codes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Module'
ALTER TABLE [dbo].[Module]
ADD CONSTRAINT [PK_Module]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------