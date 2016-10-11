#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Example_6_9
{
   partial class Form1 : Form
   {
      private BookDataSet books;
      public Form1()
      {
         InitializeComponent();
         books = new BookDataSet();
         books.ReadXml("Books.xml");
         dgBooks.DataSource = books.Books;
      }

      private void btnSumScores_Click(object sender, EventArgs e)
      {
         int sum = 0;
         foreach (BookDataSet.Book book in books.Books)
         {
            foreach (BookDataSet.BookReview review in book.Reviews())
            {
               sum += Convert.ToInt32(review.Rating);
            }
         }
         MessageBox.Show(this, "Score Total: " + sum.ToString());
      }
   }
}