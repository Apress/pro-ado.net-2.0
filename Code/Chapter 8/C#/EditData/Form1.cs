#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CreateDataSet;
#endregion

namespace EditData
{
   partial class Form1 : Form
   {
      private CustProd myDataSet;

      public Form1()
      {
         InitializeComponent();
      }

      private void btnCreate_Click(object sender, EventArgs e)
      {
         myDataSet = new CustProd();
         dgCustomers.DataSource = myDataSet.Customers;
         dgCustomerProducts.DataSource = myDataSet.CustomerProducts;
         dgProducts.DataSource = myDataSet.Products;
      }

      private void btnLoad_Click(object sender, EventArgs e)
      {
         OpenFileDialog dlg = new OpenFileDialog();
         dlg.Filter = "Xml Files (*.xml)|*.xml"; ;
         dlg.ShowDialog();
         if (dlg.FileName.Length > 0)
            LoadXML(dlg.FileName);
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         SaveFileDialog dlg = new SaveFileDialog();
         dlg.Filter = "Xml Files (*.xml)|*.xml"; ;
         dlg.ShowDialog();
         if (dlg.FileName.Length > 0)
            myDataSet.WriteXml(dlg.FileName);
      }

      private void LoadXML(string fileName)
      {
         myDataSet = new CustProd();
         myDataSet.ReadXml(fileName);
         dgCustomers.DataSource = myDataSet.Customers;
         dgCustomerProducts.DataSource = myDataSet.CustomerProducts;
         dgProducts.DataSource = myDataSet.Products;
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}