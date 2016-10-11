#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace Exercise_11_2
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         SqlConnection connection1 = new SqlConnection(connectionString);
         SqlConnection connection2 = new SqlConnection(connectionString);

         SqlCommand command1 = connection1.CreateCommand();
         SqlCommand command2 = connection2.CreateCommand();

         connection1.Open();
         connection2.Open();
         SqlTransaction transaction1 = connection1.BeginTransaction(IsolationLevel.Snapshot);
         command1.Transaction = transaction1;
         SqlTransaction transaction2 = 
            connection2.BeginTransaction(IsolationLevel.Snapshot);
         command2.Transaction = transaction2;

         SqlDataReader myReader;
         try
         {
            command1.CommandText = 
               "INSERT INTO CUSTOMERS (FIRSTNAME, LASTNAME, ACCOUNTBALANCE) VALUES ('Bat', 'Man', 100)";
            command1.ExecuteNonQuery();

            command2.CommandText = 
               "SELECT FIRSTNAME, LASTNAME from CUSTOMERS where FIRSTNAME = 'Bat'";
            myReader = command2.ExecuteReader();

            Console.WriteLine("Results when the transaction is midway:");
            if (!myReader.HasRows)
               Console.WriteLine("No Rows Found");
            while (myReader.Read())
            {
               Console.WriteLine("FirstName: " + myReader[0] + " and LastName: " + myReader[1]);
            }
            myReader.Close();

            transaction1.Rollback();

            command2.CommandText = 
               "SELECT FIRSTNAME, LASTNAME from CUSTOMERS where FIRSTNAME = 'Bat'";
            myReader = command2.ExecuteReader();

            Console.WriteLine("Results when the transaction is rolled back:");
            if (!myReader.HasRows)
               Console.WriteLine("No Rows Found");
            while (myReader.Read())
            {
               Console.WriteLine("FirstName: " + myReader[0] + " and LastName: " + myReader[1]);
            }
            myReader.Close();
         }
         catch (System.Exception ex)
         {
            Console.WriteLine(ex.ToString());
         }
         finally
         {
            connection1.Dispose();
            connection2.Dispose();
         }
         Console.Read();
      }
   }
}
