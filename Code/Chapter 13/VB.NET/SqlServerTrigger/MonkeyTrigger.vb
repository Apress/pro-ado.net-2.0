Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server


Partial Public Class Triggers
    ' Enter existing table or view for the target and uncomment the attribute line
   <Microsoft.SqlServer.Server.SqlTrigger(Name:="MonkeyTrigger", _
      Target:="dbo.Person", Event:="FOR INSERT")> _
    Public Shared Sub MonkeyTrigger()
      Dim stContext As SqlTriggerContext = SqlContext.TriggerContext

      If stContext.TriggerAction = TriggerAction.Insert Then
         ' Check the column
         Using contextConn As SqlConnection = _
            New SqlConnection("context connection=true")
            Dim cmd As SqlCommand = contextConn.CreateCommand()
            contextConn.Open()
            cmd.CommandText = "Select PersonName from Inserted"

            Dim personName As String = CType(cmd.ExecuteScalar(), String)

            If personName.ToUpper() = "MONKEY" Then
               System.Transactions.Transaction.Current.Rollback()
               SqlContext.Pipe.Send("Monkey not allowed in this table, eat bannana on tree")
            End If
            contextConn.Close()
         End Using
      End If
   End Sub
End Class

'Create Assembly SqlServerTrigger
'from
''C:\Apress\MY WORK\Chapter #13\Code\VB.NET\SqlServerTrigger\bin\SqlServerTrigger.dll'
'GO

'Create Trigger MonkeyTrigger 
' ON Person
' FOR INSERT
'As
'External Name
'SqlServerTrigger.[SqlServerTrigger.Triggers].MonkeyTrigger
'Go
