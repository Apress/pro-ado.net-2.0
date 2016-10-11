namespace Exercise_9_1
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
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.testDataSet = new Exercise_9_1.TestDataSet();
         this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.animalsTableAdapter = new Exercise_9_1.TestDataSetTableAdapters.AnimalsTableAdapter();
         this.animalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.animalsDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsBindingNavigator)).BeginInit();
         this.animalsBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // testDataSet
         // 
         this.testDataSet.DataSetName = "TestDataSet";
         // 
         // animalsBindingSource
         // 
         this.animalsBindingSource.DataMember = "Animals";
         this.animalsBindingSource.DataSource = this.testDataSet;
         // 
         // animalsTableAdapter
         // 
         this.animalsTableAdapter.ClearBeforeFill = true;
         // 
         // animalsBindingNavigator
         // 
         this.animalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.animalsBindingNavigator.BindingSource = this.animalsBindingSource;
         this.animalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.animalsBindingNavigator.CountItemFormat = "of {0}";
         this.animalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.animalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
         this.animalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.animalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.animalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.animalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.animalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.animalsBindingNavigator.Name = "animalsBindingNavigator";
         this.animalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.animalsBindingNavigator.Size = new System.Drawing.Size(342, 25);
         this.animalsBindingNavigator.TabIndex = 0;
         this.animalsBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 25);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         // 
         // bindingNavigatorSaveItem
         // 
         this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
         this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
         this.bindingNavigatorSaveItem.Text = "Save Data";
         this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
         // 
         // animalsDataGridView
         // 
         this.animalsDataGridView.AutoGenerateColumns = false;
         this.animalsDataGridView.Columns.Add(this.dataGridViewTextBoxColumn1);
         this.animalsDataGridView.Columns.Add(this.dataGridViewTextBoxColumn2);
         this.animalsDataGridView.DataSource = this.animalsBindingSource;
         this.animalsDataGridView.Location = new System.Drawing.Point(0, 28);
         this.animalsDataGridView.Name = "animalsDataGridView";
         this.animalsDataGridView.Size = new System.Drawing.Size(342, 220);
         this.animalsDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalID";
         this.dataGridViewTextBoxColumn1.HeaderText = "AnimalID";
         this.dataGridViewTextBoxColumn1.Name = "AnimalID";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalName";
         this.dataGridViewTextBoxColumn2.HeaderText = "AnimalName";
         this.dataGridViewTextBoxColumn2.Name = "AnimalName";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(342, 248);
         this.Controls.Add(this.animalsDataGridView);
         this.Controls.Add(this.animalsBindingNavigator);
         this.Name = "Form1";
         this.Text = "Exercise 9.1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.animalsBindingNavigator)).EndInit();
         this.animalsBindingNavigator.ResumeLayout(false);
         this.animalsBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion

      private Exercise_9_1.TestDataSet testDataSet;
      private System.Windows.Forms.BindingSource animalsBindingSource;
      private Exercise_9_1.TestDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
      private System.Windows.Forms.BindingNavigator animalsBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView animalsDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}

