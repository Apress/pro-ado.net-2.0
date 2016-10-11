Imports System.Data

Module Module1
   Dim WithEvents productsTable As DataTable
   Sub Main()
      productsTable = SetupAndPopulateDataTable()
      ' Setup Events
      AddHandler productsTable.ColumnChanged, AddressOf productsTable_ColumnChanged
      AddHandler productsTable.ColumnChanging, AddressOf productsTable_ColumnChanging
      AddHandler productsTable.RowChanged, AddressOf productsTable_RowChanged
      AddHandler productsTable.RowChanging, AddressOf productsTable_RowChanging
      AddHandler productsTable.RowDeleted, AddressOf productsTable_RowDeleted
      AddHandler productsTable.RowDeleting, AddressOf productsTable_RowDeleting

      Console.WriteLine("Change some data and watch the events fire.")
      Console.WriteLine("------------------------------------------")
      productsTable.Rows(0)("Name") = "Pinto"

      Console.WriteLine("")
      Console.WriteLine("Delete a row and watch the events fire.")
      Console.WriteLine("------------------------------------------")
      productsTable.Rows(0).Delete()

      Console.Read()
   End Sub

   Function SetupAndPopulateDataTable() As DataTable
      ' Create the table
      Dim productsTable As New DataTable("Products")

      ' Build the Products schema
      productsTable.Columns.Add("ID", GetType(System.Int32))
      productsTable.Columns.Add("Name", GetType(System.String))
      productsTable.Columns.Add("Category", GetType(System.Int32))

      ' Set up the ID column as the primary key
      productsTable.PrimaryKey = New DataColumn() {productsTable.Columns("ID")}

      productsTable.Columns("ID").AutoIncrement = True
      productsTable.Columns("ID").AutoIncrementSeed = 1
      productsTable.Columns("ID").ReadOnly = True

      Dim tempRow As DataRow

      ' Populate the Products table with 10 cars
      Dim i As Int32 = 0
      For i = 0 To 9
         tempRow = productsTable.NewRow()

         ' Make every even row a Caterham Seven de Dion
         If Math.IEEERemainder(i, 2) = 0 Then
            tempRow("Name") = "Caterham Seven de Dion #" & i.ToString()
            tempRow("Category") = 1
         Else
            tempRow("Name") = "Dodge Viper #" & i.ToString()
            tempRow("Category") = 2
         End If

         productsTable.Rows.Add(tempRow)
      Next i
      productsTable.AcceptChanges()
      Return productsTable
   End Function

   Private Sub productsTable_ColumnChanged(ByVal sender As Object, _
      ByVal e As DataColumnChangeEventArgs)
      Console.WriteLine("productsTable_ColumnChanged.")
      Console.WriteLine("   Value: " & e.Row("Name").ToString())
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   Private Sub productsTable_ColumnChanging(ByVal sender As Object, _
      ByVal e As DataColumnChangeEventArgs)
      Console.WriteLine("productsTable_ColumnChanging.")
      Console.WriteLine("   Value: " & e.Row("Name").ToString())
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   Private Sub productsTable_RowChanged(ByVal sender As Object, _
      ByVal e As DataRowChangeEventArgs)
      Console.WriteLine("productsTable_RowChanged.")
      Console.WriteLine("   Value: " & e.Row("Name").ToString())
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   Private Sub productsTable_RowChanging(ByVal sender As Object, _
      ByVal e As DataRowChangeEventArgs)
      Console.WriteLine("productsTable_RowChanging.")
      Console.WriteLine("   Value: " & e.Row("Name").ToString())
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   Private Sub productsTable_RowDeleted(ByVal sender As Object, _
      ByVal e As DataRowChangeEventArgs)
      Console.WriteLine("productsTable_RowDeleted.")
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   Private Sub productsTable_RowDeleting(ByVal sender As Object, _
      ByVal e As DataRowChangeEventArgs)
      Console.WriteLine("productsTable_RowDeleting.")
      Console.WriteLine("   RowState: " & e.Row.RowState.ToString())
   End Sub

   'Private Sub productsTable_TableCleared(ByVal sender As Object, _
   '   ByVal e As DataTableClearEventArgs)
   '    Console.WriteLine("productsTable_TableCleared")
   'End Sub

   'Private Sub productsTable_TableClearing(ByVal sender As Object, _
   '   ByVal e As DataTableClearEventArgs)
   '    Console.WriteLine("productsTable_TableClearing")
   'End Sub

   'Private Sub productsTable_TableNewRow(ByVal sender As Object, _
   '   ByVal e As DataTableNewRowEventArgs)
   '    Console.WriteLine("productsTable_TableNewRow")
   'End Sub
End Module
