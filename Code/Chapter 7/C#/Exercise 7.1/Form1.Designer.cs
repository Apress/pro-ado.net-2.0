namespace Exercise_7_1
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
         System.Windows.Forms.Label firstNameLabel;
         System.Windows.Forms.Label lastNameLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.testDataSet = new Exercise_7_1.TestDataSet();
         this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.userTableTableAdapter = new Exercise_7_1.TestDataSetTableAdapters.UserTableTableAdapter();
         this.userTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         firstNameLabel = new System.Windows.Forms.Label();
         lastNameLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.userTableBindingNavigator)).BeginInit();
         this.userTableBindingNavigator.SuspendLayout();
         this.SuspendLayout();
         // 
         // firstNameLabel
         // 
         firstNameLabel.AutoSize = true;
         firstNameLabel.Location = new System.Drawing.Point(78, 37);
         firstNameLabel.Name = "firstNameLabel";
         firstNameLabel.Size = new System.Drawing.Size(56, 13);
         firstNameLabel.TabIndex = 1;
         firstNameLabel.Text = "First Name:";
         // 
         // lastNameLabel
         // 
         lastNameLabel.AutoSize = true;
         lastNameLabel.Location = new System.Drawing.Point(78, 67);
         lastNameLabel.Name = "lastNameLabel";
         lastNameLabel.Size = new System.Drawing.Size(57, 13);
         lastNameLabel.TabIndex = 3;
         lastNameLabel.Text = "Last Name:";
         // 
         // testDataSet
         // 
         this.testDataSet.DataSetName = "TestDataSet";
         // 
         // userTableBindingSource
         // 
         this.userTableBindingSource.DataMember = "UserTable";
         this.userTableBindingSource.DataSource = this.testDataSet;
         // 
         // userTableTableAdapter
         // 
         this.userTableTableAdapter.ClearBeforeFill = true;
         // 
         // userTableBindingNavigator
         // 
         this.userTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.userTableBindingNavigator.BindingSource = this.userTableBindingSource;
         this.userTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.userTableBindingNavigator.CountItemFormat = "of {0}";
         this.userTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.userTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.userTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.userTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.userTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.userTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.userTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.userTableBindingNavigator.Name = "userTableBindingNavigator";
         this.userTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.userTableBindingNavigator.Size = new System.Drawing.Size(292, 25);
         this.userTableBindingNavigator.TabIndex = 0;
         this.userTableBindingNavigator.Text = "bindingNavigator1";
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
         // firstNameTextBox
         // 
         this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource, "FirstName", true));
         this.firstNameTextBox.Location = new System.Drawing.Point(141, 34);
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
         this.firstNameTextBox.TabIndex = 2;
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource, "LastName", true));
         this.lastNameTextBox.Location = new System.Drawing.Point(142, 64);
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
         this.lastNameTextBox.TabIndex = 4;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(292, 103);
         this.Controls.Add(lastNameLabel);
         this.Controls.Add(this.lastNameTextBox);
         this.Controls.Add(firstNameLabel);
         this.Controls.Add(this.firstNameTextBox);
         this.Controls.Add(this.userTableBindingNavigator);
         this.Name = "Form1";
         this.Text = "Exercise 7.1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.userTableBindingNavigator)).EndInit();
         this.userTableBindingNavigator.ResumeLayout(false);
         this.userTableBindingNavigator.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion

		private TestDataSet testDataSet;
		private System.Windows.Forms.BindingSource userTableBindingSource;
      private Exercise_7_1.TestDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
		private System.Windows.Forms.BindingNavigator userTableBindingNavigator;
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
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
	}
}

