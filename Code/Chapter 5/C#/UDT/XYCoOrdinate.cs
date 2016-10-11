using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential)]
[SqlUserDefinedType(Format.Native)]
public struct XYCoOrdinate : INullable
{
   private int x;
   private int y;

   public int X
   {
      get { return x; }
      set { x = value; }
   }
   public int Y
   {
      get { return y; }
      set { y = value; }
   }

   public override string ToString()
   {
      return x.ToString() + "," + y.ToString();
   }

   public bool IsNull
   {
      get
      {
         return false;
      }
   }

   public static XYCoOrdinate Null
   {
      get
      {
         XYCoOrdinate h = new XYCoOrdinate();
         return h;
      }
   }

   public static XYCoOrdinate Parse(SqlString s)
   {
      if (s.IsNull || s.Value.ToLower().Equals("null"))
      {
         return Null;
      }
      XYCoOrdinate u = new XYCoOrdinate();

      string str = s.ToString().Trim();
      int commaLocation = str.IndexOf(",");
      try
      {
         u.X = Convert.ToInt32(str.Substring(0, commaLocation));
         u.Y =
          Convert.ToInt32(
           str.Substring(commaLocation + 1, str.Length - commaLocation - 1));
      }
      catch (Exception ex)
      {
         throw new ApplicationException(
          "Error converting " + str + " to a co-ordinate.", ex);
      }
      return u;
   }
}