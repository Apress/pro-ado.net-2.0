Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Data.Common

Public Class Form1
   Private dbRecordsHolder As ArrayList

   Private Sub btnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopulate.Click
      Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = New SqlCommand("Select * from TestDemo", testConnection)
         testConnection.Open()
         Dim sqlDr As SqlDataReader = testCommand.ExecuteReader(CommandBehavior.CloseConnection)
         If sqlDr.HasRows Then
            Dim rec As DbDataRecord
            For Each rec In sqlDr
               dbRecordsHolder.Add(rec)
            Next
         End If
      End Using ' testConnection.Dispose is called automatically
   End Sub

   Private Sub btnDataBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataBind.Click
      myDataGrid.DataSource = dbRecordsHolder
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      dbRecordsHolder = New ArrayList()
   End Sub
End Class
