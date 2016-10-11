Imports CreateDataSet
Imports System.Data

Public Class Form1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
   Private CustomersTable As DataTable
   Private CustomersView As DataView

   Private Sub btnLoad_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnLoad.Click
      CustomersTable = _
         CreateDataSet.DataSetFiller.FillDataset(dataFilePath).Tables("Customers")
      CustomersView = New DataView(CustomersTable)
      dgView.DataSource = CustomersView
   End Sub
   Private Sub btnSort_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnSort.Click
      CustomersView.Sort = "FirstName ASC"
   End Sub
   Private Sub btnFilter_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnFilter.Click
      CustomersView.RowFilter = "LastName like '%OfJungle'"
   End Sub
   Private Sub btnFindRows_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnFindRows.Click
      Dim drvs() As DataRowView = CustomersView.FindRows("Tarzan")
      Dim drv As DataRowView
      For Each drv In drvs
         MessageBox.Show(drv.Row("FirstName") & " " & drv.Row("LastName"), "Selected Item")
      Next
   End Sub
End Class
