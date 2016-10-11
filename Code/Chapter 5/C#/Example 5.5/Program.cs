#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient ;
#endregion

namespace Example_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI" ;
            using (SqlConnection testConnection = new SqlConnection(connectionString))
            {
                SqlCommand testCommand =
                    new SqlCommand("Select * from UserBasicInformation" + ";" +
                    "Select * from PermissionsTable", testConnection);
                testConnection.Open();
                SqlDataReader sqlDr = testCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (sqlDr.HasRows)
                {
                    do
                    {
                        Console.WriteLine("_____________________");
                        while (sqlDr.Read())
                        {
                            Console.WriteLine(sqlDr.GetInt32(0)
                                + " : " + sqlDr.GetString(1));
                        }
                    } while (sqlDr.NextResult());
                }
            } // testConnection.Dispose is called automatically
            Console.Read() ;
        }
    }
}