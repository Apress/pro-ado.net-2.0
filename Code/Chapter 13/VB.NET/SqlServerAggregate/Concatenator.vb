Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Text

<Serializable()> _
<Microsoft.SqlServer.Server.SqlUserDefinedAggregate(Format.UserDefined, _
  MaxByteSize:=8000)> _
Public Structure Concatenator
   Implements IBinarySerialize

   Private sb As StringBuilder

   Public Sub Init()
      sb = New StringBuilder
   End Sub

   Public Sub Accumulate(ByVal value As SqlString)
      sb.Append(value)
      sb.Append(",")
   End Sub

   Public Sub Merge(ByVal value As Concatenator)
      Accumulate(value.ToString())
   End Sub

   Public Overrides Function ToString() As String
      Return sb.ToString()
   End Function

   Public Function Terminate() As SqlString
      sb.Remove(sb.Length - 1, 1)
      Return sb.ToString()
   End Function

#Region "IBinarySerialize Members"
   Public Sub Read(ByVal r As System.IO.BinaryReader) _
      Implements IBinarySerialize.Read
      sb = New StringBuilder()
      sb.Append(r.ReadString())
   End Sub

   Public Sub Write(ByVal w As System.IO.BinaryWriter) _
      Implements IBinarySerialize.Write
      If (sb.Length > 0) Then
         w.Write(sb.ToString())
      End If
   End Sub
#End Region
End Structure

