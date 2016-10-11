#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient ;
using System.Data.Common;
using System.Collections;

#endregion

namespace Example_5_4
{
    partial class Form1 : Form
    {
        private ArrayList dbRecordsHolder;
        public Form1()
        {
            InitializeComponent();
            dbRecordsHolder = new ArrayList();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI;Asynchronous Processing=true";
            SqlConnection testConnection = new SqlConnection(connectionString);
            
            SqlCommand testCommand =
                new SqlCommand("Select * from TestDemo", testConnection);
            testConnection.Open();

            AsyncCallback callback = new AsyncCallback(DataReaderIsReady);
            IAsyncResult asyncresult = testCommand.BeginExecuteReader(callback, testCommand);
        }

        private void DataReaderIsReady(IAsyncResult result)
        {
            MessageBox.Show("Results Load Complete","I'm Done");
            SqlCommand testCommand = (SqlCommand)result.AsyncState;

            SqlDataReader sqlDr = testCommand.EndExecuteReader(result);
            if (sqlDr.HasRows)
            {
                foreach (DbDataRecord rec in sqlDr)
                {
                    dbRecordsHolder.Add(rec);
                }
            }
            sqlDr.Close();
            testCommand.Connection.Dispose();
        }

        private void btnDataBind_Click(object sender, EventArgs e)
        {
            myDataGrid.DataSource = dbRecordsHolder;
        }
    }
}