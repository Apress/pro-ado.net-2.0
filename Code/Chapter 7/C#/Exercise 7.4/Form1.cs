#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

#endregion

namespace Exercise_7_4
{
   partial class Form1 : Form
   {
      private DataSet myData;
      public Form1()
      {
         InitializeComponent();
         myData = new DataSet();
      }

      private void buttonSchema_Click(object sender, EventArgs e)
      {
         string connectionString =
         "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;";

         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText = "Select * from userTable; Select * from permissionsTable";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(testCommand);

            dataAdapter.FillSchema(myData, SchemaType.Source);
         } // testConnection.Dispose called automatically.
         DisplayContents() ;
      }

      private void buttonData_Click(object sender, EventArgs e)
      {
         string connectionString =
         "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;";

         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText = "Select * from userTable; Select * from permissionsTable";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(testCommand);

            dataAdapter.Fill(myData);
         } // testConnection.Dispose called automatically.
         DisplayContents() ;
      }

      private void DisplayContents()
      {
         myData.WriteXml(Application.StartupPath + "\\myData.Xml", XmlWriteMode.WriteSchema) ;
         xmlBrowser.Navigate(Application.StartupPath + "\\myData.Xml") ;
      }
   }
}