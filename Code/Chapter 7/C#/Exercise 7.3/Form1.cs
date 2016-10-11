#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
#endregion

namespace Exercise_7_3
{
   partial class Form1 : Form
   {
      private DataSet myData;

      public Form1()
      {
         InitializeComponent();
         myData = new DataSet();
      }

      private void buttonUserData_Click(object sender, EventArgs e)
      {
         // If there is a data source, remove it.
         datagridView.DataSource = "";
         // Never hard code connection strings.
         // Usually you would get this from a config file
         string connectionString =
         "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;";

         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText = "Select * from userTable";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(testCommand);

            dataAdapter.Fill(myData, "UserTable");
         } // testConnection.Dispose called automatically.
         UpdateComboBox();
      }

      private void btnPermData_Click(object sender, EventArgs e)
      {
         // Never hard code connection strings.
         // Usually you would get this from a config file
         string connectionString =
         "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;";

         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlCommand testCommand = testConnection.CreateCommand();
            testCommand.CommandText = "Select PermissionType from PermissionsTable";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(testCommand);

            dataAdapter.Fill(myData, "PermissionsTable");
         } // testConnection.Dispose called automatically.
         UpdateComboBox();
      }

      private void UpdateComboBox()
      {
         comboTables.Items.Clear();
         foreach (DataTable tbl in myData.Tables)
         {
            comboTables.Items.Add(tbl.TableName);
         }
      }

      private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
      {
         datagridView.DataSource = myData.Tables[comboTables.SelectedIndex];
      }
   }
}