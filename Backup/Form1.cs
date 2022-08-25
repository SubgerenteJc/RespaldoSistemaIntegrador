// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.Form1
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.mx.com.pilgrims.wslogistica;
using WindowsFormsApp1.TmwDispatchHorizonSvc;

namespace WindowsFormsApp1
{
  public class Form1 : Form
  {
    private int limpiar = 0;
    private IContainer components = (IContainer) null;
    private System.Windows.Forms.GroupBox groupBox1;
    private DateTimePicker dateTimePicker2;
    private DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCargar;
    private System.Windows.Forms.Label lblResult;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        this.dateTimePicker1.Value = this.dateTimePicker1.Value.AddDays(-5.0);
        foreach (DateTime dateTime in this.EachDay(this.dateTimePicker1.Value, this.dateTimePicker2.Value))
        {
          this.cargar_dia(dateTime.ToString("yyyy/MM/dd"));
          this.lblResult.Visible = true;
        }
        this.cargar_dia(DateTime.Now.ToString("yyyy/MM/dd"));
      }
      catch (Exception ex)
      {
        string message = ex.Message;
      }
      this.Close();
    }

    private void cargar_dia(string fecha)
    {
      wsLogistica wsLogistica = new wsLogistica();
      DataSet dataSet1 = new DataSet();
      XmlDocument xmlDocument = new XmlDocument();
      DataSet dataSet2 = new DataSet();
      SqlConnection getConnection = new dbConnector().GetConnection;
      wsLogistica.WSL_GetInfoEmbarque("FR21", Convert.ToDateTime(fecha + "T" + DateTime.Now.ToString("HH:mm:ss")));
      XmlNode infoEmbarque = wsLogistica.WSL_GetInfoEmbarque("FR21", Convert.ToDateTime(fecha + "T23:00:00"));
      xmlDocument.LoadXml(infoEmbarque.OuterXml.Replace("</IdCliente><Cliente>", "</IdCliente><ClienteDescipcion>").Replace("</Cliente><FechaEntregaMin>", "</ClienteDescipcion><FechaEntregaMin>"));
      XmlNodeReader xmlNodeReader = new XmlNodeReader((XmlNode) xmlDocument);
      int num1 = (int) dataSet1.ReadXml((XmlReader) xmlNodeReader);
      if (dataSet1.Tables["Embarque"] == null)
        return;
      int num2 = 0;
      foreach (DataRow row in (InternalDataCollectionBase) dataSet1.Tables["Embarque"].Rows)
      {
        using (SqlCommand sqlCommand = new SqlCommand())
        {
          sqlCommand.Connection = getConnection;
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.CommandText = "sp_sl_Pilgrims_Embarque";
          sqlCommand.Parameters.AddWithValue("@ruta", (object) row["Ruta"].ToString());
          sqlCommand.Parameters.AddWithValue("@origen", (object) row["Origen"].ToString());
          sqlCommand.Parameters.AddWithValue("@destino", (object) row["Destino"].ToString());
          sqlCommand.Parameters.AddWithValue("@tipoUnidad", (object) row["TipoUnidad"].ToString());
          sqlCommand.Parameters.AddWithValue("@proveedor", (object) row["Proveedor"].ToString());
          sqlCommand.Parameters.AddWithValue("@plantaPago", (object) row["PlantaPago"].ToString());
          sqlCommand.Parameters.AddWithValue("@fecha", (object) row["Fecha"].ToString());
          sqlCommand.Parameters.AddWithValue("@comentarios", (object) row["Comentarios"].ToString());
          sqlCommand.Parameters.AddWithValue("@remolque", (object) row["Remolque1"].ToString());
          sqlCommand.Parameters.AddWithValue("@tipoViaje", (object) row["TipoViaje"].ToString());
          sqlCommand.Parameters.AddWithValue("@peso", (object) row["Peso"].ToString());
          sqlCommand.Parameters.AddWithValue("@unidadPiezas", (object) row["UnidadPiezas"].ToString());
          sqlCommand.Parameters.AddWithValue("@CantidadPiezas", (object) row["CantidadPiezas"].ToString());
          sqlCommand.Parameters.AddWithValue("@Tractor", (object) row["Tractor"].ToString());
          sqlCommand.Parameters.AddWithValue("@remolques", (object) row["Remolque2"].ToString());
          sqlCommand.Parameters.AddWithValue("@idEmbarque", (object) row["Embarque_Id"].ToString());
          sqlCommand.Parameters.AddWithValue("@rutaNombre", (object) row["RutaNombre"].ToString());
          sqlCommand.Parameters.AddWithValue("@distribuidor", (object) row["Distribuidor"].ToString());
          sqlCommand.Parameters.AddWithValue("@idOrigen", (object) row["IdOrigen"].ToString());
          sqlCommand.Parameters.AddWithValue("@idDestino", (object) row["IdDestino"].ToString());
          sqlCommand.Parameters.AddWithValue("@dolly", (object) row["Dolly"].ToString());
          sqlCommand.Parameters.AddWithValue("@sellos", (object) row["Sellos"].ToString());
          sqlCommand.Parameters.AddWithValue("@operador", (object) row["Operador"].ToString());
          sqlCommand.Parameters.AddWithValue("@sellos2", (object) row["Sellos2"].ToString());
          sqlCommand.Parameters.AddWithValue("@valePlastico", (object) row["ValePlastico"].ToString());
          sqlCommand.Parameters.AddWithValue("@flejePlastico", (object) row["FlejePlastico"].ToString());
          sqlCommand.Parameters.AddWithValue("@valePlastico2", (object) row["ValePlastico2"].ToString());
          sqlCommand.Parameters.AddWithValue("@flejePlastico2", (object) row["FlejePlastico2"].ToString());
          sqlCommand.Parameters.AddWithValue("@accion", (object) num2);
          ++num2;
          try
          {
            getConnection.Open();
            sqlCommand.ExecuteNonQuery();
          }
          catch (SqlException ex)
          {
            string message = ex.Message;
          }
          finally
          {
            getConnection.Close();
          }
        }
      }
      foreach (DataRow row in (InternalDataCollectionBase) dataSet1.Tables["Cliente"].Rows)
      {
        using (SqlCommand sqlCommand = new SqlCommand())
        {
          sqlCommand.Connection = getConnection;
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.CommandText = "sp_sl_Pilgrims_Cliente";
          sqlCommand.Parameters.AddWithValue("@idClient", (object) row[0].ToString());
          sqlCommand.Parameters.AddWithValue("@clienteDescripcion", (object) row[1].ToString());
          sqlCommand.Parameters.AddWithValue("@fechaEntregaMin", (object) row[2].ToString());
          sqlCommand.Parameters.AddWithValue("@fechaEntregaMax", (object) row[3].ToString());
          sqlCommand.Parameters.AddWithValue("@client_Id", (object) Convert.ToInt32(row[4].ToString()));
          sqlCommand.Parameters.AddWithValue("@embarque_id", (object) Convert.ToInt32(row[5].ToString()));
          sqlCommand.Parameters.AddWithValue("@accion", (object) 1);
          try
          {
            getConnection.Open();
            sqlCommand.ExecuteNonQuery();
          }
          catch (SqlException ex)
          {
            string message = ex.Message;
          }
          finally
          {
            getConnection.Close();
          }
        }
      }
      foreach (DataRow row in (InternalDataCollectionBase) dataSet1.Tables["Pedido"].Rows)
      {
        using (SqlCommand sqlCommand = new SqlCommand())
        {
          if (row[4].ToString() != "")
          {
            sqlCommand.Connection = getConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_sl_Pilgrims_Pedido";
            sqlCommand.Parameters.AddWithValue("@pedido_Id", (object) Convert.ToInt32(row["Pedido_Id"].ToString()));
            sqlCommand.Parameters.AddWithValue("@entrega", (object) row["Entrega"].ToString());
            sqlCommand.Parameters.AddWithValue("@factura", (object) row["Factura"].ToString());
            sqlCommand.Parameters.AddWithValue("@client_Id", (object) Convert.ToInt32(row["Cliente_Id"].ToString()));
            sqlCommand.Parameters.AddWithValue("@secuencia", (object) Convert.ToInt32(row["Secuencia"].ToString()));
            sqlCommand.Parameters.AddWithValue("@lugarEntrega", (object) Convert.ToInt32(row["LugarEntrega"].ToString()));
            sqlCommand.Parameters.AddWithValue("@domicilio", (object) row["Domicilio"].ToString());
            sqlCommand.Parameters.AddWithValue("@cP", (object) row["CP"].ToString());
            sqlCommand.Parameters.AddWithValue("@ciudad", (object) row["Ciudad"].ToString());
            sqlCommand.Parameters.AddWithValue("@estado", (object) row["Estado"].ToString());
            sqlCommand.Parameters.AddWithValue("@pais", (object) row["Pais"].ToString());
            sqlCommand.Parameters.AddWithValue("@destino", (object) Convert.ToInt32(row["Destino"].ToString()));
            sqlCommand.Parameters.AddWithValue("@caja", (object) Convert.ToInt32(row["Caja"].ToString()));
            sqlCommand.Parameters.AddWithValue("@accion", (object) 1);
            try
            {
              getConnection.Open();
              sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
              string message = ex.Message;
            }
            finally
            {
              getConnection.Close();
            }
          }
        }
      }
      using (SqlCommand sqlCommand = new SqlCommand())
      {
        sqlCommand.Connection = getConnection;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "sp_sl_Pilgrims_Detalle";
        sqlCommand.Parameters.AddWithValue("@myTableType", (object) dataSet1.Tables["Detalle"]);
        sqlCommand.Parameters.AddWithValue("@accion", (object) 1);
        try
        {
          getConnection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
          string message = ex.Message;
        }
        finally
        {
          getConnection.Close();
        }
      }
      using (SqlCommand sqlCommand = new SqlCommand())
      {
        sqlCommand.Connection = getConnection;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "sp_sl_Pilgrims_Rutas";
        sqlCommand.Parameters.AddWithValue("@accion", (object) 1);
        try
        {
          getConnection.Open();
          sqlCommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
          string message = ex.Message;
        }
        finally
        {
          getConnection.Close();
        }
      }
      using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
      {
        try
        {
          sqlDataAdapter.SelectCommand = new SqlCommand("sp_sl_Pilgrims_CatalogoClientes", getConnection);
          sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
          sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object) 1);
          sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ruta", (object) "");
          DataSet dataSet3 = new DataSet();
          sqlDataAdapter.Fill(dataSet3, "result_name");
          this.crearOrden(dataSet3.Tables["result_name"]);
        }
        catch (SqlException ex)
        {
          string message = ex.Message;
        }
        finally
        {
          getConnection.Close();
        }
      }
    }

    protected DataSet cargarStops(string ruta)
    {
      SqlConnection getConnection = new dbConnector().GetConnection;
      DataSet dataSet;
      using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
      {
        sqlDataAdapter.SelectCommand = new SqlCommand("sp_sl_Pilgrims_CatalogoClientes", getConnection);
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object) 2);
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ruta", (object) ruta);
        dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet, "result_name");
      }
      return dataSet;
    }

    public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
    {
      for (DateTime day = from.Date; day.Date <= thru.Date; day = day.AddDays(1.0))
        yield return day;
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
      foreach (DateTime dateTime in this.EachDay(this.dateTimePicker1.Value, this.dateTimePicker2.Value))
      {
        this.cargar_dia(dateTime.ToString("yyyy/MM/dd"));
        this.lblResult.Visible = true;
      }
    }

    private void crearOrden(System.Data.DataTable datosOrden)
    {
      foreach (DataRow row1 in (InternalDataCollectionBase) datosOrden.Rows)
      {
        string ruta = row1["ruta"].ToString();
        string str1 = row1["origenTMW"].ToString();
        row1["origen"].ToString();
        string str2 = row1["Remolque1"].ToString();
        string str3 = row1["Remolque2"].ToString();
        string str4 = row1["Operador"].ToString();
        string str5 = row1["Tractor"].ToString();
        string str6 = row1["Dolly"].ToString();
        string str7 = row1["idBitacora"].ToString();
        string str8 = "SEN";
        if (str3 != "")
          str8 = "FULL";
        DateTime dateTime1 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString());
        DateTime dateTime2 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString()).AddHours(0.084);
        string str9 = str6;
        string str10 = "HPL";
        row1[8].ToString();
        row1[9].ToString();
        DateTime dateTime3 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString());
        DateTime dateTime4 = dateTime3.AddHours(Convert.ToDouble(row1[15].ToString()));
        dateTime3 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString());
        DateTime dateTime5 = dateTime3.AddHours(Convert.ToDouble(row1[15].ToString()) + 0.084);
        string str11 = "LUL";
        string str12 = row1[0].ToString();
        row1[3].ToString();
        dateTime3 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString());
        dateTime3 = dateTime3.AddHours(Convert.ToDouble(row1[15].ToString()));
        DateTime dateTime6 = dateTime3.AddHours(2.0);
        dateTime3 = Convert.ToDateTime(row1["FechaEntregaMin"].ToString());
        dateTime3 = dateTime3.AddHours(Convert.ToDouble(row1[15].ToString()) + 0.084);
        DateTime dateTime7 = dateTime3.AddHours(2.0);
        string str13 = "IDMT";
        int int16 = (int) Convert.ToInt16(row1[20].ToString());
        Decimal num = Convert.ToDecimal(row1[21].ToString());
        if (num > new Decimal(1000))
          num /= new Decimal(1000);
        else if (num > new Decimal(100))
          num /= new Decimal(100);
        DispatchHorizon dispatch = new DispatchHorizon();
        Move move = new Move();
        move.Legs = new List<Leg>()
        {
          new Leg()
          {
            lgh_number = -1,
            Driver1 = str4,
            Tractor = str5,
            lgh_type1 = str8
          }
        };
        move.Stops = new List<Stop>();
        List<Stop> stops1 = move.Stops;
        Stop stop1 = new Stop();
        stop1.ord_hdrnumber = new int?(-1);
        stop1.lgh_number = new int?(-1);
        stop1.ArrivalDate = dateTime1;
        stop1.DepartureDate = dateTime2;
        stop1.EarliestDate = dateTime1;
        stop1.LatestDate = dateTime2;
        stop1.Trailer1 = str2;
        stop1.Trailer2 = str3;
        stop1.Location = new Location() { Id = str1 };
        stop1.Event = str10;
        stops1.Add(stop1);
        DataSet dataSet = this.cargarStops(ruta);
        string str14 = "";
        foreach (DataRow row2 in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
        {
          if (str14 != row2["Secuencia"].ToString())
          {
            Stop stop2 = new Stop();
            stop2.ord_hdrnumber = new int?(-1);
            stop2.lgh_number = new int?(-1);
            stop2.ArrivalDate = dateTime4;
            stop2.DepartureDate = dateTime5;
            stop2.EarliestDate = dateTime4;
            stop2.LatestDate = dateTime5;
            stop2.Trailer1 = str2;
            stop2.Trailer2 = str3;
            stop2.Location = new Location()
            {
              Id = row2["compania_tmw"].ToString()
            };
            stop2.Event = str11;
            List<Freight> freightList = new List<Freight>();
            Freight freight = new Freight();
            freight.cmd_code = "ALIMENTO";
            freight.Count = (double) int16;
            freight.Weight = Math.Round(Convert.ToDouble(Convert.ToDouble(num)), 0);
            freight.WeightUnit = "TON";
            freightList.Add(freight);
            stop2.Freight = freightList;
            Stop stop3 = stop2;
            move.Stops.Add(stop3);
          }
          str14 = row2["Secuencia"].ToString();
        }
        List<Stop> stops2 = move.Stops;
        Stop stop4 = new Stop();
        stop4.ord_hdrnumber = new int?(-1);
        stop4.lgh_number = new int?(-1);
        stop4.ArrivalDate = dateTime6;
        stop4.DepartureDate = dateTime7;
        stop4.Trailer1 = str2;
        stop4.Trailer2 = str3;
        stop4.EarliestDate = dateTime6;
        stop4.LatestDate = dateTime7;
        stop4.Location = new Location() { Id = str12 };
        stop4.Event = str13;
        stops2.Add(stop4);
        dispatch.Moves = new List<Move>() { move };
        DispatchHorizon dispatchHorizon = dispatch;
        List<Order> orderList1 = new List<Order>();
        List<Order> orderList2 = orderList1;
        Order order1 = new Order();
        order1.BillTo = "PILGRIMS";
        order1.BookedDate = DateTime.Now;
        order1.ord_hdrnumber = -1;
        order1.ReferenceNumbers = ((IEnumerable<ReferenceNumber>) new ReferenceNumber[2]
        {
          new ReferenceNumber() { RefType = "SID", RefNumber = ruta },
          new ReferenceNumber() { RefType = "LPID", RefNumber = str7 }
        }).ToList<ReferenceNumber>();
        order1.RevType1 = "CORP";
        order1.RevType2 = "QRO";
        order1.RevType3 = "PIL";
        order1.RevType4 = "DED";
        Order order2 = order1;
        orderList2.Add(order2);
        List<Order> orderList3 = orderList1;
        dispatchHorizon.Orders = orderList3;
        try
        {
          if (str4 != "")
          {
            int movNumber = new DispatchHorizonServiceClient().SaveDispatchHandleExceptions(dispatch).Moves[0].mov_number;
            if (str6 != "")
            {
              SqlConnection getConnection = new dbConnector().GetConnection;
              using (SqlCommand sqlCommand = new SqlCommand())
              {
                sqlCommand.Connection = getConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_sl_Pilgrims_ComplementoDatos";
                sqlCommand.Parameters.AddWithValue("@ConjuntoDatos", (object) "updateDolly");
                sqlCommand.Parameters.AddWithValue("@dato", (object) str9);
                sqlCommand.Parameters.AddWithValue("@IdCampo", (object) movNumber.ToString());
                try
                {
                  getConnection.Open();
                  sqlCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                  string message = ex.Message;
                }
                finally
                {
                  getConnection.Close();
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
          string message = ex.Message;
        }
      }
    }

    private void exportar_a_Excel(System.Data.DataTable dttable)
    {
      Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
      _Workbook workbook = (_Workbook) application.Workbooks.Open("D:\\Salida\\pilgrims.xls", System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing);
      _Worksheet activeSheet = (_Worksheet) workbook.ActiveSheet;
      activeSheet.Unprotect((object) "tdrjr");
      if (this.limpiar == 0)
      {
        for (int index1 = 2; index1 <= 80; ++index1)
        {
          for (int index2 = 1; index2 <= 40; ++index2)
            activeSheet.Cells[(object) index1, (object) index2] = (object) "";
          this.limpiar = 1;
        }
      }
      int num = 2;
      foreach (DataRow row in (InternalDataCollectionBase) dttable.Rows)
      {
        activeSheet.Cells[(object) num, (object) 3] = (object) row[2].ToString();
        activeSheet.Cells[(object) num, (object) 8] = (object) row[0].ToString();
        activeSheet.Cells[(object) num, (object) 9] = (object) row[3].ToString();
        activeSheet.Cells[(object) num, (object) 10] = (object) Convert.ToDateTime(row[5].ToString() + " " + row[13].ToString());
        Microsoft.Office.Interop.Excel.Range cells1 = activeSheet.Cells;
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (System.ValueType) num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (System.ValueType) 11;
        DateTime dateTime = Convert.ToDateTime(row[5].ToString() + " " + row[13].ToString());
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (System.ValueType) dateTime.AddHours(0.084);
        cells1[(object) local1, (object) local2] = (object) local3;
        activeSheet.Cells[(object) num, (object) 12] = (object) "UNKNOWN";
        activeSheet.Cells[(object) num, (object) 13] = (object) "CARGA";
        activeSheet.Cells[(object) num, (object) 17] = (object) row[8].ToString();
        activeSheet.Cells[(object) num, (object) 18] = (object) row[9].ToString();
        Microsoft.Office.Interop.Excel.Range cells2 = activeSheet.Cells;
        // ISSUE: variable of a boxed type
        __Boxed<int> local4 = (System.ValueType) num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local5 = (System.ValueType) 20;
        dateTime = Convert.ToDateTime(row[5].ToString() + "T" + row[13].ToString());
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local6 = (System.ValueType) dateTime.AddHours(Convert.ToDouble(row[15].ToString()));
        cells2[(object) local4, (object) local5] = (object) local6;
        Microsoft.Office.Interop.Excel.Range cells3 = activeSheet.Cells;
        // ISSUE: variable of a boxed type
        __Boxed<int> local7 = (System.ValueType) num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local8 = (System.ValueType) 21;
        dateTime = Convert.ToDateTime(row[5].ToString() + "T" + row[13].ToString());
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local9 = (System.ValueType) dateTime.AddHours(Convert.ToDouble(row[15].ToString()) + 0.084);
        cells3[(object) local7, (object) local8] = (object) local9;
        activeSheet.Cells[(object) num, (object) 22] = (object) "UNKNOWN";
        activeSheet.Cells[(object) num, (object) 23] = (object) "DESCARGA";
        activeSheet.Cells[(object) num, (object) 27] = (object) row[0].ToString();
        activeSheet.Cells[(object) num, (object) 28] = (object) row[3].ToString();
        Microsoft.Office.Interop.Excel.Range cells4 = activeSheet.Cells;
        // ISSUE: variable of a boxed type
        __Boxed<int> local10 = (System.ValueType) num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local11 = (System.ValueType) 30;
        dateTime = Convert.ToDateTime(row[5].ToString() + "T" + row[13].ToString());
        dateTime = dateTime.AddHours(Convert.ToDouble(row[15].ToString()));
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local12 = (System.ValueType) dateTime.AddHours(2.0);
        cells4[(object) local10, (object) local11] = (object) local12;
        Microsoft.Office.Interop.Excel.Range cells5 = activeSheet.Cells;
        // ISSUE: variable of a boxed type
        __Boxed<int> local13 = (System.ValueType) num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local14 = (System.ValueType) 31;
        dateTime = Convert.ToDateTime(row[5].ToString() + "T" + row[13].ToString());
        dateTime = dateTime.AddHours(Convert.ToDouble(row[15].ToString()) + 0.084);
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local15 = (System.ValueType) dateTime.AddHours(2.0);
        cells5[(object) local13, (object) local14] = (object) local15;
        activeSheet.Cells[(object) num, (object) 33] = (object) "TERMINA VACIO";
        ++num;
      }
      application.Visible = false;
      application.UserControl = true;
      workbook.Save();
      application.ActiveWorkbook.Close((object) true, (object) workbook, System.Type.Missing);
      application.Quit();
      int idProcces = this.iGetIDProcces("EXCEL");
      if (idProcces != -1)
        Process.GetProcessById(idProcces).Kill();
      string path2 = "pilgrims.xls";
      string path1 = "D:\\Salida";
      string str = "D:\\FTP\\DX";
      string sourceFileName = Path.Combine(path1, path2);
      string destFileName = Path.Combine(str, path2);
      if (!Directory.Exists(str))
        Directory.CreateDirectory(str);
      File.Copy(sourceFileName, destFileName, true);
    }

    private int iGetIDProcces(string nameProcces)
    {
      try
      {
        foreach (Process process in Process.GetProcessesByName(nameProcces))
        {
          if (process.MainWindowTitle == "")
            return process.Id;
        }
        return -1;
      }
      catch (Exception ex)
      {
        return -1;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnCargar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dateTimePicker2 = new DateTimePicker();
      this.dateTimePicker1 = new DateTimePicker();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.lblResult);
      this.groupBox1.Controls.Add((Control) this.btnCargar);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.dateTimePicker2);
      this.groupBox1.Controls.Add((Control) this.dateTimePicker1);
      this.groupBox1.Location = new System.Drawing.Point(12, 46);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(1050, 332);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Carga Ordenes Pilgrims";
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblResult.Location = new System.Drawing.Point(209, 226);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new Size(153, 29);
      this.lblResult.TabIndex = 5;
      this.lblResult.Text = "Carga Lista";
      this.lblResult.Visible = false;
      this.btnCargar.Location = new System.Drawing.Point(306, 91);
      this.btnCargar.Name = "btnCargar";
      this.btnCargar.Size = new Size(87, 30);
      this.btnCargar.TabIndex = 4;
      this.btnCargar.Text = "Cargar";
      this.btnCargar.UseVisualStyleBackColor = true;
      this.btnCargar.Click += new EventHandler(this.btnCargar_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new System.Drawing.Point(32, 109);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Hasta";
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new System.Drawing.Point(32, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(47, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Desde:";
      this.dateTimePicker2.Location = new System.Drawing.Point(36, 145);
      this.dateTimePicker2.Name = "dateTimePicker2";
      this.dateTimePicker2.Size = new Size(208, 20);
      this.dateTimePicker2.TabIndex = 1;
      this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
      this.dateTimePicker1.Location = new System.Drawing.Point(36, 77);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(208, 20);
      this.dateTimePicker1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1074, 390);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
