#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace Exercise_9_2
{
   class Program
   {
      private static string connectionString = "Server=(local);Database=Test;Integrated Security=SSPI";
      static void Main(string[] args)
      {
         SqlDataAdapter myDataAdapter =
            new SqlDataAdapter("Select * from Animals2", connectionString);
         SqlCommandBuilder cmdBldr = new SqlCommandBuilder(myDataAdapter) ;

         cmdBldr.ConflictOption = ConflictOption.OverwriteChanges;

         Console.WriteLine("Update Command = ");
         Console.WriteLine(cmdBldr.GetUpdateCommand().CommandText);
      }
   }
}
