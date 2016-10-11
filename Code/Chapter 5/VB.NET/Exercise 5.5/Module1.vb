Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Sub Main()
      Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"

      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = _
            New SqlCommand("Select * from UserBasicInformation" & ";" & "Select * from PermissionsTable", testConnection)
         testConnection.Open()
         Dim sqlDr As SqlDataReader = testCommand.ExecuteReader(CommandBehavior.CloseConnection)

         If sqlDr.HasRows Then
            Do
               Console.WriteLine("_____________________")
               While sqlDr.Read()
                  Console.WriteLine(sqlDr.GetInt32(0) _
                     & " : " + sqlDr.GetString(1))
               End While
            Loop While sqlDr.NextResult()
         End If
      End Using
   End Sub
End Module
