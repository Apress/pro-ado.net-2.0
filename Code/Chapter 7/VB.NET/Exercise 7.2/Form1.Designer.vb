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
      Me.datagridView = New System.Windows.Forms.DataGridView
      Me.buttonFillData = New System.Windows.Forms.Button
      Me.buttonBind = New System.Windows.Forms.Button
      CType(Me.datagridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'datagridView
      '
      Me.datagridView.Location = New System.Drawing.Point(2, 0)
      Me.datagridView.Name = "datagridView"
      Me.datagridView.Size = New System.Drawing.Size(267, 240)
      Me.datagridView.TabIndex = 0
      '
      'buttonFillData
      '
      Me.buttonFillData.Location = New System.Drawing.Point(112, 247)
      Me.buttonFillData.Name = "buttonFillData"
      Me.buttonFillData.Size = New System.Drawing.Size(75, 23)
      Me.buttonFillData.TabIndex = 1
      Me.buttonFillData.Text = "Fill Data"
      '
      'buttonBind
      '
      Me.buttonBind.Location = New System.Drawing.Point(194, 247)
      Me.buttonBind.Name = "buttonBind"
      Me.buttonBind.Size = New System.Drawing.Size(75, 23)
      Me.buttonBind.TabIndex = 2
      Me.buttonBind.Text = "Data Bind"
      '
      'Form1
      '
      Me.ClientSize = New System.Drawing.Size(270, 273)
      Me.Controls.Add(Me.buttonBind)
      Me.Controls.Add(Me.buttonFillData)
      Me.Controls.Add(Me.datagridView)
      Me.Name = "Form1"
      Me.Text = "Exercise 7.2"
      CType(Me.datagridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents datagridView As System.Windows.Forms.DataGridView
   Friend WithEvents buttonFillData As System.Windows.Forms.Button
   Friend WithEvents buttonBind As System.Windows.Forms.Button

End Class
