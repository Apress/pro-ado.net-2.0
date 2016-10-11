Module Module1
   Sub Main()
      Dim testDS As TestDataSet = New TestDataSet()
      Dim tableAdapter As TestDataSetTableAdapters.DemoTableAdapter = _
            New TestDataSetTableAdapters.DemoTableAdapter()
      tableAdapter.Fill(testDS.Demo)

      Dim demoRow As TestDataSet.DemoRow = _
         CType(testDS.Demo.Rows(0), TestDataSet.DemoRow)
      Console.WriteLine(demoRow.DemoValue)
   End Sub
End Module
