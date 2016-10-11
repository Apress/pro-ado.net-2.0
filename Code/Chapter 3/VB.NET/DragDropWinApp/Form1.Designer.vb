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
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Me.TestDataSet = New DragDropWinApp.TestDataSet
      Me.DemoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.DemoTableAdapter = New DragDropWinApp.TestDataSetTableAdapters.DemoTableAdapter
      Me.DemoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
      Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
      Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
      Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
      Me.bindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
      Me.DemoDataGridView = New System.Windows.Forms.DataGridView
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DemoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DemoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.DemoBindingNavigator.SuspendLayout()
      CType(Me.DemoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TestDataSet
      '
      Me.TestDataSet.DataSetName = "TestDataSet"
      '
      'DemoBindingSource
      '
      Me.DemoBindingSource.DataMember = "Demo"
      Me.DemoBindingSource.DataSource = Me.TestDataSet
      '
      'DemoTableAdapter
      '
      Me.DemoTableAdapter.ClearBeforeFill = True
      '
      'DemoBindingNavigator
      '
      Me.DemoBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
      Me.DemoBindingNavigator.BindingSource = Me.DemoBindingSource
      Me.DemoBindingNavigator.CountItem = Me.bindingNavigatorCountItem
      Me.DemoBindingNavigator.CountItemFormat = "of {0}"
      Me.DemoBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
      Me.DemoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorSaveItem})
      Me.DemoBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.DemoBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
      Me.DemoBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
      Me.DemoBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
      Me.DemoBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
      Me.DemoBindingNavigator.Name = "DemoBindingNavigator"
      Me.DemoBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
      Me.DemoBindingNavigator.Size = New System.Drawing.Size(329, 25)
      Me.DemoBindingNavigator.TabIndex = 0
      Me.DemoBindingNavigator.Text = "BindingNavigator1"
      '
      'bindingNavigatorMoveFirstItem
      '
      Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
      Me.bindingNavigatorMoveFirstItem.Text = "Move first"
      '
      'bindingNavigatorMovePreviousItem
      '
      Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
      Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
      '
      'bindingNavigatorSeparator
      '
      Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
      '
      'bindingNavigatorPositionItem
      '
      Me.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
      Me.bindingNavigatorPositionItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
      Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
      Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
      Me.bindingNavigatorPositionItem.Text = "0"
      Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
      '
      'bindingNavigatorCountItem
      '
      Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
      Me.bindingNavigatorCountItem.Text = "of {0}"
      Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'bindingNavigatorSeparator1
      '
      Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator"
      '
      'bindingNavigatorMoveNextItem
      '
      Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
      Me.bindingNavigatorMoveNextItem.Text = "Move next"
      '
      'bindingNavigatorMoveLastItem
      '
      Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
      Me.bindingNavigatorMoveLastItem.Text = "Move last"
      '
      'bindingNavigatorSeparator2
      '
      Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator"
      '
      'bindingNavigatorAddNewItem
      '
      Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
      Me.bindingNavigatorAddNewItem.Text = "Add new"
      '
      'bindingNavigatorDeleteItem
      '
      Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
      Me.bindingNavigatorDeleteItem.Text = "Delete"
      '
      'bindingNavigatorSaveItem
      '
      Me.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.bindingNavigatorSaveItem.Image = CType(resources.GetObject("bindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem"
      Me.bindingNavigatorSaveItem.Text = "Save Data"
      '
      'DemoDataGridView
      '
      Me.DemoDataGridView.AutoGenerateColumns = False
      Me.DemoDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn1)
      Me.DemoDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn2)
      Me.DemoDataGridView.DataSource = Me.DemoBindingSource
      Me.DemoDataGridView.Location = New System.Drawing.Point(0, 28)
      Me.DemoDataGridView.Name = "DemoDataGridView"
      Me.DemoDataGridView.Size = New System.Drawing.Size(328, 83)
      Me.DemoDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "DemoID"
      Me.DataGridViewTextBoxColumn1.HeaderText = "DemoID"
      Me.DataGridViewTextBoxColumn1.Name = "DemoID"
      Me.DataGridViewTextBoxColumn1.ReadOnly = True
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "DemoValue"
      Me.DataGridViewTextBoxColumn2.HeaderText = "DemoValue"
      Me.DataGridViewTextBoxColumn2.Name = "DemoValue"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(329, 114)
      Me.Controls.Add(Me.DemoDataGridView)
      Me.Controls.Add(Me.DemoBindingNavigator)
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DemoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DemoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.DemoBindingNavigator.ResumeLayout(False)
      Me.DemoBindingNavigator.PerformLayout()
      CType(Me.DemoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TestDataSet As DragDropWinApp.TestDataSet
   Friend WithEvents DemoBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents DemoTableAdapter As DragDropWinApp.TestDataSetTableAdapters.DemoTableAdapter
   Friend WithEvents DemoBindingNavigator As System.Windows.Forms.BindingNavigator
   Friend WithEvents bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
   Friend WithEvents bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents bindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents DemoDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
