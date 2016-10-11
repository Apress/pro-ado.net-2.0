namespace Exercise_9_4
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
         this.dgView = new System.Windows.Forms.DataGridView();
         this.btnLoad = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
         this.SuspendLayout();
// 
// dgView
// 
         this.dgView.Location = new System.Drawing.Point(3, 4);
         this.dgView.Name = "dgView";
         this.dgView.Size = new System.Drawing.Size(353, 228);
         this.dgView.TabIndex = 0;
// 
// btnLoad
// 
         this.btnLoad.Location = new System.Drawing.Point(199, 240);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.TabIndex = 1;
         this.btnLoad.Text = "Load";
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
// 
// btnSave
// 
         this.btnSave.Location = new System.Drawing.Point(281, 239);
         this.btnSave.Name = "btnSave";
         this.btnSave.TabIndex = 2;
         this.btnSave.Text = "Save";
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(357, 265);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnLoad);
         this.Controls.Add(this.dgView);
         this.Name = "Form1";
         this.Text = "Exercise 9.4";
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgView;
      private System.Windows.Forms.Button btnLoad;
      private System.Windows.Forms.Button btnSave;
   }
}

