#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

#endregion

namespace Exercise_10_1
{
   partial class Form1 : Form
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      private AnimalsDataSet animalsData;

      public Form1()
      {
         InitializeComponent();
         FillData();
      }

      private void FillData()
      {
         animalsData = new AnimalsDataSet();
         SqlDataAdapter sqlDa = new SqlDataAdapter(
            "Select * from Animals; Select * from Pets; Select * from PetBelonging",
            connectionString);
         sqlDa.TableMappings.Add("Table", "Animals");
         sqlDa.TableMappings.Add("Table1", "Pets");
         sqlDa.TableMappings.Add("Table2", "PetBelonging");
         sqlDa.Fill(animalsData);

         dgAnimals.DataSource = animalsData.Tables["Animals"];
         dgPets.DataSource = animalsData.Tables["Pets"];
         dgPetBelonging.DataSource = animalsData.Tables["PetBelonging"];
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         using (SqlConnection testConnection = new SqlConnection(connectionString))
         {
            SqlDataAdapter sqlDa;

            testConnection.Open();
            SqlTransaction trans = testConnection.BeginTransaction();
            SqlParameter param;

            // Lets deal with the inserts first.

            // Starting at the top of the hierarchy - the animals table.          
            #region insertAnimalCommand
            SqlCommand insertAnimalCommand = new SqlCommand();
            insertAnimalCommand.Connection = testConnection;
            insertAnimalCommand = new SqlCommand("UP_ANIMALINSERT");
            insertAnimalCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@AnimalID", SqlDbType.Int, 4, "AnimalID");
            param.Direction = ParameterDirection.Output;
            insertAnimalCommand.Parameters.Add(param);

            param = new SqlParameter("@AnimalType", SqlDbType.VarChar, 50, "AnimalType");
            param.Direction = ParameterDirection.Input;
            insertAnimalCommand.Parameters.Add(param);

            insertAnimalCommand.Transaction = trans;
            #endregion

            // Moving down the hierarchy - the Pets Table
            #region insertPetCommand
            SqlCommand insertPetCommand = new SqlCommand();
            insertPetCommand.Connection = testConnection;

            insertPetCommand = new SqlCommand("UP_PETSINSERT");
            insertPetCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@PetID", SqlDbType.Int, 4, "PetID");
            param.Direction = ParameterDirection.Output;
            insertPetCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            param.Direction = ParameterDirection.Input;
            insertPetCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName");
            param.Direction = ParameterDirection.Input;
            insertPetCommand.Parameters.Add(param);

            param = new SqlParameter("@Weight", SqlDbType.Int, 4, "Weight");
            param.Direction = ParameterDirection.Input;
            insertPetCommand.Parameters.Add(param);

            // This parameter will be retreived from the first command insertAnimalCommand
            param = new SqlParameter("@AnimalID", SqlDbType.Int, 4, "AnimalID");
            param.Direction = ParameterDirection.Input;
            insertPetCommand.Parameters.Add(param);

            insertPetCommand.Transaction = trans;
            #endregion

            // Finally moving to the end of the hierarchy - PetBelonging
            #region insertPetBelongingCommand
            SqlCommand insertPetBelongingCommand = new SqlCommand();
            insertPetBelongingCommand.Connection = testConnection;

            insertPetBelongingCommand = new SqlCommand("UP_PETBELONGINGINSERT");
            insertPetBelongingCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@PetBelongingID", SqlDbType.Int, 4, "PetBelongingID");
            param.Direction = ParameterDirection.Output;
            insertPetBelongingCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name");
            param.Direction = ParameterDirection.Input;
            insertPetBelongingCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Float, 8, "Price");
            param.Direction = ParameterDirection.Input;
            insertPetBelongingCommand.Parameters.Add(param);

            // This parameter will be retreived from the first command insertPetCommand
            param = new SqlParameter("@PetID", SqlDbType.Int, 4, "PetID");
            param.Direction = ParameterDirection.Input;
            insertPetBelongingCommand.Parameters.Add(param);

            insertPetBelongingCommand.Transaction = trans;
            #endregion

            // .. Start the work
            try
            {
               sqlDa = new SqlDataAdapter("Select * from Animals", testConnection);
               sqlDa.InsertCommand = insertAnimalCommand;
               sqlDa.InsertCommand.Connection = testConnection;
               sqlDa.Update(animalsData.Animals.Select("", "", DataViewRowState.Added));

               sqlDa = new SqlDataAdapter("Select * from Pets", testConnection);
               sqlDa.InsertCommand = insertPetCommand;
               sqlDa.InsertCommand.Connection = testConnection;
               sqlDa.Update(animalsData.Pets.Select("", "", DataViewRowState.Added));

               sqlDa = new SqlDataAdapter("Select * from PetBelonging", testConnection);
               sqlDa.InsertCommand = insertPetBelongingCommand;
               sqlDa.InsertCommand.Connection = testConnection;
               sqlDa.Update(animalsData.PetBelonging.Select("", "", DataViewRowState.Added));

               // All good, lets commit.
               trans.Commit();
            }
            catch (System.Exception)
            {
               trans.Rollback();
            }
            finally
            {
               FillData();
               testConnection.Dispose();
            }
         }
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}