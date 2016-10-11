Imports CreateDataSet
Imports System.Data

Public Class Form1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim customerProducts As DataSet = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath)
      Dim productsTable As DataTable = customerProducts.Tables(1)

      Dim totalPrice As DataColumn = New DataColumn("Total Price")
      totalPrice.Expression = "Price + Price * TaxPercent"
      productsTable.Columns.Add(totalPrice)
      dataGridView1.DataSource = productsTable
   End Sub
End Class
