#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient ;

#endregion

namespace Exercise_11_3
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testConnection.Open();
            
            SqlTransaction myTransaction = testConnection.BeginTransaction();
            testCommand.Transaction = myTransaction;

            try
            {
               testCommand.CommandText = 
                  "Insert into Customers (FirstName, LastName, AccountBalance) Values ('Bat','Man',100)";
               testCommand.ExecuteNonQuery();
               myTransaction.Save("firstCustomer");

               testCommand.CommandText = 
                  "Insert into Customers (FirstName, LastName, AccountBalance) Values ('The','Joker',100)";
               testCommand.ExecuteNonQuery();

               myTransaction.Rollback("firstCustomer");

               testCommand.CommandText = 
                  "Insert into Customers (FirstName, LastName, AccountBalance) Values ('Robin','Sidekick',100)";
               testCommand.ExecuteNonQuery();
               myTransaction.Commit();

               testCommand.CommandText = "Select * from Customers";
               SqlDataReader sqlDa = testCommand.ExecuteReader();

               while (sqlDa.Read())
               {
                  Console.WriteLine(
                     " FirstName: " + sqlDa["FirstName"] + 
                     " LastName = " + sqlDa["LastName"] + 
                     " AccountBalance = " + sqlDa["AccountBalance"]);
               }
               sqlDa.Close();
            }
            catch (System.Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }
            testConnection.Close();
         } // testConnection.Dispose is called automatically.
      }
   }
}
