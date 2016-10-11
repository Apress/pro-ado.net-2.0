using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HandWrittenUDFTest
{
   class Program
   {
      private static string connectionString = "Data Source=(local);Initial Catalog=test;Integrated Security=SSPI;";

      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText =
               "Select dbo.GetRandomNumber()";
            testConnection.Open() ;
            int randomNum = (int)testCommand.ExecuteScalar();
            Console.WriteLine(randomNum);
            testConnection.Close();
         }
      }
   }
}
