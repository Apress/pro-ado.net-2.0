Imports System.Text
Imports Microsoft.Data.SqlXml
Imports System.IO

Module Module1

   Private connectionString As String = "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI"

   Sub Main()
      Dim xmlQuery As FileStream = New FileStream("updategram.xml", FileMode.Open)
      Dim cmd As SqlXmlCommand = New SqlXmlCommand(connectionString)
      cmd.CommandStream = xmlQuery
      cmd.CommandType = SqlXmlCommandType.UpdateGram
      cmd.ExecuteNonQuery()
      xmlQuery.Close()
   End Sub

End Module
