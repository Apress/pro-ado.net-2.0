namespace Exercise_7_3
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
         this.comboTables = new System.Windows.Forms.ComboBox();
         this.datagridView = new System.Windows.Forms.DataGridView();
         this.buttonUserData = new System.Windows.Forms.Button();
         this.buttonPermData = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.datagridView)).BeginInit();
         this.SuspendLayout();
         // 
         // comboTables
         // 
         this.comboTables.FormattingEnabled = true;
         this.comboTables.Location = new System.Drawing.Point(2, 0);
         this.comboTables.Name = "comboTables";
         this.comboTables.Size = new System.Drawing.Size(277, 21);
         this.comboTables.TabIndex = 0;
         this.comboTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
         // 
         // datagridView
         // 
         this.datagridView.Location = new System.Drawing.Point(2, 28);
         this.datagridView.Name = "datagridView";
         this.datagridView.Size = new System.Drawing.Size(277, 297);
         this.datagridView.TabIndex = 1;
         // 
         // buttonUserData
         // 
         this.buttonUserData.Location = new System.Drawing.Point(2, 333);
         this.buttonUserData.Name = "buttonUserData";
         this.buttonUserData.Size = new System.Drawing.Size(127, 20);
         this.buttonUserData.TabIndex = 2;
         this.buttonUserData.Text = "Fill User Data";
         this.buttonUserData.Click += new System.EventHandler(this.buttonUserData_Click);
         // 
         // buttonPermData
         // 
         this.buttonPermData.Location = new System.Drawing.Point(136, 333);
         this.buttonPermData.Name = "buttonPermData";
         this.buttonPermData.Size = new System.Drawing.Size(143, 20);
         this.buttonPermData.TabIndex = 3;
         this.buttonPermData.Text = "Fill Permissions Data";
         this.buttonPermData.Click += new System.EventHandler(this.btnPermData_Click);
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(282, 358);
         this.Controls.Add(this.buttonPermData);
         this.Controls.Add(this.buttonUserData);
         this.Controls.Add(this.datagridView);
         this.Controls.Add(this.comboTables);
         this.Name = "Form1";
         this.Text = "Exercise 7.3";
         ((System.ComponentModel.ISupportInitialize)(this.datagridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ComboBox comboTables;
      private System.Windows.Forms.DataGridView datagridView;
      private System.Windows.Forms.Button buttonUserData;
      private System.Windows.Forms.Button buttonPermData;
   }
}

