namespace Exercise_8_8
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dgView = new System.Windows.Forms.DataGridView();
         this.btnLoad = new System.Windows.Forms.Button();
         this.btnSort = new System.Windows.Forms.Button();
         this.btnFilter = new System.Windows.Forms.Button();
         this.btnFindRows = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
         this.SuspendLayout();
// 
// dgView
// 
         this.dgView.AllowUserToAddRows = false;
         this.dgView.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
         this.dgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgView.DefaultCellStyle = dataGridViewCellStyle2;
         this.dgView.Font = new System.Drawing.Font("Tahoma", 8F);
         this.dgView.GridColor = System.Drawing.Color.Silver;
         this.dgView.Location = new System.Drawing.Point(3, 47);
         this.dgView.Name = "dgView";
         this.dgView.ReadOnly = true;
         this.dgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgView.Size = new System.Drawing.Size(331, 277);
         this.dgView.TabIndex = 0;
// 
// btnLoad
// 
         this.btnLoad.Location = new System.Drawing.Point(13, 4);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.TabIndex = 1;
         this.btnLoad.Text = "Load Data";
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
// 
// btnSort
// 
         this.btnSort.Location = new System.Drawing.Point(95, 3);
         this.btnSort.Name = "btnSort";
         this.btnSort.TabIndex = 2;
         this.btnSort.Text = "Sort Data";
         this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
// 
// btnFilter
// 
         this.btnFilter.Location = new System.Drawing.Point(177, 3);
         this.btnFilter.Name = "btnFilter";
         this.btnFilter.TabIndex = 3;
         this.btnFilter.Text = "Filter Data";
         this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
// 
// btnFindRows
// 
         this.btnFindRows.Location = new System.Drawing.Point(259, 2);
         this.btnFindRows.Name = "btnFindRows";
         this.btnFindRows.TabIndex = 4;
         this.btnFindRows.Text = "Find Rows";
         this.btnFindRows.Click += new System.EventHandler(this.btnFindRows_Click);
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(336, 327);
         this.Controls.Add(this.btnFindRows);
         this.Controls.Add(this.btnFilter);
         this.Controls.Add(this.btnSort);
         this.Controls.Add(this.btnLoad);
         this.Controls.Add(this.dgView);
         this.Name = "Form1";
         this.Text = "Exercise 8.8";
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgView;
      private System.Windows.Forms.Button btnLoad;
      private System.Windows.Forms.Button btnSort;
      private System.Windows.Forms.Button btnFilter;
      private System.Windows.Forms.Button btnFindRows;
   }
}

