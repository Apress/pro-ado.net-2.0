#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;

#endregion

namespace Example_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the table
            DataTable productsTable = new DataTable("Products") ;
            // Build the Products schema
            productsTable.Columns.Add("ID", typeof(System.Int32)) ;
            productsTable.Columns.Add("Name", typeof(System.String)) ;
            productsTable.Columns.Add("Category", typeof(System.Int32)) ;

            // Set up the ID column as the primary key
            productsTable.PrimaryKey = 
                new DataColumn[] { productsTable.Columns["ID"] };

            productsTable.Columns["ID"].AutoIncrement = true ;
            productsTable.Columns["ID"].AutoIncrementSeed = 1 ;
            productsTable.Columns["ID"].ReadOnly = true ;

            DataRow tempRow;
            for (int i = 0; i < 10; i++)
            {
                tempRow = productsTable.NewRow();
                // Make every even row Caterham Seven de Dion
                if (Math.IEEERemainder(i, 2) == 0)
                {
                    tempRow["Name"] = "Caterham Seven de Dion #" + i.ToString() ;
                    tempRow["Category"] = 1;
                }
                else
                {
                    tempRow["Name"] = "Dodge Viper #" + i.ToString() ;
                    tempRow["Category"] = 2;
                }
                productsTable.Rows.Add(tempRow);
            }
            productsTable.WriteXml("productsTable.xml") ;
        }
    }
}
