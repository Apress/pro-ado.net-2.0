Imports System.Data
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module Module1

   Sub Main()
      Dim bf As New BinaryFormatter()
      Dim fs As New FileStream( _
         System.Environment.CurrentDirectory.ToString() & _
         "\ds.dat", FileMode.OpenOrCreate)
      Dim ds As DataSet = GiveMeFakeData()
      ds.RemotingFormat = SerializationFormat.Binary
      bf.Serialize(fs, ds)
      fs.Close()

      ' Check the deserialization performance.
      fs = New FileStream( _
         System.Environment.CurrentDirectory.ToString() & _
         "\ds.dat", FileMode.Open)
      Dim nowTicks As Long = DateTime.Now.Ticks
      Dim ds2 As DataSet = CType(bf.Deserialize(fs), DataSet)
      Dim tickstotal As Long = DateTime.Now.Ticks - nowTicks
      Console.WriteLine(("Took me : " + tickstotal.ToString()))
      fs.Close()
   End Sub

   Function GiveMeFakeData() As DataSet
      Dim ds As New DataSet()
      Dim dt As New DataTable("Animals")
      dt.Columns.Add(New DataColumn("AnimalID"))
      dt.Columns.Add(New DataColumn("AnimalType"))

      Dim dr As DataRow
      Dim i As Integer
      For i = 0 To 1000
         dr = dt.NewRow()
         dr(0) = 1
         dr(1) = "Rabbit"
         dt.Rows.Add(dr)

         dr = dt.NewRow()
         dr(0) = 2
         dr(1) = "Monkey"
         dt.Rows.Add(dr)

         dr = dt.NewRow()
         dr(0) = 3
         dr(1) = "Donkey"
         dt.Rows.Add(dr)

         dr = dt.NewRow()
         dr(0) = 4
         dr(1) = "Dog"
         dt.Rows.Add(dr)
      Next i

      ds.Tables.Add(dt)

      Return ds
   End Function
End Module
