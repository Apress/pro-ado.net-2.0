namespace Exercise_8_9
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
         this.xmlViewer = new System.Windows.Forms.WebBrowser();
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
         this.SuspendLayout();
// 
// dgView
// 
         this.dgView.Location = new System.Drawing.Point(6, 2);
         this.dgView.Name = "dgView";
         this.dgView.Size = new System.Drawing.Size(381, 185);
         this.dgView.TabIndex = 0;
// 
// xmlViewer
// 
         this.xmlViewer.Location = new System.Drawing.Point(6, 194);
         this.xmlViewer.Name = "xmlViewer";
         this.xmlViewer.Size = new System.Drawing.Size(381, 298);
         this.xmlViewer.TabIndex = 1;
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(389, 494);
         this.Controls.Add(this.xmlViewer);
         this.Controls.Add(this.dgView);
         this.Name = "Form1";
         this.Text = "Exercise 8.9";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgView;
      private System.Windows.Forms.WebBrowser xmlViewer;
   }
}

