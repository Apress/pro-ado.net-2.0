#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
#endregion

namespace Exercise_7_6
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            OleDbConnection dbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=..\\..\\db.mdb");
            OleDbDataAdapter usersDataAdapter = new OleDbDataAdapter("SELECT ID, fn, ln, cty, st FROM tabUsers", dbConn);
            DataSet usersDataSet = new DataSet("User");
            DoDataMappings(usersDataAdapter);
            usersDataAdapter.Fill(usersDataSet);
            foreach (DataRow r in usersDataSet.Tables["tabUsers"].Rows)
            {
               Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, City: {3}, State: {4}", r["UserID"], r["FirstName"], r["LastName"], r["City"], r["State"]);
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
      }

      private static void DoDataMappings(OleDbDataAdapter dataAdapter)
      {
         try
         {
            // Define an array of columns to map.
            DataColumnMapping[] mappedColumns = {
               new DataColumnMapping("ID", "UserID"), 
               new DataColumnMapping("fn", "FirstName"), 
               new DataColumnMapping("ln", "LastName"), 
               new DataColumnMapping("cty", "City"), 
               new DataColumnMapping("st", "State")
            };

            // Define the table containing the mapped columns.
            DataTableMapping usersTableMapping = new DataTableMapping("Table", "tabUsers", mappedColumns);

            // Activate the mapping mechanism.
            dataAdapter.TableMappings.Add(usersTableMapping);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.ToString());
         }
      }
   }
}