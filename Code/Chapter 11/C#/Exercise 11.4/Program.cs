#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

#endregion

namespace Exercise_11_4
{
   class Program
   {
      private static string connectionString1 = "Server=(local);Database=Credits;Integrated Security=SSPI";
      private static string connectionString2 = "Server=(local);Database=Debits;Integrated Security=SSPI";

      static void Main(string[] args)
      {
         try
         {
            using (TransactionScope myTransaction = new TransactionScope())
            {
               using (SqlConnection connection1 = new SqlConnection(connectionString1))
               {
                  connection1.Open();
                  SqlCommand myCommand = connection1.CreateCommand();
                  myCommand.CommandText = "Insert into Credits (CreditAmount) Values (100)";
                  myCommand.ExecuteNonQuery();
               }

               Console.WriteLine("The first connection transaction has done it's work, moving on to the second.");
               Console.ReadLine();

               using (SqlConnection connection2 = new SqlConnection(connectionString2))
               {
                  connection2.Open();
                  SqlCommand myCommand = connection2.CreateCommand();
                  myCommand.CommandText = "Insert into Debits(DebitAmount) Values (100)";
                  myCommand.ExecuteNonQuery();
               }
            }
         }
         catch (System.Exception ex)
         {
            Console.WriteLine(ex.ToString());
         }
      }
   }
}
