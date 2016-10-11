Create Database Test
GO
USE Test
GO
CREATE TABLE Animals(
	AnimalID int NOT NULL,
	AnimalName varchar(50) NOT NULL,
 CONSTRAINT PK_Animals PRIMARY KEY (AnimalID)
)
GO