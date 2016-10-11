using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlXml;
using System.IO;

namespace Exercise_12_4
{
   class Program
   {
      private static string connectionString = "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         SqlXmlCommand cmd = new SqlXmlCommand(connectionString);
         SqlXmlParameter parm;
         cmd.CommandText = "SELECT FirstName, LastName FROM Person.Contact WHERE LastName=? For XML Auto";
         parm = cmd.CreateParameter();
         parm.Value = "Achong";
         string strResult;
         try
         {
            Stream strm = cmd.ExecuteStream();
            strm.Position = 0;
            using (StreamReader sr = new StreamReader(strm))
            {
               Console.WriteLine(sr.ReadToEnd());
            }
         }
         catch (SqlXmlException e)
         {
            //in case of an error, this prints error returned.
            e.ErrorStream.Position = 0;
            strResult = new StreamReader(e.ErrorStream).ReadToEnd();
            System.Console.WriteLine(strResult);
         }
      }
   }
}