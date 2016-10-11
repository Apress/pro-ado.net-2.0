#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Exercise_9_6
{
   partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnMerge_Click(object sender, EventArgs e)
      {
         DataTable table1 = (DataTable)dgView1.DataSource;
         DataTable table2 = (DataTable)dgView2.DataSource;
         table1.Merge(table2);
      }

      private void btnSameNoPK_Click(object sender, EventArgs e)
      {
         VariousTables.Table0DataTable table1 = new VariousTables.Table0DataTable();
         table1.LoadDataRow(new object[] { "1", "One" }, true);
         table1.LoadDataRow(new object[] { "2", "Two" }, true);

         VariousTables.Table0DataTable table2 = new VariousTables.Table0DataTable();
         table2.LoadDataRow(new object[] { "2", "Monkey" }, true);
         table2.LoadDataRow(new object[] { "3", "Donkey" }, true);

         dgView1.DataSource = table1;
         dgView2.DataSource = table2;
      }

      private void btnSameWithPK_Click(object sender, EventArgs e)
      {
         VariousTables.Table1DataTable table1 = new VariousTables.Table1DataTable();
         table1.LoadDataRow(new object[] { "1", "One" }, true);
         table1.LoadDataRow(new object[] { "2", "Two" }, true);

         VariousTables.Table1DataTable table2 = new VariousTables.Table1DataTable();
         table2.LoadDataRow(new object[] { "2", "Monkey" }, true);
         table2.LoadDataRow(new object[] { "3", "Donkey" }, true);

         dgView1.DataSource = table1;
         dgView2.DataSource = table2;
      }

      private void btnCCNoPK_Click(object sender, EventArgs e)
      {
         VariousTables.Table0DataTable table1 = new VariousTables.Table0DataTable();
         table1.LoadDataRow(new object[] { "1", "One" }, true);
         table1.LoadDataRow(new object[] { "2", "Two" }, true);

         VariousTables.Table2DataTable table2 = new VariousTables.Table2DataTable();
         table2.LoadDataRow(new object[] { "2", "Monkey" }, true);
         table2.LoadDataRow(new object[] { "3", "Donkey" }, true);

         dgView1.DataSource = table1;
         dgView2.DataSource = table2;
      }

      private void btnCCWithPK_Click(object sender, EventArgs e)
      {
         VariousTables.Table1DataTable table1 = new VariousTables.Table1DataTable();
         table1.LoadDataRow(new object[] { "1", "One" }, true);
         table1.LoadDataRow(new object[] { "2", "Two" }, true);

         VariousTables.Table2DataTable table2 = new VariousTables.Table2DataTable();
         table2.LoadDataRow(new object[] { "2", "Monkey" }, true);
         table2.LoadDataRow(new object[] { "3", "Donkey" }, true);

         dgView1.DataSource = table1;
         dgView2.DataSource = table2;
      }

      private void btnDifferent_Click(object sender, EventArgs e)
      {
         //VariousTables.Table0DataTable table1 = new VariousTables.Table0DataTable();
         
          //Note I have the above line commented. Because it doesn't work - here is an explanation why.
          //This is because if you view the final merged table - it contains results that violate the unique constraint setup 
          //in Table0DataTable. So internally in Merge, 
          //The constraints are turned off (this gives a performance boost)
          //data is merged
          //Constraints are enabled <-- you get an exception here because the merged datatable does not have unique values in ColumnA ;)

         //Go ahead and uncomment the above, and comment 3 lines below and see a running proof of what I just told ya.

         DataTable table1 = new DataTable();
         table1.Columns.Add(new DataColumn("ColumnA"));
         table1.Columns.Add(new DataColumn("ColumnB"));
         table1.LoadDataRow(new object[] { "1", "One" }, true);
         table1.LoadDataRow(new object[] { "2", "Two" }, true);

         VariousTables.Table3DataTable table2 = new VariousTables.Table3DataTable();
         table2.LoadDataRow(new object[] { "3", "Monkey" }, true);
         table2.LoadDataRow(new object[] { "4", "Donkey" }, true);

         dgView1.DataSource = table1;
         dgView2.DataSource = table2;
      }
   }
}