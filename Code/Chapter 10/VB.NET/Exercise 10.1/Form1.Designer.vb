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
      Me.components = New System.ComponentModel.Container
      Dim DataGridViewRow1 As System.Windows.Forms.DataGridViewRow = New System.Windows.Forms.DataGridViewRow
      Me.AnimalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.animalsDataSet = New Exercise_10_1.AnimalsDataSet
      Me.dgPets = New System.Windows.Forms.DataGridView
      Me.dataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.PetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.dataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dgAnimals = New System.Windows.Forms.DataGridView
      Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dgPetBelonging = New System.Windows.Forms.DataGridView
      Me.dataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.dataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.PetBelongingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.btnSave = New System.Windows.Forms.Button
      Me.btnExit = New System.Windows.Forms.Button
      Me.label3 = New System.Windows.Forms.Label
      Me.label2 = New System.Windows.Forms.Label
      Me.label1 = New System.Windows.Forms.Label
      CType(Me.AnimalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.animalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgPets, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgPetBelonging, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PetBelongingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'AnimalsBindingSource
      '
      Me.AnimalsBindingSource.DataMember = "Animals"
      Me.AnimalsBindingSource.DataSource = Me.animalsDataSet
      '
      'animalsDataSet
      '
      Me.animalsDataSet.DataSetName = "AnimalsDataSet"
      Me.animalsDataSet.Locale = New System.Globalization.CultureInfo("en-US")
      Me.animalsDataSet.RemotingFormat = System.Data.SerializationFormat.Xml
      '
      'dgPets
      '
      Me.dgPets.AutoGenerateColumns = False
      Me.dgPets.Columns.Add(Me.dataGridViewTextBoxColumn7)
      Me.dgPets.Columns.Add(Me.dataGridViewTextBoxColumn12)
      Me.dgPets.Columns.Add(Me.dataGridViewTextBoxColumn13)
      Me.dgPets.Columns.Add(Me.dataGridViewTextBoxColumn14)
      Me.dgPets.Columns.Add(Me.dataGridViewTextBoxColumn15)
      Me.dgPets.DataSource = Me.PetsBindingSource
      Me.dgPets.Location = New System.Drawing.Point(3, 224)
      Me.dgPets.Name = "dgPets"
      Me.dgPets.Size = New System.Drawing.Size(546, 150)
      Me.dgPets.TabIndex = 18
      '
      'dataGridViewTextBoxColumn7
      '
      Me.dataGridViewTextBoxColumn7.DataPropertyName = "PetID"
      Me.dataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewRow1.DefaultCellStyle
      Me.dataGridViewTextBoxColumn7.HeaderText = "PetID"
      Me.dataGridViewTextBoxColumn7.Name = "PetID"
      Me.dataGridViewTextBoxColumn7.ReadOnly = True
      Me.dataGridViewTextBoxColumn7.ValueType = GetType(Integer)
      '
      'dataGridViewTextBoxColumn12
      '
      Me.dataGridViewTextBoxColumn12.DataPropertyName = "AnimalID"
      Me.dataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewRow1.DefaultCellStyle
      Me.dataGridViewTextBoxColumn12.HeaderText = "AnimalID"
      Me.dataGridViewTextBoxColumn12.Name = "AnimalID"
      Me.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dataGridViewTextBoxColumn12.ValueType = GetType(Integer)
      '
      'dataGridViewTextBoxColumn13
      '
      Me.dataGridViewTextBoxColumn13.DataPropertyName = "FirstName"
      Me.dataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewRow1.DefaultCellStyle
      Me.dataGridViewTextBoxColumn13.HeaderText = "FirstName"
      Me.dataGridViewTextBoxColumn13.Name = "FirstName"
      Me.dataGridViewTextBoxColumn13.ValueType = GetType(String)
      '
      'dataGridViewTextBoxColumn14
      '
      Me.dataGridViewTextBoxColumn14.DataPropertyName = "LastName"
      Me.dataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewRow1.DefaultCellStyle
      Me.dataGridViewTextBoxColumn14.HeaderText = "LastName"
      Me.dataGridViewTextBoxColumn14.Name = "LastName"
      Me.dataGridViewTextBoxColumn14.ValueType = GetType(String)
      '
      'dataGridViewTextBoxColumn15
      '
      Me.dataGridViewTextBoxColumn15.DataPropertyName = "Weight"
      Me.dataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewRow1.DefaultCellStyle
      Me.dataGridViewTextBoxColumn15.HeaderText = "Weight"
      Me.dataGridViewTextBoxColumn15.Name = "Weight"
      Me.dataGridViewTextBoxColumn15.ValueType = GetType(Integer)
      '
      'PetsBindingSource
      '
      Me.PetsBindingSource.DataMember = "Pets"
      Me.PetsBindingSource.DataSource = Me.animalsDataSet
      '
      'dataGridViewTextBoxColumn2
      '
      Me.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalType"
      Me.dataGridViewTextBoxColumn2.HeaderText = "AnimalType"
      Me.dataGridViewTextBoxColumn2.Name = "AnimalType"
      Me.dataGridViewTextBoxColumn2.ValueType = GetType(String)
      '
      'dgAnimals
      '
      Me.dgAnimals.AutoGenerateColumns = False
      Me.dgAnimals.Columns.Add(Me.dataGridViewTextBoxColumn1)
      Me.dgAnimals.Columns.Add(Me.dataGridViewTextBoxColumn2)
      Me.dgAnimals.DataSource = Me.AnimalsBindingSource
      Me.dgAnimals.Location = New System.Drawing.Point(3, 35)
      Me.dgAnimals.Name = "dgAnimals"
      Me.dgAnimals.Size = New System.Drawing.Size(245, 150)
      Me.dgAnimals.TabIndex = 16
      '
      'dataGridViewTextBoxColumn1
      '
      Me.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalID"
      Me.dataGridViewTextBoxColumn1.HeaderText = "AnimalID"
      Me.dataGridViewTextBoxColumn1.Name = "AnimalID"
      Me.dataGridViewTextBoxColumn1.ReadOnly = True
      Me.dataGridViewTextBoxColumn1.ValueType = GetType(Integer)
      '
      'dataGridViewTextBoxColumn9
      '
      Me.dataGridViewTextBoxColumn9.DataPropertyName = "PetID"
      Me.dataGridViewTextBoxColumn9.HeaderText = "PetID"
      Me.dataGridViewTextBoxColumn9.Name = "PetID"
      Me.dataGridViewTextBoxColumn9.ValueType = GetType(Integer)
      '
      'dataGridViewTextBoxColumn8
      '
      Me.dataGridViewTextBoxColumn8.DataPropertyName = "PetBelongingID"
      Me.dataGridViewTextBoxColumn8.HeaderText = "PetBelongingID"
      Me.dataGridViewTextBoxColumn8.Name = "PetBelongingID"
      Me.dataGridViewTextBoxColumn8.ReadOnly = True
      Me.dataGridViewTextBoxColumn8.ValueType = GetType(Integer)
      '
      'dgPetBelonging
      '
      Me.dgPetBelonging.AutoGenerateColumns = False
      Me.dgPetBelonging.Columns.Add(Me.dataGridViewTextBoxColumn8)
      Me.dgPetBelonging.Columns.Add(Me.dataGridViewTextBoxColumn9)
      Me.dgPetBelonging.Columns.Add(Me.dataGridViewTextBoxColumn10)
      Me.dgPetBelonging.Columns.Add(Me.dataGridViewTextBoxColumn11)
      Me.dgPetBelonging.DataSource = Me.PetBelongingBindingSource
      Me.dgPetBelonging.Location = New System.Drawing.Point(258, 35)
      Me.dgPetBelonging.Name = "dgPetBelonging"
      Me.dgPetBelonging.Size = New System.Drawing.Size(446, 150)
      Me.dgPetBelonging.TabIndex = 17
      '
      'dataGridViewTextBoxColumn10
      '
      Me.dataGridViewTextBoxColumn10.DataPropertyName = "Price"
      Me.dataGridViewTextBoxColumn10.HeaderText = "Price"
      Me.dataGridViewTextBoxColumn10.Name = "Price"
      Me.dataGridViewTextBoxColumn10.ValueType = GetType(Decimal)
      '
      'dataGridViewTextBoxColumn11
      '
      Me.dataGridViewTextBoxColumn11.DataPropertyName = "Name"
      Me.dataGridViewTextBoxColumn11.HeaderText = "Name"
      Me.dataGridViewTextBoxColumn11.Name = "Name"
      Me.dataGridViewTextBoxColumn11.ValueType = GetType(String)
      '
      'PetBelongingBindingSource
      '
      Me.PetBelongingBindingSource.DataMember = "PetBelonging"
      Me.PetBelongingBindingSource.DataSource = Me.animalsDataSet
      '
      'btnSave
      '
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.Location = New System.Drawing.Point(577, 224)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(127, 37)
      Me.btnSave.TabIndex = 15
      Me.btnSave.Text = "Save My Data"
      '
      'btnExit
      '
      Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.Location = New System.Drawing.Point(577, 337)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(127, 37)
      Me.btnExit.TabIndex = 14
      Me.btnExit.Text = "Exit Application"
      '
      'label3
      '
      Me.label3.AutoSize = True
      Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.label3.Location = New System.Drawing.Point(258, 4)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(123, 24)
      Me.label3.TabIndex = 13
      Me.label3.Text = "PetBelonging"
      '
      'label2
      '
      Me.label2.AutoSize = True
      Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.label2.Location = New System.Drawing.Point(3, 193)
      Me.label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(46, 24)
      Me.label2.TabIndex = 12
      Me.label2.Text = "Pets"
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.label1.Location = New System.Drawing.Point(3, 4)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(77, 24)
      Me.label1.TabIndex = 11
      Me.label1.Text = "Animals"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(5, 13)
      Me.ClientSize = New System.Drawing.Size(706, 376)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.label3)
      Me.Controls.Add(Me.label2)
      Me.Controls.Add(Me.label1)
      Me.Controls.Add(Me.dgPets)
      Me.Controls.Add(Me.dgAnimals)
      Me.Controls.Add(Me.dgPetBelonging)
      Me.Controls.Add(Me.btnSave)
      Me.Name = "Form1"
      Me.Text = "Exercise 10.1"
      CType(Me.AnimalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.animalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgPets, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgAnimals, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgPetBelonging, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PetBelongingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents AnimalsBindingSource As System.Windows.Forms.BindingSource
   Private animalsDataSet As Exercise_10_1.AnimalsDataSet
   Private WithEvents dgPets As System.Windows.Forms.DataGridView
   Private WithEvents dataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents PetsBindingSource As System.Windows.Forms.BindingSource
   Private WithEvents dataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dgAnimals As System.Windows.Forms.DataGridView
   Private WithEvents dataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dgPetBelonging As System.Windows.Forms.DataGridView
   Private WithEvents dataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents dataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents PetBelongingBindingSource As System.Windows.Forms.BindingSource
   Private WithEvents btnSave As System.Windows.Forms.Button
   Private WithEvents btnExit As System.Windows.Forms.Button
   Private WithEvents label3 As System.Windows.Forms.Label
   Private WithEvents label2 As System.Windows.Forms.Label
   Private WithEvents label1 As System.Windows.Forms.Label

End Class
