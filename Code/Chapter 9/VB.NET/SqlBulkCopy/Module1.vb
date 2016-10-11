Imports System.Data
Imports System.Data.SqlClient


Module Module1
   Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"

   Sub Main()
      Using firstConnection As SqlConnection = New SqlConnection(connectionString)
         Dim cmdAnimals As SqlCommand = firstConnection.CreateCommand()
         cmdAnimals.CommandText = "Select * from Animals"
         firstConnection.Open()
         Dim dr As SqlDataReader = cmdAnimals.ExecuteReader()

         Using secondConnection As SqlConnection = New SqlConnection(connectionString)
            Dim bc As SqlBulkCopy = New SqlBulkCopy(secondConnection)
            bc.DestinationTableName = "AnimalsCopy"
            bc.WriteToServer(dr)
            bc.Close()
            dr.Close()
         End Using ' Dispose is called on secondConnection
      End Using ' Dispose is called on firstConnection
   End Sub
End Module
