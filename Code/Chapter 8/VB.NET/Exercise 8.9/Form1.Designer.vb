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
        Me.xmlViewer = New System.Windows.Forms.WebBrowser
        Me.dgView = New System.Windows.Forms.DataGridView
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xmlViewer
        '
        Me.xmlViewer.Location = New System.Drawing.Point(1, 193)
        Me.xmlViewer.Name = "xmlViewer"
        Me.xmlViewer.Size = New System.Drawing.Size(381, 298)
        Me.xmlViewer.TabIndex = 3
        '
        'dgView
        '
        Me.dgView.Location = New System.Drawing.Point(1, 1)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(381, 185)
        Me.dgView.TabIndex = 2
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(383, 492)
        Me.Controls.Add(Me.xmlViewer)
        Me.Controls.Add(Me.dgView)
        Me.Name = "Form1"
        Me.Text = "Exercise 8.9"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents xmlViewer As System.Windows.Forms.WebBrowser
    Private WithEvents dgView As System.Windows.Forms.DataGridView

End Class
