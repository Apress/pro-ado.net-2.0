using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccChanges
{
   public partial class Form1 : Form
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      private DataSet ds = null;

      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from Customers",testConnection);
            SqlCommand myUpdateCommand = new SqlCommand("Update Customers Set FirstName = @FirstName where CustomerID = @CustomerID");

            SqlParameter param1 = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            param1.SourceColumn = "FirstName";

            SqlParameter param2 = new SqlParameter("@CustomerID", SqlDbType.VarChar, 50);
            param2.SourceColumn = "CustomerID";

            myUpdateCommand.Parameters.AddRange(new SqlParameter[] {param1,param2}) ;
            myUpdateCommand.Connection = testConnection;

            sqlDA.UpdateCommand = myUpdateCommand;

            testConnection.Open();
            SqlTransaction myTransaction = testConnection.BeginTransaction();
            sqlDA.UpdateCommand.Transaction = myTransaction;
            sqlDA.AcceptChangesDuringUpdate = false;

            try
            {
               sqlDA.Update(ds);
               myTransaction.Commit();
               ds.AcceptChanges();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from Customers", testConnection);
            ds = new DataSet();
            sqlDA.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
         }
      }
   }
}