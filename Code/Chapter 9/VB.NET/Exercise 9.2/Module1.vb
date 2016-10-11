Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Sub Main()
      Dim myDataAdapter As SqlDataAdapter = _
         New SqlDataAdapter("Select * from Animals2", connectionString)
      Dim cmdBldr As SqlCommandBuilder = New SqlCommandBuilder(myDataAdapter)

      cmdBldr.ConflictOption = ConflictOption.CompareRowVersion

      Console.WriteLine("Update Command = ")
      Console.WriteLine(cmdBldr.GetUpdateCommand().CommandText)
   End Sub
End Module
