Imports System.Data

Public Class Form1
   Private Sub btnSameNoPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSameNoPK.Click
      Dim table1 As VariousTables.Table0DataTable = New VariousTables.Table0DataTable()
      table1.LoadDataRow(New Object() {"1", "One"}, True)
      table1.LoadDataRow(New Object() {"2", "Two"}, True)

      Dim table2 As VariousTables.Table0DataTable = New VariousTables.Table0DataTable()
      table2.LoadDataRow(New Object() {"2", "Monkey"}, True)
      table2.LoadDataRow(New Object() {"3", "Donkey"}, True)

      dgView1.DataSource = table1
      dgView2.DataSource = table2
   End Sub
   Private Sub btnSameWithPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSameWithPK.Click
      Dim table1 As VariousTables.Table1DataTable = New VariousTables.Table1DataTable()
      table1.LoadDataRow(New Object() {"1", "One"}, True)
      table1.LoadDataRow(New Object() {"2", "Two"}, True)

      Dim table2 As VariousTables.Table1DataTable = New VariousTables.Table1DataTable()
      table2.LoadDataRow(New Object() {"2", "Monkey"}, True)
      table2.LoadDataRow(New Object() {"3", "Donkey"}, True)

      dgView1.DataSource = table1
      dgView2.DataSource = table2
   End Sub
   Private Sub btnCCNoPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCNoPK.Click
      Dim table1 As VariousTables.Table0DataTable = New VariousTables.Table0DataTable()
      table1.LoadDataRow(New Object() {"1", "One"}, True)
      table1.LoadDataRow(New Object() {"2", "Two"}, True)

      Dim table2 As VariousTables.Table2DataTable = New VariousTables.Table2DataTable()
      table2.LoadDataRow(New Object() {"2", "Monkey"}, True)
      table2.LoadDataRow(New Object() {"3", "Donkey"}, True)

      dgView1.DataSource = table1
      dgView2.DataSource = table2
   End Sub
   Private Sub btnCCWithPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCWithPK.Click
      Dim table1 As VariousTables.Table1DataTable = New VariousTables.Table1DataTable()
      table1.LoadDataRow(New Object() {"1", "One"}, True)
      table1.LoadDataRow(New Object() {"2", "Two"}, True)

      Dim table2 As VariousTables.Table2DataTable = New VariousTables.Table2DataTable()
      table2.LoadDataRow(New Object() {"2", "Monkey"}, True)
      table2.LoadDataRow(New Object() {"3", "Donkey"}, True)

      dgView1.DataSource = table1
      dgView2.DataSource = table2
   End Sub
   Private Sub btnDifferent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDifferent.Click
      'Dim table1 As VariousTables.Table0DataTable = New VariousTables.Table0DataTable()

      'Note I have the above line commented. Because it doesn't work - here is an explanation why.
      'This is because if you view the final merged table - it contains results that violate the unique constraint setup 
      'in Table0DataTable. So internally in Merge, 
      'The constraints are turned off (this gives a performance boost)
      'data is merged
      'Constraints are enabled <-- you get an exception here because the merged datatable does not have unique values in ColumnA ;)

      ' Go ahead and uncomment the above, and comment 3 lines below and see a running proof of what I just told ya.

      Dim table1 As DataTable = New DataTable()
      table1.Columns.Add(New DataColumn("ColumnA"))
      table1.Columns.Add(New DataColumn("ColumnB"))
      table1.LoadDataRow(New Object() {"1", "One"}, True)
      table1.LoadDataRow(New Object() {"2", "Two"}, True)

      Dim table2 As VariousTables.Table3DataTable = New VariousTables.Table3DataTable()
      table2.LoadDataRow(New Object() {"2", "Monkey"}, True)
      table2.LoadDataRow(New Object() {"3", "Donkey"}, True)

      dgView1.DataSource = table1
      dgView2.DataSource = table2
   End Sub
   Private Sub btnMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMerge.Click
      Dim table1 As DataTable = CType(dgView1.DataSource, DataTable)
      Dim table2 As DataTable = CType(dgView2.DataSource, DataTable)
      table1.Merge(table2)
   End Sub
End Class
