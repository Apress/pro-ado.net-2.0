use Master
Go
CREATE DATABASE Test
Go

use Test
Go

CREATE TABLE [dbo].[PermissionsTable](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PermissionsTable] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
Go

CREATE TABLE [dbo].[UserPermissionsTable](
	[UserPermissionsID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PermissionsID] [int] NOT NULL,
 CONSTRAINT [PK_UserPermissionsTable] PRIMARY KEY CLUSTERED 
(
	[UserPermissionsID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
Go

CREATE TABLE [dbo].[UserTable](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
Go

ALTER TABLE [dbo].[UserPermissionsTable]  WITH CHECK ADD  CONSTRAINT [FK_UserPermissionsTable_PermissionsTable] FOREIGN KEY(	[PermissionsID])
REFERENCES [PermissionsTable] (	[PermissionID])
GO

ALTER TABLE [dbo].[UserPermissionsTable]  WITH CHECK ADD  CONSTRAINT [FK_UserPermissionsTable_UserTable] FOREIGN KEY(	[UserID])
REFERENCES [UserTable] (	[UserID])
GO
