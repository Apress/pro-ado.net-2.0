namespace Exercise_8_6
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.btnSumPrices = new System.Windows.Forms.Button();
         this.lblSumPrice = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
// 
// dataGridView1
// 
         this.dataGridView1.Location = new System.Drawing.Point(2, 0);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(545, 135);
         this.dataGridView1.TabIndex = 0;
// 
// btnSumPrices
// 
         this.btnSumPrices.Location = new System.Drawing.Point(459, 142);
         this.btnSumPrices.Name = "btnSumPrices";
         this.btnSumPrices.TabIndex = 1;
         this.btnSumPrices.Text = "Sum Prices";
         this.btnSumPrices.Click += new System.EventHandler(this.btnSumPrices_Click);
// 
// lblSumPrice
// 
         this.lblSumPrice.AutoSize = true;
         this.lblSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSumPrice.Location = new System.Drawing.Point(275, 146);
         this.lblSumPrice.Name = "lblSumPrice";
         this.lblSumPrice.Size = new System.Drawing.Size(0, 0);
         this.lblSumPrice.TabIndex = 2;
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(546, 169);
         this.Controls.Add(this.lblSumPrice);
         this.Controls.Add(this.btnSumPrices);
         this.Controls.Add(this.dataGridView1);
         this.Name = "Form1";
         this.Text = "Exercise 8.6";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button btnSumPrices;
      private System.Windows.Forms.Label lblSumPrice;
   }
}

