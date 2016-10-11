Imports System.Data
Imports System.Data.SqlClient
Module Module1

   Sub Main()
      Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = New SqlCommand("Select count(*) from TestDemo", testConnection)
         testConnection.Open()
         Dim numResults As Integer = CType(testCommand.ExecuteScalar(), Integer)
         Console.WriteLine("Total number of rows in TestDemo: " + numResults)
         testConnection.Close()
      End Using
      ' testConnection.Dispose is called automatically
      Console.Read()
   End Sub
End Module
