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
        Me.nestedRelation = New System.Windows.Forms.CheckBox
        Me.btnShowXml = New System.Windows.Forms.Button
        Me.petsGrid = New System.Windows.Forms.DataGridView
        Me.AnimalsGrid = New System.Windows.Forms.DataGridView
        Me.btnSetupGrids = New System.Windows.Forms.Button
        CType(Me.petsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nestedRelation
        '
        Me.nestedRelation.AutoSize = True
        Me.nestedRelation.Location = New System.Drawing.Point(400, 7)
        Me.nestedRelation.Name = "nestedRelation"
        Me.nestedRelation.Size = New System.Drawing.Size(109, 17)
        Me.nestedRelation.TabIndex = 9
        Me.nestedRelation.Text = "Is Relation Nested"
        '
        'btnShowXml
        '
        Me.btnShowXml.Location = New System.Drawing.Point(252, 2)
        Me.btnShowXml.Name = "btnShowXml"
        Me.btnShowXml.Size = New System.Drawing.Size(121, 27)
        Me.btnShowXml.TabIndex = 8
        Me.btnShowXml.Text = "Show XML"
        '
        'petsGrid
        '
        Me.petsGrid.BackgroundColor = System.Drawing.Color.Silver
        Me.petsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.petsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.petsGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.petsGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.petsGrid.GridColor = System.Drawing.Color.DimGray
        Me.petsGrid.Location = New System.Drawing.Point(13, 194)
        Me.petsGrid.Name = "petsGrid"
        Me.petsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.petsGrid.Size = New System.Drawing.Size(496, 150)
        Me.petsGrid.TabIndex = 7
        '
        'AnimalsGrid
        '
        Me.AnimalsGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.AnimalsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lavender
        Me.AnimalsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AnimalsGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.AnimalsGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.AnimalsGrid.GridColor = System.Drawing.Color.RoyalBlue
        Me.AnimalsGrid.Location = New System.Drawing.Point(13, 37)
        Me.AnimalsGrid.Name = "AnimalsGrid"
        Me.AnimalsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AnimalsGrid.Size = New System.Drawing.Size(496, 150)
        Me.AnimalsGrid.TabIndex = 6
        '
        'btnSetupGrids
        '
        Me.btnSetupGrids.Location = New System.Drawing.Point(13, 2)
        Me.btnSetupGrids.Name = "btnSetupGrids"
        Me.btnSetupGrids.Size = New System.Drawing.Size(212, 28)
        Me.btnSetupGrids.TabIndex = 5
        Me.btnSetupGrids.Text = "Create DataSet and DataBind"
        '
        'Form1
        '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
        Me.ClientSize = New System.Drawing.Size(524, 353)
        Me.Controls.Add(Me.nestedRelation)
        Me.Controls.Add(Me.btnShowXml)
        Me.Controls.Add(Me.petsGrid)
        Me.Controls.Add(Me.AnimalsGrid)
        Me.Controls.Add(Me.btnSetupGrids)
        Me.Name = "Form1"
        Me.Text = "Exercise 6.3"
        CType(Me.petsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nestedRelation As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowXml As System.Windows.Forms.Button
    Friend WithEvents petsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AnimalsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnSetupGrids As System.Windows.Forms.Button

End Class
