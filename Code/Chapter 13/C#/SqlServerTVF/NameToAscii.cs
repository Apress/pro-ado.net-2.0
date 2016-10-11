using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Collections;

namespace SqlServerTVF
{
   public partial class UserDefinedFunctions
   {
      [Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName = "FillRow",
      TableDefinition = "charpart nchar(1), intpart int")]
      public static IEnumerable NameToAscii(string InputName)
      {
         return new NameSplitter(InputName.ToCharArray());
      }

      //[Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName = "FillRow", 
      //   TableDefinition="charpart nchar(1), intpart int")]
      //public static IEnumerable NameToAscii(string InputName)
      //{
      //   foreach (char c in InputName)
      //   {
      //      yield return new NameRow(c, (int)c);
      //   }
      //}

      public static void FillRow(object row, out char charpart, out int intpart)
      {
         // break the row into its columnar parts. 
         charpart = ((NameRow)row).CharPart;
         intpart = ((NameRow)row).IntPart;
      }
   };

   public class NameRow
   {
      public Char CharPart;
      public Int32 IntPart;

      public NameRow(Char c, Int32 i)
      {
         CharPart = c;
         IntPart = i;
      }
   }

   public class NameSplitter :  IEnumerable, IEnumerator
   {
	   private Int32 idx = - 1;
	   private Char[] _inputName;

	   public NameSplitter(Char[] InputName)
	   {
		   _inputName = InputName;
	   }

	   public System.Collections.IEnumerator GetEnumerator()
	   {
		   return new NameSplitter(_inputName);
	   }

	   public object Current
	   {
		   get
		   {
			   if(( idx > - 1 ))
			   {
				   Char c = _inputName[idx];
				   return new NameRow(c, Convert.ToInt32(c));
			   }
			   else
			   {
				   return - 1;
			   }
		   }
	   }
	   public bool MoveNext()
	   {
		   idx = idx + 1;
		   if(( idx < _inputName.Length ))
		   {
			   return true;
		   }
		   else
		   {
			   return false;
		   }
	   }

	   public void Reset()
	   {
		   idx = - 1;
	   }
   }
}

//Create Assembly SqlServerTVF
//from
//'C:\PlayArea\SqlServerTVF\bin\Debug\SqlServerTVF.dll'
//GO

//Create Function NameToAscii 
//(
//   @InputName NVARCHAR(4000)
//)
//Returns Table 
//(
//   charpart nchar, 
//   intpart Int
//)
//As
//External Name
//SqlServerTVF.[SqlServerTVF.UserDefinedFunctions].NameToAscii 
//Go

//Select * from dbo.NameToAscii ('Sahil Malik') order by intpart
//Go
