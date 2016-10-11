Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private myData As New DataSet
   Private Sub buttonSchema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSchema.Click
      Dim connectionString As String = _
       "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;"

      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select * from userTable; Select * from PermissionsTable"
         Dim dataAdapter As New SqlDataAdapter(testCommand)

         dataAdapter.FillSchema(myData, SchemaType.Source)
      End Using
      ' testConnection.Dispose called automatically.
      DisplayContents()
   End Sub
   Private Sub buttonData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonData.Click
      Dim connectionString As String = _
       "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI;"

      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select * from userTable; Select * from PermissionsTable"
         Dim dataAdapter As New SqlDataAdapter(testCommand)

         dataAdapter.Fill(myData)
      End Using
      ' testConnection.Dispose called automatically.
      DisplayContents()
   End Sub
    Private Sub DisplayContents()
        myData.WriteXml(Application.StartupPath & "\myData.Xml", XmlWriteMode.WriteSchema)
        xmlBrowser.Navigate(Application.StartupPath & "\myData.Xml")
    End Sub
End Class
