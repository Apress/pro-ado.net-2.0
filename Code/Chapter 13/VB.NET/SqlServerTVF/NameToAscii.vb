Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Collections
Imports System.Runtime.InteropServices

Namespace SqlServerTVF
   Partial Public Class UserDefinedFunctions
      <Microsoft.SqlServer.Server.SqlFunction(FillRowMethodName:="FillRow", _
         TableDefinition:="charpart nchar(1), intpart int")> _
      Public Shared Function NameToAscii(ByVal InputName As String) As IEnumerable
         Return New NameSplitter(InputName.ToCharArray())
      End Function

      Public Shared Sub FillRow(ByVal row As Object, _
         <Out()> ByRef charpart As Char, <Out()> ByRef intpart As Integer)
         ' break the row into its columnar parts. 
         charpart = CType(row, NameRow).CharPart
         intpart = CType(row, NameRow).IntPart
      End Sub
   End Class


   Public Class NameSplitter
      Implements IEnumerable, IEnumerator

      Private idx As Int32 = -1
      Private _inputName As Char()
      Private _current As Char

      Public Sub New(ByVal InputName As Char())
         _inputName = InputName
      End Sub

      Public Function GetEnumerator() As System.Collections.IEnumerator _
         Implements System.Collections.IEnumerable.GetEnumerator
         Return New NameSplitter(_inputName)
      End Function

      Public ReadOnly Property Current() As Object _
         Implements System.Collections.IEnumerator.Current
         Get
            If (idx > -1) Then
               Dim c As Char = _inputName(idx)
               Return New NameRow(c, Asc(c))
            Else
               Return -1
            End If
         End Get
      End Property

      Public Function MoveNext() As Boolean _
         Implements System.Collections.IEnumerator.MoveNext
         idx = idx + 1
         If (idx < _inputName.Length) Then
            Return True
         Else
            Return False
         End If
      End Function

      Public Sub Reset() Implements System.Collections.IEnumerator.Reset
         idx = -1
      End Sub
   End Class

   Public Class NameRow
      Public CharPart As Char
      Public IntPart As Int32

      Public Sub New(ByVal c As Char, ByVal i As Int32)
         CharPart = c
         IntPart = i
      End Sub
   End Class
End Namespace