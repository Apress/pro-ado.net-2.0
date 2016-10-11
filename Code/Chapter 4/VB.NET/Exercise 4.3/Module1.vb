Imports System.Data
Imports System.Data.SqlClient

Module Module1

   Sub Main()
      Dim testConnection As SqlConnection = New SqlConnection("")
      Dim startTicks As Long = DateTime.Now.Ticks

      For i As Integer = 0 To 1000
         testConnection = New SqlConnection("")
         testConnection.Open()
         testConnection.Close()
      Next

      Dim endTicks As Long = DateTime.Now.Ticks
      Console.WriteLine("Time taken : " & (endTicks - startTicks) & " ticks.")
      testConnection.Dispose()
   End Sub

End Module
