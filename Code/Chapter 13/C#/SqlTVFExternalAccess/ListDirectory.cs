using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Collections;

namespace SqlTVFExternalAccess
{
   public partial class UserDefinedFunctions
   {
      [Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName = "FillRow", 
         TableDefinition="FileName nvarchar(4000), FileSize nvarchar(4000)")]
      public static IEnumerable GetDircontents(string DirName)
      {
         DirectoryInfo startDir = new DirectoryInfo(DirName);
         // This implements IEnumerable, so we are done :)
         return startDir.GetFiles();
      }

      public static void FillRow(object row, out string FileName, out string FileSize)
      {
         FileInfo oneFile = (FileInfo)row;
         FileName = oneFile.Name;
         FileSize = oneFile.Length.ToString();
      }
   };
}

//Drop Function GetDircontents 
//Drop Assembly SqlTVFExternalAccess


//Create Assembly SqlTVFExternalAccess
//from
//'C:\PlayArea\SqlTVFExternalAccess\bin\Debug\SqlTVFExternalAccess.dll'
//WITH PERMISSION_SET = EXTERNAL_ACCESS
//GO

//Create Function GetDircontents 
//(
//   @DirName NVARCHAR(4000)
//)
//Returns Table 
//(
//   FileDirName NVARCHAR(4000), 
//   FileSize NVARCHAR(4000)
//)
//As
//External Name
//SqlTVFExternalAccess.[SqlTVFExternalAccess.UserDefinedFunctions].GetDircontents 
//Go

//Select * from dbo.GetDircontents ('C:\WINDOWS\Tasks')
//Go
