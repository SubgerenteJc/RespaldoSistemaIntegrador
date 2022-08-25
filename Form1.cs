// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.Form1
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;

using WindowsFormsApp1.mx.com.pilgrims.wslogistica;
using WindowsFormsApp1.TmwDispatchHorizonSvc;
using DataTable = System.Data.DataTable;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections;


namespace WindowsFormsApp1
{
    public class Form1 : Form
    {
        private int limpiar = 0;
        private IContainer components = (IContainer)null;
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
                Leer_Cliente("SAYER");
                //Leer_Cliente("WALMART");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            this.Close();
        }
        private void Leer_Cliente(string cliente)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(@"\\10.223.208.41\Users\Administrator\Documents\" + cliente);
                FileInfo[] files = di.GetFiles("*.xml");
                int cantidad = files.Length;
                foreach (FileInfo file in files)
                {
                    var ultimo_archivo = file;
                    string datestring = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string aname = datestring + "-" + ultimo_archivo.Name;
                    string farchivo = ultimo_archivo + datestring;
                    string sourceFile = @"\\10.223.208.41\Users\Administrator\Documents\" + cliente + @"\" + ultimo_archivo;
                    string destinationFile = @"\\10.223.208.41\inetpub\wwwroot\SWUpload\Uploads\" + datestring + "-" + ultimo_archivo;
                    System.IO.File.Move(sourceFile, destinationFile);
                    DirectoryInfo dis = new DirectoryInfo(@"\\10.223.208.41\inetpub\wwwroot\SWUpload\Uploads");
                    FileInfo[] filess = dis.GetFiles("*.xml");
                    var lasts = filess.Last();
                    cargarEnSQL(aname, cliente);
                }
                int cargarEnSQL(string narchivo, string usuario)
                {
                    int resultado = 0;
                    try
                    {
                        //NOS CONECTAMOS CON LA BASE DE DATOS
                        SqlConnection getConnection = new dbConnector().GetConnection;
                        using (SqlConnection cn = new SqlConnection())
                        {
                            SqlCommand cmd = new SqlCommand("usp_xml", getConnection);
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@narchivo", narchivo);
                            cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                            cmd.CommandType = CommandType.StoredProcedure;

                            getConnection.Open();
                            cmd.ExecuteNonQuery();
                            resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        string mensaje = ex.Message.ToString();
                        resultado = 0;
                    }
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            this.cargar_dia(DateTime.Now.ToString("yyyy/MM/dd"), cliente);
        }
        private void cargar_dia(string fecha, string Cliente)
        {

            SqlConnection getConnection = new dbConnector().GetConnection;
            //variables de archivo a leer
            String Archivo = "";
            String RutaArchivos = @"\\10.223.208.41\inetpub\wwwroot\SWUpload\Uploads\";
            int num2 = 0;
            //Leer archivos desde el SQL con la fecha del día

            //Declarar variabbles de viaje
            String Fecha = "", Transporte = "", Operador = "", Remolque = "", Remolque2 = "", Dolly = "", Origen = "", Origen_Descripcion = "", Destino = "", Destino_Descripcion = "", Kilometros_Totales = "";
            if (Cliente == "SAYER")
            {
                DataSet ArchivosSubidos = LeerCargaArchivos(fecha, 1,Cliente);
                foreach (DataRow rowArchivos in (InternalDataCollectionBase)ArchivosSubidos.Tables[0].Rows)
                {
                    Archivo = rowArchivos["narchivo"].ToString();
                    //construir ruta archivo
                    string sourceFileName = Path.Combine(RutaArchivos, Archivo);
                    //leer archivo fisico en ruta
                    XmlDocument doc = new XmlDocument();
                    doc.Load(sourceFileName);

                    DataSet dataSet1 = new DataSet();
                    XmlTextReader xtr = new XmlTextReader(doc.OuterXml, XmlNodeType.Element, null);
                    dataSet1.ReadXml(xtr);
                    if (dataSet1.Tables["Viaje"] == null)
                        return;
                    num2 = 0;


                    foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["Viaje"].Rows)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Embarque";
                            sqlCommand.Parameters.AddWithValue("@ruta", Convert.ToInt32((object)row["Transporte"].ToString())).ToString();
                            sqlCommand.Parameters.AddWithValue("@origen", (object)row["Origen"].ToString());
                            sqlCommand.Parameters.AddWithValue("@destino", (object)row["Destino"].ToString());
                            sqlCommand.Parameters.AddWithValue("@tipoUnidad", "");
                            sqlCommand.Parameters.AddWithValue("@proveedor", "");
                            sqlCommand.Parameters.AddWithValue("@plantaPago", "");
                            sqlCommand.Parameters.AddWithValue("@fecha", (object)row["Fecha"].ToString());
                            sqlCommand.Parameters.AddWithValue("@comentarios", "");
                            sqlCommand.Parameters.AddWithValue("@remolque", (object)row["Remolque"].ToString());
                            sqlCommand.Parameters.AddWithValue("@tipoViaje", (object)row["Kilometros_Totales"].ToString());
                            sqlCommand.Parameters.AddWithValue("@peso", "25.0");
                            sqlCommand.Parameters.AddWithValue("@unidadPiezas", "");
                            sqlCommand.Parameters.AddWithValue("@CantidadPiezas", "");
                            sqlCommand.Parameters.AddWithValue("@Tractor", "");
                            sqlCommand.Parameters.AddWithValue("@remolques", (object)row["Remolque2"].ToString());
                            sqlCommand.Parameters.AddWithValue("@idEmbarque", (object)row["Viaje_Id"].ToString());
                            sqlCommand.Parameters.AddWithValue("@rutaNombre", "");
                            sqlCommand.Parameters.AddWithValue("@distribuidor", "");
                            sqlCommand.Parameters.AddWithValue("@idOrigen", (object)row["Origen"].ToString());
                            sqlCommand.Parameters.AddWithValue("@idDestino", (object)row["Destino"].ToString());
                            sqlCommand.Parameters.AddWithValue("@dolly", (object)row["Dolly"].ToString());
                            sqlCommand.Parameters.AddWithValue("@sellos", "");
                            //sqlCommand.Parameters.AddWithValue("@operador", (object)row["Operador"].ToString());
                            sqlCommand.Parameters.AddWithValue("@operador", (object)row["Operador"].ToString());
                            sqlCommand.Parameters.AddWithValue("@sellos2", "");
                            sqlCommand.Parameters.AddWithValue("@valePlastico", "");
                            sqlCommand.Parameters.AddWithValue("@flejePlastico", "");
                            sqlCommand.Parameters.AddWithValue("@valePlastico2", "");
                            sqlCommand.Parameters.AddWithValue("@flejePlastico2", "");
                            sqlCommand.Parameters.AddWithValue("@accion", (object)num2);
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
                    foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["Ruta"].Rows)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Cliente";
                            sqlCommand.Parameters.AddWithValue("@idClient", (object)row["Destino"].ToString());
                            sqlCommand.Parameters.AddWithValue("@clienteDescripcion", (object)row["Destino_Descripcion"].ToString());
                            //TODO: buscar las fechas vengan desde el xml
                            sqlCommand.Parameters.AddWithValue("@fechaEntregaMin", DateTime.Now.AddMinutes(60).ToString());
                            sqlCommand.Parameters.AddWithValue("@fechaEntregaMax", DateTime.Now.AddMinutes(61).ToString());
                            if (row[7].ToString() != "")
                            {
                                string ruta = row["Ruta_Id"].ToString();
                                sqlCommand.Parameters.AddWithValue("@client_Id", (object)Convert.ToInt32(row["Ruta_Id"].ToString()));
                            }
                            else
                            {
                                sqlCommand.Parameters.AddWithValue("@client_Id", "0");
                            }
                            sqlCommand.Parameters.AddWithValue("@embarque_id", (object)Convert.ToInt32(row["Rutas_Id"].ToString()));
                            sqlCommand.Parameters.AddWithValue("@distancia", (object)Convert.ToDecimal(row["DISTANCIA"].ToString()));
                            sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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
                    if (dataSet1.Tables.Count > 3)
                    {
                        foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["Mercancias"].Rows)
                        {
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {

                                sqlCommand.Connection = getConnection;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.CommandText = "sp_sl_Pilgrims_Pedido";
                                sqlCommand.Parameters.AddWithValue("@pedido_Id", (object)Convert.ToInt32(row["Mercancias_Id"].ToString()));
                                sqlCommand.Parameters.AddWithValue("@entrega", "");
                                sqlCommand.Parameters.AddWithValue("@factura", "");
                                sqlCommand.Parameters.AddWithValue("@client_Id", (object)Convert.ToInt32(row["Ruta_Id"].ToString()));
                                sqlCommand.Parameters.AddWithValue("@secuencia", "");
                                sqlCommand.Parameters.AddWithValue("@lugarEntrega", "");
                                sqlCommand.Parameters.AddWithValue("@domicilio", "");
                                sqlCommand.Parameters.AddWithValue("@cP", "");
                                sqlCommand.Parameters.AddWithValue("@ciudad", "");
                                sqlCommand.Parameters.AddWithValue("@estado", "");
                                sqlCommand.Parameters.AddWithValue("@pais", "");
                                sqlCommand.Parameters.AddWithValue("@destino", "");
                                sqlCommand.Parameters.AddWithValue("@caja", "");
                                sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Detalle";
                            sqlCommand.Parameters.AddWithValue("@myTableType", (object)dataSet1.Tables["Mercancia"]);
                            sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlDataAdapter.SelectCommand = new SqlCommand("sp_sl_Pilgrims_Rutas", getConnection);
                            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)1);

                            DataSet dataSet3 = new DataSet();
                            sqlDataAdapter.Fill(dataSet3, "result_name");

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
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)1);
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ruta", (object)"");
                            DataSet dataSet3 = new DataSet();
                            sqlDataAdapter.Fill(dataSet3, "result_name");
                            this.crearOrden(dataSet3.Tables["result_name"], Archivo, Cliente);
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
            else if (Cliente == "WALMART")
            {
                DataSet ArchivosSubidos = LeerCargaArchivos(fecha, 1,Cliente);
                foreach (DataRow rowArchivos in (InternalDataCollectionBase)ArchivosSubidos.Tables[0].Rows)
                {
                    Archivo = rowArchivos["narchivo"].ToString();
                    //construir ruta archivo
                    string sourceFileName = Path.Combine(RutaArchivos, Archivo);
                    //leer archivo fisico en ruta
                    XmlDocument doc = new XmlDocument();
                    doc.Load(sourceFileName);

                    DataSet dataSet1 = new DataSet();
                    XmlTextReader xtr = new XmlTextReader(doc.OuterXml, XmlNodeType.Element, null);
                    dataSet1.ReadXml(xtr);
                    if (dataSet1.Tables["CartaPorte"] == null)
                        return;
                    num2 = 0;


                    foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["CartaPorte"].Rows)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Embarque";
                            sqlCommand.Parameters.AddWithValue("@ruta", Convert.ToInt32((object)row["ID_Carga_WTMS"].ToString())).ToString();
                            sqlCommand.Parameters.AddWithValue("@origen", dataSet1.Tables["Traslado"].Rows[0].ItemArray[3].ToString());
                            sqlCommand.Parameters.AddWithValue("@destino", dataSet1.Tables["Traslado"].Rows[0].ItemArray[1].ToString());
                            sqlCommand.Parameters.AddWithValue("@tipoUnidad", "");
                            sqlCommand.Parameters.AddWithValue("@proveedor", "");
                            sqlCommand.Parameters.AddWithValue("@plantaPago", "");
                            sqlCommand.Parameters.AddWithValue("@fecha", (object)row["FechaCargaOrigen"].ToString().Replace("T", " "));
                            sqlCommand.Parameters.AddWithValue("@comentarios", "");
                            sqlCommand.Parameters.AddWithValue("@remolque", dataSet1.Tables["Remolque"].Rows[0].ItemArray[0].ToString());
                            sqlCommand.Parameters.AddWithValue("@tipoViaje", "");
                            sqlCommand.Parameters.AddWithValue("@peso", "25.0");
                            sqlCommand.Parameters.AddWithValue("@unidadPiezas", "");
                            sqlCommand.Parameters.AddWithValue("@CantidadPiezas", "");
                            sqlCommand.Parameters.AddWithValue("@Tractor", "");
                            sqlCommand.Parameters.AddWithValue("@remolques", "");
                            sqlCommand.Parameters.AddWithValue("@idEmbarque", (object)row["CartaPorte_Id"].ToString());
                            sqlCommand.Parameters.AddWithValue("@rutaNombre", "");
                            sqlCommand.Parameters.AddWithValue("@distribuidor", "");
                            sqlCommand.Parameters.AddWithValue("@idOrigen", dataSet1.Tables["Traslado"].Rows[0].ItemArray[3].ToString());
                            sqlCommand.Parameters.AddWithValue("@idDestino", dataSet1.Tables["Traslado"].Rows[0].ItemArray[1].ToString());
                            sqlCommand.Parameters.AddWithValue("@dolly", "");
                            sqlCommand.Parameters.AddWithValue("@sellos", "");
                            //sqlCommand.Parameters.AddWithValue("@operador", (object)row["Operador"].ToString());
                            sqlCommand.Parameters.AddWithValue("@operador", "");
                            sqlCommand.Parameters.AddWithValue("@sellos2", "");
                            sqlCommand.Parameters.AddWithValue("@valePlastico", "");
                            sqlCommand.Parameters.AddWithValue("@flejePlastico", "");
                            sqlCommand.Parameters.AddWithValue("@valePlastico2", "");
                            sqlCommand.Parameters.AddWithValue("@flejePlastico2", "");
                            sqlCommand.Parameters.AddWithValue("@accion", (object)num2);
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
                    foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["Traslado"].Rows)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Cliente";
                            sqlCommand.Parameters.AddWithValue("@idClient", (object)row["IDDestino"].ToString());
                            sqlCommand.Parameters.AddWithValue("@clienteDescripcion", (object)row["IDDestino"].ToString());
                            //TODO: buscar las fechas vengan desde el xml
                            sqlCommand.Parameters.AddWithValue("@fechaEntregaMin", dataSet1.Tables["CartaPorte"].Rows[0].ItemArray[6].ToString().Replace("T"," "));
                            sqlCommand.Parameters.AddWithValue("@fechaEntregaMax", dataSet1.Tables["CartaPorte"].Rows[0].ItemArray[6].ToString().Replace("T", " "));
                            
                            sqlCommand.Parameters.AddWithValue("@client_Id", (object)Convert.ToInt32(row["Traslado_Id"].ToString()));
                            
                            sqlCommand.Parameters.AddWithValue("@embarque_id", (object)Convert.ToInt32(row["Traslados_Id"].ToString()));
                            sqlCommand.Parameters.AddWithValue("@distancia", (object)Convert.ToDecimal(row["DistanciaRecorrida"].ToString()));
                            sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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
                    if (dataSet1.Tables.Count > 3)
                    {
                        foreach (DataRow row in (InternalDataCollectionBase)dataSet1.Tables["Mercancias"].Rows)
                        {
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {

                                sqlCommand.Connection = getConnection;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.CommandText = "sp_sl_Pilgrims_Pedido";
                                sqlCommand.Parameters.AddWithValue("@pedido_Id", (object)Convert.ToInt32(row["Mercancias_Id"].ToString()));
                                sqlCommand.Parameters.AddWithValue("@entrega", "");
                                sqlCommand.Parameters.AddWithValue("@factura", "");
                                sqlCommand.Parameters.AddWithValue("@client_Id", (object)Convert.ToInt32(row["Traslado_Id"].ToString()));
                                sqlCommand.Parameters.AddWithValue("@secuencia", "");
                                sqlCommand.Parameters.AddWithValue("@lugarEntrega", "");
                                sqlCommand.Parameters.AddWithValue("@domicilio", "");
                                sqlCommand.Parameters.AddWithValue("@cP", "");
                                sqlCommand.Parameters.AddWithValue("@ciudad", "");
                                sqlCommand.Parameters.AddWithValue("@estado", "");
                                sqlCommand.Parameters.AddWithValue("@pais", "");
                                sqlCommand.Parameters.AddWithValue("@destino", "");
                                sqlCommand.Parameters.AddWithValue("@caja", "");
                                sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = getConnection;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.CommandText = "sp_sl_Pilgrims_Mercancia";
                            sqlCommand.Parameters.AddWithValue("@myTableType", (object)dataSet1.Tables["Mercancia"]);
                            sqlCommand.Parameters.AddWithValue("@accion", (object)1);
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

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlDataAdapter.SelectCommand = new SqlCommand("sp_sl_Pilgrims_Rutas", getConnection);
                            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)1);

                            DataSet dataSet3 = new DataSet();
                            sqlDataAdapter.Fill(dataSet3, "result_name");

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
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)1);
                            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ruta", (object)"");
                            DataSet dataSet3 = new DataSet();
                            sqlDataAdapter.Fill(dataSet3, "result_name");
                            this.crearOrden(dataSet3.Tables["result_name"], Archivo, Cliente);
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

        protected DataSet cargarStops(string ruta)
        {
            SqlConnection getConnection = new dbConnector().GetConnection;
            DataSet dataSet;
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = new SqlCommand("sp_sl_Pilgrims_CatalogoClientes", getConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)2);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ruta", (object)ruta);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "result_name");
            }
            return dataSet;
        }

        protected DataSet LeerCargaArchivos(String dato, int accion, String cliente)
        {
            SqlConnection getConnection = new dbConnector().GetConnection;
            DataSet dataSet;
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = new SqlCommand("sp_obtener_xml_integracion_cliente", getConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dato", (object)dato);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@accion", (object)accion);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cliente", (object)cliente);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Archivos");
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
                //this.cargar_dia(dateTime.ToString("yyyy/MM/dd"));
                this.lblResult.Visible = true;
            }
        }


        private void crearOrden(System.Data.DataTable datosOrden, String Archivo, String Cliente)
        {
            try
            {
                foreach (DataRow row1 in (InternalDataCollectionBase)datosOrden.Rows)
                {
                    string ruta = row1["ruta"].ToString();
                    string origenTMW = row1["origenTMW"].ToString();
                    string Remolque1 = row1["Remolque1"].ToString();
                    string Remolque2 = row1["Remolque2"].ToString();
                    string Operador = row1["Operador"].ToString();
                    string Tractor = row1["Tractor"].ToString();
                    string Dolly = row1["Dolly"].ToString();
                    string Distancia = row1["Distancia"].ToString();
                    string TipoViaje = "SEN";
                    if (Remolque2 != "")
                    {
                        TipoViaje = "FULL";
                    }
                    DateTime dateTime1 = Convert.ToDateTime(row1["Fecha"].ToString());
                    DateTime dateTime2 = Convert.ToDateTime(row1["Fecha"].ToString()).AddHours(0.084);
                    string str9 = Dolly;
                    string origenTMW0 = "HPL";


                    string origenTMW1 = "LUL";
                    string origenTMW2 = row1["compania_tmw"].ToString();


                   // DateTime dateTime6 = Convert.ToDateTime(row1["FechaEntregaMax"].ToString()).AddHours(Convert.ToDouble(Distancia) / 65);
                    //DateTime dateTime7 = Convert.ToDateTime(row1["FechaEntregaMax"].ToString()).AddHours(Convert.ToDouble(Distancia) / 65).AddHours(0.084);

                    string origenTMW3 = "IDMT";



                    //inicia SystemsLink
                    DispatchHorizon dispatch = new DispatchHorizon();
                    Move move = new Move();
                    if(Cliente== "SAYER")
                    { 
                        move.Legs = new List<Leg>()
                        {
                            new Leg()
                            {
                            lgh_number = -1,
                            Driver1 = Operador,
                            Tractor = Tractor,
                            lgh_type1 = TipoViaje
                            }
                        };
                    }
                    if(Cliente == "WALMART")
                    {
                        move.Legs = new List<Leg>()
                        {
                            new Leg()
                            {
                            lgh_number = -1,
                            Driver1 = "",
                            Tractor = Tractor,
                            lgh_type1 = TipoViaje
                            }
                        };
                    }
                    if (Tractor == "306" || Tractor == "307")
                    {
                        Remolque1 = "";
                        Remolque2 = "";
                    }
                    move.Stops = new List<Stop>();
                    //stop inicial
                    List<Stop> stops1 = move.Stops;
                    Stop stop1 = new Stop();
                    stop1.ord_hdrnumber = new int?(-1);
                    stop1.lgh_number = new int?(-1);
                    stop1.ArrivalDate = dateTime1;
                    stop1.DepartureDate = dateTime2.AddHours(2);
                    stop1.EarliestDate = dateTime1;
                    stop1.LatestDate = dateTime2.AddHours(2);
                    stop1.Trailer1 = Remolque1;
                    stop1.Trailer2 = Remolque2;
                    stop1.Location = new Location() { Id = origenTMW };
                    stop1.Event = origenTMW0;
                    stops1.Add(stop1);
                    DataSet dataSet = this.cargarStops(ruta);
                    string origenTMW4 = origenTMW;
                    //stops intermedios
                    DateTime dateTime4 = dateTime2.AddHours(2);
                    DateTime dateTime5 = dateTime4;
                    Order order1 = new Order();
                    int rutas = 1;
                    foreach (DataRow row2 in (InternalDataCollectionBase)dataSet.Tables[0].Rows)
                    {

                        dateTime4 = dateTime4.AddHours(Convert.ToDouble(row2["Distancia"].ToString()) / 65); //mas el calculo de la distancia
                        Stop stop2 = new Stop();
                        stop2.ord_hdrnumber = new int?(-1);
                        stop2.lgh_number = new int?(-1);
                        stop2.ArrivalDate = dateTime4;
                        dateTime5 = dateTime4.AddHours(2);
                        stop2.DepartureDate = dateTime5;
                        stop2.EarliestDate = dateTime4;
                        stop2.LatestDate = dateTime5;
                        dateTime4 = dateTime5;
                        stop2.Trailer1 = Remolque1;
                        stop2.Trailer2 = Remolque2;
                        stop2.Location = new Location()
                        {
                            Id = row2["CompaniaStop"].ToString()
                        };
                        if (rutas == dataSet.Tables[0].Rows.Count && row2["CargaTon"].ToString() == "" && rutas > 1)
                        {
                            stop2.Event = "IDMTNR";
                        }
                        else
                        {
                            stop2.Event = origenTMW1;
                        }
                        if (rutas == dataSet.Tables[0].Rows.Count && row2["CargaTon"].ToString() == "" && rutas == 1 && Tractor != "306" && Tractor != "307")
                        {
                            order1.FromOrder = "SAYER-VACIO";
                        }
                        Stop stop3 = stop2;
                        move.Stops.Add(stop3);
                        rutas++;
                    }
                    List<Stop> stops2 = move.Stops;
                    //stop final
                    dispatch.Moves = new List<Move>() { move };
                    DispatchHorizon dispatchHorizon = dispatch;
                    List<Order> orderList1 = new List<Order>();
                    List<Order> orderList2 = orderList1;

                    
                    
                    if (Tractor == "306" || Tractor == "307")
                    {
                        order1.BillTo = "SAYTORT";
                        order1.RevType1 = "QRO";
                        order1.FromOrder = "DEDI-THORTON";
                    }

                    if(Cliente == "SAYER") { 
                        order1.BillTo = "SAYER";
                        if (Remolque2 != "")
                        {
                            order1.BillTo = "SAYFUL";
                        }
                        order1.BookedDate = DateTime.Now;
                        order1.ord_hdrnumber = -1;
                        order1.ReferenceNumbers = ((IEnumerable<ReferenceNumber>)new ReferenceNumber[1]
                        {
                          new ReferenceNumber() { RefType = "TRN", RefNumber = ruta }
                        }).ToList<ReferenceNumber>();
                        order1.RevType1 = "QRO";
                        order1.RevType2 = "QRO";
                        order1.RevType3 = "SAY";
                        order1.RevType4 = "EC5";
                    }
                    if (Cliente == "WALMART")
                    {
                        order1.BillTo = "WALMART";
                        order1.BookedDate = DateTime.Now;
                        order1.ord_hdrnumber = -1;
                        order1.ReferenceNumbers = ((IEnumerable<ReferenceNumber>)new ReferenceNumber[1]
                        {
                          new ReferenceNumber() { RefType = "BL#", RefNumber = ruta }
                        }).ToList<ReferenceNumber>();
                        order1.RevType1 = "VVI";
                        order1.RevType2 = "VILLA";
                        order1.RevType3 = "ABI";
                        order1.RevType4 = "EC8";
                    }
                    Order order2 = order1;
                    orderList2.Add(order2);
                    List<Order> orderList3 = orderList1;
                    dispatchHorizon.Orders = orderList3;
                    try
                    {
                        if (order1.BillTo != "")
                        {

                            int movNumber = 0;

                            try
                            {
                                movNumber = new DispatchHorizonServiceClient().SaveDispatchHandleExceptions(dispatch).Moves[0].mov_number;

                            }
                            catch (SqlException ex)
                            {
                                string message = ex.Message;
                            }
                            if (Dolly != "" && movNumber != 0)
                            {
                                SqlConnection getConnection = new dbConnector().GetConnection;
                                using (SqlCommand sqlCommand = new SqlCommand())
                                {
                                    sqlCommand.Connection = getConnection;
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.CommandText = "sp_sl_Pilgrims_ComplementoDatos";
                                    sqlCommand.Parameters.AddWithValue("@ConjuntoDatos", (object)"updateDolly");
                                    sqlCommand.Parameters.AddWithValue("@dato", (object)str9);
                                    sqlCommand.Parameters.AddWithValue("@IdCampo", (object)movNumber.ToString());
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
                            //Insertar las mercancias
                            if (movNumber != 0)
                            {
                                SqlConnection getConnection = new dbConnector().GetConnection;
                                using (SqlCommand sqlCommand = new SqlCommand())
                                {
                                    sqlCommand.Connection = getConnection;
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.CommandText = "sp_sl_Pilgrims_ComplementoDatos";
                                    sqlCommand.Parameters.AddWithValue("@ConjuntoDatos", (object)"insertaMercancias");
                                    sqlCommand.Parameters.AddWithValue("@dato", (object)movNumber.ToString());
                                    sqlCommand.Parameters.AddWithValue("@IdCampo", (object)movNumber.ToString());
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
                            if (movNumber != 0)
                            {
                                SqlConnection getConnection = new dbConnector().GetConnection;
                                using (SqlCommand sqlCommand = new SqlCommand())
                                {
                                    sqlCommand.Connection = getConnection;
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.CommandText = "sp_ConvoyAlertaOrdenesIntegrador";
                                    sqlCommand.Parameters.AddWithValue("@accion", (object)movNumber);
                                    sqlCommand.Parameters.AddWithValue("@cliente", (object)Cliente);
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
                            if (movNumber != 0)
                            {
                                SqlConnection getConnection = new dbConnector().GetConnection;
                                using (SqlCommand sqlCommand = new SqlCommand())
                                {
                                    sqlCommand.Connection = getConnection;
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.CommandText = "sp_sl_Pilgrims_Int_Salida";
                                    sqlCommand.Parameters.AddWithValue("@ConjuntoDatos", (object)"ArchivoProcesado");
                                    sqlCommand.Parameters.AddWithValue("@dato", (object)Archivo.ToString());
                                    sqlCommand.Parameters.AddWithValue("@IdCampo", (object)Archivo.ToString());
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
                            if (movNumber != 0)
                            {
                                WorkCycleService.WorkCycleServiceClient cycleServiceClient = new WorkCycleService.WorkCycleServiceClient();
                                string tokenValue = new WorkCycleService.WorkCycleServiceClient().GetToken("internalUID", "internalPass").Token.TokenValue;
                                foreach (DataRow row in (InternalDataCollectionBase)this.cargarDatosRecalculo().Tables[0].Rows)
                                {
                                    new WorkCycleService.WorkCycleServiceClient().ReCalculateMileageForOrderHeader(Convert.ToInt32(row["ord_number"].ToString()), tokenValue);
                                    new WorkCycleService.WorkCycleServiceClient().RateOrder(Convert.ToInt32(row["ord_number"].ToString()), tokenValue);
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
            catch (SqlException ex)
            {
                string message = ex.Message;
            }
        }
        protected DataSet cargarDatosRecalculo()
        {
            SqlConnection getConnection = new dbConnector().GetConnection;
            DataSet dataSet;
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = new SqlCommand("sp_datosRecalculoWorkCycle_sl", getConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "result_name");
            }
            return dataSet;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


    }
}
