#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace Exercise_9_3
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";

      static void Main(string[] args)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText = "Select * from Animals";
            SqlDataAdapter sqlDa = new SqlDataAdapter(testCommand);
            DataTable animalsTable = new DataTable("Animals");
            sqlDa.Fill(animalsTable);

            DisplayRowStates("Row states for a freshly filled DataTable:",animalsTable);

            DataRow rowInQuestion;
            // Make Changes - Modify the puppy
            rowInQuestion = animalsTable.Rows[0];
            rowInQuestion["AnimalName"] = "Dog";
            // Make Changes - Delete the cat
            rowInQuestion = animalsTable.Rows[1];
            rowInQuestion.Delete();
            // Leave the Horse untouched.
            // Make Changes - Insert a camel
            rowInQuestion = animalsTable.NewRow();
            rowInQuestion["AnimalID"] = 4;
            rowInQuestion["AnimalName"] = "Camel";
            animalsTable.Rows.Add(rowInQuestion);

            DisplayRowStates("Row states for a modified DataTable:", animalsTable);

            // Detached Row
            rowInQuestion = animalsTable.NewRow();
            rowInQuestion["AnimalID"] = 5;
            rowInQuestion["AnimalName"] = "Monkey";
            Console.WriteLine("Monkey Row's RowState: " + rowInQuestion.RowState.ToString());
            Console.ReadLine();

            // Update the changes back to the database.
            SqlCommandBuilder cmbldr = new SqlCommandBuilder(sqlDa);

            // Setup Update Command
            sqlDa.UpdateCommand = cmbldr.GetUpdateCommand();
            Console.WriteLine("Update Command: " + sqlDa.UpdateCommand.CommandText);

            // Setup Insert Command
            sqlDa.InsertCommand = cmbldr.GetInsertCommand();
            Console.WriteLine("Insert Command: " + sqlDa.InsertCommand.CommandText);

            // Setup Delete Command
            sqlDa.DeleteCommand = cmbldr.GetDeleteCommand() ;
            Console.WriteLine("Delete Command: " + sqlDa.DeleteCommand.CommandText);

            sqlDa.Update(animalsTable);

            DisplayRowStates("Final Row States:", animalsTable);
         }
      }

      private static void DisplayRowStates(string Message, DataTable table)
      {
         Console.Clear();
         Console.WriteLine("\n");
         Console.WriteLine(Message);
         Console.WriteLine("-------------------------------------------");

         foreach (DataRow dr in table.Rows)
         {
            Console.WriteLine(dr.RowState.ToString());
         }

         Console.WriteLine("\nPress Enter to Continue ..");
         Console.ReadLine();
      }
   }
}

