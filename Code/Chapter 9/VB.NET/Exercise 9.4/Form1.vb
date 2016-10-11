Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
   Private connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Private animalsTable As DataTable

   Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
      Dim sqlDA As SqlDataAdapter = New SqlDataAdapter("Select * from Animals", connectionString)
      animalsTable.Rows.Clear()
      sqlDA.Fill(animalsTable)
   End Sub
   Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
      Dim insertCommand As SqlCommand = New SqlCommand()
      insertCommand.CommandType = CommandType.StoredProcedure

      Dim param As SqlParameter

      param = New SqlParameter("@AnimalID", SqlDbType.Int)
      param.Direction = ParameterDirection.Output
      param.SourceColumn = "AnimalID"
      insertCommand.Parameters.Add(param)

      param = New SqlParameter("@AnimalName", SqlDbType.VarChar)
      param.SourceColumn = "AnimalName"
      insertCommand.Parameters.Add(param)

      param = New SqlParameter("@AccountNumber", SqlDbType.Int)
      param.SourceColumn = "AccountNumber"
      param.Size = 40
      param.Direction = ParameterDirection.Output
      insertCommand.Parameters.Add(param)

      insertCommand.CommandText = "UP_ANIMALINSERT"
      Dim sqlDA As SqlDataAdapter = New SqlDataAdapter("Select * from Animals", connectionString)
      insertCommand.Connection = New SqlConnection(connectionString)
      insertCommand.UpdatedRowSource = UpdateRowSource.Both
      sqlDA.InsertCommand = insertCommand

      sqlDA.Update(animalsTable)
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      ' Setup the schema for the Table.
      animalsTable = New DataTable("Animals")
      Dim dc As DataColumn

      dc = New DataColumn("AnimalID")
      dc.Unique = True
      dc.AutoIncrement = True
      dc.AutoIncrementSeed = -1
      dc.AutoIncrementStep = -1
      dc.DataType = Type.GetType("System.Int32") 
      animalsTable.Columns.Add(dc)

      dc = New DataColumn("AnimalName")
      animalsTable.Columns.Add(dc)

      dc = New DataColumn("AccountNumber")
      dc.ReadOnly = True
      animalsTable.Columns.Add(dc)

      ' DataBind it, even though it has no rows in it yet.
      dgView.DataSource = animalsTable
   End Sub
End Class
