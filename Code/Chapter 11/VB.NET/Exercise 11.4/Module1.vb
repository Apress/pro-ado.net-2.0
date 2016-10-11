Imports System.Data
Imports System.Data.SqlClient
Imports System.Transactions

Module Module1

   Private connectionString1 As String = "Server=(local);Database=Credits;Integrated Security=SSPI"
   Private connectionString2 As String = "Server=(local);Database=Debits;Integrated Security=SSPI"

   Sub Main()
      Try
         Using myTransaction As TransactionScope = New TransactionScope()
            Using connection1 As SqlConnection = New SqlConnection(connectionString1)
               connection1.Open()
               Dim myCommand As SqlCommand = connection1.CreateCommand()
               myCommand.CommandText = _
                  "Insert into Credits (CreditAmount) Values (100)"
               myCommand.ExecuteNonQuery()
            End Using

            Console.WriteLine( _
            "The first connection transaction has done it's work," & _
            " moving on to the second.")
            Console.ReadLine()

            Using connection2 As SqlConnection = New SqlConnection(connectionString2)
               connection2.Open()
               Dim myCommand As SqlCommand = connection2.CreateCommand()
               myCommand.CommandText = _
                  "Insert into Debits(DebitAmount) Values (100)"
               myCommand.ExecuteNonQuery()
            End Using

         End Using
      Catch ex As System.Exception
         Console.WriteLine(ex.ToString())
      End Try
   End Sub

End Module
