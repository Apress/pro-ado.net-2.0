Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Runtime.InteropServices

<Serializable()> _
<StructLayout(LayoutKind.Sequential)> _
<SqlUserDefinedType(Format.Native)> _
Public Structure XYCoOrdinate
   Implements INullable

   Private m_x As Integer
   Private m_y As Integer

   Public Property X() As Integer
      Get
         Return m_x
      End Get
      Set(ByVal value As Integer)
         m_x = value
      End Set
   End Property

   Public Property Y() As Integer
      Get
         Return m_y
      End Get
      Set(ByVal value As Integer)
         m_y = value
      End Set
   End Property

   Public Overrides Function ToString() As String
      Return m_x.ToString() & "," & m_y.ToString()
   End Function

   Public ReadOnly Property IsNull() As Boolean Implements INullable.IsNull
      Get
         Return False
      End Get
   End Property

   Public Shared ReadOnly Property Null() As XYCoOrdinate
      Get
         Dim h As XYCoOrdinate = New XYCoOrdinate
         Return h
      End Get
   End Property

   Public Shared Function Parse(ByVal s As SqlString) As XYCoOrdinate
      If s.IsNull Or s.Value.ToLower().Equals("null") Then
         Return Null
      End If
      Dim u As XYCoOrdinate = New XYCoOrdinate()

      Dim str As String = s.ToString().Trim()
      Dim commaLocation As Integer = str.IndexOf(",")
      Try
         u.X = CInt(str.Substring(0, commaLocation))
         u.Y = CInt(str.Substring(commaLocation + 1, str.Length - commaLocation - 1))
      Catch ex As Exception
         Throw New ApplicationException( _
          "Error converting " + str + " to a co-ordinate.", ex)
      End Try
      Return u
   End Function
End Structure

