using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlXml;
using System.IO;

namespace Exercise_12_6
{
   class Program
   {
      private static string connectionString = "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         FileStream xmlQuery = new FileStream("updategram.xml", FileMode.Open);
         SqlXmlCommand cmd = new SqlXmlCommand(connectionString);
         cmd.CommandStream = xmlQuery;
         cmd.CommandType = SqlXmlCommandType.UpdateGram;
         cmd.ExecuteNonQuery();
         xmlQuery.Close();
      }
   }
}
