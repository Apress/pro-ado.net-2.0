namespace Exercise_7_4
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
         this.xmlBrowser = new System.Windows.Forms.WebBrowser();
         this.buttonSchema = new System.Windows.Forms.Button();
         this.buttonData = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // xmlBrowser
         // 
         this.xmlBrowser.AllowWebBrowserDrop = false;
         this.xmlBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.xmlBrowser.Location = new System.Drawing.Point(1, -2);
         this.xmlBrowser.Name = "xmlBrowser";
         this.xmlBrowser.Size = new System.Drawing.Size(500, 489);
         // 
         // buttonSchema
         // 
         this.buttonSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonSchema.Location = new System.Drawing.Point(330, 494);
         this.buttonSchema.Name = "buttonSchema";
         this.buttonSchema.Size = new System.Drawing.Size(75, 23);
         this.buttonSchema.TabIndex = 1;
         this.buttonSchema.Text = "Fill Schema";
         this.buttonSchema.Click += new System.EventHandler(this.buttonSchema_Click);
         // 
         // buttonData
         // 
         this.buttonData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonData.Location = new System.Drawing.Point(412, 494);
         this.buttonData.Name = "buttonData";
         this.buttonData.Size = new System.Drawing.Size(75, 23);
         this.buttonData.TabIndex = 2;
         this.buttonData.Text = "Fill Data";
         this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(499, 519);
         this.Controls.Add(this.buttonData);
         this.Controls.Add(this.buttonSchema);
         this.Controls.Add(this.xmlBrowser);
         this.Name = "Form1";
         this.Text = "Exercise 7.4";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.WebBrowser xmlBrowser;
      private System.Windows.Forms.Button buttonSchema;
      private System.Windows.Forms.Button buttonData;
   }
}

