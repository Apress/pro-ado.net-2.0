Imports System.Data
Imports System.Data.SqlClient
Module Module1

   Sub Main()
      Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = _
            New SqlCommand("Select * from TestDemo", testConnection)
         testConnection.Open()
         Dim sqlDr As SqlDataReader = testCommand.ExecuteReader(CommandBehavior.CloseConnection)

         If sqlDr.HasRows Then
            While sqlDr.Read()
               Console.WriteLine("TestDemo: " & sqlDr.GetInt32(0) _
                  & " and Description : " & sqlDr.GetString(1))
            End While
         End If
      End Using
      ' testConnection.Dispose is called automatically
      Console.Read()
   End Sub
End Module
