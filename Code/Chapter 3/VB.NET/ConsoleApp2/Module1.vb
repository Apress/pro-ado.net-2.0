Imports System.Data.SqlClient

Module Module1

   Private connectionString As String = _
      "Data Source=(local);Initial Catalog=Test;Integrated Security=True"
   Sub Main()
      Dim testConnection As SqlConnection = New SqlConnection(connectionString)
      Dim testCommand As SqlCommand = testConnection.CreateCommand()
      testCommand.CommandText = "Select DemoValue from Demo where DemoID = 1"
      testConnection.Open()
      Dim result As String = CType(testCommand.ExecuteScalar(), String)
      testConnection.Close()
      Console.WriteLine(result)
   End Sub

End Module
