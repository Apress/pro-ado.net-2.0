#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

#endregion

namespace Exercise_9_4
{
   partial class Form1 : Form
   {
      private string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";

      private DataTable animalsTable;

      public Form1()
      {
         InitializeComponent();

         // Setup the schema for the Table.
         animalsTable = new DataTable("Animals");
         DataColumn dc ;

         dc = new DataColumn("AnimalID");
         dc.Unique = true;
         dc.AutoIncrement = true;
         dc.AutoIncrementSeed = -1;
         dc.AutoIncrementStep = -1;
         dc.DataType = typeof(System.Int32);
         animalsTable.Columns.Add(dc);

         dc = new DataColumn("AnimalName");
         animalsTable.Columns.Add(dc);

         dc = new DataColumn("AccountNumber");
         dc.ReadOnly = true;
         animalsTable.Columns.Add(dc);

         // DataBind it, even though it has no rows in it yet.
         dgView.DataSource = animalsTable;
      }

      private void btnLoad_Click(object sender, EventArgs e)
      {
         SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from Animals", connectionString);
         animalsTable.Rows.Clear();
         sqlDA.Fill(animalsTable);
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         SqlCommand insertCommand = new SqlCommand();
         insertCommand.CommandType = CommandType.StoredProcedure;
         
         SqlParameter param;

         param = new SqlParameter("@AnimalID", SqlDbType.Int);
         param.Direction = ParameterDirection.Output;
         param.SourceColumn = "AnimalID";
         insertCommand.Parameters.Add(param);

         param = new SqlParameter("@AnimalName", SqlDbType.VarChar);
         param.SourceColumn = "AnimalName";
         insertCommand.Parameters.Add(param);

         param = new SqlParameter("@AccountNumber", SqlDbType.Int);
         param.SourceColumn = "AccountNumber";
         param.Size = 40;
         param.Direction = ParameterDirection.Output;
         insertCommand.Parameters.Add(param);

         insertCommand.CommandText = "UP_ANIMALINSERT";
         SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from Animals", connectionString);
         insertCommand.Connection = new SqlConnection(connectionString);
         insertCommand.UpdatedRowSource = UpdateRowSource.Both;
         sqlDA.InsertCommand = insertCommand;

         sqlDA.Update(animalsTable);
      }
   }
}