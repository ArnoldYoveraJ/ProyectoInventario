using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class DUsuario
    {
        private int _Cod_usu;

        public int Cod_usu
        {
            get { return _Cod_usu; }
            set { _Cod_usu = value; }
        }
        private string _Nom_completo;

        public string Nom_completo
        {
            get { return _Nom_completo; }
            set { _Nom_completo = value; }
        }
        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        private string _Contra;

        public string Contra
        {
            get { return _Contra; }
            set { _Contra = value; }
        }
        private string _Tipo;

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        private int _Estado;

        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private string _Textobuscar;

        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; }
        }

       
        public DUsuario() { }

        public DUsuario(int cod,string nom,string usu,string contra,string tipo, int est) {
            this.Cod_usu = cod;
            this.Nom_completo = nom;
            this.Usuario = usu;
            this.Contra = contra;
            this.Tipo = tipo;
            this.Estado = est;
        }

        public string Insertar(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spinsertar_usuario";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@nom_com", usuario.Nom_completo);
                sql1.Parameters.AddWithValue("@usu", usuario.Usuario);
                sql1.Parameters.AddWithValue("@contra", usuario.Contra);
                sql1.Parameters.AddWithValue("@tipo", usuario.Tipo);
                sql1.Parameters.AddWithValue("@est", usuario.Estado);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
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

        public string Editar(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speditar_usuario";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_usu", usuario.Cod_usu);
                sql1.Parameters.AddWithValue("@nom_com", usuario.Nom_completo);
                sql1.Parameters.AddWithValue("@usu", usuario.Usuario);
                sql1.Parameters.AddWithValue("@contra", usuario.Contra);
                sql1.Parameters.AddWithValue("@tipo", usuario.Tipo);
                sql1.Parameters.AddWithValue("@est", usuario.Estado);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se editó el Registro";
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

        public string Eliminar(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speliminar_usuario";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_usu", usuario.Cod_usu);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el Registro";
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
            DataTable dt = new DataTable("usuario");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spmostrar_usuario";
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

        public DataTable Buscar_nombre(DUsuario usuario)
        {
            DataTable dt = new DataTable("usuario");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_nombre";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@textobuscar", usuario.Textobuscar);
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

        public DataTable Buscar_usuario(DUsuario usuario)
        {
            DataTable dt = new DataTable("usuario");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_usuario";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@texto_buscar",usuario.Textobuscar);

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
