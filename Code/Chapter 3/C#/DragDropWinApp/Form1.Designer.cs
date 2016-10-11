namespace DragDropWinApp
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
         this.testDataSet = new DragDropWinApp.TestDataSet();
         this.demoBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.demoTableAdapter = new DragDropWinApp.TestDataSetTableAdapters.DemoTableAdapter();
         this.demoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.demoDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.demoBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.demoBindingNavigator)).BeginInit();
         this.demoBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.demoDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // testDataSet
         // 
         this.testDataSet.DataSetName = "TestDataSet";
         // 
         // demoBindingSource
         // 
         this.demoBindingSource.DataMember = "Demo";
         this.demoBindingSource.DataSource = this.testDataSet;
         // 
         // demoTableAdapter
         // 
         this.demoTableAdapter.ClearBeforeFill = true;
         // 
         // demoBindingNavigator
         // 
         this.demoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.demoBindingNavigator.BindingSource = this.demoBindingSource;
         this.demoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.demoBindingNavigator.CountItemFormat = "of {0}";
         this.demoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.demoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.demoBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.demoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.demoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.demoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.demoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.demoBindingNavigator.Name = "demoBindingNavigator";
         this.demoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.demoBindingNavigator.Size = new System.Drawing.Size(298, 25);
         this.demoBindingNavigator.TabIndex = 0;
         this.demoBindingNavigator.Text = "bindingNavigator1";
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
         this.bindingNavigatorPositionItem.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorSaveItem
         // 
         this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
         this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
         this.bindingNavigatorSaveItem.Text = "Save Data";
         this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
         // 
         // demoDataGridView
         // 
         this.demoDataGridView.AutoGenerateColumns = false;
         this.demoDataGridView.Columns.Add(this.dataGridViewTextBoxColumn1);
         this.demoDataGridView.Columns.Add(this.dataGridViewTextBoxColumn2);
         this.demoDataGridView.DataSource = this.demoBindingSource;
         this.demoDataGridView.Location = new System.Drawing.Point(0, 28);
         this.demoDataGridView.Name = "demoDataGridView";
         this.demoDataGridView.Size = new System.Drawing.Size(300, 87);
         this.demoDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "DemoID";
         this.dataGridViewTextBoxColumn1.HeaderText = "DemoID";
         this.dataGridViewTextBoxColumn1.Name = "DemoID";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "DemoValue";
         this.dataGridViewTextBoxColumn2.HeaderText = "DemoValue";
         this.dataGridViewTextBoxColumn2.Name = "DemoValue";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 115);
         this.Controls.Add(this.demoDataGridView);
         this.Controls.Add(this.demoBindingNavigator);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.demoBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.demoBindingNavigator)).EndInit();
         this.demoBindingNavigator.ResumeLayout(false);
         this.demoBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.demoDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private TestDataSet testDataSet;
      private System.Windows.Forms.BindingSource demoBindingSource;
      private DragDropWinApp.TestDataSetTableAdapters.DemoTableAdapter demoTableAdapter;
      private System.Windows.Forms.BindingNavigator demoBindingNavigator;
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
      private System.Windows.Forms.DataGridView demoDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
   }
}

