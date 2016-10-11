Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

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
      Me.btnSave = New System.Windows.Forms.Button
      Me.btnLoad = New System.Windows.Forms.Button
      Me.dgView = New System.Windows.Forms.DataGridView
      CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(278, 236)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.TabIndex = 5
      Me.btnSave.Text = "Save"
      '
      'btnLoad
      '
      Me.btnLoad.Location = New System.Drawing.Point(196, 237)
      Me.btnLoad.Name = "btnLoad"
      Me.btnLoad.TabIndex = 4
      Me.btnLoad.Text = "Load"
      '
      'dgView
      '
      Me.dgView.Location = New System.Drawing.Point(0, 1)
      Me.dgView.Name = "dgView"
      Me.dgView.Size = New System.Drawing.Size(353, 228)
      Me.dgView.TabIndex = 3
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
      Me.ClientSize = New System.Drawing.Size(353, 260)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnLoad)
      Me.Controls.Add(Me.dgView)
      Me.Name = "Form1"
      Me.Text = "Exercise 9.4"
      CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents btnSave As System.Windows.Forms.Button
   Private WithEvents btnLoad As System.Windows.Forms.Button
   Private WithEvents dgView As System.Windows.Forms.DataGridView

End Class
