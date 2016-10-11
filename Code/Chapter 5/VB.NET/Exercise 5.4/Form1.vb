Imports System.Data
Imports System.Data.Common
Imports System.Collections
Imports System.Data.SqlClient

Public Class Form1

   Dim dbRecordsHolder As ArrayList

   Private Sub btnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopulate.Click
      Dim connectionString As String = _
         "Server=(local);Database=Test;Integrated Security=SSPI;Asynchronous Processing=true"
      Dim testConnection As SqlConnection = _
         New SqlConnection(connectionString)

      Dim testCommand As SqlCommand = _
         New SqlCommand("Select * from TestDemo", testConnection)
      testConnection.Open()

      Dim callback As AsyncCallback = New AsyncCallback(AddressOf DataReaderIsReady)
      Dim asyncresult As IAsyncResult = testCommand.BeginExecuteReader(callback, testCommand)
   End Sub

   Private Sub DataReaderIsReady(ByVal result As IAsyncResult)
      Dim testCommand As SqlCommand = CType(result.AsyncState, SqlCommand)

      Dim sqlDr As SqlDataReader = testCommand.EndExecuteReader(result)
      If sqlDr.HasRows Then

         Dim rec As DbDataRecord
         For Each rec In sqlDr
            dbRecordsHolder.Add(rec)
         Next
      End If
      sqlDr.Close()
      testCommand.Connection.Dispose()
   End Sub

   Private Sub btnDataBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataBind.Click
      myDataGrid.DataSource = dbRecordsHolder
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      dbRecordsHolder = New ArrayList()
   End Sub
End Class
