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
      Me.TestDataSet = New Exercise_9_1.TestDataSet
      Me.AnimalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.AnimalsTableAdapter = New Exercise_9_1.TestDataSetTableAdapters.AnimalsTableAdapter
      Me.AnimalsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.AnimalsDataGridView = New System.Windows.Forms.DataGridView
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.AnimalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.AnimalsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.AnimalsBindingNavigator.SuspendLayout()
      CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TestDataSet
      '
      Me.TestDataSet.DataSetName = "TestDataSet"
      '
      'AnimalsBindingSource
      '
      Me.AnimalsBindingSource.DataMember = "Animals"
      Me.AnimalsBindingSource.DataSource = Me.TestDataSet
      '
      'AnimalsTableAdapter
      '
      Me.AnimalsTableAdapter.ClearBeforeFill = True
      '
      'AnimalsBindingNavigator
      '
      Me.AnimalsBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
      Me.AnimalsBindingNavigator.BindingSource = Me.AnimalsBindingSource
      Me.AnimalsBindingNavigator.CountItem = Me.bindingNavigatorCountItem
      Me.AnimalsBindingNavigator.CountItemFormat = "of {0}"
      Me.AnimalsBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
      Me.AnimalsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorSaveItem})
      Me.AnimalsBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.AnimalsBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
      Me.AnimalsBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
      Me.AnimalsBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
      Me.AnimalsBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
      Me.AnimalsBindingNavigator.Name = "AnimalsBindingNavigator"
      Me.AnimalsBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
      Me.AnimalsBindingNavigator.Size = New System.Drawing.Size(335, 25)
      Me.AnimalsBindingNavigator.TabIndex = 0
      Me.AnimalsBindingNavigator.Text = "BindingNavigator1"
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
      'AnimalsDataGridView
      '
      Me.AnimalsDataGridView.AutoGenerateColumns = False
      Me.AnimalsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn1)
      Me.AnimalsDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn2)
      Me.AnimalsDataGridView.DataSource = Me.AnimalsBindingSource
      Me.AnimalsDataGridView.Location = New System.Drawing.Point(0, 28)
      Me.AnimalsDataGridView.Name = "AnimalsDataGridView"
      Me.AnimalsDataGridView.Size = New System.Drawing.Size(333, 220)
      Me.AnimalsDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "AnimalID"
      Me.DataGridViewTextBoxColumn1.HeaderText = "AnimalID"
      Me.DataGridViewTextBoxColumn1.Name = "AnimalID"
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "AnimalName"
      Me.DataGridViewTextBoxColumn2.HeaderText = "AnimalName"
      Me.DataGridViewTextBoxColumn2.Name = "AnimalName"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(335, 251)
      Me.Controls.Add(Me.AnimalsDataGridView)
      Me.Controls.Add(Me.AnimalsBindingNavigator)
      Me.Name = "Form1"
      Me.Text = "Exercise 9.1"
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.AnimalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.AnimalsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.AnimalsBindingNavigator.ResumeLayout(False)
      Me.AnimalsBindingNavigator.PerformLayout()
      CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TestDataSet As Exercise_9_1.TestDataSet
   Friend WithEvents AnimalsBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents AnimalsTableAdapter As Exercise_9_1.TestDataSetTableAdapters.AnimalsTableAdapter
   Friend WithEvents AnimalsBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents AnimalsDataGridView As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
