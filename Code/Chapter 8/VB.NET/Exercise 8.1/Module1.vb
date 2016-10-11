Imports System.Data
Imports CreateDataSet

Module Module1
   Private dataFilePath As String = "..\..\..\..\Data.Xml"
  Sub Main()
      ' Base DataTable
      Dim myTable As DataTable = DataSetFiller.FillDataset(dataFilePath).Tables(0)
      ' Set Primary Key
      myTable.PrimaryKey = New DataColumn() _
         {myTable.Columns("CustomerID")}

      Dim dr As DataRow = myTable.Rows.Find("2")
      If dr IsNot Nothing Then
         Console.WriteLine("Find a row using a base DataSet")
         ShowDataRow(dr)
      End If

      ' Strongly typed DataSet
      Dim myStrongDataTable As CustProd.CustomersDataTable = DataSetFiller.FillStrongDataSet(dataFilePath).Customers
      Dim cr As CustProd.CustomersRow = myStrongDataTable.FindByCustomerID(2)
      If cr IsNot Nothing Then
         Console.WriteLine("Find a row using a strongly typed DataSet")
         Console.WriteLine(cr.CustomerID & " " & cr.FirstName & " " & cr.LastName)
      End If
   End Sub
   Sub ShowDataRow(ByVal dr As DataRow)
      For Each dc As DataColumn In dr.Table.Columns
         Console.Write(dr(dc) & " ")
      Next
      Console.WriteLine("")
   End Sub
End Module
