Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

   Private Shared connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Private ds As DataSet = Nothing

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim sqlDA As SqlDataAdapter = New SqlDataAdapter("Select * from Customers", testConnection)
         ds = New DataSet()
         sqlDA.Fill(ds)
         dataGridView1.DataSource = ds.Tables(0)
      End Using
   End Sub

   Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim sqlDA As SqlDataAdapter = New SqlDataAdapter("Select * from Customers", testConnection)
         Dim myUpdateCommand As SqlCommand = New SqlCommand("Update Customers Set FirstName = @FirstName where CustomerID = @CustomerID")

         Dim param1 As SqlParameter = New SqlParameter("@FirstName", SqlDbType.VarChar, 50)
         param1.SourceColumn = "FirstName"

         Dim param2 As SqlParameter = New SqlParameter("@CustomerID", SqlDbType.VarChar, 50)
         param2.SourceColumn = "CustomerID"

         myUpdateCommand.Parameters.AddRange(New SqlParameter() {param1, param2})
         myUpdateCommand.Connection = testConnection

         sqlDA.UpdateCommand = myUpdateCommand

         testConnection.Open()
         Dim myTransaction As SqlTransaction = testConnection.BeginTransaction()
         sqlDA.UpdateCommand.Transaction = myTransaction
         sqlDA.AcceptChangesDuringUpdate = False

         Try
            sqlDA.Update(ds)
            myTransaction.Commit()
            ds.AcceptChanges()
         Catch ex As Exception
            MessageBox.Show(ex.ToString())
         End Try
      End Using
   End Sub
End Class
