#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using CreateDataSet;
#endregion

namespace Exercise_8_1
{
   class Program
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      static void Main(string[] args)
      {
         // Base DataTable
         DataTable myTable = DataSetFiller.FillDataset(dataFilePath).Tables[0] ;
         // Set Primary Key
         myTable.PrimaryKey = new DataColumn[] { myTable.Columns["CustomerID"] };
         DataRow dr = myTable.Rows.Find("2");
         if (dr != null)
         {
            Console.WriteLine("Find a row using a base DataSet");
            ShowDataRow(dr);
         }

         // Strongly typed DataSet
         CustProd.CustomersDataTable myStrongDataTable = DataSetFiller.FillStrongDataSet(dataFilePath).Customers;
         CustProd.CustomersRow cr = myStrongDataTable.FindByCustomerID(2);
         if (cr != null)
         {
            Console.WriteLine("Find a row using a strongly typed DataSet");
            Console.WriteLine(cr.CustomerID + " " + cr.FirstName + " " + cr.LastName);
         }
      }

      static void ShowDataRow(DataRow dr)
      {
         foreach (DataColumn dc in dr.Table.Columns)
         {
            Console.Write(dr[dc] + " ");
         }
         Console.Write("\n\n");
      }
   }
}
