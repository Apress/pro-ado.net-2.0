#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Exercise_9_5
{
   partial class Form1 : Form
   {
      private CustProd myDataSet;

      public Form1()
      {
         InitializeComponent();

         myDataSet = new CustProd();
         dgCustomers.DataSource = myDataSet.Customers;
         dgCustomerProducts.DataSource = myDataSet.CustomerProducts;
         dgProducts.DataSource = myDataSet.Products;

         myDataSet.ReadXml("Data.xml");
         myDataSet.AcceptChanges();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnGetChanges_Click(object sender, EventArgs e)
      {
         CustProd changedDS = (CustProd)myDataSet.GetChanges();
         dgCustomers.DataSource = changedDS.Customers;
         dgCustomerProducts.DataSource = changedDS.CustomerProducts;
         dgProducts.DataSource = changedDS.Products;
      }
   }
}