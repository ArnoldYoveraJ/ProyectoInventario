using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DProveedor
    {
        private int _Cod_prov;

        public int Cod_prov
        {
            get { return _Cod_prov; }
            set { _Cod_prov = value; }
        }
        private string _Razon_social;

        public string Razon_social
        {
            get { return _Razon_social; }
            set { _Razon_social = value; }
        }
        private string _Sector_comercial;

        public string Sector_comercial
        {
            get { return _Sector_comercial; }
            set { _Sector_comercial = value; }
        }
        private string _Tipo_doc;

        public string Tipo_doc
        {
            get { return _Tipo_doc; }
            set { _Tipo_doc = value; }
        }
        private string _Num_doc;

        public string Num_doc
        {
            get { return _Num_doc; }
            set { _Num_doc = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Texto_buscar;

        public string Texto_buscar
        {
            get { return _Texto_buscar; }
            set { _Texto_buscar = value; }
        }

        public DProveedor() { }

        public DProveedor(int cod_prov, string raz_soc,string sect_com,string tip_doc ,string num_doc ,string dir,string tel,string email,string texto_buscar)
        {
            this.Cod_prov = cod_prov;
            this.Razon_social = raz_soc;
            this.Sector_comercial = sect_com;
            this.Tipo_doc = tip_doc;
            this.Num_doc = num_doc;
            this.Direccion = dir;
            this.Telefono = tel;
            this.Email = email;
            this.Texto_buscar = texto_buscar;
        }

        public string Insertar(DProveedor proveedor)
        {
            string rpta="";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spinsertar_proveedor";
                sql1.CommandType = CommandType.StoredProcedure;

               SqlParameter parcod_pro = new SqlParameter();
               parcod_pro.ParameterName = "@cod_prov";
               parcod_pro.SqlDbType = SqlDbType.Int;
               parcod_pro.Direction = ParameterDirection.Output;
               sql1.Parameters.Add(parcod_pro);

                sql1.Parameters.AddWithValue("@razon_s", proveedor.Razon_social);
                sql1.Parameters.AddWithValue("@sector", proveedor.Sector_comercial);
                sql1.Parameters.AddWithValue("@tip_doc", proveedor.Tipo_doc);
                sql1.Parameters.AddWithValue("@num_doc", proveedor.Num_doc);
                sql1.Parameters.AddWithValue("@dir", proveedor.Direccion);
                sql1.Parameters.AddWithValue("@tel", proveedor.Telefono);
                sql1.Parameters.AddWithValue("@email", proveedor.Email);
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

        public string Editar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speditar_proveedor";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_prov", proveedor.Cod_prov);
                sql1.Parameters.AddWithValue("@razon_s", proveedor.Razon_social);
                sql1.Parameters.AddWithValue("@sector", proveedor.Sector_comercial);
                sql1.Parameters.AddWithValue("@tip_doc", proveedor.Tipo_doc);
                sql1.Parameters.AddWithValue("@num_doc", proveedor.Num_doc);
                sql1.Parameters.AddWithValue("@dir", proveedor.Direccion);
                sql1.Parameters.AddWithValue("@tel", proveedor.Telefono);
                sql1.Parameters.AddWithValue("@email", proveedor.Email);
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

        public string Eliminar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "speliminar_proveedor";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@cod_prov", proveedor.Cod_prov);
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
            DataTable dt = new DataTable("proveedor");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spmostrar_proveedor";
                sql1.CommandType = CommandType.StoredProcedure;

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

        public DataTable Buscar_razon_social(DProveedor proveedor)
        {
            DataTable dt = new DataTable("proveedor");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_prov_razon_social";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@texto_buscar", proveedor.Texto_buscar);

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

        public DataTable Buscar_numdoc(DProveedor proveedor)
        {
            DataTable dt = new DataTable("proveedor");
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = con;
                sql1.CommandText = "spbuscar_proveedor_numdoc";
                sql1.CommandType = CommandType.StoredProcedure;

                sql1.Parameters.AddWithValue("@texto_buscar", proveedor.Texto_buscar);

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
