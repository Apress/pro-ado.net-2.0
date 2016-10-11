#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

#endregion

namespace Exercise_9_7
{
   class Program
   {
      static void Main(string[] args)
      {
         DataSet dsUsers = new DataSet("Users");

         try
         {
            // Define a connection object
            OleDbConnection dbConn = new OleDbConnection(
               "Provider=Microsoft.Jet.OLEDB.4.0;" +
               "Password=;User ID=Admin;Data Source=db.mdb");

            // Create a data adapter to retrieve records from DB
            OleDbDataAdapter daUsers =
               new OleDbDataAdapter("SELECT ID,fn,ln,cty,st" +
               " FROM tabUsers", dbConn);

            // Define each column to map
            DataColumnMapping dcmUserID =
               new DataColumnMapping("ID", "UserID");
            DataColumnMapping dcmFirstName =
               new DataColumnMapping("fn", "FirstName");
            DataColumnMapping dcmLastName =
               new DataColumnMapping("ln", "LastName");
            DataColumnMapping dcmCity =
               new DataColumnMapping("cty", "City");
            DataColumnMapping dcmState =
               new DataColumnMapping("st", "State");

            // Define the table containing the mapped columns
            DataTableMapping dtmUsers = new DataTableMapping("Table", "User");
            dtmUsers.ColumnMappings.Add(dcmUserID);
            dtmUsers.ColumnMappings.Add(dcmFirstName);
            dtmUsers.ColumnMappings.Add(dcmLastName);
            dtmUsers.ColumnMappings.Add(dcmCity);
            dtmUsers.ColumnMappings.Add(dcmState);

            // Activate the mapping mechanism
            daUsers.TableMappings.Add(dtmUsers);

            // Fill the dataset
            daUsers.Fill(dsUsers);

            // Declare a command builder to create SQL instructions
            // to create and update records.
            OleDbCommandBuilder cb = new OleDbCommandBuilder(daUsers);

            // Insert a new record in the DataSet
            DataRow r = dsUsers.Tables[0].NewRow();
            r["FirstName"] = "Eddie";
            r["LastName"] = "Robinson";
            r["City"] = "Houston";
            r["State"] = "Texas";
            dsUsers.Tables[0].Rows.Add(r);

            // Insert the record in the database
            daUsers.Update(dsUsers.GetChanges());

            // Align in-memory data with the data source ones
            dsUsers.AcceptChanges();

            // Print successfully message
            Console.WriteLine("A new record has been" + " added to the database.");
         }
         catch (Exception ex)
         {
            // Reject DataSet changes
            dsUsers.RejectChanges();

            // An error occurred. Show the error message
            Console.WriteLine(ex.Message);
         }
      }
   }
}
