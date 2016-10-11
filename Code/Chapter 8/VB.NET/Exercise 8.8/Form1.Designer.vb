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
        Me.btnFindRows = New System.Windows.Forms.Button
        Me.btnFilter = New System.Windows.Forms.Button
        Me.btnSort = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.dgView = New System.Windows.Forms.DataGridView
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFindRows
        '
        Me.btnFindRows.Location = New System.Drawing.Point(249, 1)
        Me.btnFindRows.Name = "btnFindRows"
        Me.btnFindRows.TabIndex = 9
        Me.btnFindRows.Text = "Find Rows"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(167, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.TabIndex = 8
        Me.btnFilter.Text = "Filter Data"
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(85, 2)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.TabIndex = 7
        Me.btnSort.Text = "Sort Data"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(3, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 6
        Me.btnLoad.Text = "Load Data"
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgView.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgView.GridColor = System.Drawing.Color.Silver
        Me.dgView.Location = New System.Drawing.Point(3, 45)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.Size = New System.Drawing.Size(331, 277)
        Me.dgView.TabIndex = 5
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(335, 323)
        Me.Controls.Add(Me.btnFindRows)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgView)
        Me.Name = "Form1"
        Me.Text = "Exercise 8.8"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnFindRows As System.Windows.Forms.Button
    Private WithEvents btnFilter As System.Windows.Forms.Button
    Private WithEvents btnSort As System.Windows.Forms.Button
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents dgView As System.Windows.Forms.DataGridView

End Class
