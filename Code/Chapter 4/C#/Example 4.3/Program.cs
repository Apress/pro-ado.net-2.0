#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient ;
#endregion

namespace Exercise_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection testConnection = 
                new SqlConnection
                ("Server=(local);Database=Test;Integrated Security=SSPI;");
            long starticks = DateTime.Now.Ticks;
            for (int i = 0; i <= 1000; i++)
            {
                testConnection =
                new SqlConnection
                ("Server=(local);Database=Test;Integrated Security=SSPI;Pooling=false;");
                testConnection.Open();
                testConnection.Close();
            }
            long endticks = DateTime.Now.Ticks;
            Console.WriteLine("Time taken : " + (endticks - starticks) + " ticks.");
            testConnection.Dispose();
        }
    }
}
