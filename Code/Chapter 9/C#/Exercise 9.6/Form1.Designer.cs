namespace Exercise_9_6
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
         this.dgView1 = new System.Windows.Forms.DataGridView();
         this.dgView2 = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnSameNoPK = new System.Windows.Forms.Button();
         this.btnSameWithPK = new System.Windows.Forms.Button();
         this.btnCCNoPK = new System.Windows.Forms.Button();
         this.btnCCWithPK = new System.Windows.Forms.Button();
         this.btnDifferent = new System.Windows.Forms.Button();
         this.btnMerge = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgView2)).BeginInit();
         this.SuspendLayout();
// 
// dgView1
// 
         this.dgView1.AllowUserToAddRows = false;
         this.dgView1.AllowUserToDeleteRows = false;
         this.dgView1.Location = new System.Drawing.Point(4, 26);
         this.dgView1.Name = "dgView1";
         this.dgView1.ReadOnly = true;
         this.dgView1.Size = new System.Drawing.Size(479, 150);
         this.dgView1.TabIndex = 0;
// 
// dgView2
// 
         this.dgView2.AllowUserToAddRows = false;
         this.dgView2.AllowUserToDeleteRows = false;
         this.dgView2.Location = new System.Drawing.Point(4, 206);
         this.dgView2.Name = "dgView2";
         this.dgView2.ReadOnly = true;
         this.dgView2.Size = new System.Drawing.Size(479, 150);
         this.dgView2.TabIndex = 1;
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(4, 5);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 14);
         this.label1.TabIndex = 2;
         this.label1.Text = "Table1";
// 
// label2
// 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 185);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 14);
         this.label2.TabIndex = 3;
         this.label2.Text = "Table2";
// 
// btnSameNoPK
// 
         this.btnSameNoPK.Location = new System.Drawing.Point(490, 52);
         this.btnSameNoPK.Name = "btnSameNoPK";
         this.btnSameNoPK.Size = new System.Drawing.Size(240, 23);
         this.btnSameNoPK.TabIndex = 4;
         this.btnSameNoPK.Text = "Same Structures No PK";
         this.btnSameNoPK.Click += new System.EventHandler(this.btnSameNoPK_Click);
// 
// btnSameWithPK
// 
         this.btnSameWithPK.Location = new System.Drawing.Point(490, 82);
         this.btnSameWithPK.Name = "btnSameWithPK";
         this.btnSameWithPK.Size = new System.Drawing.Size(240, 23);
         this.btnSameWithPK.TabIndex = 5;
         this.btnSameWithPK.Text = "Same Structures With PK";
         this.btnSameWithPK.Click += new System.EventHandler(this.btnSameWithPK_Click);
// 
// btnCCNoPK
// 
         this.btnCCNoPK.Location = new System.Drawing.Point(490, 143);
         this.btnCCNoPK.Name = "btnCCNoPK";
         this.btnCCNoPK.Size = new System.Drawing.Size(240, 23);
         this.btnCCNoPK.TabIndex = 6;
         this.btnCCNoPK.Text = "Common Column, No PK";
         this.btnCCNoPK.Click += new System.EventHandler(this.btnCCNoPK_Click);
// 
// btnCCWithPK
// 
         this.btnCCWithPK.Location = new System.Drawing.Point(490, 173);
         this.btnCCWithPK.Name = "btnCCWithPK";
         this.btnCCWithPK.Size = new System.Drawing.Size(240, 23);
         this.btnCCWithPK.TabIndex = 7;
         this.btnCCWithPK.Text = "Common Column, with PK";
         this.btnCCWithPK.Click += new System.EventHandler(this.btnCCWithPK_Click);
// 
// btnDifferent
// 
         this.btnDifferent.Location = new System.Drawing.Point(490, 232);
         this.btnDifferent.Name = "btnDifferent";
         this.btnDifferent.Size = new System.Drawing.Size(240, 23);
         this.btnDifferent.TabIndex = 8;
         this.btnDifferent.Text = "Different Table Structures";
         this.btnDifferent.Click += new System.EventHandler(this.btnDifferent_Click);
// 
// btnMerge
// 
         this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMerge.Location = new System.Drawing.Point(490, 291);
         this.btnMerge.Name = "btnMerge";
         this.btnMerge.Size = new System.Drawing.Size(240, 43);
         this.btnMerge.TabIndex = 9;
         this.btnMerge.Text = "Table1.Merge(Table2)";
         this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(736, 360);
         this.Controls.Add(this.btnMerge);
         this.Controls.Add(this.btnDifferent);
         this.Controls.Add(this.btnCCWithPK);
         this.Controls.Add(this.btnCCNoPK);
         this.Controls.Add(this.btnSameWithPK);
         this.Controls.Add(this.btnSameNoPK);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgView2);
         this.Controls.Add(this.dgView1);
         this.Name = "Form1";
         this.Text = "Exercise 9.6";
         ((System.ComponentModel.ISupportInitialize)(this.dgView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgView2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dgView1;
      private System.Windows.Forms.DataGridView dgView2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnSameNoPK;
      private System.Windows.Forms.Button btnSameWithPK;
      private System.Windows.Forms.Button btnCCNoPK;
      private System.Windows.Forms.Button btnCCWithPK;
      private System.Windows.Forms.Button btnDifferent;
      private System.Windows.Forms.Button btnMerge;
   }
}