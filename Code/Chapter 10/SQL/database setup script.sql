-- Create DataBase
Use Master
GO

Drop Database Test
GO

Create Database Test
GO

Use Test
GO

-- Setup Tables
CREATE TABLE Animals(
	AnimalID INT NOT NULL IDENTITY,
	AnimalType VARCHAR(50) NOT NULL,
	timestamp,
 CONSTRAINT PK_Animals PRIMARY KEY (AnimalID)
)
GO

CREATE TABLE Pets(
	PetID INT NOT NULL IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Weight INT NOT NULL,
	AnimalID INT NOT NULL REFERENCES Animals(AnimalID),
	timestamp,
 CONSTRAINT PK_Pets PRIMARY KEY (PetID)
)
GO

CREATE TABLE PetBelonging(
	PetBelongingID INT NOT NULL IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Price FLOAT NOT NULL,
	PetID INT NOT NULL REFERENCES Pets(PetID),
	timestamp,
 CONSTRAINT PK_PetBelonging PRIMARY KEY (PetBelongingID)
)
GO


-- Data Population
Insert into Animals (AnimalType) Values ('Dog')
Insert into Pets (FirstName, LastName, Weight, AnimalID) Values ('Tashu', 'Malik', 100,1)
Insert into PetBelonging(Name, Price, PetID) Values('Collar',10,1)
Insert into PetBelonging(Name, Price, PetID) Values('Bone',2,1)
GO

-- Create Stored Procedures
CREATE PROCEDURE UP_ANIMALINSERT
  @AnimalID INT OUTPUT,
  @AnimalType VARCHAR(50)
AS
   INSERT INTO ANIMALS 
		(AnimalType) 
   VALUES 
		(@AnimalType) 

   SELECT @AnimalID = SCOPE_IDENTITY()
GO


CREATE PROCEDURE UP_PETSINSERT
  @PetID INT OUTPUT,
  @FirstName VARCHAR(50),
  @LastName VARCHAR(50),
  @Weight INT,
  @AnimalID INT
AS
   INSERT INTO PETS
		(FirstName, LastName, Weight, AnimalID) 
   VALUES 
		(@FirstName, @LastName, @Weight, @AnimalID) 

   SELECT @PetID = SCOPE_IDENTITY()
GO


CREATE PROCEDURE UP_PETBELONGINGINSERT
  @PetBelongingID INT OUTPUT,
  @Name VARCHAR(50),
  @Price FLOAT,
  @PetID INT
AS
   INSERT INTO PETBELONGING
		(Name, Price, PetID) 
   VALUES 
		(@Name, @Price, @PetID) 

   SELECT @PetBelongingID = SCOPE_IDENTITY()
GO