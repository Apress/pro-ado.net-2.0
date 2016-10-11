Imports System.Data
Imports CreateDataSet

Module Module1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"

   Sub Main()
      Dim myTable As DataTable = DataSetFiller.FillDataset(dataFilePath).Tables(0)
      myTable.PrimaryKey = New DataColumn() _
         {myTable.Columns("CustomerID")}

      myTable.AcceptChanges()
      Dim janeRow As DataRow = myTable.Rows.Find("5")
      janeRow("LastName") = "QueenOfJungle"
      Dim drs() As DataRow = myTable.Select("", "", DataViewRowState.ModifiedOriginal)
      If Not drs Is Nothing Then
         Dim dr As DataRow
         For Each dr In drs
            ShowDataRow(dr)
         Next
      End If
   End Sub
   Sub ShowDataRow(ByVal dr As DataRow)
      Dim dc As DataColumn
      For Each dc In dr.Table.Columns
         Console.Write(dr(dc) & " ")
      Next
      Console.WriteLine("")
   End Sub
End Module
