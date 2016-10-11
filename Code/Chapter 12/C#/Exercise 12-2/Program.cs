using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Exercise_12_2
{
   class Program
   {
      private static string strConnection = "Server=(local);Database=Test;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         string strXMLDoc = 
            "<Top>" + @"<Region RegionID=""11"" RegionDescription=""UpTown""/>" + 
            @"<Region RegionID=""22"" RegionDescription=""DownTown""/>" + "</Top>";

         SqlConnection sqlConnection = new SqlConnection(strConnection);
         SqlCommand openXMLCommand = new SqlCommand("RegionInsert", sqlConnection);
         openXMLCommand.CommandType = CommandType.StoredProcedure;

         SqlParameter xmlDocParm = 
            openXMLCommand.Parameters.Add("@xmlDoc", SqlDbType.NVarChar, 4000);
         xmlDocParm.Value = strXMLDoc;

         sqlConnection.Open();
         openXMLCommand.ExecuteNonQuery();

         xmlDocParm.Value = strXMLDoc.Replace("Town", "state");
         openXMLCommand.CommandText = "RegionUpdate";
         openXMLCommand.ExecuteNonQuery();

         openXMLCommand.CommandText = "RegionDelete";
         openXMLCommand.ExecuteNonQuery();

         sqlConnection.Close();
      }
   }
}