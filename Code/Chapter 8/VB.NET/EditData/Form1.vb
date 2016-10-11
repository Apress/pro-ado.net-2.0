Imports CreateDataSet

Public Class Form1

    Private myDataSet As CustProd

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "Xml Files (*.xml)|*.xml"
        dlg.ShowDialog()
        If dlg.FileName.Length > 0 Then
            LoadXML(dlg.FileName)
        End If
    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        myDataSet = New CustProd()
        dgCustomers.DataSource = myDataSet.Customers
        dgCustomerProducts.DataSource = myDataSet.CustomerProducts
        dgProducts.DataSource = myDataSet.Products
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        dlg.Filter = "Xml Files (*.xml)|*.xml"
        dlg.ShowDialog()
        If dlg.FileName.Length > 0 Then
            myDataSet.WriteXml(dlg.FileName)
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadXML(ByVal fileName As String)
        myDataSet = New CustProd()
        myDataSet.ReadXml(fileName)
        dgCustomers.DataSource = myDataSet.Customers
        dgCustomerProducts.DataSource = myDataSet.CustomerProducts
        dgProducts.DataSource = myDataSet.Products
    End Sub
End Class
