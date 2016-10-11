Imports System
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class UserDefinedFunctions
   <Microsoft.SqlServer.Server.SqlFunction()> _
   Public Shared Function GetRandomNumber() As SqlInt32
      Dim rnd As Random = New Random
      Return rnd.Next()
   End Function
End Class
