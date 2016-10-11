namespace Example_5_4
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
           this.btnPopulate = new System.Windows.Forms.Button();
           this.myDataGrid = new System.Windows.Forms.DataGridView();
           this.btnDataBind = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
           this.SuspendLayout();
           // 
           // btnPopulate
           // 
           this.btnPopulate.Location = new System.Drawing.Point(98, 160);
           this.btnPopulate.Name = "btnPopulate";
           this.btnPopulate.Size = new System.Drawing.Size(98, 23);
           this.btnPopulate.TabIndex = 0;
           this.btnPopulate.Text = "Populate Arraylist";
           this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
           // 
           // myDataGrid
           // 
           dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
           dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
           dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
           this.myDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
           dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
           dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
           dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
           dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
           dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
           dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
           dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
           this.myDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
           this.myDataGrid.Font = new System.Drawing.Font("Tahoma", 8F);
           this.myDataGrid.GridColor = System.Drawing.Color.Silver;
           this.myDataGrid.Location = new System.Drawing.Point(5, 3);
           this.myDataGrid.Name = "myDataGrid";
           this.myDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
           this.myDataGrid.Size = new System.Drawing.Size(279, 150);
           this.myDataGrid.TabIndex = 1;
           // 
           // btnDataBind
           // 
           this.btnDataBind.Location = new System.Drawing.Point(209, 160);
           this.btnDataBind.Name = "btnDataBind";
           this.btnDataBind.Size = new System.Drawing.Size(75, 23);
           this.btnDataBind.TabIndex = 2;
           this.btnDataBind.Text = "DataBind";
           this.btnDataBind.Click += new System.EventHandler(this.btnDataBind_Click);
           // 
           // Form1
           // 
           this.ClientSize = new System.Drawing.Size(290, 185);
           this.Controls.Add(this.btnDataBind);
           this.Controls.Add(this.myDataGrid);
           this.Controls.Add(this.btnPopulate);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           this.MaximizeBox = false;
           this.Name = "Form1";
           this.Text = "Example 5.4";
           ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.DataGridView myDataGrid;
        private System.Windows.Forms.Button btnDataBind;
    }
}

