using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
   [Microsoft.SqlServer.Server.SqlProcedure]
   public static void GetConcatenatedNames(string role)
   {
      using (SqlConnection contextConnection = new SqlConnection("context connection = true"))
      {
         SqlCommand contextCommand =
            new SqlCommand(
            "Select dbo.Concatenator(PersonName) from Person " +
            "where PersonRole = @Role Group By PersonRole", contextConnection);

         contextCommand.Parameters.AddWithValue("@Role", role);
         contextConnection.Open();

         SqlContext.Pipe.ExecuteAndSend(contextCommand);
      }
   }

   [Microsoft.SqlServer.Server.SqlProcedure]
   public static void GetNames(string role)
   {
      using (SqlConnection contextConnection = new SqlConnection("context connection = true"))
      {
         SqlCommand contextCommand =
            new SqlCommand(
            "Select PersonName from Person " +
            "where PersonRole = @Role", contextConnection);

         contextCommand.Parameters.AddWithValue("@Role", role);

         contextConnection.Open();

         // first, create the record and specify the metadata for the results
         SqlDataRecord rec = new SqlDataRecord(
             new SqlMetaData("PersonName", SqlDbType.NVarChar, 200)
             );

         // start a new result-set
         SqlContext.Pipe.SendResultsStart(rec);

         // send rows
         SqlDataReader rdr = contextCommand.ExecuteReader();
         while (rdr.Read())
         {
            rec.SetString(0, rdr.GetString(0));
            SqlContext.Pipe.SendResultsRow(rec);
         }

         // complete the result-set
         SqlContext.Pipe.SendResultsEnd();
      }
   }

   [Microsoft.SqlServer.Server.SqlProcedure]
   public static void InsertName(string personName, string personRole)
   {
      using (SqlConnection contextConnection = new SqlConnection("context connection = true"))
      {
         SqlCommand contextCommand =
            new SqlCommand(
            "Insert into Person(PersonName, PersonRole) Values (@PersonName, @PersonRole)", 
            contextConnection);

         contextCommand.Parameters.AddWithValue("@PersonName", personName);
         contextCommand.Parameters.AddWithValue("@PersonRole", personRole);

         contextConnection.Open();
         contextCommand.ExecuteScalar();
         // System.Transactions.Transaction.Current.Rollback();
         contextConnection.Close();
      }
   }
};

//Create Assembly SqlServerStoredProc
//from
//'C:\SqlServerStoredProc\SqlServerStoredProc.dll'
//GO

//Create Procedure GetConcatenatedNames 
//(
//   @Role NVARCHAR(4000)
//)
//As
//External Name
//SqlServerStoredProc.[SqlServerStoredProc.StoredProcedures].GetConcatenatedNames
//Go

//Create Procedure GetNames 
//(
//   @Role NVARCHAR(4000)
//)
//As
//External Name
//SqlServerStoredProc.[SqlServerStoredProc.StoredProcedures].GetNames
//Go

//exec dbo.GetNames 'Reviewer'
//Go
