#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

#endregion

namespace Exercise_8_9
{
   partial class Form1 : Form
   {
      private static string dataFilePath = @"..\..\..\..\..\Data.Xml";
      private DataTable CustomersTable;
      private XmlDataDocument xdd;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         CustomersTable = CreateDataSet.DataSetFiller.FillDataset(dataFilePath).Tables["Customers"];
         xdd = new XmlDataDocument(CustomersTable.DataSet);
         dgView.DataSource = CustomersTable;
         xdd.Save(Application.ExecutablePath + "_xdd.xml");
         xmlViewer.Navigate(Application.ExecutablePath + "_xdd.xml");
         CustomersTable.RowChanged +=new DataRowChangeEventHandler(CustomersTable_RowChanged);
      }

      void CustomersTable_RowChanged(object sender, DataRowChangeEventArgs e)
      {
         xdd.Save(Application.ExecutablePath + "_xdd.xml");
         xmlViewer.Navigate(Application.ExecutablePath + "_xdd.xml");
      }
   }
}