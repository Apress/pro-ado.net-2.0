#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Exercise_8_7
{
   partial class Form1 : Form
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      private DataSet customerProducts;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         customerProducts = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath);
         foreach (DataRow dr in customerProducts.Tables["Customers"].Rows)
         {
            lbCustomers.Items.Add(dr["CustomerID"] + ":" + dr["FirstName"] + " " + dr["LastName"]);
         }
      }

      private void btnFilter2_Click(object sender, EventArgs e)
      {
         DataRow custProdRow;
         DataRow ProdRow;
         DataTable custProdTable = customerProducts.Tables["CustomerProducts"] ;
         lbProducts.Items.Clear();
         foreach (object item in lbCustomerProducts.Items)
         {
            int custProdId = (int)item;
            custProdRow = custProdTable.Rows.Find(custProdId);
            ProdRow = custProdRow.GetParentRow(customerProducts.Relations[0]);
            lbProducts.Items.Add(ProdRow["ProductName"]);
         }
      }

      private void btnFilter1_Click(object sender, EventArgs e)
      {
         if (lbCustomers.SelectedIndex == -1)
            return;
         DataRow selectedRow = customerProducts.Tables["Customers"].Rows[lbCustomers.SelectedIndex];
         DataRow[] childRows = selectedRow.GetChildRows(customerProducts.Relations[1]);
         lbCustomerProducts.Items.Clear();
         foreach (DataRow dr in childRows)
         {
            lbCustomerProducts.Items.Add(dr["CustomerProductID"]);
         }
      }
   }
}