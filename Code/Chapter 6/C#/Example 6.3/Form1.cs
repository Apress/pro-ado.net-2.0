#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Example_6_3
{
   partial class Form1 : Form
   {
      private DataSet petsData;
      public Form1()
      {
         InitializeComponent();
      }

      private void btnPopulate_Click(object sender, EventArgs e)
      {
         petsData = CreateSchema();
         petsGrid.DataSource = petsData.Tables["Pet"];
         AnimalsGrid.DataSource = petsData.Tables["Animal"];
      }

      private DataSet CreateSchema()
      {
         DataTable AnimalTable = new DataTable("Animal");
         DataColumn myDataColumn;

         myDataColumn = new DataColumn("AnimalID", typeof(System.Int32));
         myDataColumn.AutoIncrement = true;
         AnimalTable.Columns.Add(myDataColumn);

         myDataColumn = new DataColumn("AnimalName", typeof(System.String));
         AnimalTable.Columns.Add(myDataColumn);

         DataTable petsTable = new DataTable("Pet");

         myDataColumn = new DataColumn("PetID", typeof(System.Int32));
         myDataColumn.AutoIncrement = true;
         petsTable.Columns.Add(myDataColumn);

         myDataColumn = new DataColumn("AnimalID", typeof(System.Int32));
         petsTable.Columns.Add(myDataColumn);

         myDataColumn = new DataColumn("PetName", typeof(System.String));
         petsTable.Columns.Add(myDataColumn);

         DataSet toReturn = new DataSet("petsData");
         toReturn.Tables.Add(AnimalTable);
         toReturn.Tables.Add(petsTable);
         toReturn.Relations.Add(
            new DataRelation("AnimalsPets",
            AnimalTable.Columns["AnimalID"], petsTable.Columns["AnimalID"]));

         return toReturn;
      }

      private void btnShowXml_Click(object sender, EventArgs e)
      {
         MessageBox.Show(petsData.GetXml(), "DataSet Contents");
      }

      private void nestedRelation_CheckedChanged(object sender, EventArgs e)
      {
         if (petsData != null)
         {
            petsData.Relations[0].Nested = nestedRelation.Checked;
         }
      }
   }
}