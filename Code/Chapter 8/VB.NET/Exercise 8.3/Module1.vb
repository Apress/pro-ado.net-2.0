Imports System.Data
Imports CreateDataSet

Module Module1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"

   Sub Main()
      Dim myTable As DataTable = DataSetFiller.FillDataset(dataFilePath).Tables(0)
      Dim drs() As DataRow = myTable.Select("LastName Like '%OfJungle'", "FirstName ASC")
      If drs IsNot Nothing Then
         For Each dr As DataRow In drs
            ShowDataRow(dr)
         Next
      End If
   End Sub
   Sub ShowDataRow(ByVal dr As DataRow)
      For Each dc As DataColumn In dr.Table.Columns
         Console.Write(dr(dc) & " ")
      Next
      Console.WriteLine("")
   End Sub
End Module
