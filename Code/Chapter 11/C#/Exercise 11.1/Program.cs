#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace Exercise_11_1
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand myCommand = testConnection.CreateCommand();
            SqlTransaction myTransaction = null;
            try
            {
               testConnection.Open();
               myTransaction = testConnection.BeginTransaction();
               myCommand.Transaction = myTransaction;
               myCommand.CommandText = "Insert into CustomerProduct (CustomerID, ProductID) Values (2, 1)";
               myCommand.ExecuteNonQuery();
               myCommand.CommandText = "Update Customers Set AccountBalance = 96 Where CustomerID = 2";
               myCommand.ExecuteNonQuery();
               myTransaction.Commit();
            }
            catch (System.Exception ex)
            {
               myTransaction.Rollback();
               throw ex;
            }
            finally
            {
               testConnection.Close();
            }
         }
      }
   }
}
