namespace Exercise_9_5
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dgCustomers = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.dgCustomerProducts = new System.Windows.Forms.DataGridView();
         this.label3 = new System.Windows.Forms.Label();
         this.dgProducts = new System.Windows.Forms.DataGridView();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnGetChanges = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgCustomerProducts)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
         this.SuspendLayout();
// 
// dgCustomers
// 
         this.dgCustomers.BackgroundColor = System.Drawing.Color.Gainsboro;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         this.dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgCustomers.DefaultCellStyle = dataGridViewCellStyle2;
         this.dgCustomers.Font = new System.Drawing.Font("Courier New", 9F);
         this.dgCustomers.GridColor = System.Drawing.Color.DarkGray;
         this.dgCustomers.Location = new System.Drawing.Point(13, 34);
         this.dgCustomers.Name = "dgCustomers";
         this.dgCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgCustomers.Size = new System.Drawing.Size(451, 200);
         this.dgCustomers.TabIndex = 0;
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 5);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(83, 22);
         this.label1.TabIndex = 1;
         this.label1.Text = "Customers";
// 
// label2
// 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(13, 241);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(138, 22);
         this.label2.TabIndex = 3;
         this.label2.Text = "CustomerProducts";
// 
// dgCustomerProducts
// 
         this.dgCustomerProducts.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
         this.dgCustomerProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateBlue;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgCustomerProducts.DefaultCellStyle = dataGridViewCellStyle4;
         this.dgCustomerProducts.Font = new System.Drawing.Font("Tahoma", 8F);
         this.dgCustomerProducts.GridColor = System.Drawing.Color.Peru;
         this.dgCustomerProducts.Location = new System.Drawing.Point(13, 270);
         this.dgCustomerProducts.Name = "dgCustomerProducts";
         this.dgCustomerProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.dgCustomerProducts.Size = new System.Drawing.Size(451, 200);
         this.dgCustomerProducts.TabIndex = 2;
// 
// label3
// 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(15, 481);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(69, 22);
         this.label3.TabIndex = 5;
         this.label3.Text = "Products";
// 
// dgProducts
// 
         this.dgProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
         dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9F);
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
         this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9F);
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgProducts.DefaultCellStyle = dataGridViewCellStyle6;
         this.dgProducts.Font = new System.Drawing.Font("Courier New", 9F);
         this.dgProducts.GridColor = System.Drawing.Color.DarkGray;
         this.dgProducts.Location = new System.Drawing.Point(15, 510);
         this.dgProducts.Name = "dgProducts";
         this.dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
         this.dgProducts.Size = new System.Drawing.Size(449, 200);
         this.dgProducts.TabIndex = 4;
// 
// btnClose
// 
         this.btnClose.Location = new System.Drawing.Point(13, 732);
         this.btnClose.Name = "btnClose";
         this.btnClose.TabIndex = 9;
         this.btnClose.Text = "Exit";
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
// 
// btnGetChanges
// 
         this.btnGetChanges.Location = new System.Drawing.Point(389, 732);
         this.btnGetChanges.Name = "btnGetChanges";
         this.btnGetChanges.TabIndex = 10;
         this.btnGetChanges.Text = "Get Changes";
         this.btnGetChanges.Click += new System.EventHandler(this.btnGetChanges_Click);
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(478, 767);
         this.Controls.Add(this.btnGetChanges);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.dgProducts);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dgCustomerProducts);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgCustomers);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.Text = "Exercise 9.5";
         this.TopMost = true;
         ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgCustomerProducts)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dgCustomers;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.DataGridView dgCustomerProducts;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DataGridView dgProducts;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnGetChanges;
   }
}

