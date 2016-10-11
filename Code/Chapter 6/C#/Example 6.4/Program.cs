#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary ;
using System.Data ;
using System.IO ;
#endregion

namespace Example_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////
            Console.WriteLine("For a fair demo, please make sure the previous file is deleted.");
            Console.Read();
            /////////////////////////////
            
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(
                  System.Environment.CurrentDirectory.ToString() + "\\ds.dat", 
                  FileMode.OpenOrCreate);
            DataSet ds = GiveMeFakeData() ;
            ds.RemotingFormat = SerializationFormat.Binary;
            bf.Serialize(fs, ds);
            fs.Close();

            // Check the deserialization performance.
            fs = new FileStream(
                  System.Environment.CurrentDirectory.ToString() + "\\ds.dat", 
                  FileMode.Open);
            long nowticks = DateTime.Now.Ticks;
            DataSet ds2 = (DataSet)bf.Deserialize(fs);
            long tickstotal = DateTime.Now.Ticks - nowticks ;
            Console.WriteLine("Took me : " + tickstotal);
            fs.Close();
        }

         public static DataSet GiveMeFakeData()
         {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Animals");
            dt.Columns.Add(new DataColumn("AnimalID"));
            dt.Columns.Add(new DataColumn("AnimalType"));

            DataRow dr;
            for (int i = 0; i <= 1000; i++)
            {
                  dr = dt.NewRow();
                  dr[0] = 1;
                  dr[1] = "Rabbit";
                  dt.Rows.Add(dr);

                  dr = dt.NewRow();
                  dr[0] = 2;
                  dr[1] = "Monkey";
                  dt.Rows.Add(dr);

                  dr = dt.NewRow();
                  dr[0] = 3;
                  dr[1] = "Donkey";
                  dt.Rows.Add(dr);

                  dr = dt.NewRow();
                  dr[0] = 4;
                  dr[1] = "Dog";
                  dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            return ds;
         }
    }
}
