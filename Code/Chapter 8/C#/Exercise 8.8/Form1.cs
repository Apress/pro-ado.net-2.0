#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace Exercise_8_8
{
   partial class Form1 : Form
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      private DataTable CustomersTable;
      private DataView CustomersView;

      public Form1()
      {
         InitializeComponent();
      }

      private void btnLoad_Click(object sender, EventArgs e)
      {
         CustomersTable = CreateDataSet.DataSetFiller.FillDataset(dataFilePath).Tables["Customers"];
         CustomersView = new DataView(CustomersTable);
         dgView.DataSource = CustomersView;
      }

      private void btnSort_Click(object sender, EventArgs e)
      {
         CustomersView.Sort = "FirstName ASC";
      }

      private void btnFilter_Click(object sender, EventArgs e)
      {
         CustomersView.RowFilter = "LastName like '%OfJungle'" ;
      }

      private void btnFindRows_Click(object sender, EventArgs e)
      {
         DataRowView[] drvs = CustomersView.FindRows("Tarzan");
         foreach (DataRowView drv in drvs)
         {
            MessageBox.Show(drv.Row["FirstName"] + " " + drv.Row["LastName"], "Selected Item");
         }
      }
    }
}