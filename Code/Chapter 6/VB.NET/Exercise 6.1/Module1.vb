Imports System.Data

Module Module1

   Sub Main()
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
      productsTable.WriteXml("productsTable.xml")
   End Sub

End Module
