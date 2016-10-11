Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Dim connectionString As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Sub Main()
      Using testConnection As SqlConnection = New SqlConnection(connectionString)
         Dim testCommand As SqlCommand = testConnection.CreateCommand()
         testCommand.CommandText = "Select * from Animals"
         Dim sqlDa As SqlDataAdapter = New SqlDataAdapter(testCommand)
         Dim animalsTable As DataTable = New DataTable("Animals")
         sqlDa.Fill(animalsTable)

         DisplayRowStates("Row states for a freshly filled DataTable:", animalsTable)

         Dim rowInQuestion As DataRow
         ' Make Changes - Modify the puppy
         rowInQuestion = animalsTable.Rows(0)
         rowInQuestion("AnimalName") = "Dog"
         ' Make Changes - Delete the cat
         rowInQuestion = animalsTable.Rows(1)
         rowInQuestion.Delete()
         ' Leave the Horse untouched.
         ' Make Changes - Insert a camel
         rowInQuestion = animalsTable.NewRow()
         rowInQuestion("AnimalID") = 4
         rowInQuestion("AnimalName") = "Camel"
         animalsTable.Rows.Add(rowInQuestion)

         DisplayRowStates("Row states for a modified DataTable:", animalsTable)

         ' Detached Row
         rowInQuestion = animalsTable.NewRow()
         rowInQuestion("AnimalID") = 5
         rowInQuestion("AnimalName") = "Monkey"
         Console.WriteLine("Monkey Row's RowState: " + rowInQuestion.RowState.ToString())
         Console.ReadLine()

         ' Update the changes back to the database.
         Dim cmbldr As SqlCommandBuilder = New SqlCommandBuilder(sqlDa)

         ' Setup Update Command
         sqlDa.UpdateCommand = cmbldr.GetUpdateCommand()
         Console.WriteLine("Update Command: " + sqlDa.UpdateCommand.CommandText)

         ' Setup Insert Command
         sqlDa.InsertCommand = cmbldr.GetInsertCommand()
         Console.WriteLine("Insert Command: " + sqlDa.InsertCommand.CommandText)

         ' Setup Delete Command
         sqlDa.DeleteCommand = cmbldr.GetDeleteCommand()
         Console.WriteLine("Delete Command: " + sqlDa.DeleteCommand.CommandText)

         sqlDa.Update(animalsTable)

         DisplayRowStates("Final Row States:", animalsTable)
      End Using
   End Sub

   Private Sub DisplayRowStates(ByVal Message As String, ByVal table As DataTable)
      Console.Clear()
      Console.WriteLine(vbCrLf)
      Console.WriteLine(Message)
      Console.WriteLine("-------------------------------------------")

      Dim dr As DataRow
      For Each dr In table.Rows
         Console.WriteLine(dr.RowState.ToString())
      Next

      Console.WriteLine(vbCrLf + "Press Enter to Continue ..")
      Console.ReadLine()
   End Sub
End Module
