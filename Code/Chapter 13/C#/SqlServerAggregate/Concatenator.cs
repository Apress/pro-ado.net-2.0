using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

using System.Text;

namespace SqlServerAggregate
{
   [Serializable]
   [Microsoft.SqlServer.Server.SqlUserDefinedAggregate(Format.UserDefined, 
      MaxByteSize=8000)]
   public struct Concatenator : IBinarySerialize
   {
      private StringBuilder sb;
      public void Init()
      {
         sb = new StringBuilder();
      }

      public void Accumulate(SqlString Value)
      {
         sb.Append(Value);
         sb.Append(",");
      }

      public void Merge(Concatenator Group)
      {
         Accumulate(Group.ToString());
      }

      public override string ToString()
      {
         return sb.ToString();
      }

      public SqlString Terminate()
      {
         sb.Remove(sb.Length - 1, 1);
         return sb.ToString();
      }

      #region IBinarySerialize Members

      public void Read(System.IO.BinaryReader r)
      {
         sb = new StringBuilder();
         sb.Append(r.ReadString());
      }

      public void Write(System.IO.BinaryWriter w)
      {
         if (sb.Length > 0)
            w.Write(sb.ToString());
      }

      #endregion
   }
}

//Create Table Person
//(
//   PersonID int identity primary key,
//   PersonName varchar(200),
//   PersonRole varchar(200)
//)
//GO

//Insert into Person (PersonName, PersonRole) Values ('Sahil Malik', 'Author')
//Insert into Person (PersonName, PersonRole) Values ('Erick Sgarbi', 'Reviewer')
//Insert into Person (PersonName, PersonRole) Values ('Frans Bouma', 'Reviewer')
//Insert into Person (PersonName, PersonRole) Values ('Jonathan Hassell', 'Lead Editor')
//GO


//Create Assembly SqlServerAggregate
//from
//'C:\PlayArea\SqlServerUDT\bin\Debug\SqlServerAggregate.dll'
//GO

//CREATE AGGREGATE Concatenator( @instr nvarchar(400) )
//RETURNS nvarchar(MAX)
//EXTERNAL NAME [SqlServerAggregate].[SqlServerAggregate.Concatenator]
//GO

//Select PersonRole, dbo.Concatenator(PersonName) from Person where PersonRole = 'Reviewer' Group By PersonRole