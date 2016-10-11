#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

#endregion

namespace CreateDataSet
{
   public static class DataSetFiller
   {
      public static DataSet FillDataset(string xmlFile)
      {
         DataSet ds = new DataSet();
         ds.ReadXml(xmlFile);
         return ds;
      }

      public static CustProd FillStrongDataSet(string xmlFile)
      {
         CustProd ds = new CustProd();
         ds.ReadXml(xmlFile);
         return ds;
      }
   }
}
