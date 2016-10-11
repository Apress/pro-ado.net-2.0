#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

#endregion

namespace Example_6_7
{
   class Program
   {
static void Main(string[] args)
{
   BookDataSet myDS = new BookDataSet();
   myDS.ReadXml("Books.xml");

   Console.WriteLine("Relations Found:");
   foreach (DataRelation xRelation in myDS.Relations)
   {
      Console.WriteLine(xRelation.RelationName);
   }

   Console.WriteLine("Apress Books and Reviews");
   Console.WriteLine("----------------------");

   foreach (BookDataSet.BooksRow Book in myDS.Books.Rows)
   {
      Console.WriteLine(Book.Title);

      foreach (BookDataSet.BookReviewsRow Review in Book.GetBookReviewsRows())
      {
         Console.WriteLine("  {0}", Review.Rating);
      }
   }
}
   }
}
