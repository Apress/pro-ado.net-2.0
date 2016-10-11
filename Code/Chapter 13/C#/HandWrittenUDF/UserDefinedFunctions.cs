using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace HandWrittenUDF
{
   public class UserDefinedFunctions
   {
      [Microsoft.SqlServer.Server.SqlFunction]
      public static SqlInt32 GetRandomNumber()
      {
         Random rnd = new Random();
         return rnd.Next();
      }
   }
}

// SQL SCRIPT
//Create Assembly HandWrittenUDF
//from
//'C:\PlayArea\SqlServerProject\HandWrittenUDF\bin\Debug\HandWrittenUDF.dll'
//GO

//Create Function GetRandomNumber ()
//Returns Int
//As
//External Name
//HandWrittenUDF.[HandWrittenUDF.UserDefinedFunctions].GetRandomNumber
//Go

//Select dbo.GetRandomNumber()
//Go