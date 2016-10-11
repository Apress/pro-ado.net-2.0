Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private myData As New DataSet
   Private Sub buttonUserData_Click( _
      ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles buttonUserData.Click
      ' If there is a data source, remove it.
      datagridView.DataSource = Nothing
      ' Never hard code connection strings.
      ' Usually you would get this from a config file
      Dim connectionString As String = _
       "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;"

      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select * from userTable"
         Dim dataAdapter As New SqlDataAdapter(testCommand)

         dataAdapter.Fill(myData, "UserTable")
      End Using ' testConnection.Dispose called automatically.
      UpdateComboBox()
   End Sub
   Private Sub buttonPermData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPermData.Click
      ' If there is a data source, remove it.
      datagridView.DataSource = Nothing
      ' Never hard code connection strings.
      ' Usually you would get this from a config file
      Dim connectionString As String = _
       "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;"

      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select PermissionType from PermissionsTable"
         Dim dataAdapter As New SqlDataAdapter(testCommand)

         dataAdapter.Fill(myData, "PermissionsTable")
      End Using ' testConnection.Dispose called automatically.
      UpdateComboBox()
   End Sub

   Private Sub UpdateComboBox()
      comboTables.Items.Clear()
      For Each tbl As DataTable In myData.Tables
         comboTables.Items.Add(tbl.TableName)
      Next
   End Sub
   Private Sub comboTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTables.SelectedIndexChanged
      datagridView.DataSource = myData.Tables(comboTables.SelectedIndex)
   End Sub
End Class
