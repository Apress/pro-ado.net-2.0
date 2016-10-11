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
      Me.btnMerge = New System.Windows.Forms.Button
      Me.btnDifferent = New System.Windows.Forms.Button
      Me.btnCCWithPK = New System.Windows.Forms.Button
      Me.btnCCNoPK = New System.Windows.Forms.Button
      Me.btnSameWithPK = New System.Windows.Forms.Button
      Me.btnSameNoPK = New System.Windows.Forms.Button
      Me.label2 = New System.Windows.Forms.Label
      Me.label1 = New System.Windows.Forms.Label
      Me.dgView2 = New System.Windows.Forms.DataGridView
      Me.dgView1 = New System.Windows.Forms.DataGridView
      CType(Me.dgView2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnMerge
      '
      Me.btnMerge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnMerge.Location = New System.Drawing.Point(490, 288)
      Me.btnMerge.Name = "btnMerge"
      Me.btnMerge.Size = New System.Drawing.Size(240, 43)
      Me.btnMerge.TabIndex = 19
      Me.btnMerge.Text = "Table1.Merge(Table2)"
      '
      'btnDifferent
      '
      Me.btnDifferent.Location = New System.Drawing.Point(490, 229)
      Me.btnDifferent.Name = "btnDifferent"
      Me.btnDifferent.Size = New System.Drawing.Size(240, 23)
      Me.btnDifferent.TabIndex = 18
      Me.btnDifferent.Text = "Different Table Structures"
      '
      'btnCCWithPK
      '
      Me.btnCCWithPK.Location = New System.Drawing.Point(490, 170)
      Me.btnCCWithPK.Name = "btnCCWithPK"
      Me.btnCCWithPK.Size = New System.Drawing.Size(240, 23)
      Me.btnCCWithPK.TabIndex = 17
      Me.btnCCWithPK.Text = "Common Column, with PK"
      '
      'btnCCNoPK
      '
      Me.btnCCNoPK.Location = New System.Drawing.Point(490, 140)
      Me.btnCCNoPK.Name = "btnCCNoPK"
      Me.btnCCNoPK.Size = New System.Drawing.Size(240, 23)
      Me.btnCCNoPK.TabIndex = 16
      Me.btnCCNoPK.Text = "Common Column, No PK"
      '
      'btnSameWithPK
      '
      Me.btnSameWithPK.Location = New System.Drawing.Point(490, 79)
      Me.btnSameWithPK.Name = "btnSameWithPK"
      Me.btnSameWithPK.Size = New System.Drawing.Size(240, 23)
      Me.btnSameWithPK.TabIndex = 15
      Me.btnSameWithPK.Text = "Same Structures With PK"
      '
      'btnSameNoPK
      '
      Me.btnSameNoPK.Location = New System.Drawing.Point(490, 49)
      Me.btnSameNoPK.Name = "btnSameNoPK"
      Me.btnSameNoPK.Size = New System.Drawing.Size(240, 23)
      Me.btnSameNoPK.TabIndex = 14
      Me.btnSameNoPK.Text = "Same Structures No PK"
      '
      'label2
      '
      Me.label2.AutoSize = True
      Me.label2.Location = New System.Drawing.Point(4, 182)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(39, 14)
      Me.label2.TabIndex = 13
      Me.label2.Text = "Table2"
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(4, 2)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(39, 14)
      Me.label1.TabIndex = 12
      Me.label1.Text = "Table1"
      '
      'dgView2
      '
      Me.dgView2.AllowUserToAddRows = False
      Me.dgView2.AllowUserToDeleteRows = False
      Me.dgView2.Location = New System.Drawing.Point(4, 203)
      Me.dgView2.Name = "dgView2"
      Me.dgView2.ReadOnly = True
      Me.dgView2.Size = New System.Drawing.Size(479, 150)
      Me.dgView2.TabIndex = 11
      '
      'dgView1
      '
      Me.dgView1.AllowUserToAddRows = False
      Me.dgView1.AllowUserToDeleteRows = False
      Me.dgView1.Location = New System.Drawing.Point(4, 23)
      Me.dgView1.Name = "dgView1"
      Me.dgView1.ReadOnly = True
      Me.dgView1.Size = New System.Drawing.Size(479, 150)
      Me.dgView1.TabIndex = 10
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
      Me.ClientSize = New System.Drawing.Size(735, 356)
      Me.Controls.Add(Me.btnMerge)
      Me.Controls.Add(Me.btnDifferent)
      Me.Controls.Add(Me.btnCCWithPK)
      Me.Controls.Add(Me.btnCCNoPK)
      Me.Controls.Add(Me.btnSameWithPK)
      Me.Controls.Add(Me.btnSameNoPK)
      Me.Controls.Add(Me.label2)
      Me.Controls.Add(Me.label1)
      Me.Controls.Add(Me.dgView2)
      Me.Controls.Add(Me.dgView1)
      Me.Name = "Form1"
      Me.Text = "Exercise 9.6"
      CType(Me.dgView2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents btnMerge As System.Windows.Forms.Button
   Private WithEvents btnDifferent As System.Windows.Forms.Button
   Private WithEvents btnCCWithPK As System.Windows.Forms.Button
   Private WithEvents btnCCNoPK As System.Windows.Forms.Button
   Private WithEvents btnSameWithPK As System.Windows.Forms.Button
   Private WithEvents btnSameNoPK As System.Windows.Forms.Button
   Private WithEvents label2 As System.Windows.Forms.Label
   Private WithEvents label1 As System.Windows.Forms.Label
   Private WithEvents dgView2 As System.Windows.Forms.DataGridView
   Private WithEvents dgView1 As System.Windows.Forms.DataGridView

End Class
