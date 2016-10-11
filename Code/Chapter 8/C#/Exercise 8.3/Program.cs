#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CreateDataSet;

#endregion

namespace Exercise_8_3
{
   class Program
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      static void Main(string[] args)
      {
         DataTable myTable = DataSetFiller.FillDataset(dataFilePath).Tables[0];
         DataRow[] drs = myTable.Select("LastName Like '%OfJungle'","FirstName ASC");
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
