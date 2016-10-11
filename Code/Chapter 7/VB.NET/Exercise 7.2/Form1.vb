Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private userData As New DataTable

   Private Sub buttonFillData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonFillData.Click
      Dim connectionString As String
      connectionString = _
          "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;"
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select FirstName, LastName from UserTable"
         Dim dataAdapter As New SqlDataAdapter(testCommand)
         dataAdapter.Fill(userData)
      End Using
   End Sub

   Private Sub buttonBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonBind.Click
      datagridView.DataSource = userData
   End Sub
End Class
