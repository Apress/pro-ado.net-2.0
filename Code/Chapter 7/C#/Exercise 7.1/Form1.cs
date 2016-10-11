using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercise_7_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (this.Validate())
			{
				this.userTableBindingSource.EndEdit();
				this.userTableTableAdapter.Update(this.testDataSet.UserTable);
			}
			else
			{
				System.Windows.Forms.MessageBox.Show(this, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'testDataSet.UserTable' table. You can move, or remove it, as needed.
			this.userTableTableAdapter.Fill(this.testDataSet.UserTable);

		}
	}
}