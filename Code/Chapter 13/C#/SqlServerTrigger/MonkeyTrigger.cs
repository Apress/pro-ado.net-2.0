using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.SqlServer.Server;


public partial class Triggers
{
   [Microsoft.SqlServer.Server.SqlTrigger (Name="MonkeyTrigger", Target="dbo.Person", Event="FOR INSERT")]
   public static void MonkeyTrigger()
   {
      SqlTriggerContext stContext = SqlContext.TriggerContext;

      if (stContext.TriggerAction == TriggerAction.Insert)
      {
         // Check the column
         using (SqlConnection contextConn = new SqlConnection("context connection=true"))
         {
            SqlCommand cmd = contextConn.CreateCommand();
            contextConn.Open();
            cmd.CommandText = "Select PersonName from Inserted";

            string personName = (string) cmd.ExecuteScalar();

            if (personName.ToUpper() == "MONKEY")
            {
               System.Transactions.Transaction.Current.Rollback();
               SqlContext.Pipe.Send("Monkey not allowed in this table, eat bannana on tree");
            }
            contextConn.Close();
         }
      }
   }
}
//Create Assembly SqlServerTrigger
//from
//'C:\SqlServerTrigger\SqlServerTrigger.dll'
//GO

//Create Trigger MonkeyTrigger 
// ON Person
// FOR INSERT
//As
//External Name
//SqlServerTrigger.[SqlServerTrigger.Triggers].MonkeyTrigger
//Go
