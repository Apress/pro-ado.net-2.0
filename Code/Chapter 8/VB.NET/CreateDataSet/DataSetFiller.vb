Imports System
Imports System.Data

Public Class DataSetFiller
   Public Shared Function FillDataset(ByVal xmlFile As String) As DataSet
      Dim ds As New DataSet()
      ds.ReadXml(xmlFile)
      Return ds
   End Function

   Public Shared Function FillStrongDataSet(ByVal xmlFile As String) As CustProd
      Dim ds As New CustProd()
      ds.ReadXml(xmlFile)
      Return ds
   End Function
End Class
