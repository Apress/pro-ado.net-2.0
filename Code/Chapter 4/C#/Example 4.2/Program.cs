#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data ;
using System.Data.SqlClient ;
#endregion

namespace Exercise_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder connstrBuilder = new SqlConnectionStringBuilder();
            connstrBuilder.DataSource = "(local)";
            connstrBuilder.InitialCatalog = "Test";
            connstrBuilder.IntegratedSecurity = true;

            using (SqlConnection testConnection = new SqlConnection(connstrBuilder.ToString()))
            {
               try
               {
                  testConnection.Open();
                  if (testConnection.State == ConnectionState.Open)
                  {
                     Console.WriteLine("Connection successfully opened");
                     Console.WriteLine("Connection string used: " +
                         testConnection.ConnectionString);
                  }
               }
               catch (Exception)
               {
                  if (testConnection.State != ConnectionState.Open)
                  {
                     Console.WriteLine("Connection open failed");
                     Console.WriteLine("Connection string used: "
                         + testConnection.ConnectionString);
                  }
               }
            } 
            // Automatic dispose call on conn ensures connection is closed.
            Console.WriteLine("Press any key to continue ..");
            Console.Read();
        }
    }
}
