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
      Me.buttonPermData = New System.Windows.Forms.Button
      Me.buttonUserData = New System.Windows.Forms.Button
      Me.datagridView = New System.Windows.Forms.DataGridView
      Me.comboTables = New System.Windows.Forms.ComboBox
      CType(Me.datagridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'buttonPermData
      '
      Me.buttonPermData.Location = New System.Drawing.Point(135, 340)
      Me.buttonPermData.Name = "buttonPermData"
      Me.buttonPermData.Size = New System.Drawing.Size(143, 20)
      Me.buttonPermData.TabIndex = 7
      Me.buttonPermData.Text = "Fill Permissions Data"
      '
      'buttonUserData
      '
      Me.buttonUserData.Location = New System.Drawing.Point(1, 340)
      Me.buttonUserData.Name = "buttonUserData"
      Me.buttonUserData.Size = New System.Drawing.Size(127, 20)
      Me.buttonUserData.TabIndex = 6
      Me.buttonUserData.Text = "Fill User Data"
      '
      'datagridView
      '
      Me.datagridView.Location = New System.Drawing.Point(1, 35)
      Me.datagridView.Name = "datagridView"
      Me.datagridView.Size = New System.Drawing.Size(277, 297)
      Me.datagridView.TabIndex = 5
      '
      'comboTables
      '
      Me.comboTables.FormattingEnabled = True
      Me.comboTables.Location = New System.Drawing.Point(1, 7)
      Me.comboTables.Name = "comboTables"
      Me.comboTables.Size = New System.Drawing.Size(277, 21)
      Me.comboTables.TabIndex = 4
      '
      'Form1
      '
      Me.ClientSize = New System.Drawing.Size(282, 365)
      Me.Controls.Add(Me.buttonPermData)
      Me.Controls.Add(Me.buttonUserData)
      Me.Controls.Add(Me.datagridView)
      Me.Controls.Add(Me.comboTables)
      Me.Name = "Form1"
      Me.Text = "Exercise 7.3"
      CType(Me.datagridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents buttonPermData As System.Windows.Forms.Button
   Private WithEvents buttonUserData As System.Windows.Forms.Button
   Private WithEvents datagridView As System.Windows.Forms.DataGridView
   Private WithEvents comboTables As System.Windows.Forms.ComboBox

End Class
