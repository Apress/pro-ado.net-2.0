#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

#endregion

namespace Example_6_5
{
   class Program
   {
      static void Main(string[] args)
      {
         DataSet BookDataSet = new DataSet();
         BookDataSet.ReadXmlSchema("BookDataSet.xsd");
         BookDataSet.ReadXml("Books.xml");

         Console.WriteLine("Recent Books:");
         Console.WriteLine("-------------");

         foreach (DataRow xRow in BookDataSet.Tables["Books"].Rows)
         {
            Console.WriteLine("{0} by {1}", xRow["Title"], xRow["Publisher"]);
         }
      }
   }
}
