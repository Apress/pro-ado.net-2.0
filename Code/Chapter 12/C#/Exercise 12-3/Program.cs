using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace Exercise_12_3
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=AdventureWorks;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = 
               new SqlCommand("Select Top 1 Resume from HumanResources.JobCandidate", testConnection);
            testConnection.Open();

            // Method 1
            XmlReader xrdr = testCommand.ExecuteXmlReader();
            xrdr.Read();
            Console.WriteLine(xrdr.ReadOuterXml());

            SqlDataReader rdr = testCommand.ExecuteReader();
            
            while (rdr.Read())
            {
               // Method 2
               Console.WriteLine(rdr.GetString(0));

               // Method 3
               XmlReader xr = rdr.GetSqlXml(0).CreateReader();
               xr.Read();
               Console.WriteLine(xr.ReadOuterXml());

               // Method 4
               Object o = rdr.GetProviderSpecificValue(0);
               // Strangely enough this prints SqlString
               Console.WriteLine(o.GetType().ToString());
               Console.WriteLine(o.ToString());
            }
         }
      }
   }
}
