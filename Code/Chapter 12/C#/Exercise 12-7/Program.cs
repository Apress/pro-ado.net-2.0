using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlXml;
using System.IO;

namespace Exercise_12_7
{
   class Program
   {
      private static string connectionString = "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         SqlXmlCommand cmd = new SqlXmlCommand(connectionString);
         cmd.CommandText = "Person.Contact";
         cmd.CommandType = SqlXmlCommandType.XPath;
         cmd.SchemaPath = "Person.Contact.xsd";
         cmd.ClientSideXml = true;
         cmd.RootTag = "Person.Contact";

         SqlXmlAdapter da = new SqlXmlAdapter(cmd) ;
         DataSet ds = new DataSet();
         try
         {
            // Fill the dataset  
            da.Fill(ds);
            // Make some change
            ds.Tables[0].Rows[1]["LastName"] = "Unabel";
            // Update the data back to the database.
            da.Update(ds.GetChanges());
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.ToString());
         }
      }
   }
}