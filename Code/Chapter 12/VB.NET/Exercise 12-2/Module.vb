Imports System.Data
Imports System.Data.SqlClient

Module Module1
   Private strConnection As String = "Server=(local);Database=Test;Integrated Security=SSPI"
   Sub Main()
      Dim strXMLDoc As String = _
          "<Top>" & _
              "<Region RegionID=""11"" RegionDescription=""UpTown""/>" & _
              "<Region RegionID=""22"" RegionDescription=""DownTown""/>" & _
          "</Top>"

      Dim sqlConnection As SqlConnection = New SqlConnection(strConnection)
      Dim openXMLCommand As SqlCommand = New SqlCommand("RegionInsert", sqlConnection)
      openXMLCommand.CommandType = CommandType.StoredProcedure

      Dim xmlDocParm As SqlParameter = _
          openXMLCommand.Parameters.Add("@xmlDoc", SqlDbType.NVarChar, 4000)
      xmlDocParm.Value = strXMLDoc

      sqlConnection.Open()
      openXMLCommand.ExecuteNonQuery()

      xmlDocParm.Value = strXMLDoc.Replace("Town", "state")
      openXMLCommand.CommandText = "RegionUpdate"
      openXMLCommand.ExecuteNonQuery()

      openXMLCommand.CommandText = "RegionDelete"
      openXMLCommand.ExecuteNonQuery()

      sqlConnection.Close()
   End Sub
End Module
