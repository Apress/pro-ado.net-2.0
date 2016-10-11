namespace Exercise_8_7
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
         this.lbCustomers = new System.Windows.Forms.ListBox();
         this.btnFilter1 = new System.Windows.Forms.Button();
         this.lbCustomerProducts = new System.Windows.Forms.ListBox();
         this.btnFilter2 = new System.Windows.Forms.Button();
         this.lbProducts = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
// 
// lbCustomers
// 
         this.lbCustomers.FormattingEnabled = true;
         this.lbCustomers.Location = new System.Drawing.Point(1, 2);
         this.lbCustomers.Name = "lbCustomers";
         this.lbCustomers.Size = new System.Drawing.Size(141, 238);
         this.lbCustomers.TabIndex = 0;
// 
// btnFilter1
// 
         this.btnFilter1.Location = new System.Drawing.Point(149, 105);
         this.btnFilter1.Name = "btnFilter1";
         this.btnFilter1.Size = new System.Drawing.Size(101, 23);
         this.btnFilter1.TabIndex = 1;
         this.btnFilter1.Text = "GetChildRows >>";
         this.btnFilter1.Click += new System.EventHandler(this.btnFilter1_Click);
// 
// lbCustomerProducts
// 
         this.lbCustomerProducts.FormattingEnabled = true;
         this.lbCustomerProducts.Location = new System.Drawing.Point(257, 2);
         this.lbCustomerProducts.Name = "lbCustomerProducts";
         this.lbCustomerProducts.Size = new System.Drawing.Size(133, 238);
         this.lbCustomerProducts.TabIndex = 2;
// 
// btnFilter2
// 
         this.btnFilter2.Location = new System.Drawing.Point(397, 105);
         this.btnFilter2.Name = "btnFilter2";
         this.btnFilter2.Size = new System.Drawing.Size(108, 23);
         this.btnFilter2.TabIndex = 3;
         this.btnFilter2.Text = "GetParentRow >>";
         this.btnFilter2.Click += new System.EventHandler(this.btnFilter2_Click);
// 
// lbProducts
// 
         this.lbProducts.FormattingEnabled = true;
         this.lbProducts.Location = new System.Drawing.Point(512, 2);
         this.lbProducts.Name = "lbProducts";
         this.lbProducts.Size = new System.Drawing.Size(157, 238);
         this.lbProducts.TabIndex = 4;
// 
// Form1
// 
         this.AutoScaleDimensions= new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(671, 242);
         this.Controls.Add(this.lbProducts);
         this.Controls.Add(this.btnFilter2);
         this.Controls.Add(this.lbCustomerProducts);
         this.Controls.Add(this.btnFilter1);
         this.Controls.Add(this.lbCustomers);
         this.Name = "Form1";
         this.Text = "Exercise 8.7";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListBox lbCustomers;
      private System.Windows.Forms.Button btnFilter1;
      private System.Windows.Forms.ListBox lbCustomerProducts;
      private System.Windows.Forms.Button btnFilter2;
      private System.Windows.Forms.ListBox lbProducts;

   }
}

