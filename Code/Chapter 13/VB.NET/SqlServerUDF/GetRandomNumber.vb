Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Partial Public Class UserDefinedFunctions
   <Microsoft.SqlServer.Server.SqlFunction()> _
   Public Shared Function GetRandomNumber2() As SqlInt32
      Dim rnd As Random = New Random
      Return rnd.Next()
   End Function
End Class
