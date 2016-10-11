namespace Exercise_10_1
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewRow dataGridViewRow1 = new System.Windows.Forms.DataGridViewRow();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnExit = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.dgPetBelonging = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.PetBelongingBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.dgAnimals = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.AnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.dgPets = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.PetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.animalsDataSet = new Exercise_10_1.AnimalsDataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dgPetBelonging)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PetBelongingBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.AnimalsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgPets)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PetsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
         this.SuspendLayout();
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(77, 24);
         this.label1.TabIndex = 1;
         this.label1.Text = "Animals";
// 
// label2
// 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(13, 196);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(46, 24);
         this.label2.TabIndex = 3;
         this.label2.Text = "Pets";
// 
// label3
// 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(268, 7);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(123, 24);
         this.label3.TabIndex = 5;
         this.label3.Text = "PetBelonging";
// 
// btnExit
// 
         this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExit.Location = new System.Drawing.Point(587, 340);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(127, 37);
         this.btnExit.TabIndex = 6;
         this.btnExit.Text = "Exit Application";
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
// 
// btnSave
// 
         this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.Location = new System.Drawing.Point(587, 227);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(127, 37);
         this.btnSave.TabIndex = 7;
         this.btnSave.Text = "Save My Data";
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
// 
// dgPetBelonging
// 
         this.dgPetBelonging.AutoGenerateColumns = false;
         this.dgPetBelonging.Columns.Add(this.dataGridViewTextBoxColumn8);
         this.dgPetBelonging.Columns.Add(this.dataGridViewTextBoxColumn9);
         this.dgPetBelonging.Columns.Add(this.dataGridViewTextBoxColumn10);
         this.dgPetBelonging.Columns.Add(this.dataGridViewTextBoxColumn11);
         this.dgPetBelonging.DataSource = this.PetBelongingBindingSource;
         this.dgPetBelonging.Location = new System.Drawing.Point(268, 38);
         this.dgPetBelonging.Name = "dgPetBelonging";
         this.dgPetBelonging.Size = new System.Drawing.Size(446, 150);
         this.dgPetBelonging.TabIndex = 9;
// 
// dataGridViewTextBoxColumn8
// 
         this.dataGridViewTextBoxColumn8.DataPropertyName = "PetBelongingID";
         this.dataGridViewTextBoxColumn8.HeaderText = "PetBelongingID";
         this.dataGridViewTextBoxColumn8.Name = "PetBelongingID";
         this.dataGridViewTextBoxColumn8.ReadOnly = true;
         this.dataGridViewTextBoxColumn8.ValueType = typeof(int);
// 
// dataGridViewTextBoxColumn9
// 
         this.dataGridViewTextBoxColumn9.DataPropertyName = "PetID";
         this.dataGridViewTextBoxColumn9.HeaderText = "PetID";
         this.dataGridViewTextBoxColumn9.Name = "PetID";
         this.dataGridViewTextBoxColumn9.ValueType = typeof(int);
// 
// dataGridViewTextBoxColumn10
// 
         this.dataGridViewTextBoxColumn10.DataPropertyName = "Price";
         this.dataGridViewTextBoxColumn10.HeaderText = "Price";
         this.dataGridViewTextBoxColumn10.Name = "Price";
         this.dataGridViewTextBoxColumn10.ValueType = typeof(decimal);
// 
// dataGridViewTextBoxColumn11
// 
         this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
         this.dataGridViewTextBoxColumn11.HeaderText = "Name";
         this.dataGridViewTextBoxColumn11.Name = "Name";
         this.dataGridViewTextBoxColumn11.ValueType = typeof(string);
// 
// PetBelongingBindingSource
// 
         this.PetBelongingBindingSource.DataMember = "PetBelonging";
         this.PetBelongingBindingSource.DataSource = this.animalsDataSet;
// 
// dgAnimals
// 
         this.dgAnimals.AutoGenerateColumns = false;
         this.dgAnimals.Columns.Add(this.dataGridViewTextBoxColumn1);
         this.dgAnimals.Columns.Add(this.dataGridViewTextBoxColumn2);
         this.dgAnimals.DataSource = this.AnimalsBindingSource;
         this.dgAnimals.Location = new System.Drawing.Point(13, 38);
         this.dgAnimals.Name = "dgAnimals";
         this.dgAnimals.Size = new System.Drawing.Size(245, 150);
         this.dgAnimals.TabIndex = 8;
// 
// dataGridViewTextBoxColumn1
// 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalID";
         this.dataGridViewTextBoxColumn1.HeaderText = "AnimalID";
         this.dataGridViewTextBoxColumn1.Name = "AnimalID";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         this.dataGridViewTextBoxColumn1.ValueType = typeof(int);
// 
// dataGridViewTextBoxColumn2
// 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalType";
         this.dataGridViewTextBoxColumn2.HeaderText = "AnimalType";
         this.dataGridViewTextBoxColumn2.Name = "AnimalType";
         this.dataGridViewTextBoxColumn2.ValueType = typeof(string);
// 
// AnimalsBindingSource
// 
         this.AnimalsBindingSource.DataMember = "Animals";
         this.AnimalsBindingSource.DataSource = this.animalsDataSet;
// 
// dgPets
// 
         this.dgPets.AutoGenerateColumns = false;
         this.dgPets.Columns.Add(this.dataGridViewTextBoxColumn7);
         this.dgPets.Columns.Add(this.dataGridViewTextBoxColumn12);
         this.dgPets.Columns.Add(this.dataGridViewTextBoxColumn13);
         this.dgPets.Columns.Add(this.dataGridViewTextBoxColumn14);
         this.dgPets.Columns.Add(this.dataGridViewTextBoxColumn15);
         this.dgPets.DataSource = this.PetsBindingSource;
         this.dgPets.Location = new System.Drawing.Point(13, 227);
         this.dgPets.Name = "dgPets";
         this.dgPets.Size = new System.Drawing.Size(546, 150);
         this.dgPets.TabIndex = 10;
// 
// dataGridViewTextBoxColumn7
// 
         this.dataGridViewTextBoxColumn7.DataPropertyName = "PetID";
         this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewRow1.DefaultCellStyle;
         this.dataGridViewTextBoxColumn7.HeaderText = "PetID";
         this.dataGridViewTextBoxColumn7.Name = "PetID";
         this.dataGridViewTextBoxColumn7.ReadOnly = true;
         this.dataGridViewTextBoxColumn7.ValueType = typeof(int);
// 
// dataGridViewTextBoxColumn12
// 
         this.dataGridViewTextBoxColumn12.DataPropertyName = "AnimalID";
         this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewRow1.DefaultCellStyle;
         this.dataGridViewTextBoxColumn12.HeaderText = "AnimalID";
         this.dataGridViewTextBoxColumn12.Name = "AnimalID";
         this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewTextBoxColumn12.ValueType = typeof(int);
// 
// dataGridViewTextBoxColumn13
// 
         this.dataGridViewTextBoxColumn13.DataPropertyName = "FirstName";
         this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewRow1.DefaultCellStyle;
         this.dataGridViewTextBoxColumn13.HeaderText = "FirstName";
         this.dataGridViewTextBoxColumn13.Name = "FirstName";
         this.dataGridViewTextBoxColumn13.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn14
// 
         this.dataGridViewTextBoxColumn14.DataPropertyName = "LastName";
         this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewRow1.DefaultCellStyle;
         this.dataGridViewTextBoxColumn14.HeaderText = "LastName";
         this.dataGridViewTextBoxColumn14.Name = "LastName";
         this.dataGridViewTextBoxColumn14.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn15
// 
         this.dataGridViewTextBoxColumn15.DataPropertyName = "Weight";
         this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewRow1.DefaultCellStyle;
         this.dataGridViewTextBoxColumn15.HeaderText = "Weight";
         this.dataGridViewTextBoxColumn15.Name = "Weight";
         this.dataGridViewTextBoxColumn15.ValueType = typeof(int);
// 
// PetsBindingSource
// 
         this.PetsBindingSource.DataMember = "Pets";
         this.PetsBindingSource.DataSource = this.animalsDataSet;
// 
// animalsDataSet
// 
         this.animalsDataSet.DataSetName = "AnimalsDataSet";
         this.animalsDataSet.Locale = new System.Globalization.CultureInfo("en-US");
         this.animalsDataSet.RemotingFormat = System.Data.SerializationFormat.Xml;
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(723, 387);
         this.Controls.Add(this.dgPets);
         this.Controls.Add(this.dgPetBelonging);
         this.Controls.Add(this.dgAnimals);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Exercise 10.1";
         ((System.ComponentModel.ISupportInitialize)(this.dgPetBelonging)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PetBelongingBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.AnimalsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgPets)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PetsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.DataGridView dgPetBelonging;
      private System.Windows.Forms.DataGridView dgAnimals;
      private System.Windows.Forms.DataGridView dgPets;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
      private System.Windows.Forms.BindingSource PetBelongingBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.BindingSource AnimalsBindingSource;
      private System.Windows.Forms.BindingSource PetsBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
      private AnimalsDataSet animalsDataSet;
   }
}

