#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Exercise_8_6
{
   partial class Form1 : Form
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      private DataTable productsTable;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         DataSet customerProducts = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath);
         productsTable = customerProducts.Tables[1];

         DataColumn totalPrice = new DataColumn("Total Price");
         totalPrice.Expression = "Price + Price * TaxPercent";
         productsTable.Columns.Add(totalPrice);
         dataGridView1.DataSource = productsTable;
      }

      private void btnSumPrices_Click(object sender, EventArgs e)
      {
         string price = productsTable.Compute("Sum(Price)", "Price < 500").ToString();
         lblSumPrice.Text = "The total price is : " + price;
      }
   }
}