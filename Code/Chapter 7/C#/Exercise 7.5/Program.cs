#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

#endregion

namespace Exercise_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OleDbConnection dbConn = 
                   new OleDbConnection(
                   "Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=..\\..\\db.mdb");
                string selectQuery = 
                   "SELECT ID AS UserID, fn AS FirstName, " + 
                   "ln AS LastName, cty AS City, st AS State FROM tabUsers";
                OleDbDataAdapter usersDataAdapter = new OleDbDataAdapter(selectQuery, dbConn);
                DataSet usersDataSet = new DataSet("Users");
                usersDataAdapter.Fill(usersDataSet);
                foreach (DataRow userRow in usersDataSet.Tables[0].Rows)
                {
                    Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, City: {3}, State: {4}", 
                       userRow["UserID"], userRow["FirstName"], 
                       userRow["LastName"], userRow["City"], userRow["State"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
