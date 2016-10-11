#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data ;
using System.Data.SqlClient ;

#endregion

namespace Exercise_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection testConnection =
                            new SqlConnection(
                            "Server=(local);Database=Test;Integrated Security=SSPI");
            try
            {
               testConnection.Open();
               if (testConnection.State == ConnectionState.Open)
               {
                  Console.WriteLine("Successfully opened a connection");
               }
            }
            catch (Exception)
            {
               if (testConnection.State != ConnectionState.Open)
               {
                  Console.WriteLine("Failed to open a connection");
               }
            }
            finally
            {
               // Closing a connection ensures connection pooling.
               if (testConnection.State == ConnectionState.Open)
               {
                  testConnection.Close();
               }
               testConnection.Dispose();
            }
        }
    }
}
