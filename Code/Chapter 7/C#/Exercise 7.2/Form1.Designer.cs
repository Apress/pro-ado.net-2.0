namespace Exercise_7_2
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
         this.datagridView = new System.Windows.Forms.DataGridView();
         this.buttonFillData = new System.Windows.Forms.Button();
         this.buttonBind = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.datagridView)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridView
         // 
         this.datagridView.Location = new System.Drawing.Point(1, -1);
         this.datagridView.Name = "datagridView";
         this.datagridView.Size = new System.Drawing.Size(280, 244);
         this.datagridView.TabIndex = 0;
         // 
         // buttonFillData
         // 
         this.buttonFillData.Location = new System.Drawing.Point(124, 250);
         this.buttonFillData.Name = "buttonFillData";
         this.buttonFillData.Size = new System.Drawing.Size(75, 23);
         this.buttonFillData.TabIndex = 1;
         this.buttonFillData.Text = "Fill Data";
         this.buttonFillData.Click += new System.EventHandler(this.buttonFillData_Click);
         // 
         // buttonBind
         // 
         this.buttonBind.Location = new System.Drawing.Point(206, 250);
         this.buttonBind.Name = "buttonBind";
         this.buttonBind.Size = new System.Drawing.Size(75, 23);
         this.buttonBind.TabIndex = 2;
         this.buttonBind.Text = "DataBind";
         this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(282, 274);
         this.Controls.Add(this.buttonBind);
         this.Controls.Add(this.buttonFillData);
         this.Controls.Add(this.datagridView);
         this.Name = "Form1";
         this.Text = "Exercise 7.2";
         ((System.ComponentModel.ISupportInitialize)(this.datagridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridView;
      private System.Windows.Forms.Button buttonFillData;
      private System.Windows.Forms.Button buttonBind;
   }
}

