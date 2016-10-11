#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient ;
#endregion

namespace Example_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI" ;
            using (SqlConnection testConnection = new SqlConnection(connectionString))
            {
                SqlCommand testCommand =
                    new SqlCommand("Select * from TestDemo", testConnection);
                testConnection.Open();
                SqlDataReader sqlDr = testCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (sqlDr.HasRows)
                {
                    while (sqlDr.Read())
                    {
                        Console.WriteLine("TestDemo: " + sqlDr.GetInt32(0) 
                            + " and Description : " + sqlDr.GetString(1));
                    }
                }
            } // testConnection.Dispose is called automatically
            Console.Read() ;
        }
    }
}