Public Class Form1

   Private Sub bindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindingNavigatorSaveItem.Click
      If Me.Validate Then
         Me.AnimalsBindingSource.EndEdit()
         Me.AnimalsTableAdapter.Update(Me.TestDataSet.Animals)
      Else
         System.Windows.Forms.MessageBox.Show(Me, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
      End If

   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'TestDataSet.Animals' table. You can move, or remove it, as needed.
      Me.AnimalsTableAdapter.Fill(Me.TestDataSet.Animals)

   End Sub
End Class
