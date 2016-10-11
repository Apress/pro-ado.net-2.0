Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Private connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"

   Sub Main()
      Dim connection1 As SqlConnection = New SqlConnection(connectionString)
      Dim connection2 As SqlConnection = New SqlConnection(connectionString)

      Dim command1 As SqlCommand = connection1.CreateCommand()
      Dim command2 As SqlCommand = connection2.CreateCommand()

      connection1.Open()
      connection2.Open()
      Dim transaction1 As SqlTransaction = _
         connection1.BeginTransaction(IsolationLevel.Snapshot)
      command1.Transaction = transaction1
      Dim transaction2 As SqlTransaction = _
         connection2.BeginTransaction(IsolationLevel.Snapshot)
      command2.Transaction = transaction2

      Dim myReader As SqlDataReader
      Try
         command1.CommandText = _
            "INSERT INTO CUSTOMERS (FIRSTNAME, LASTNAME, ACCOUNTBALANCE) " & _
            " VALUES ('Bat', 'Man', 100)"
         command1.ExecuteNonQuery()

         command2.CommandText = _
            "SELECT FIRSTNAME, LASTNAME from CUSTOMERS where FIRSTNAME = 'Bat'"
         myReader = command2.ExecuteReader()

         Console.WriteLine("Results when the transaction is midway:")

         If Not myReader.HasRows Then
            Console.WriteLine("No Rows Found")
         End If

         While myReader.Read()
            Console.WriteLine("FirstName: " + myReader(0) + " and LastName: " + myReader(1))
         End While

         myReader.Close()

         transaction1.Rollback()

         command2.CommandText = _
            "SELECT FIRSTNAME, LASTNAME from CUSTOMERS where FIRSTNAME = 'Bat'"
         myReader = command2.ExecuteReader()

         Console.WriteLine("Results when the transaction is rolled back:")
         If Not myReader.HasRows Then
            Console.WriteLine("No Rows Found")
         End If
         While myReader.Read()
            Console.WriteLine("FirstName: " + myReader(0) + " and LastName: " + myReader(1))
         End While
         myReader.Close()
      Catch ex As System.Exception
         Console.WriteLine(ex.ToString())
      Finally
         connection1.Dispose()
         connection2.Dispose()
      End Try
      Console.Read()
   End Sub

End Module
