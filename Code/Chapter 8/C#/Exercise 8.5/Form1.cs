#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Exercise_8_5
{
   partial class Form1 : Form
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         DataSet customerProducts = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath);
         DataTable productsTable = customerProducts.Tables[1];

         DataColumn totalPrice = new DataColumn("Total Price");
         totalPrice.Expression = "Price + Price * TaxPercent";
         productsTable.Columns.Add(totalPrice);
         dataGridView1.DataSource = productsTable;
      }
   }
}