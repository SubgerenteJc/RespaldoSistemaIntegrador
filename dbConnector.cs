// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.dbConnector
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
  public class dbConnector
  {
    private SqlConnection SqlConn = (SqlConnection) null;

    public SqlConnection GetConnection
    {
      get
      {
        return this.SqlConn;
      }
      set
      {
        this.SqlConn = value;
      }
    }

    public dbConnector()
    {
      this.SqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
    }
  }
}
