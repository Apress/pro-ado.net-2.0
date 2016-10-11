#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient ;
#endregion

namespace Example_5_1
{
   class Program
   {
      static void Main(string[] args)
      {
            string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI" ;
            using (SqlConnection testConnection = new SqlConnection(connectionString))
            {
               SqlCommand testCommand = new SqlCommand("Select count(*) from TestDemo",testConnection);
               testConnection.Open();
               int numResults = (int) testCommand.ExecuteScalar();
               Console.WriteLine("Total number of rows in TestDemo: " + numResults);
               testConnection.Close();
            } // testConnection.Dispose is called automatically
            Console.Read() ;
      }
   }
}