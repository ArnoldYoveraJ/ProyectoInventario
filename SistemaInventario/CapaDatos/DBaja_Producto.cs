using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DBaja_Producto
    {
        private int _Cod_Baja;

        public int Cod_Baja
        {
            get { return _Cod_Baja; }
            set { _Cod_Baja = value; }
        }
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private string _Explicacion;

        public string Explicacion
        {
            get { return _Explicacion; }
            set { _Explicacion = value; }
        }
        private string _Estado;

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        private int _Cod_Producto;

        public int Cod_Producto
        {
            get { return _Cod_Producto; }
            set { _Cod_Producto = value; }
        }

        public DBaja_Producto() { }

        public DBaja_Producto(int cod_baja,DateTime fecha, string explicacion,string est,int cod_pro) 
        {
            this.Cod_Baja = cod_baja;
            this.Fecha = fecha;
            this.Explicacion = explicacion;
            this.Estado = est;
            this.Cod_Producto = cod_pro;
        }

        public string Insertar(DBaja_Producto baja_producto)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spinsertar_baja_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod_pro = new SqlParameter();
                parcod_pro.ParameterName = "@COD_BAJA";
                parcod_pro.SqlDbType = SqlDbType.Int;
                parcod_pro.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(parcod_pro);

                sql1.Parameters.AddWithValue("@FECHA", baja_producto.Fecha);
                sql1.Parameters.AddWithValue("@EXPLICACION", baja_producto.Explicacion);
                sql1.Parameters.AddWithValue("@ESTADO", baja_producto.Estado);
                sql1.Parameters.AddWithValue("@COD_PRODUCTO", baja_producto.Cod_Producto);
                rpta = sql1.ExecuteNonQuery() != 0 ? "OK" : "No se ingreso el Registro";
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

        public string Editar(DBaja_Producto baja_producto)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speditar_baja_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@COD_BAJA", baja_producto.Cod_Baja);
                sql1.Parameters.AddWithValue("@FECHA", baja_producto.Fecha);
                sql1.Parameters.AddWithValue("@EXPLICACION", baja_producto.Explicacion);
                sql1.Parameters.AddWithValue("@ESTADO", baja_producto.Estado);
                sql1.Parameters.AddWithValue("@COD_PRODUCTO", baja_producto.Cod_Producto);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se Edito el Registro";
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

        public string Eliminar(DBaja_Producto baja_producto)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speliminar_baja_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_baja", baja_producto.Cod_Baja);
                sql1.Parameters.AddWithValue("@cod_pro", baja_producto.Cod_Producto);
                rpta = sql1.ExecuteNonQuery() != 1 ? "OK" : "No se Eliminó el Registro";
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
            DataTable dt = new DataTable("baja_productos");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spmostrar_baja_producto";
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

        public DataTable Buscar_Baja_Productos(DateTime fecha_ini, DateTime fecha_fin)
        {
            DataTable dt = new DataTable("baja_productos");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_baja_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@fecha_ini", fecha_ini);
                sql1.Parameters.AddWithValue("@fecha_fin", fecha_fin);

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
