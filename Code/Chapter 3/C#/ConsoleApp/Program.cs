using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         TestDataSet testDS = new TestDataSet();
         TestDataSetTableAdapters.DemoTableAdapter tableAdapter = 
            new TestDataSetTableAdapters.DemoTableAdapter();
         tableAdapter.Fill(testDS.Demo);

         TestDataSet.DemoRow demoRow = 
            (TestDataSet.DemoRow)testDS.Demo.Rows[0];
         Console.WriteLine(demoRow.DemoValue);
      }
   }
}
