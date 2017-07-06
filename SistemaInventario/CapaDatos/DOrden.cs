using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DOrden
    {
        private int _Cod_Orden;

        public int Cod_Orden
        {
            get { return _Cod_Orden; }
            set { _Cod_Orden = value; }
        }
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private string _Tipo_Comprobante;

        public string Tipo_Comprobante
        {
            get { return _Tipo_Comprobante; }
            set { _Tipo_Comprobante = value; }
        }
        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

      
        private int _Cod_Usu;

        public int Cod_Usu
        {
            get { return _Cod_Usu; }
            set { _Cod_Usu = value; }
        }
        private int _Cod_Prov;

        public int Cod_Prov
        {
            get { return _Cod_Prov; }
            set { _Cod_Prov = value; }
        }

        public DOrden() { }

        public DOrden(int cod_orden,DateTime fecha,string tip_compro,string est,int cod_usu,int cod_prov)
        {
            this.Cod_Orden = cod_orden;
            this.Fecha = fecha;
            this.Tipo_Comprobante = tip_compro;
            this.Estado = est;
            this.Cod_Usu = cod_usu;
            this.Cod_Prov = cod_prov;
        }

        public string Insertar(DOrden Orden,List<DDetalle_Orden> Detalle)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                //Establecer la transacción
                SqlTransaction SqlTra = con.BeginTransaction();

                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.Transaction = SqlTra;
                sql1.CommandText = "spingresar_orden";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod_orden = new SqlParameter();
                parcod_orden.ParameterName = "@cod_orden";
                parcod_orden.SqlDbType = SqlDbType.Int;
                parcod_orden.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(parcod_orden);

                sql1.Parameters.AddWithValue("@fecha", Orden.Fecha);
                sql1.Parameters.AddWithValue("@tipo_comprobante", Orden.Tipo_Comprobante);
                sql1.Parameters.AddWithValue("@cod_usu", Orden.Estado);
                sql1.Parameters.AddWithValue("@cod_prov", Orden.Cod_Usu);
                sql1.Parameters.AddWithValue("@estado", Orden.Estado);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";

                if(rpta.Equals("OK"))
                {
                    //obtner el código del ingreso generado
                    this.Cod_Orden = Convert.ToInt32(sql1.Parameters["cod_orden"].Value);
                    foreach (DDetalle_Orden ord in Detalle)
                    {
                        ord.Cod_Orden = this.Cod_Orden;
                        //llamar a metodo insertar de ddetalle_ingreso
                        // rpta = Detalle. Insertar(ord,ref SqlCon,ref SqlTra);
                        rpta = ord.Insertar(ord, ref con, ref SqlTra);
                        if(rpta.Equals("OK"))
                        {
                            break;
                        }
                    }
                    if(rpta.Equals("OK"))
                    {
                        SqlTra.Commit();
                    }
                    else
                    {
                        SqlTra.Rollback();
                    }
                }
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return rpta;
        }

        public string Anular(DOrden orden)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spanular_ingreso_orden";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_orden", orden.Cod_Orden);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("orden");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spmostrar_orden_ingreso";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sql1);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return dt;
        }

        public DataTable Buscar_orden_ingreso_porfecha(string fecha_ini,string fecha_fin)
        {
            DataTable dt = new DataTable("orden");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_orden_ingreso_porfecha";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@fechainicio", fecha_ini);
                sql1.Parameters.AddWithValue("@fechafin", fecha_fin);

                SqlDataAdapter da = new SqlDataAdapter(sql1);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return dt;
        }

        public DataTable Mostrar_Detalle_Ingreso(string textobuscar)
        {
            DataTable dt = new DataTable("orden");//detalle_ingreso
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spmostrar_detalle_ingreso";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@textobuscar", textobuscar);

                SqlDataAdapter da = new SqlDataAdapter(sql1);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return dt;
        }
    }
}
