Imports System.Data
Imports CreateDataSet

Public Class Form1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
   Private productsTable As DataTable

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim customerProducts As DataSet = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath)
      productsTable = customerProducts.Tables(1)

      Dim totalPrice As DataColumn = New DataColumn("Total Price")
      totalPrice.Expression = "Price + Price * TaxPercent"
      productsTable.Columns.Add(totalPrice)
      dataGridView1.DataSource = productsTable
   End Sub

   Private Sub btnSumPrices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumPrices.Click
      Dim price As String = productsTable.Compute("Sum(Price)", "Price < 500").ToString()
      lblSumPrice.Text = "The total price is : " & price
   End Sub
End Class
