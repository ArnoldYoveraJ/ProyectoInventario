using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;//Para trabajar con tipo de datos de SQlServer
using System.Data.SqlClient;//para poder enviar comandos de la aplicacion a SQLServer
namespace CapaDatos
{

    public class DCategoria
    {
        private int _Cod_cat;
        private string _Nom_cat;
        private string _TextoBuscar;
        public int Cod_cat
        {
            get { return _Cod_cat; }
            set { _Cod_cat = value; }
        }
       
        public string Nom_cat
        {
            get { return _Nom_cat; }
            set { _Nom_cat = value; }
        }
        
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        SqlConnection sqlcon;
        SqlCommand sql1;
        SqlDataAdapter da;
        DataTable dt;
        //constructor
        public DCategoria() { }

        //constructor con parámetros
        public DCategoria(int cod_cat,string nom_cat,string texto)
        {
            this.Cod_cat = cod_cat;
            this.Nom_cat = nom_cat;
            this.TextoBuscar = texto;
        }

        //Metodo Insertar
        public string Insertar(DCategoria Categoria)
        {
            string rpta="";
            SqlConnection sqlcon= new SqlConnection();
            try
            {
                sqlcon.ConnectionString=Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1= new SqlCommand();//especificamos la consulta
                sql1.Connection=sqlcon;
                sql1.CommandText="spinsertar_categoria";
                sql1.CommandType=CommandType.StoredProcedure;

                SqlParameter parCod_Cat = new SqlParameter();
                parCod_Cat.ParameterName="@COD_CAT";
                parCod_Cat.SqlDbType=SqlDbType.Int;
                parCod_Cat.Direction=ParameterDirection.Output;
                sql1.Parameters.Add(parCod_Cat);

                SqlParameter parNombre= new SqlParameter();
                parNombre.ParameterName="@NOM_CAT";
                parNombre.SqlDbType=SqlDbType.VarChar;
                parNombre.Size=30;
                parNombre.Value=Categoria.Nom_cat;
                sql1.Parameters.Add(parNombre);

                rpta=sql1.ExecuteNonQuery()==1? "OK":"No se ingreso el Registro";

            }
            catch(Exception e){
                rpta=e.Message;
            }
            finally{
                if(sqlcon.State==ConnectionState.Open)sqlcon.Close();
            }
           return rpta;

        }
        //Metodo Editar 
        public string Editar(DCategoria Categoria)
        {
            string rpta="";
            SqlConnection sqlcon= new SqlConnection();
            try
            {
                sqlcon.ConnectionString=Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1= new SqlCommand();//especificamos la consulta
                sql1.Connection=sqlcon;
                sql1.CommandText="speditar_categoria";
                sql1.CommandType=CommandType.StoredProcedure;

                SqlParameter parCod_Cat = new SqlParameter();
                parCod_Cat.ParameterName="@COD_CAT";
                parCod_Cat.SqlDbType=SqlDbType.Int;
                parCod_Cat.Value=Categoria.Cod_cat;
                sql1.Parameters.Add(parCod_Cat);

                SqlParameter parNombre= new SqlParameter();
                parNombre.ParameterName="@NOM_CAT";
                parNombre.SqlDbType=SqlDbType.VarChar;
                parNombre.Size=30;
                parNombre.Value=Categoria.Nom_cat;
                sql1.Parameters.Add(parNombre);

                rpta=sql1.ExecuteNonQuery()==1?"OK":"No se Actualizó el Registro";

            }
            catch(Exception e){
                rpta=e.Message;
            }
            finally{
                if(sqlcon.State==ConnectionState.Open)sqlcon.Close();
            }
           return rpta;
        }
        //Metodo para Eliminar
        public string Eliminar(DCategoria Categoria)
        {
             string rpta="";
             SqlConnection sqlcon= new SqlConnection();
            try
            {
                sqlcon.ConnectionString=Conexion.Cn;
                sqlcon.Open();
                SqlCommand sql1= new SqlCommand();//especificamos la consulta
                sql1.Connection=sqlcon;
                sql1.CommandText="speliminar_categoria";
                sql1.CommandType=CommandType.StoredProcedure;

                SqlParameter parCod_Cat = new SqlParameter();
                parCod_Cat.ParameterName="@COD_CAT";
                parCod_Cat.SqlDbType=SqlDbType.Int;
                parCod_Cat.Value=Categoria.Cod_cat;
                sql1.Parameters.Add(parCod_Cat); 

                rpta=sql1.ExecuteNonQuery()==1?"OK":"No se Elimnó el Registro";

            }
            catch(Exception e){
                rpta=e.Message;
            }
            finally{
                if(sqlcon.State==ConnectionState.Open)sqlcon.Close();
            }
           return rpta;
        }

        //Mostrar
        public DataTable Mostrar()
        {
            DataTable dt= new DataTable("CATEGORIA");
            SqlConnection sqlcon= new SqlConnection();
            try 
	        {	        
		        sqlcon.ConnectionString=Conexion.Cn;
                SqlCommand sql1= new SqlCommand();
                sql1.Connection=sqlcon;
                sql1.CommandText="spmostrar_categoria";
                sql1.CommandType=CommandType.StoredProcedure;

                SqlDataAdapter sqldat=new SqlDataAdapter(sql1);
                sqldat.Fill(dt);
	        }
	        catch (Exception ex)
	        {
                dt=null;
	        }
            return dt;
          }

        //Buscar
        public DataTable Buscar(DCategoria Categoria)
        {
            DataTable dt = new DataTable("CATEGORIA");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spbuscar_categoria";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextobuscar = new SqlParameter();
                parTextobuscar.ParameterName = "@textobuscar";
                parTextobuscar.SqlDbType = SqlDbType.VarChar;
                parTextobuscar.Size = 50;
                parTextobuscar.Value = Categoria.TextoBuscar;
                sql1.Parameters.Add(parTextobuscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(sql1);
                sqldat.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }
    }
}
