namespace Example_6_3
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
         this.btnSetupGrids = new System.Windows.Forms.Button();
         this.AnimalsGrid = new System.Windows.Forms.DataGridView();
         this.petsGrid = new System.Windows.Forms.DataGridView();
         this.btnShowXml = new System.Windows.Forms.Button();
         this.nestedRelation = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.petsGrid)).BeginInit();
         this.SuspendLayout();
// 
// btnSetupGrids
// 
         this.btnSetupGrids.Location = new System.Drawing.Point(12, 8);
         this.btnSetupGrids.Name = "btnSetupGrids";
         this.btnSetupGrids.Size = new System.Drawing.Size(212, 28);
         this.btnSetupGrids.TabIndex = 0;
         this.btnSetupGrids.Text = "Create DataSet and DataBind";
         this.btnSetupGrids.Click += new System.EventHandler(this.btnPopulate_Click);
// 
// AnimalsGrid
// 
         this.AnimalsGrid.BackgroundColor = System.Drawing.Color.Lavender;
         this.AnimalsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender;
         this.AnimalsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.AnimalsGrid.DefaultCellStyle = dataGridViewCellStyle2;
         this.AnimalsGrid.Font = new System.Drawing.Font("Tahoma", 8F);
         this.AnimalsGrid.GridColor = System.Drawing.Color.RoyalBlue;
         this.AnimalsGrid.Location = new System.Drawing.Point(12, 43);
         this.AnimalsGrid.Name = "AnimalsGrid";
         this.AnimalsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.AnimalsGrid.Size = new System.Drawing.Size(496, 150);
         this.AnimalsGrid.TabIndex = 1;
// 
// petsGrid
// 
         this.petsGrid.BackgroundColor = System.Drawing.Color.Silver;
         this.petsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         this.petsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.petsGrid.DefaultCellStyle = dataGridViewCellStyle4;
         this.petsGrid.Font = new System.Drawing.Font("Tahoma", 8F);
         this.petsGrid.GridColor = System.Drawing.Color.DimGray;
         this.petsGrid.Location = new System.Drawing.Point(12, 200);
         this.petsGrid.Name = "petsGrid";
         this.petsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.petsGrid.Size = new System.Drawing.Size(496, 150);
         this.petsGrid.TabIndex = 2;
// 
// btnShowXml
// 
         this.btnShowXml.Location = new System.Drawing.Point(251, 8);
         this.btnShowXml.Name = "btnShowXml";
         this.btnShowXml.Size = new System.Drawing.Size(121, 27);
         this.btnShowXml.TabIndex = 3;
         this.btnShowXml.Text = "Show XML";
         this.btnShowXml.Click += new System.EventHandler(this.btnShowXml_Click);
// 
// nestedRelation
// 
         this.nestedRelation.AutoSize = true;
         this.nestedRelation.Location = new System.Drawing.Point(399, 13);
         this.nestedRelation.Name = "nestedRelation";
         this.nestedRelation.Size = new System.Drawing.Size(109, 17);
         this.nestedRelation.TabIndex = 4;
         this.nestedRelation.Text = "Is Relation Nested";
         this.nestedRelation.CheckedChanged += new System.EventHandler(this.nestedRelation_CheckedChanged);
// 
// Form1
// 
         this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
         this.ClientSize = new System.Drawing.Size(522, 362);
         this.Controls.Add(this.nestedRelation);
         this.Controls.Add(this.btnShowXml);
         this.Controls.Add(this.petsGrid);
         this.Controls.Add(this.AnimalsGrid);
         this.Controls.Add(this.btnSetupGrids);
         this.Name = "Form1";
         this.Text = "Example 6.3";
         ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.petsGrid)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnSetupGrids;
      private System.Windows.Forms.DataGridView AnimalsGrid;
      private System.Windows.Forms.DataGridView petsGrid;
      private System.Windows.Forms.Button btnShowXml;
      private System.Windows.Forms.CheckBox nestedRelation;
   }
}

