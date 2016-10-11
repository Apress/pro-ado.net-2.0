#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO ;
#endregion

namespace Exercise_12_1
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=AdventureWorks;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand(); testCommand.CommandText = 
               "SELECT " +
               "LOGINID, TITLE, " +
               "   HUMANRESOURCES.DEPARTMENT.DEPARTMENTID, HUMANRESOURCES.DEPARTMENT.NAME " +
               "FROM " +
               "   HUMANRESOURCES.EMPLOYEE " +
               "   INNER JOIN HUMANRESOURCES.DEPARTMENT ON " +
               "   HUMANRESOURCES.EMPLOYEE.DEPARTMENTID = HUMANRESOURCES.DEPARTMENT.DEPARTMENTID " +
               "WHERE HUMANRESOURCES.DEPARTMENT.DEPARTMENTID = 7 " +
               "FOR XML RAW, XMLDATA";

               testConnection.Open();
               XmlReader xrdr = testCommand.ExecuteXmlReader();
               StreamWriter sw = new StreamWriter("Output.xml");
               sw.WriteLine("<xml>");

               while (xrdr.Read())
               {
                  sw.WriteLine(xrdr.ReadOuterXml());
               }

               sw.WriteLine("</xml>");
               sw.Close();
               xrdr.Close();
               testConnection.Close();
         }
      }
   }
}