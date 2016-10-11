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
        Me.dgBooks = New System.Windows.Forms.DataGridView
        Me.btnSumScores = New System.Windows.Forms.Button
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgBooks
        '
        Me.dgBooks.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender
        Me.dgBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgBooks.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgBooks.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgBooks.Location = New System.Drawing.Point(13, 4)
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBooks.Size = New System.Drawing.Size(467, 283)
        Me.dgBooks.TabIndex = 0
        '
        'btnSumScores
        '
        Me.btnSumScores.Location = New System.Drawing.Point(405, 295)
        Me.btnSumScores.Name = "btnSumScores"
        Me.btnSumScores.TabIndex = 1
        Me.btnSumScores.Text = "Sum Scores"
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(492, 329)
        Me.Controls.Add(Me.btnSumScores)
        Me.Controls.Add(Me.dgBooks)
        Me.Name = "Form1"
        Me.Text = "Annotated Typed Dataset Binding Example"
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgBooks As System.Windows.Forms.DataGridView
    Friend WithEvents btnSumScores As System.Windows.Forms.Button

End Class
