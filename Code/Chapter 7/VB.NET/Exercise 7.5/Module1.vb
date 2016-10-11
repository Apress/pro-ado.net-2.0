Imports System.Data
Imports System.Data.OleDb

Module Module1
   Sub Main()
      Try
         ' Define a connection object
         Dim dbConn As New OleDbConnection( _
            "Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=..\db.mdb")

         ' Create a data adapter to retrieve records from db
         Dim selectQuery As String = _
            "SELECT ID AS UserID, fn AS FirstName, " & _
            "ln AS LastName, cty AS City, st AS State FROM tabUsers"
         Dim usersDataAdapter As New OleDbDataAdapter(selectQuery, dbConn)
         Dim usersDataSet As New DataSet("Users")

         ' Fill the dataset
         usersDataAdapter.Fill(usersDataSet)

         ' Go through the records and print them using the mapped names
         For Each userRow As DataRow In usersDataSet.Tables(0).Rows
            Console.WriteLine("ID: {0}, FirstName: {1}, LastName: {2}, City: {3}, State: {4}", _
               userRow("UserID"), userRow("FirstName"), _
               userRow("LastName"), userRow("City"), userRow("State"))
         Next
      Catch ex As Exception
         ' An error occurred. Show the error message
         Console.WriteLine(ex.Message)
      End Try
   End Sub
End Module