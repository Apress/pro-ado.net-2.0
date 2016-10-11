<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.button1 = New System.Windows.Forms.Button
      Me.dataGridView1 = New System.Windows.Forms.DataGridView
      CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'button1
      '
      Me.button1.Location = New System.Drawing.Point(288, 194)
      Me.button1.Name = "button1"
      Me.button1.Size = New System.Drawing.Size(75, 23)
      Me.button1.TabIndex = 3
      Me.button1.Text = "Save"
      '
      'dataGridView1
      '
      Me.dataGridView1.Location = New System.Drawing.Point(0, 1)
      Me.dataGridView1.Name = "dataGridView1"
      Me.dataGridView1.Size = New System.Drawing.Size(363, 187)
      Me.dataGridView1.TabIndex = 2
      Me.dataGridView1.Text = "dataGridView1"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(364, 218)
      Me.Controls.Add(Me.button1)
      Me.Controls.Add(Me.dataGridView1)
      Me.Name = "Form1"
      Me.Text = "AccChanges"
      CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents button1 As System.Windows.Forms.Button
   Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class
