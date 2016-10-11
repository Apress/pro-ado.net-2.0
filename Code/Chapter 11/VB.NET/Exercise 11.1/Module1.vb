Imports System
Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Private connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Sub Main()
      Using testConnection As New SqlConnection(connectionString)
         Dim myCommand As SqlCommand = testConnection.CreateCommand()
         Dim myTransaction As SqlTransaction = Nothing

         Try
            testConnection.Open()
            myTransaction = testConnection.BeginTransaction()
            myCommand.Transaction = myTransaction
            myCommand.CommandText = "Insert into CustomerProduct (CustomerID, ProductID) Values (2, 1)"
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "Update Customers Set AccountBalance = 96 Where CustomerID = 2"
            myCommand.ExecuteNonQuery()
            myTransaction.Commit()
         Catch ex As Exception
            Try
               myTransaction.Rollback()
            Catch ex1 As SqlException
               Throw ex1
            End Try
         Finally
            testConnection.Close()
         End Try
      End Using
   End Sub
End Module