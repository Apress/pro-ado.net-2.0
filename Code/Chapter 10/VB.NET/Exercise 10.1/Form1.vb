Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
   Private connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Private animalsData As AnimalsDataSet

   Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim sqlDa As SqlDataAdapter

         testConnection.Open()
         Dim trans As SqlTransaction = testConnection.BeginTransaction()
         Dim param As SqlParameter

         ' Lets deal with the inserts first.

         ' Starting at the top of the hierarchy - the animals table.          
         ' insertAnimalCommand
         Dim insertAnimalCommand As SqlCommand = New SqlCommand()
         insertAnimalCommand.Connection = testConnection
         insertAnimalCommand = New SqlCommand("UP_ANIMALINSERT")
         insertAnimalCommand.CommandType = CommandType.StoredProcedure

         param = New SqlParameter("@AnimalID", SqlDbType.Int, 4, "AnimalID")
         param.Direction = ParameterDirection.Output
         insertAnimalCommand.Parameters.Add(param)

         param = New SqlParameter("@AnimalType", SqlDbType.VarChar, 50, "AnimalType")
         param.Direction = ParameterDirection.Input
         insertAnimalCommand.Parameters.Add(param)

         insertAnimalCommand.Transaction = trans

         ' Moving down the hierarchy - the Pets Table
         '  insertPetCommand
         Dim insertPetCommand As SqlCommand = New SqlCommand()
         insertPetCommand.Connection = testConnection

         insertPetCommand = New SqlCommand("UP_PETSINSERT")
         insertPetCommand.CommandType = CommandType.StoredProcedure

         param = New SqlParameter("@PetID", SqlDbType.Int, 4, "PetID")
         param.Direction = ParameterDirection.Output
         insertPetCommand.Parameters.Add(param)

         param = New SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName")
         param.Direction = ParameterDirection.Input
         insertPetCommand.Parameters.Add(param)

         param = New SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName")
         param.Direction = ParameterDirection.Input
         insertPetCommand.Parameters.Add(param)

         param = New SqlParameter("@Weight", SqlDbType.Int, 4, "Weight")
         param.Direction = ParameterDirection.Input
         insertPetCommand.Parameters.Add(param)

         ' This parameter will be retreived from the first command insertAnimalCommand
         param = New SqlParameter("@AnimalID", SqlDbType.Int, 4, "AnimalID")
         param.Direction = ParameterDirection.Input
         insertPetCommand.Parameters.Add(param)

         insertPetCommand.Transaction = trans

         ' Finally moving to the end of the hierarchy - PetBelonging
         '  insertPetBelongingCommand
         Dim insertPetBelongingCommand As SqlCommand = New SqlCommand()
         insertPetBelongingCommand.Connection = testConnection

         insertPetBelongingCommand = New SqlCommand("UP_PETBELONGINGINSERT")
         insertPetBelongingCommand.CommandType = CommandType.StoredProcedure

         param = New SqlParameter("@PetBelongingID", SqlDbType.Int, 4, "PetBelongingID")
         param.Direction = ParameterDirection.Output
         insertPetBelongingCommand.Parameters.Add(param)

         param = New SqlParameter("@Name", SqlDbType.VarChar, 50, "Name")
         param.Direction = ParameterDirection.Input
         insertPetBelongingCommand.Parameters.Add(param)

         param = New SqlParameter("@Price", SqlDbType.Float, 8, "Price")
         param.Direction = ParameterDirection.Input
         insertPetBelongingCommand.Parameters.Add(param)

         ' This parameter will be retreived from the first command insertPetCommand
         param = New SqlParameter("@PetID", SqlDbType.Int, 4, "PetID")
         param.Direction = ParameterDirection.Input
         insertPetBelongingCommand.Parameters.Add(param)

         insertPetBelongingCommand.Transaction = trans

         ' .. Start the work
         Try
            sqlDa = New SqlDataAdapter("Select * from Animals", testConnection)
            sqlDa.InsertCommand = insertAnimalCommand
            sqlDa.InsertCommand.Connection = testConnection
            sqlDa.Update(animalsData.Animals.Select("", "", DataViewRowState.Added))

            sqlDa = New SqlDataAdapter("Select * from Pets", testConnection)
            sqlDa.InsertCommand = insertPetCommand
            sqlDa.InsertCommand.Connection = testConnection
            sqlDa.Update(animalsData.Pets.Select("", "", DataViewRowState.Added))

            sqlDa = New SqlDataAdapter("Select * from PetBelonging", testConnection)
            sqlDa.InsertCommand = insertPetBelongingCommand
            sqlDa.InsertCommand.Connection = testConnection
            sqlDa.Update(animalsData.PetBelonging.Select("", "", DataViewRowState.Added))

            ' All good, lets commit.
            trans.Commit()
         Catch
            trans.Rollback()
         Finally
            FillData()
            testConnection.Close()
         End Try
      End Using
   End Sub

   Private Sub FillData()
      animalsData = New AnimalsDataSet()
      Dim sqlDA As SqlDataAdapter = New SqlDataAdapter( _
         "Select * from Animals; Select * from Pets;" & _
         "Select * from PetBelonging", _
         connectionString)
      sqlDa.TableMappings.Add("Table", "Animals")
      sqlDa.TableMappings.Add("Table1", "Pets")
      sqlDa.TableMappings.Add("Table2", "PetBelonging")
      sqlDa.Fill(animalsData)

      dgAnimals.DataSource = animalsData.Tables("Animals")
      dgPets.DataSource = animalsData.Tables("Pets")
      dgPetBelonging.DataSource = _
         animalsData.Tables("PetBelonging")
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      FillData()
   End Sub
End Class
