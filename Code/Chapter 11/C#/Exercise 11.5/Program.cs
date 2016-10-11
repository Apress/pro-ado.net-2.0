using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ConsoleApplication5
{
   class Program
   {
      private static string connectionString1 = "Server=(local);Database=Test1;Integrated Security=SSPI";
      private static string connectionString2 = "Server=(local);Database=Test2;Integrated Security=SSPI";
      private static bool isThreadRunning = false;
      static void Main(string[] args)
      {
         try
         {
            using (TransactionScope myTransaction = new TransactionScope())
            {
               Thread myThread;
               myThread = new System.Threading.Thread(new ParameterizedThreadStart(ThreadEntryPoint));
               Transaction tran = Transaction.Current.Clone();
               myThread.Start(tran);

               using (SqlConnection connection1 = new SqlConnection(connectionString1))
               {
                  connection1.Open();
                  // Do something here - this connection will auto-enlist
               }
               // Wait for the other thread to finish
               while (isThreadRunning)
               {
                  Console.Write("\rWaiting for thread to finish ..");
               }
               myTransaction.Complete();
            }
         }
         catch (System.Exception ex)
         {
            Console.WriteLine(ex.ToString());
         }
      }

      private static void ThreadEntryPoint(object transactionInstance)
      {
         isThreadRunning = true;
         Transaction tran = (Transaction)transactionInstance;
         using (SqlConnection connection2 = new SqlConnection(connectionString2))
         {
            connection2.Open();
            connection2.EnlistTransaction(tran);
            // Do something here - this connection is manually enlisted.
            tran.Rollback(); // ok to do
         }
         isThreadRunning = false;
      }
   }
}