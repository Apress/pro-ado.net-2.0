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
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Me.TestDataSet = New Exercise_7_1.TestDataSet
      Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.UserTableTableAdapter = New Exercise_7_1.TestDataSetTableAdapters.UserTableTableAdapter
      Me.UserTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox
      Me.LastNameTextBox = New System.Windows.Forms.TextBox
      FirstNameLabel = New System.Windows.Forms.Label
      LastNameLabel = New System.Windows.Forms.Label
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UserTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UserTableBindingNavigator.SuspendLayout()
      Me.SuspendLayout()
      '
      'TestDataSet
      '
      Me.TestDataSet.DataSetName = "TestDataSet"
      '
      'UserTableBindingSource
      '
      Me.UserTableBindingSource.DataMember = "UserTable"
      Me.UserTableBindingSource.DataSource = Me.TestDataSet
      '
      'UserTableTableAdapter
      '
      Me.UserTableTableAdapter.ClearBeforeFill = True
      '
      'UserTableBindingNavigator
      '
      Me.UserTableBindingNavigator.AddNewItem = Me.bindingNavigatorAddNewItem
      Me.UserTableBindingNavigator.BindingSource = Me.UserTableBindingSource
      Me.UserTableBindingNavigator.CountItem = Me.bindingNavigatorCountItem
      Me.UserTableBindingNavigator.CountItemFormat = "of {0}"
      Me.UserTableBindingNavigator.DeleteItem = Me.bindingNavigatorDeleteItem
      Me.UserTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorSaveItem})
      Me.UserTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.UserTableBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
      Me.UserTableBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
      Me.UserTableBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
      Me.UserTableBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
      Me.UserTableBindingNavigator.Name = "UserTableBindingNavigator"
      Me.UserTableBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
      Me.UserTableBindingNavigator.Size = New System.Drawing.Size(292, 25)
      Me.UserTableBindingNavigator.TabIndex = 0
      Me.UserTableBindingNavigator.Text = "BindingNavigator1"
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
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(92, 42)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(56, 13)
      FirstNameLabel.TabIndex = 1
      FirstNameLabel.Text = "First Name:"
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(155, 39)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.FirstNameTextBox.TabIndex = 2
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(91, 71)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(57, 13)
      LastNameLabel.TabIndex = 3
      LastNameLabel.Text = "Last Name:"
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(155, 68)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
      Me.LastNameTextBox.TabIndex = 4
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(292, 100)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(Me.UserTableBindingNavigator)
      Me.Name = "Form1"
      Me.Text = "Exercise 7.1"
      CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UserTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UserTableBindingNavigator.ResumeLayout(False)
      Me.UserTableBindingNavigator.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TestDataSet As Exercise_7_1.TestDataSet
   Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents UserTableTableAdapter As Exercise_7_1.TestDataSetTableAdapters.UserTableTableAdapter
   Friend WithEvents UserTableBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox

End Class
