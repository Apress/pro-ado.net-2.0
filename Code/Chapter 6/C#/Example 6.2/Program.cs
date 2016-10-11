#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

#endregion

namespace Example_6_2
{
   class Program
   {
      static void Main(string[] args)
      {
            DataTable productsTable = SetupAndPopulateDataTable();
            // Setup Events.
            productsTable.ColumnChanged += 
               new DataColumnChangeEventHandler(productsTable_ColumnChanged);
            productsTable.ColumnChanging += 
               new DataColumnChangeEventHandler(productsTable_ColumnChanging);
            productsTable.RowChanged +=
               new DataRowChangeEventHandler(productsTable_RowChanged);
            productsTable.RowChanging +=
               new DataRowChangeEventHandler(productsTable_RowChanging);
            productsTable.RowDeleted +=
               new DataRowChangeEventHandler(productsTable_RowDeleted);
            productsTable.RowDeleting +=
               new DataRowChangeEventHandler(productsTable_RowDeleting);

            Console.WriteLine("Change some data and watch the events fire.");
            Console.WriteLine("------------------------------------------");
            productsTable.Rows[0]["Name"] = "Pinto";

            Console.WriteLine("\nDelete a row and watch the events fire.");
            Console.WriteLine("------------------------------------------");
            productsTable.Rows[0].Delete();

            Console.Read();
         }

      private static DataTable SetupAndPopulateDataTable()
      {
            // Create the table
            DataTable productsTable = new DataTable("Products");
            // Build the Products schema
            productsTable.Columns.Add("ID", typeof(System.Int32));
            productsTable.Columns.Add("Name", typeof(System.String));
            productsTable.Columns.Add("Category", typeof(System.Int32));

            // Set up the ID column as the primary key
            productsTable.PrimaryKey =
               new DataColumn[] { productsTable.Columns["ID"] };

            productsTable.Columns["ID"].AutoIncrement = true;
            productsTable.Columns["ID"].AutoIncrementSeed = 1;
            productsTable.Columns["ID"].ReadOnly = true;

            DataRow tempRow;
            for (int i = 0; i < 10; i++)
            {
               tempRow = productsTable.NewRow();
               // Make every even row Caterham Seven de Dion
               if (Math.IEEERemainder(i, 2) == 0)
               {
                  tempRow["Name"] = "Caterham Seven de Dion #" + i.ToString();
                  tempRow["Category"] = 1;
               }
               else
               {
                  tempRow["Name"] = "Dodge Viper #" + i.ToString();
                  tempRow["Category"] = 2;
               }
               productsTable.Rows.Add(tempRow);
            }
            productsTable.AcceptChanges();
            return productsTable;
      }

      private static void productsTable_ColumnChanged
         (object sender, DataColumnChangeEventArgs e)
      {
            Console.WriteLine("productsTable_ColumnChanged");
            Console.WriteLine("   Value: " + e.Row["Name"].ToString());
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }

      private static void productsTable_ColumnChanging
         (object sender, DataColumnChangeEventArgs e)
      {
            Console.WriteLine("productsTable_ColumnChanging");
            Console.WriteLine("   Value: " + e.Row["Name"].ToString());
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }

      private static void productsTable_RowChanged
         (object sender, DataRowChangeEventArgs e)
      {
            Console.WriteLine("productsTable_RowChanged");
            Console.WriteLine("   Value: " + e.Row["Name"].ToString());
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }

      private static void productsTable_RowChanging
         (object sender, DataRowChangeEventArgs e)
      {
            Console.WriteLine("productsTable_RowChanging");
            Console.WriteLine("   Value: " + e.Row["Name"].ToString());
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }

      private static void productsTable_RowDeleted
         (object sender, DataRowChangeEventArgs e)
      {
            Console.WriteLine("productsTable_RowDeleted");
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }

      private static void productsTable_RowDeleting
         (object sender, DataRowChangeEventArgs e)
      {
            Console.WriteLine("productsTable_RowDeleting");
            Console.WriteLine("   RowState: " + e.Row.RowState.ToString());
      }
   }
}