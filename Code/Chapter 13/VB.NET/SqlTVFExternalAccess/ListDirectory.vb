Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.IO

Namespace SqlTVFExternalAccess
   Partial Public Class UserDefinedFunctions
      <Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName:="FillRow", _
         TableDefinition:="FileName nvarchar(4000), FileSize nvarchar(4000)")> _
      Public Shared Function GetDircontents(ByVal DirName As String) As IEnumerable
         Dim startDir As DirectoryInfo = New DirectoryInfo(DirName)
         ' This implements IEnumerable, so we are done :)
         Return startDir.GetFiles()
      End Function

      Public Shared Sub FillRow(ByVal row As Object, _
         <Out()> ByRef FileName As String, <Out()> ByRef FileSize As String)
         ' break the row into its columnar parts. 
         Dim oneFile As FileInfo = CType(row, FileInfo)
         FileName = oneFile.Name
         FileSize = oneFile.Length.ToString()
      End Sub
   End Class
End Namespace