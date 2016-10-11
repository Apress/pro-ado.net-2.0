Imports System.Data

Public Class Form1

   Dim petsData As DataSet
   Private Sub btnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetupGrids.Click
      petsData = CreateSchema()
      petsGrid.DataSource = petsData.Tables("Pet")
      AnimalsGrid.DataSource = petsData.Tables("Animal")
   End Sub
   Private Sub btnShowXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowXml.Click
      MessageBox.Show(petsData.GetXml(), "DataSet Contents")
   End Sub
   Private Sub nestedRelation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nestedRelation.CheckedChanged
      If Not petsData Is Nothing Then
         petsData.Relations(0).Nested = nestedRelation.Checked
      End If
   End Sub

   Private Function CreateSchema() As DataSet
      Dim AnimalTable As DataTable = New DataTable("Animal")
      Dim myDataColumn As DataColumn

      myDataColumn = New DataColumn("AnimalID", GetType(System.Int32))
      myDataColumn.AutoIncrement = True
      AnimalTable.Columns.Add(myDataColumn)

      myDataColumn = New DataColumn("AnimalName", GetType(System.String))
      AnimalTable.Columns.Add(myDataColumn)

      Dim petsTable As DataTable = New DataTable("Pet")

      myDataColumn = New DataColumn("PetID", GetType(System.Int32))
      myDataColumn.AutoIncrement = True
      petsTable.Columns.Add(myDataColumn)

      myDataColumn = New DataColumn("AnimalID", GetType(System.Int32))
      petsTable.Columns.Add(myDataColumn)

      myDataColumn = New DataColumn("PetName", GetType(System.String))
      petsTable.Columns.Add(myDataColumn)

      Dim toReturn As DataSet = New DataSet("petsData")
      toReturn.Tables.Add(AnimalTable)
      toReturn.Tables.Add(petsTable)
      toReturn.Relations.Add( _
         New DataRelation("AnimalsPets", _
         AnimalTable.Columns("AnimalID"), petsTable.Columns("AnimalID")))

      Return toReturn
   End Function
End Class
