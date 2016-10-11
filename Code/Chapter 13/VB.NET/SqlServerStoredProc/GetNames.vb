Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server


Partial Public Class StoredProcedures
   <Microsoft.SqlServer.Server.SqlProcedure()> _
   Public Shared Sub GetConcatenatedNames(ByVal role As String)
      Using contextConnection As SqlConnection = _
         New SqlConnection("context connection = true")

         Dim contextCommand As SqlCommand = _
            New SqlCommand( _
            "Select dbo.Concatenator(PersonName) from Person " & _
            "where PersonRole = @Role Group By PersonRole", contextConnection)

         contextCommand.Parameters.AddWithValue("@Role", role)
         contextConnection.Open()

         SqlContext.Pipe.ExecuteAndSend(contextCommand)
      End Using
   End Sub

   <Microsoft.SqlServer.Server.SqlProcedure()> _
   Public Shared Sub GetNames(ByVal role As String)
      Using contextConnection As SqlConnection = _
         New SqlConnection("context connection = true")

         Dim contextCommand As SqlCommand = _
            New SqlCommand("Select PersonName from Person where PersonRole = @Role", _
            contextConnection)

         contextCommand.Parameters.AddWithValue("@Role", role)

         contextConnection.Open()

         ' first, create the record and specify the metadata for the results
         Dim rec As SqlDataRecord = _
            New SqlDataRecord(New SqlMetaData("PersonName", _
            SqlDbType.NVarChar, 200))

         ' start a new result-set
         SqlContext.Pipe.SendResultsStart(rec)

         ' send rows
         Dim rdr As SqlDataReader = contextCommand.ExecuteReader()
         While rdr.Read()
            rec.SetString(0, rdr.GetString(0))
            SqlContext.Pipe.SendResultsRow(rec)
         End While

         ' complete the result-set
         SqlContext.Pipe.SendResultsEnd()
      End Using
   End Sub

   <Microsoft.SqlServer.Server.SqlProcedure()> _
   Public Shared Sub InsertName(ByVal personName As String, ByVal personRole As String)
      Using contextConnection As SqlConnection = _
         New SqlConnection("context connection = true")
         Dim contextCommand As SqlCommand = _
            New SqlCommand( _
            "Insert into Person(PersonName, PersonRole) " & _
            " Values (@PersonName, @PersonRole)", _
            contextConnection)

         contextCommand.Parameters.AddWithValue("@PersonName", personName)
         contextCommand.Parameters.AddWithValue("@PersonRole", personRole)

         contextConnection.Open()
         contextCommand.ExecuteScalar()
         ' System.Transactions.Transaction.Current.Rollback();
         contextConnection.Close()
      End Using
   End Sub
End Class
