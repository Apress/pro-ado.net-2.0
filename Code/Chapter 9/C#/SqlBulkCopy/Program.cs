using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SqlBulkCopyDemo
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";

      static void Main(string[] args)
      {
         using (SqlConnection firstConnection = new SqlConnection(connectionString))
         {
            SqlCommand cmdAnimals = firstConnection.CreateCommand();
            cmdAnimals.CommandText = "Select * from Animals";
            firstConnection.Open();
            SqlDataReader dr = cmdAnimals.ExecuteReader();

            using (SqlConnection secondConnection = new SqlConnection(connectionString))
            {
               SqlBulkCopy bc = new SqlBulkCopy(secondConnection);
               bc.DestinationTableName = "AnimalsCopy";
               bc.WriteToServer(dr);
               bc.Close();
               dr.Close();
            }
         }
      }
   }
}