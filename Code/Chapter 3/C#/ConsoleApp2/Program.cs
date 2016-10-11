using System;
using System.Data.SqlClient ;

namespace ConsoleApp2
{
   class Program
   {
      private static string connectionString = "Data Source=(local);Initial Catalog=Test;Integrated Security=True";
      static void Main(string[] args)
      {
         SqlConnection testConnection = new SqlConnection(connectionString);
         SqlCommand testCommand = testConnection.CreateCommand() ;
         testCommand.CommandText = "Select DemoValue from Demo where DemoID = 1" ;
         testConnection.Open() ;
         string result = (string)testCommand.ExecuteScalar() ;
         testConnection.Close();
         Console.WriteLine(result) ;
      }
   }
}