CREATE DATABASE TEST
GO

USE TEST
GO

CREATE TABLE Region
(
RegionID INT PRIMARY KEY,
RegionDescription VARCHAR(3000)
)
GO

-- XML Document is of the form
-- <Top>
--   <Region> region elements here </Region>
--   <Region> region elements here </Region>
--   ...
-- </Top>
CREATE PROCEDURE RegionInsert @xmlDoc NVARCHAR(4000) AS
DECLARE @docIndex INT
EXECUTE sp_xml_preparedocument @docIndex OUTPUT, @xmlDoc

-- 1 is ATTRIBUTE-centric mapping
INSERT Region 
SELECT RegionID, RegionDescription 
FROM OPENXML(@docIndex, N'/Top/Region', 1) WITH Region

EXECUTE sp_xml_removedocument @docIndex

GO

CREATE PROCEDURE RegionUpdate @xmlDoc NVARCHAR(4000) AS

  DECLARE @docIndex INT

  EXECUTE sp_xml_preparedocument @docIndex OUTPUT, @xmlDoc
  
  UPDATE Region 
    SET Region.RegionDescription = XMLRegion.RegionDescription 
  FROM OPENXML(@docIndex, N'/Top/Region',1) WITH Region AS XMLRegion
  WHERE Region.RegionID = XMLRegion.RegionID
  
  EXECUTE sp_xml_removedocument @docIndex

GO

CREATE PROCEDURE RegionDelete @xmlDoc NVARCHAR(4000) AS
  DECLARE @docIndex INT

  EXECUTE sp_xml_preparedocument @docIndex OUTPUT, @xmlDoc
  
  DELETE Region
  FROM OPENXML(@docIndex, N'/Top/Region', 1) WITH Region AS XMLRegion
  WHERE Region.RegionID=XMLRegion.RegionID
  
  EXECUTE sp_xml_removedocument @docIndex
