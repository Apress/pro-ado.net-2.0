USE MASTER
GO

DROP DATABASE TEST
GO

CREATE DATABASE TEST
GO

USE TEST
GO

CREATE TABLE [dbo].[Animals](
	[AnimalID] [int] IDENTITY(1,1) NOT NULL,
	[AnimalName] [varchar](50) NOT NULL,
	[AccountNumber] [int] NOT NULL UNIQUE
,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
([AnimalID] ASC) ON [PRIMARY]
) ON [PRIMARY]

Insert into Animals (AnimalName, AccountNumber) Values ('Puppy',1)
Insert into Animals (AnimalName, AccountNumber) Values ('Cat',2)
Insert into Animals (AnimalName, AccountNumber) Values ('Horse',3)

CREATE TABLE [SeedGenerator]
	( [SeedGenerator] [bigint] IDENTITY(1,1) NOT NULL ) 
ON [PRIMARY]

-- Roll up seed generator
   BEGIN TRANSACTION
      INSERT INTO SEEDGENERATOR DEFAULT VALUES
      INSERT INTO SEEDGENERATOR DEFAULT VALUES
      INSERT INTO SEEDGENERATOR DEFAULT VALUES
   ROLLBACK TRANSACTION

GO

CREATE PROCEDURE UP_ANIMALINSERT
  @AnimalID INT OUTPUT,
  @AnimalName VARCHAR,
  @AccountNumber INT OUTPUT
AS
   BEGIN TRANSACTION
      INSERT INTO SEEDGENERATOR DEFAULT VALUES
      SET @AccountNumber = SCOPE_IDENTITY()
   ROLLBACK TRANSACTION

   INSERT INTO ANIMALS (ANIMALNAME, ACCOUNTNUMBER) VALUES (@AnimalName, 
     @AccountNumber)

   SELECT @AnimalID = @@IDENTITY
GO
