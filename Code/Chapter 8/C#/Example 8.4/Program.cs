#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CreateDataSet;

#endregion

namespace Exercise_8_4
{
   class Program
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      static void Main(string[] args)
      {
         DataTable myTable = DataSetFiller.FillDataset(dataFilePath).Tables[0];
         myTable.PrimaryKey = new DataColumn[] { myTable.Columns["CustomerID"] };
         myTable.AcceptChanges();
         DataRow janeRow = myTable.Rows.Find("5");
         janeRow["LastName"] = "QueenOfJungle";
         DataRow[] drs = myTable.Select("", "", DataViewRowState.ModifiedOriginal);
         if (drs != null)
         {
            foreach (DataRow dr in drs)
            {
               ShowDataRow(dr);
            }
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
