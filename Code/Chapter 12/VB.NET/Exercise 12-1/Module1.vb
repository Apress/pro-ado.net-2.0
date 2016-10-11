Imports System.Data
Imports System.Text
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Module Module1
   Private strConnection As String = "Server=(local);Database=AdventureWorks;Integrated Security=SSPI"

   Sub Main()
      Using testConnection As SqlConnection = New SqlConnection(strConnection)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = _
               "SELECT " & _
               "LOGINID, TITLE, " & _
               "   HUMANRESOURCES.DEPARTMENT.DEPARTMENTID, HUMANRESOURCES.DEPARTMENT.NAME " & _
               "FROM " & _
               "   HUMANRESOURCES.EMPLOYEE " & _
               "   INNER JOIN HUMANRESOURCES.DEPARTMENT ON " & _
               "   HUMANRESOURCES.EMPLOYEE.DEPARTMENTID = HUMANRESOURCES.DEPARTMENT.DEPARTMENTID " & _
               "WHERE HUMANRESOURCES.DEPARTMENT.DEPARTMENTID = 7 " & _
               "FOR XML RAW, XMLDATA"

         testConnection.Open()
         Dim xrdr As XmlReader = testCommand.ExecuteXmlReader()
         Dim sw As StreamWriter = New StreamWriter("Output.xml")

         sw.WriteLine("<xml>")
         While xrdr.Read()
            sw.WriteLine(xrdr.ReadOuterXml())
         End While
         sw.WriteLine("</xml>")

         sw.Close()
         xrdr.Close()
         testConnection.Close()
      End Using
   End Sub
End Module
