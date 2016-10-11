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
      Me.buttonData = New System.Windows.Forms.Button
      Me.buttonSchema = New System.Windows.Forms.Button
      Me.xmlBrowser = New System.Windows.Forms.WebBrowser
      Me.SuspendLayout()
      '
      'buttonData
      '
      Me.buttonData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.buttonData.Location = New System.Drawing.Point(457, 533)
      Me.buttonData.Name = "buttonData"
      Me.buttonData.Size = New System.Drawing.Size(75, 23)
      Me.buttonData.TabIndex = 5
      Me.buttonData.Text = "Fill Data"
      '
      'buttonSchema
      '
      Me.buttonSchema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.buttonSchema.Location = New System.Drawing.Point(375, 533)
      Me.buttonSchema.Name = "buttonSchema"
      Me.buttonSchema.Size = New System.Drawing.Size(75, 23)
      Me.buttonSchema.TabIndex = 4
      Me.buttonSchema.Text = "Fill Schema"
      '
      'xmlBrowser
      '
      Me.xmlBrowser.AllowWebBrowserDrop = False
      Me.xmlBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.xmlBrowser.Location = New System.Drawing.Point(0, 1)
      Me.xmlBrowser.Name = "xmlBrowser"
      Me.xmlBrowser.Size = New System.Drawing.Size(532, 525)
      '
      'Form1
      '
      Me.ClientSize = New System.Drawing.Size(534, 558)
      Me.Controls.Add(Me.buttonData)
      Me.Controls.Add(Me.buttonSchema)
      Me.Controls.Add(Me.xmlBrowser)
      Me.Name = "Form1"
      Me.Text = "Exercise 7.4"
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents buttonData As System.Windows.Forms.Button
   Private WithEvents buttonSchema As System.Windows.Forms.Button
    Private WithEvents xmlBrowser As System.Windows.Forms.WebBrowser

End Class
