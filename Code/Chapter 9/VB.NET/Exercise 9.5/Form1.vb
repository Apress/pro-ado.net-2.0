Imports System.Data

Public Class Form1
   Private myDataSet As CustProd
   Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnGetChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetChanges.Click
      Dim changedDS As CustProd = CType(myDataSet.GetChanges(), CustProd)
      dgCustomers.DataSource = changedDS.Customers
      dgCustomerProducts.DataSource = changedDS.CustomerProducts
      dgProducts.DataSource = changedDS.Products
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      myDataSet = New CustProd()
      dgCustomers.DataSource = myDataSet.Customers
      dgCustomerProducts.DataSource = myDataSet.CustomerProducts
      dgProducts.DataSource = myDataSet.Products

      myDataSet.ReadXml("Data.xml")
      myDataSet.AcceptChanges()
   End Sub
End Class
