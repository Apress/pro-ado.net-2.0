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
        Me.lblSumPrice = New System.Windows.Forms.Label
        Me.btnSumPrices = New System.Windows.Forms.Button
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSumPrice
        '
        Me.lblSumPrice.AutoSize = True
        Me.lblSumPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumPrice.Location = New System.Drawing.Point(274, 148)
        Me.lblSumPrice.Name = "lblSumPrice"
        Me.lblSumPrice.Size = New System.Drawing.Size(0, 0)
        Me.lblSumPrice.TabIndex = 5
        '
        'btnSumPrices
        '
        Me.btnSumPrices.Location = New System.Drawing.Point(458, 144)
        Me.btnSumPrices.Name = "btnSumPrices"
        Me.btnSumPrices.TabIndex = 4
        Me.btnSumPrices.Text = "Sum Prices"
        '
        'dataGridView1
        '
        Me.dataGridView1.Location = New System.Drawing.Point(1, 2)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(545, 135)
        Me.dataGridView1.TabIndex = 3
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(548, 168)
        Me.Controls.Add(Me.lblSumPrice)
        Me.Controls.Add(Me.btnSumPrices)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Form1"
        Me.Text = "Exercise 8.6"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblSumPrice As System.Windows.Forms.Label
    Private WithEvents btnSumPrices As System.Windows.Forms.Button
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class
