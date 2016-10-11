Imports System.Data
Imports System.Data.SqlClient

Module Module1

   Private connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"

   Sub Main()
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testConnection.Open()

         Dim myTransaction As SqlTransaction = testConnection.BeginTransaction()
         testCommand.Transaction = myTransaction

         Try
            testCommand.CommandText = _
                  "Insert into Customers (FirstName, LastName, AccountBalance)" _
                  & " Values ('Bat','Man',100)"
            testCommand.ExecuteNonQuery()
            myTransaction.Save("firstCustomer")

            testCommand.CommandText = _
                  "Insert into Customers (FirstName, LastName, AccountBalance)" _
                  & " Values ('The','Joker',100)"
            testCommand.ExecuteNonQuery()

            myTransaction.Rollback("firstCustomer")

            testCommand.CommandText = _
                  "Insert into Customers (FirstName, LastName, AccountBalance)" _
                  & " Values ('Robin','Sidekick',100)"
            testCommand.ExecuteNonQuery()
            myTransaction.Commit()

            testCommand.CommandText = "Select * from Customers"
            Dim sqlDa As SqlDataReader = testCommand.ExecuteReader()

            While sqlDa.Read()
               Console.WriteLine( _
                  " FirstName: " + sqlDa("FirstName") + _
                  " LastName = " + sqlDa("LastName") + _
                  " AccountBalance = " + sqlDa("AccountBalance"))
            End While
            sqlDa.Close()
         Catch ex As System.Exception
            Console.WriteLine(ex.ToString())
         End Try
         testConnection.Close()
      End Using
   End Sub

End Module
