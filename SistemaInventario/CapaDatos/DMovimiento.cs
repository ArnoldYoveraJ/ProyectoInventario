using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class DMovimiento
    {
        private int _Cod_mov;
        private DateTime _Fecha;
        private String _Condicion;
        private int _Cod_usu;
        private int _Cod_trabajador;
        private int _Cod_producto;

        public int Cod_mov
        {
            get { return _Cod_mov; }
            set { _Cod_mov = value; }
        }
        
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        
        public String Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }
        
        public int Cod_usu
        {
            get { return _Cod_usu; }
            set { _Cod_usu = value; }
        }
        
        public int Cod_trabajador
        {
            get { return _Cod_trabajador; }
            set { _Cod_trabajador = value; }
        }
        
        public int Cod_producto
        {
            get { return _Cod_producto; }
            set { _Cod_producto = value; }
        }

        public DMovimiento() { }

        public DMovimiento(int cod_mov,DateTime fecha, string condicion, int cod_usu,int cod_trabajador,int cod_producto) 
        {
            this.Cod_mov = cod_mov;
            this.Fecha = fecha;
            this.Condicion = condicion;
            this.Cod_usu = cod_usu;
            this.Cod_trabajador = cod_trabajador;
            this.Cod_producto = Cod_producto;
        }

       public string insertar_movimiento( DMovimiento mov)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                //crear comando
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "sp_insertar_movimiento";
                sql1.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter parcod_mov = new SqlParameter();
                parcod_mov.ParameterName = "@cod_mov";
                parcod_mov.SqlDbType = SqlDbType.Int;
                parcod_mov.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(parcod_mov);

                sql1.Parameters.AddWithValue("@FECHA", mov.Fecha);
                sql1.Parameters.AddWithValue("@CONDICION", mov.Condicion);
                sql1.Parameters.AddWithValue("@COD_USU", mov.Cod_usu);
                sql1.Parameters.AddWithValue("@COD_TRABAJADOR", mov.Cod_trabajador);
                sql1.Parameters.AddWithValue("@COD_PRODUCTO", mov.Cod_producto);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
           finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return rpta;
        }

       public string editar_movimiento(DMovimiento mov)
       {
           string rpta = "";
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               sqlcon.ConnectionString = Conexion.Cn;
               sqlcon.Open();

               //crear comando
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = sqlcon;
               sql1.CommandText = "sp_editar_movimiento";
               sql1.CommandType = CommandType.StoredProcedure;

               //parametros
               sql1.Parameters.AddWithValue("@cod_mov", mov.Cod_mov);
               sql1.Parameters.AddWithValue("@FECHA", mov.Fecha);
               sql1.Parameters.AddWithValue("@CONDICION", mov.Condicion);
               sql1.Parameters.AddWithValue("@COD_USU", mov.Cod_usu);
               sql1.Parameters.AddWithValue("@COD_TRABAJADOR", mov.Cod_trabajador);
               sql1.Parameters.AddWithValue("@COD_PRODUCTO", mov.Cod_producto);
               rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se Editó el Registro";
           }
           catch (Exception e)
           {
               rpta = e.Message;
           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
               {
                   sqlcon.Close();
               }
           }
           return rpta;
       }

       public string eliminar_movimiento(DMovimiento mov)
       {
           string rpta = "";
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               sqlcon.ConnectionString = Conexion.Cn;
               sqlcon.Open();

               //crear comando
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = sqlcon;
               sql1.CommandText = "sp_eliminar_movimiento";
               sql1.CommandType = CommandType.StoredProcedure;

               //parametros
               sql1.Parameters.AddWithValue("@cod_mov", mov.Cod_mov);
               rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";
           }
           catch (Exception e)
           {
               rpta = e.Message;
           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
               {
                   sqlcon.Close();
               }
           }
           return rpta;
       }

       public DataTable Mostrar()
       {
           DataTable dt = new DataTable("movimiento");
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "sp_mostrar_movimiento";
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

       public DataTable Buscar_por_fechas(string fecha_ini,string fecha_fin)
       {
           DataTable dt = new DataTable("movimiento");
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "SP_BUSCAR_MOVIMIENTO_FECHAS";
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
