<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

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
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.btnDataBind = New System.Windows.Forms.Button
      Me.myDataGrid = New System.Windows.Forms.DataGridView
      Me.btnPopulate = New System.Windows.Forms.Button
      CType(Me.myDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnDataBind
      '
      Me.btnDataBind.Location = New System.Drawing.Point(205, 159)
      Me.btnDataBind.Name = "btnDataBind"
      Me.btnDataBind.Size = New System.Drawing.Size(75, 23)
      Me.btnDataBind.TabIndex = 5
      Me.btnDataBind.Text = "DataBind"
      '
      'myDataGrid
      '
      DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
      DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.0!)
      DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
      Me.myDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
      DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.0!)
      DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.myDataGrid.DefaultCellStyle = DataGridViewCellStyle8
      Me.myDataGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
      Me.myDataGrid.GridColor = System.Drawing.Color.Silver
      Me.myDataGrid.Location = New System.Drawing.Point(1, 2)
      Me.myDataGrid.Name = "myDataGrid"
      Me.myDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
      Me.myDataGrid.Size = New System.Drawing.Size(279, 150)
      Me.myDataGrid.TabIndex = 4
      '
      'btnPopulate
      '
      Me.btnPopulate.Location = New System.Drawing.Point(94, 159)
      Me.btnPopulate.Name = "btnPopulate"
      Me.btnPopulate.Size = New System.Drawing.Size(98, 23)
      Me.btnPopulate.TabIndex = 3
      Me.btnPopulate.Text = "Populate Arraylist"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(283, 186)
      Me.Controls.Add(Me.btnDataBind)
      Me.Controls.Add(Me.myDataGrid)
      Me.Controls.Add(Me.btnPopulate)
      Me.Name = "Form1"
      Me.Text = "Exercise 5.3"
      CType(Me.myDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnDataBind As System.Windows.Forms.Button
   Friend WithEvents myDataGrid As System.Windows.Forms.DataGridView
   Friend WithEvents btnPopulate As System.Windows.Forms.Button

End Class
