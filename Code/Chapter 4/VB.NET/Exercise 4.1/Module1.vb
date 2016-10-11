Imports System.Data
Imports System.Data.SqlClient

Module Module1

   Sub Main()
      Dim testConnection As SqlConnection = _
         New SqlConnection( _
         "Server=(local);Database=Test;Integrated Security=SSPI")
      Try
         testConnection.Open()
         If testConnection.State = ConnectionState.Open Then
            Console.WriteLine("Successfully opened a connection")
         End If
      Catch
         If testConnection.State <> ConnectionState.Open Then
            Console.WriteLine("Failed to open a connection")
         End If
      Finally
         ' Closing a connection ensures connection pooling.
         If testConnection.State = ConnectionState.Open Then
            testConnection.Close()
         End If
         testConnection.Dispose()
      End Try
   End Sub

End Module
