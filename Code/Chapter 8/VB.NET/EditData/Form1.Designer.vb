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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.dgProducts = New System.Windows.Forms.DataGridView
        Me.label2 = New System.Windows.Forms.Label
        Me.dgCustomerProducts = New System.Windows.Forms.DataGridView
        Me.label1 = New System.Windows.Forms.Label
        Me.dgCustomers = New System.Windows.Forms.DataGridView
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCustomerProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(2, 730)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Exit"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(378, 730)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save XML"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(296, 730)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "Create New"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(214, 730)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 16
        Me.btnLoad.Text = "Load XML"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(4, 479)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 22)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Products"
        '
        'dgProducts
        '
        Me.dgProducts.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgProducts.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.dgProducts.GridColor = System.Drawing.Color.DarkGray
        Me.dgProducts.Location = New System.Drawing.Point(4, 508)
        Me.dgProducts.Name = "dgProducts"
        Me.dgProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProducts.Size = New System.Drawing.Size(449, 200)
        Me.dgProducts.TabIndex = 14
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(2, 239)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(138, 22)
        Me.label2.TabIndex = 13
        Me.label2.Text = "CustomerProducts"
        '
        'dgCustomerProducts
        '
        Me.dgCustomerProducts.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgCustomerProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomerProducts.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgCustomerProducts.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgCustomerProducts.GridColor = System.Drawing.Color.Peru
        Me.dgCustomerProducts.Location = New System.Drawing.Point(2, 268)
        Me.dgCustomerProducts.Name = "dgCustomerProducts"
        Me.dgCustomerProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCustomerProducts.Size = New System.Drawing.Size(451, 200)
        Me.dgCustomerProducts.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(2, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 22)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Customers"
        '
        'dgCustomers
        '
        Me.dgCustomers.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.dgCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomers.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCustomers.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.dgCustomers.GridColor = System.Drawing.Color.DarkGray
        Me.dgCustomers.Location = New System.Drawing.Point(2, 32)
        Me.dgCustomers.Name = "dgCustomers"
        Me.dgCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgCustomers.Size = New System.Drawing.Size(451, 200)
        Me.dgCustomers.TabIndex = 10
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 756)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.dgProducts)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.dgCustomerProducts)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgCustomers)
        Me.Name = "Form1"
        Me.Text = "Edit Data"
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCustomerProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnCreate As System.Windows.Forms.Button
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents dgProducts As System.Windows.Forms.DataGridView
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents dgCustomerProducts As System.Windows.Forms.DataGridView
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents dgCustomers As System.Windows.Forms.DataGridView

End Class
