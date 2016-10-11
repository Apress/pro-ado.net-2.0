Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Transactions

Module Module1
   Private connectionString1 As String = "Server=(local);Database=Credits;Integrated Security=SSPI"
   Private connectionString2 As String = "Server=(local);Database=Debits;Integrated Security=SSPI"

   Private isThreadRunning As Boolean = False

   Sub Main()
      Try
         Using myTransaction As TransactionScope = New TransactionScope()
            Dim myThread As Thread
            myThread = _
               New System.Threading.Thread( _
                  New ParameterizedThreadStart(AddressOf ThreadEntryPoint))
            Dim tran As Transaction = Transaction.Current.Clone()
            myThread.Start(tran)

            Using connection1 As SqlConnection = _
               New SqlConnection(connectionString1)
               connection1.Open()
               ' Do something here - this connection will autoenlist
            End Using
            ' Wait for the other thread to finish
            While (isThreadRunning)
               Console.Write("\rWaiting for thread to finish ..")
            End While
            myTransaction.Complete()
         End Using
      Catch ex As System.Exception
         Console.WriteLine(ex.ToString())
      End Try
   End Sub

   Private Sub ThreadEntryPoint(ByVal transactionInstance As Object)
      isThreadRunning = True
      Dim tran As Transaction = CType(transactionInstance, Transaction)
      Using connection2 As SqlConnection = New SqlConnection(connectionString2)
         connection2.Open()
         connection2.EnlistTransaction(tran)
         ' Do something here - this connection is manually enlisted.
         tran.Rollback() ' ok to do 
      End Using
      isThreadRunning = False
   End Sub
End Module
