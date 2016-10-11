Imports System.Data
Imports System.Data.SqlClient

Module Module1

   Sub Main()
      Dim connstrBuilder As SqlConnectionStringBuilder = _
         New SqlConnectionStringBuilder()
      connstrBuilder.DataSource = "(local)"
      connstrBuilder.InitialCatalog = "Test"
      connstrBuilder.IntegratedSecurity = True

      Using testConnection As SqlConnection = _
         New SqlConnection(connstrBuilder.ToString())
         Try
            testConnection.Open()
            If testConnection.State = ConnectionState.Open Then
               Console.WriteLine("Connection successfully opened")
               Console.WriteLine("Connection string used: " & _
                  testConnection.ConnectionString)
            End If
         Catch ex As Exception
            If testConnection.State <> ConnectionState.Open Then
               Console.WriteLine("Connection successfully failed")
               Console.WriteLine("Connection string used: " & _
                  testConnection.ConnectionString)
            End If
         End Try
      End Using
      ' Automatic Dispose Call on conn ensures connection is closed.
      Console.WriteLine("Press any key to continue ..")
      Console.Read()
   End Sub

End Module
