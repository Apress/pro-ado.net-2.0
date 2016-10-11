Imports CreateDataSet
Imports System.Data
Imports System.Xml

Public Class Form1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
   Private WithEvents CustomersTable As DataTable
   Private xdd As XmlDataDocument

   Private Sub Form1_Load( _
     ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles MyBase.Load
      CustomersTable = CreateDataSet.DataSetFiller.FillDataset(dataFilePath).Tables("Customers")
      xdd = New XmlDataDocument(CustomersTable.DataSet)
      dgView.DataSource = CustomersTable
      xdd.Save(Application.ExecutablePath & "_xdd.xml")
      xmlViewer.Navigate(Application.ExecutablePath & "_xdd.xml")
   End Sub

   Private Sub CustomersTable_RowChanged( _
     ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) _
     Handles CustomersTable.RowChanged
      xdd.Save(Application.ExecutablePath & "_xdd.xml")
      xmlViewer.Navigate(Application.ExecutablePath & "_xdd.xml")
   End Sub
End Class
