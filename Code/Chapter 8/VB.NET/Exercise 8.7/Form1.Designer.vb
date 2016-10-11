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
        Me.lbProducts = New System.Windows.Forms.ListBox
        Me.btnFilter2 = New System.Windows.Forms.Button
        Me.lbCustomerProducts = New System.Windows.Forms.ListBox
        Me.btnFilter1 = New System.Windows.Forms.Button
        Me.lbCustomers = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lbProducts
        '
        Me.lbProducts.FormattingEnabled = True
        Me.lbProducts.Location = New System.Drawing.Point(511, 1)
        Me.lbProducts.Name = "lbProducts"
        Me.lbProducts.Size = New System.Drawing.Size(157, 238)
        Me.lbProducts.TabIndex = 9
        '
        'btnFilter2
        '
        Me.btnFilter2.Location = New System.Drawing.Point(396, 104)
        Me.btnFilter2.Name = "btnFilter2"
        Me.btnFilter2.Size = New System.Drawing.Size(108, 23)
        Me.btnFilter2.TabIndex = 8
        Me.btnFilter2.Text = "GetParentRow >>"
        '
        'lbCustomerProducts
        '
        Me.lbCustomerProducts.FormattingEnabled = True
        Me.lbCustomerProducts.Location = New System.Drawing.Point(256, 1)
        Me.lbCustomerProducts.Name = "lbCustomerProducts"
        Me.lbCustomerProducts.Size = New System.Drawing.Size(133, 238)
        Me.lbCustomerProducts.TabIndex = 7
        '
        'btnFilter1
        '
        Me.btnFilter1.Location = New System.Drawing.Point(148, 104)
        Me.btnFilter1.Name = "btnFilter1"
        Me.btnFilter1.Size = New System.Drawing.Size(101, 23)
        Me.btnFilter1.TabIndex = 6
        Me.btnFilter1.Text = "GetChildRows >>"
        '
        'lbCustomers
        '
        Me.lbCustomers.FormattingEnabled = True
        Me.lbCustomers.Location = New System.Drawing.Point(0, 1)
        Me.lbCustomers.Name = "lbCustomers"
        Me.lbCustomers.Size = New System.Drawing.Size(141, 238)
        Me.lbCustomers.TabIndex = 5
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(670, 239)
        Me.Controls.Add(Me.lbProducts)
        Me.Controls.Add(Me.btnFilter2)
        Me.Controls.Add(Me.lbCustomerProducts)
        Me.Controls.Add(Me.btnFilter1)
        Me.Controls.Add(Me.lbCustomers)
        Me.Name = "Form1"
        Me.Text = "Exercise 8.7"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lbProducts As System.Windows.Forms.ListBox
    Private WithEvents btnFilter2 As System.Windows.Forms.Button
    Private WithEvents lbCustomerProducts As System.Windows.Forms.ListBox
    Private WithEvents btnFilter1 As System.Windows.Forms.Button
    Private WithEvents lbCustomers As System.Windows.Forms.ListBox

End Class
