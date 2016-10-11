Imports CreateDataSet
Imports System.Data

Public Class Form1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
   Private customerProducts As DataSet

   Private Sub btnFilter1_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnFilter1.Click
      If lbCustomers.SelectedIndex = -1 Then
         Return
      End If
      Dim selectedRow As DataRow = _
         customerProducts.Tables("Customers").Rows(lbCustomers.SelectedIndex)
      Dim childRows() As DataRow = _
         selectedRow.GetChildRows(customerProducts.Relations(1))
      lbCustomerProducts.Items.Clear()
      Dim dr As DataRow
      For Each dr In childRows
         lbCustomerProducts.Items.Add(dr("CustomerProductID"))
      Next
   End Sub
   Private Sub btnFilter2_Click( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnFilter2.Click
      Dim custProdRow As DataRow
      Dim ProdRow As DataRow
      Dim custProdTable As DataTable = customerProducts.Tables("CustomerProducts")
      lbProducts.Items.Clear()
      Dim item As Object
      For Each item In lbCustomerProducts.Items
         Dim custProdId As Integer = CType(item, Integer)
         custProdRow = custProdTable.Rows.Find(custProdId)
         ProdRow = custProdRow.GetParentRow(customerProducts.Relations(0))
         lbProducts.Items.Add(ProdRow("ProductName"))
      Next
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      customerProducts = CreateDataSet.DataSetFiller.FillStrongDataSet(dataFilePath)
      For Each dr As DataRow In customerProducts.Tables("Customers").Rows
         lbCustomers.Items.Add(dr("CustomerID") & ":" & dr("FirstName") & " " + dr("LastName"))
      Next
   End Sub
End Class
