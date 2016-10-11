Imports System.Text
Imports Microsoft.Data.SqlXml
Imports System.IO

Module Module1

   Private connectionString As String = "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI"

   Sub Main()
      Dim cmd As SqlXmlCommand = New SqlXmlCommand(connectionString)
      cmd.CommandText = "Person.Contact"
      cmd.CommandType = SqlXmlCommandType.XPath
      cmd.SchemaPath = "Person.Contact.xsd"
      cmd.ClientSideXml = True
      cmd.RootTag = "Person.Contact"

      Dim da As SqlXmlAdapter = New SqlXmlAdapter(cmd)
      Dim ds As DataSet = New DataSet()
      Try
         ' Fill the dataset  
         da.Fill(ds)
         ' Make some change
         ds.Tables(0).Rows(1)("LastName") = "Unabel"
         ' Update the data back to the database.
         da.Update(ds.GetChanges())
      Catch ex As Exception
         Console.WriteLine(ex.ToString())
      End Try
   End Sub

End Module
