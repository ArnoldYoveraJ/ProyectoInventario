using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class DTrabajador
    {
        private int _Cod_Trabajador;
        private string _Nombres;
        private string _Apellidos;
        private string _DNI;
        private string _Email;
        private string _Anexo;
        private int _Cod_Area;
        private int _Cod_Empresa;
        private string _textobuscar;

        public string Textobuscar
        {
            get { return _textobuscar; }
            set { _textobuscar = value; }
        }

        public int Cod_Trabajador
        {
            get { return _Cod_Trabajador; }
            set { _Cod_Trabajador = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        
        public string Anexo
        {
            get { return _Anexo; }
            set { _Anexo = value; }
        }

        public int Cod_Area
        {
            get { return _Cod_Area; }
            set { _Cod_Area = value; }
        }

        public int Cod_Empresa
        {
            get { return _Cod_Empresa; }
            set { _Cod_Empresa = value; }
        }
       public DTrabajador(){ }
       public DTrabajador(int cod,string nom,string ape,string dni, string email,string anexo,int cod_area,int cod_empresa,string texto) {
           this.Cod_Trabajador = cod;
           this.Nombres= nom;
           this.Apellidos = ape;
           this.DNI = dni;
           this.Email = email;
           this.Anexo = anexo;
           this.Cod_Area = cod_area;
           this.Cod_Empresa = cod_empresa;
           this.Textobuscar = texto;
       }

       public string Insertar_Trabajador(DTrabajador Trabajador)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spinsertar_trabajador";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod_tra = new SqlParameter();
                parcod_tra.ParameterName = "@cod_tra";
                parcod_tra.SqlDbType = SqlDbType.Int;
                parcod_tra.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(parcod_tra);

                sql1.Parameters.AddWithValue("@nom",Trabajador.Nombres);
                sql1.Parameters.AddWithValue("@ape", Trabajador.Apellidos);
                sql1.Parameters.AddWithValue("@dni", Trabajador.DNI);
                sql1.Parameters.AddWithValue("@email", Trabajador.Email);
                sql1.Parameters.AddWithValue("@anexo", Trabajador.Anexo);
                sql1.Parameters.AddWithValue("@cod_area", Trabajador.Cod_Area);
                sql1.Parameters.AddWithValue("@cod_emp", Trabajador.Cod_Empresa);

                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
            }
            catch(Exception e){
               rpta = e.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return rpta;
        }

       public string Editar_Trabajador(DTrabajador Trab)
       {
           string respuesta="";
           SqlConnection con = new SqlConnection();
           try 
	        {	        
		       con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "speditar_trabajador";
               sql1.CommandType = CommandType.StoredProcedure;

               sql1.Parameters.AddWithValue("@cod_tra", Trab._Cod_Trabajador);
               sql1.Parameters.AddWithValue("@nom", Trab.Nombres);
               sql1.Parameters.AddWithValue("@ape", Trab.Apellidos);
               sql1.Parameters.AddWithValue("@dni", Trab.DNI);
               sql1.Parameters.AddWithValue("@email", Trab.Email);
               sql1.Parameters.AddWithValue("@anexo", Trab.Anexo);
               sql1.Parameters.AddWithValue("@cod_area", Trab.Cod_Area);
               sql1.Parameters.AddWithValue("@cod_emp", Trab.Cod_Empresa);

              respuesta = sql1.ExecuteNonQuery() == 1? "OK" : "No se Edito el Registro";
	         }
	        catch (Exception e)
	        {
                respuesta = e.Message;
	        }
           finally
           {
               if (con.State == ConnectionState.Open) { con.Close(); }
           }

           return respuesta;
       }

       public string Eliminar_Trabajador(DTrabajador Trab)
       {
           string respuesta = "";
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();

               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "speliminar_trabajador";
               sql1.CommandType = CommandType.StoredProcedure;

               sql1.Parameters.AddWithValue("@cod", Cod_Trabajador);

               respuesta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";
           }
           catch (Exception e)
           {
               respuesta = e.Message;
           }
           finally
           {
               if (con.State == ConnectionState.Open) { con.Close(); }
           }

           return respuesta;
       }

       public DataTable Mostrar()
       {
           DataTable dt=new DataTable("TRABAJADOR");
           SqlConnection con = new SqlConnection();
           
           try
           {
               con.ConnectionString = Conexion.Cn;
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "spmostrar_trabajador";
               sql1.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da= new SqlDataAdapter(sql1);
               da.Fill(dt);
           }
           catch (Exception e)
           {
               dt = null;
               string rpta = e.Message;
            }
           return dt;
       }

       public DataTable Buscar(DTrabajador trabajador) 
       {
           DataTable dt = new DataTable("TRABAJADOR");
           SqlConnection con = new SqlConnection();

           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "spbuscar_trabajador";
               sql1.CommandType = CommandType.StoredProcedure;

               SqlParameter parTextobuscar = new SqlParameter();
               parTextobuscar.ParameterName = "@textobuscar";
               parTextobuscar.SqlDbType = SqlDbType.VarChar;
               parTextobuscar.Size = 50;
               parTextobuscar.Value = trabajador.Textobuscar;
               sql1.Parameters.Add(parTextobuscar);

               SqlDataAdapter da = new SqlDataAdapter(sql1);
               da.Fill(dt);
           }
           catch (Exception e)
           {
               dt = null;
                string rpta = e.Message;
            }
           return dt;
       }

          public DataTable Buscar_Trabajador_dni(DTrabajador trabajador)
       {
           DataTable dt = new DataTable("TRABAJADOR");
           SqlConnection con = new SqlConnection();

           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "spbuscar_trabajador_dni";
               sql1.CommandType = CommandType.StoredProcedure;

              // sql1.Parameters.AddWithValue("@textobuscar",trabajador.Textobuscar);
               SqlParameter parTextobuscar = new SqlParameter();
               parTextobuscar.ParameterName = "@textobuscar";
               parTextobuscar.SqlDbType = SqlDbType.VarChar;
               parTextobuscar.Size = 8;
               parTextobuscar.Value = trabajador.Textobuscar;
               sql1.Parameters.Add(parTextobuscar);

               SqlDataAdapter da = new SqlDataAdapter(sql1);
               da.Fill(dt);
           }
           catch (Exception e)
           {
               dt = null;
                string rpta = e.Message;
            }
           return dt;
       }

       

       public DataTable Mostrar_Empresa()
       {
           DataTable dt = new DataTable("empresa");
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               sqlcon.ConnectionString = Conexion.Cn;
               sqlcon.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = sqlcon;
               sql1.CommandText = "spmostrar_empresa";
               sql1.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da = new SqlDataAdapter(sql1);
               da.Fill(dt);
           }
           catch (Exception e)
           {
               dt = null;
                string rpta = e.Message;
            }
           return dt;
       }

       public DataTable Buscar_Productos_por_Trabajador(String apellidos)
       {
           DataTable dt = new DataTable("trabajador");
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = Conexion.Cn;
               con.Open();
               SqlCommand sql1 = new SqlCommand();
               sql1.Connection = con;
               sql1.CommandText = "sp_buscar_productosAsignador_trabajador";//modificar
               sql1.CommandType = CommandType.StoredProcedure;

               sql1.Parameters.AddWithValue("@texto", apellidos);

               SqlDataAdapter da = new SqlDataAdapter(sql1);
               da.Fill(dt);
           }
           catch (Exception e)
           {
               dt = null;
                string rpta = e.Message;
            }
           finally
           {
               if (con.State == ConnectionState.Open) { con.Close(); }
           }
           return dt;
       }

    }
}
