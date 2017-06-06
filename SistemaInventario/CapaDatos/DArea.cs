using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DArea
    {
        private int _Cod_Area;
        private string _Nom_Area;

        private string texto_buscar;

        public string Texto_buscar
        {
            get { return texto_buscar; }
            set { texto_buscar = value; }
        }
        public int Cod_Area
        {
            get { return _Cod_Area; }
            set { _Cod_Area = value; }
        }

        public string Nom_Area
        {
            get { return _Nom_Area;}
            set { _Nom_Area = value; }
        }

        public DArea() { }
        public DArea(int cod_area, string nom_area)
        {
            this.Cod_Area = cod_area;
            this.Nom_Area = nom_area;
         }

        //Metodo para Ingresar
        public string Ingresar(DArea area)
        {
            string rpta="";
            SqlConnection sqlcon= new SqlConnection();
            try 
	        {	        
		          sqlcon.ConnectionString=Conexion.Cn;
                  sqlcon.Open();
                  SqlCommand sql1= new SqlCommand();
                  sql1.Connection=sqlcon;
                  sql1.CommandText="spingresar_area";
                  sql1.CommandType= CommandType.StoredProcedure;

                  SqlParameter par_codarea= new SqlParameter();
                  par_codarea.ParameterName="@cod_area";
                  par_codarea.SqlDbType= SqlDbType.Int;
                  par_codarea.Direction=ParameterDirection.Output;
                  sql1.Parameters.Add(par_codarea);

                  SqlParameter pas_nomarea= new SqlParameter();
                  pas_nomarea.ParameterName="@nom_area";
                  pas_nomarea.SqlDbType=SqlDbType.VarChar;
                  pas_nomarea.Size=30;
                  pas_nomarea.SqlValue = area.Nom_Area;
                  sql1.Parameters.Add(Nom_Area);

                  rpta=sql1.ExecuteNonQuery() == 1?"Ok":"No se Ingresó el registro";
	        }
	     catch (Exception e)
	        {
		      rpta=e.Message;
	         }
          finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
            }

        //Metodo para Editar
        public string Editar(DArea area)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "speditar_area";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter par_codarea = new SqlParameter();
                par_codarea.ParameterName = "@cod_area";
                par_codarea.SqlDbType = SqlDbType.Int;
                par_codarea.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(par_codarea);

                SqlParameter pas_nomarea = new SqlParameter();
                pas_nomarea.ParameterName = "@nom_area";
                pas_nomarea.SqlDbType = SqlDbType.VarChar;
                pas_nomarea.Size = 30;
                pas_nomarea.SqlValue = area.Nom_Area;
                sql1.Parameters.Add(Nom_Area);

                rpta = sql1.ExecuteNonQuery() == 1 ? "Ok" : "No se Editó el registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        //Metodo para Eliminar
        public string Eliminar(DArea area)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "speliminar_area";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter par_codarea = new SqlParameter();
                par_codarea.ParameterName = "@cod_area";
                par_codarea.SqlDbType = SqlDbType.Int;
                par_codarea.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(par_codarea);

                rpta = sql1.ExecuteNonQuery() == 1 ? "Ok" : "No se Eliminó el registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }


        //Metodo para Mostrar
        public DataTable  Mostrar()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spmostrar_area";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
            }
            return dt;

        }

        //Metodo para Buscar
        public DataTable Buscar(DArea area)
        {
            DataTable dt = new DataTable("Area");
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.Open();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spbuscar_area";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parbuscar = new SqlParameter();
                parbuscar.ParameterName = "@texto_buscar";
                parbuscar.SqlDbType = SqlDbType.VarChar;
                parbuscar.Value = area.Texto_buscar;
                sql1.Parameters.Add(parbuscar);

                SqlDataAdapter da = new SqlDataAdapter(); //falta (SqlDataAdapter(sql1))
                da.Fill(dt);
                //DataColumn dc = dt.Columns.Add("cod_area", typeof(Int16));
                //dt.Columns.Add("nom_area", typeof(string));
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }

            return dt;
        }
    }
}
