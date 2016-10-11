Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Module Module1

   Private connectionString As String = "Server=(local);Database=AdventureWorks;Integrated Security=SSPI"

   Sub Main()
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = _
            New SqlCommand("Select Top 1 Resume from HumanResources.JobCandidate", _
            testConnection)
         testConnection.Open()
         Dim rdr As SqlDataReader = testCommand.ExecuteReader()

         ' Method 1
         Dim xrdr As XmlReader = testCommand.ExecuteXmlReader()
         xrdr.Read()
         Console.WriteLine(xrdr.ReadOuterXml())


         While rdr.Read()
            ' Method 2
            Console.WriteLine(rdr.GetString(0))

            ' Method 3
            Dim xr As XmlReader = rdr.GetSqlXml(0).CreateReader()
            xr.Read()
            Console.WriteLine(xr.ReadOuterXml())

            ' Method 4
            Dim o As Object = rdr.GetProviderSpecificValue(0)
            ' Strangely enough this prints SqlString
            Console.WriteLine(o.GetType().ToString())
            Console.WriteLine(o.ToString())
         End While
      End Using
   End Sub

End Module
