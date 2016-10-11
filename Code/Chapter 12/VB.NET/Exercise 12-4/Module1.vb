Imports System.Text
Imports Microsoft.Data.SqlXml
Imports System.IO
Imports System.Data

Module Module1

   Private connectionString As String = _
   "Provider=SQLOLEDB;Server=(local);database=AdventureWorks;Integrated Security=SSPI"

   Sub Main()
      Dim cmd As SqlXmlCommand = New SqlXmlCommand(connectionString)
      cmd.CommandText = "SELECT FirstName, LastName FROM Person.Contact WHERE LastName=? For XML Auto"
      Dim parm As SqlXmlParameter
      parm = cmd.CreateParameter()
      parm.Value = "Achong"
      Dim strResult As String
      Try
         Dim strm As Stream = cmd.ExecuteStream()
         strm.Position = 0
         Using sr As StreamReader = New StreamReader(strm)
            Console.WriteLine(sr.ReadToEnd())
         End Using
      Catch e As SqlXmlException
         'in case of an error, this prints error returned.
         e.ErrorStream.Position = 0
         strResult = New StreamReader(e.ErrorStream).ReadToEnd()
         System.Console.WriteLine(strResult)
      End Try
   End Sub

End Module
