using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {
        private int _Cod_producto;
        private string _Nom_Producto;
        private string _Marca;
        private string _Modelo_Placa;
        private string _Serie;
        private string _Procesador;
        private string _DD;
        private string _Ram;
        private string _SO;
        private byte[] _Imagen;
        private string _Estado;
        private string _Condicion;
        private string _Descripcion;
        private int _Cod_Cat;
        private int _Cod_Trabajador;
        private string _TextoBuscar;

        public int Cod_producto
        {
            get { return _Cod_producto; }
            set { _Cod_producto = value; }
        }

        public string Nom_Producto
        {
            get { return _Nom_Producto; }
            set { _Nom_Producto = value; }
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        
        public string Modelo_Placa
        {
            get { return _Modelo_Placa; }
            set { _Modelo_Placa = value; }
        }
        
        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }
        
        public string Procesador
        {
            get { return _Procesador; }
            set { _Procesador = value; }
        }
        
        public string DD
        {
            get { return _DD; }
            set { _DD = value; }
        }
        

        public string Ram
        {
            get { return _Ram; }
            set { _Ram = value; }
        }
        
        public string SO
        {
            get { return _SO; }
            set { _SO = value; }
        }
        
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }
        
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        
        public int Cod_Cat
        {
            get { return _Cod_Cat; }
            set { _Cod_Cat = value; }
        }

        public int Cod_Trabajador
        {
            get { return _Cod_Trabajador; }
            set { _Cod_Trabajador = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        //Constructores
        public DProducto() { }
        public DProducto(int cod_pro,string nom_pro,string marca,string modelo_placa, string serie,
        string procesa, string dd, string ram, string so,byte[]  imagen,string estado,string condicion,
        string descrip,int cod_cat,int cod_trab, string  textobuscar)
        {
            this.Cod_producto = cod_pro;
            this.Nom_Producto = nom_pro;
            this.Marca = marca;
            this.Modelo_Placa = modelo_placa;
            this.Serie = serie;
            this.Procesador = procesa;
            this.DD = dd;
            this.Ram = ram;
            this.SO = so;
            this.Imagen = imagen;
            this.Estado = estado;
            this.Condicion = condicion;
            this.Descripcion = descrip;
            this.Cod_Cat = cod_cat;
            this.Cod_Trabajador = cod_trab;
            this.TextoBuscar = textobuscar;
        }
 
        //Metodo para Insetar
        public string Insertar(DProducto producto)
        {
            string sms = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcoma = new SqlCommand();
                sqlcoma.Connection = sqlcon;
                sqlcoma.CommandText = "spinsertar_productos";
                sqlcoma.CommandType = CommandType.StoredProcedure;

                SqlParameter par = new SqlParameter();
                par.ParameterName = "@cod_producto";
                par.SqlDbType = SqlDbType.Int;
                par.Direction = ParameterDirection.Output;
                sqlcoma.Parameters.Add(par);

                SqlParameter par1 = new SqlParameter();
                par1.ParameterName = "@nom_producto";
                par1.SqlDbType = SqlDbType.VarChar;
                par1.Size = 30;
                par1.SqlValue = producto.Nom_Producto;
                sqlcoma.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter();
                par2.ParameterName = "@marca";
                par2.SqlDbType = SqlDbType.VarChar;
                par2.Size = 30;
                par2.SqlValue = producto.Marca;
                sqlcoma.Parameters.Add(par2);

                SqlParameter par3 = new SqlParameter();
                par3.ParameterName = "@modelo_placa";
                par3.SqlDbType = SqlDbType.VarChar;
                par3.Size = 30;
                par3.SqlValue = producto.Modelo_Placa;
                sqlcoma.Parameters.Add(par3);

                SqlParameter par4 = new SqlParameter();
                par4.ParameterName = "@serie";
                par4.SqlDbType = SqlDbType.VarChar;
                par4.Size = 50;
                par4.SqlValue = producto.Serie;
                sqlcoma.Parameters.Add(par4);

                SqlParameter par5 = new SqlParameter();
                par5.ParameterName = "@procesador";
                par5.SqlDbType = SqlDbType.VarChar;
                par5.Size = 20;
                par5.SqlValue = producto.Procesador;
                sqlcoma.Parameters.Add(par5);

                SqlParameter par6 = new SqlParameter();
                par6.ParameterName = "@dd";
                par6.SqlDbType = SqlDbType.VarChar;
                par6.Size = 20;
                par6.SqlValue = producto.DD;
                sqlcoma.Parameters.Add(par6);

                SqlParameter par7 = new SqlParameter();
                par7.ParameterName = "@ram";
                par7.SqlDbType = SqlDbType.VarChar;
                par7.Size = 20;
                par7.SqlValue = producto.Ram;
                sqlcoma.Parameters.Add(par7);

                SqlParameter par8 = new SqlParameter();
                par8.ParameterName = "@so";
                par8.SqlDbType = SqlDbType.VarChar;
                par8.Size = 20;
                par8.SqlValue = producto.SO;
                sqlcoma.Parameters.Add(par8);

                SqlParameter par9 = new SqlParameter();
                par9.ParameterName = "@imagen";
                par9.SqlDbType = SqlDbType.Image;
                par9.SqlValue = producto.Imagen;
                sqlcoma.Parameters.Add(par9);

                SqlParameter par10 = new SqlParameter();
                par10.ParameterName = "@estado";
                par10.SqlDbType = SqlDbType.VarChar;
                par10.SqlValue = producto.Estado;
                sqlcoma.Parameters.Add(par10);

                SqlParameter par11 = new SqlParameter();
                par11.ParameterName = "@condicion";
                par11.SqlDbType = SqlDbType.VarChar;
                par11.SqlValue = producto.Condicion;
                sqlcoma.Parameters.Add(par11);

                SqlParameter par12 = new SqlParameter();
                par12.ParameterName = "@descripcion";
                par12.SqlDbType = SqlDbType.VarChar;
                par12.Size = 50;
                par12.SqlValue = producto.Descripcion;
                sqlcoma.Parameters.Add(par12);

                SqlParameter par13 = new SqlParameter();
                par13.ParameterName = "@cod_cat";
                par13.SqlDbType = SqlDbType.Int;
                par13.SqlValue = producto.Cod_Cat;
                sqlcoma.Parameters.Add(par13);

                SqlParameter par14 = new SqlParameter();
                par14.ParameterName = "@cod_trabajador";
                par14.SqlDbType = SqlDbType.Int;
                par14.SqlValue = producto.Cod_Trabajador;
                sqlcoma.Parameters.Add(par14);

                sms = sqlcoma.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
            }
            catch (Exception e)
            {
                sms = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return sms;

            
        }

        //Metodo para Editar
        public string Editar(DProducto producto)
        {
            string sms = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcoma = new SqlCommand();
                sqlcoma.Connection = sqlcon;
                sqlcoma.CommandText = "speditar_producto";
                sqlcoma.CommandType = CommandType.StoredProcedure;

                SqlParameter par = new SqlParameter();
                par.ParameterName = "@cod_producto";
                par.SqlDbType = SqlDbType.Int;
                par.SqlValue = producto.Cod_producto;
                sqlcoma.Parameters.Add(par);

                SqlParameter par1 = new SqlParameter();
                par1.ParameterName = "@nom_producto";
                par1.SqlDbType = SqlDbType.VarChar;              
                par1.Size = 30;
                par1.SqlValue = producto.Nom_Producto;
                sqlcoma.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter();
                par2.ParameterName = "@marca";
                par2.SqlDbType = SqlDbType.VarChar;
                par2.Size = 30;
                par2.SqlValue = producto.Marca;
                sqlcoma.Parameters.Add(par2);

                SqlParameter par3 = new SqlParameter();
                par3.ParameterName = "@modelo_placa";
                par3.SqlDbType = SqlDbType.VarChar;
                par3.Size = 30;
                par3.SqlValue = producto.Modelo_Placa;
                sqlcoma.Parameters.Add(par3);

                SqlParameter par4 = new SqlParameter();
                par4.ParameterName = "@serie";
                par4.SqlDbType = SqlDbType.VarChar;
                par4.Size = 50;
                par4.SqlValue = producto.Serie;
                sqlcoma.Parameters.Add(par4);

                SqlParameter par5 = new SqlParameter();
                par5.ParameterName = "@procesador";
                par5.SqlDbType = SqlDbType.VarChar;
                par5.Size = 20;
                par5.SqlValue = producto.Procesador;
                sqlcoma.Parameters.Add(par5);

                SqlParameter par6 = new SqlParameter();
                par6.ParameterName = "@dd";
                par6.SqlDbType = SqlDbType.VarChar;
                par6.Size = 20;
                par6.SqlValue = producto.DD;
                sqlcoma.Parameters.Add(par6);

                SqlParameter par7 = new SqlParameter();
                par7.ParameterName = "@ram";
                par7.SqlDbType = SqlDbType.VarChar;
                par7.Size = 20;
                par7.SqlValue = producto.Ram;
                sqlcoma.Parameters.Add(par7);

                SqlParameter par8 = new SqlParameter();
                par8.ParameterName = "@so";
                par8.SqlDbType = SqlDbType.VarChar;
                par8.Size = 20;
                par8.SqlValue = producto.SO;
                sqlcoma.Parameters.Add(par8);

                SqlParameter par9 = new SqlParameter();
                par9.ParameterName = "@imagen";
                par9.SqlDbType = SqlDbType.Image;
                par9.SqlValue = producto.Imagen;
                sqlcoma.Parameters.Add(par9);

                SqlParameter par10 = new SqlParameter();
                par10.ParameterName = "@estado";
                par10.SqlDbType = SqlDbType.VarChar;
                par10.SqlValue = producto.Estado;
                sqlcoma.Parameters.Add(par10);

                SqlParameter par11 = new SqlParameter();
                par11.ParameterName = "@condicion";
                par11.SqlDbType = SqlDbType.VarChar;
                par11.SqlValue = producto.Condicion;
                sqlcoma.Parameters.Add(par11);

                SqlParameter par12 = new SqlParameter();
                par12.ParameterName = "@descripcion";
                par12.SqlDbType = SqlDbType.VarChar;
                par12.Size = 50;
                par12.SqlValue = producto.Descripcion;
                sqlcoma.Parameters.Add(par12);

                SqlParameter par13 = new SqlParameter();
                par13.ParameterName = "@cod_cat";
                par13.SqlDbType = SqlDbType.Int;
                par13.SqlValue = producto.Cod_Cat;
                sqlcoma.Parameters.Add(par13);

                SqlParameter par14 = new SqlParameter();
                par14.ParameterName = "@cod_trabajador";
                par14.SqlDbType = SqlDbType.Int;
                par14.SqlValue = producto.Cod_Trabajador;
                sqlcoma.Parameters.Add(par14);

                sms = sqlcoma.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizó el Registro";
            }
            catch (Exception e)
            {
                sms = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return sms;

        }

        //Metodo para Eliminar
        public string Eliminar(DProducto producto)
        {
            string sms = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcoma = new SqlCommand();
                sqlcoma.Connection = sqlcon;
                sqlcoma.CommandText = "speliminar_producto";
                sqlcoma.CommandType = CommandType.StoredProcedure;

                SqlParameter par = new SqlParameter();
                par.ParameterName = "@COD_PROD";
                par.SqlDbType = SqlDbType.Int;
                par.SqlValue = producto._Cod_producto;
                sqlcoma.Parameters.Add(par);

                sms = sqlcoma.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";
            }
            catch (Exception e)
            {
                sms = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return sms;

        }

        //Metodo para mostrar
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("PRODUCTOS");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spmostrar_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldat = new SqlDataAdapter(sql1);
                sqldat.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }

        public DataTable Mostrar_Productos_disponibles()
        {
            DataTable dt = new DataTable("PRODUCTOS");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spmostrar_producto_disponibles";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sql1);
                da.Fill(dt);
            }
            catch (Exception)
            {

                dt = null;
            }
            return dt;
        }


        //Metodo para buscar por nombre
        public DataTable Buscar(DProducto Producto)
        {
            DataTable dt = new DataTable("PRODUCTOS");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spbuscar_producto";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextobuscar = new SqlParameter();
                parTextobuscar.ParameterName = "@buscartexto";
                parTextobuscar.SqlDbType = SqlDbType.VarChar;
                parTextobuscar.Size = 50;
                parTextobuscar.Value = Producto.TextoBuscar;
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

        public DataTable Buscar_producto_marca(DProducto Producto)
        {
            DataTable dt = new DataTable("PRODUCTOS");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spbuscar_producto_marca";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextobuscar = new SqlParameter();
                parTextobuscar.ParameterName = "@buscartexto";
                parTextobuscar.SqlDbType = SqlDbType.VarChar;
                parTextobuscar.Size = 30;
                parTextobuscar.Value = Producto.TextoBuscar;
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

        public DataTable Buscar_producto_serie(DProducto Producto)
        {
            DataTable dt = new DataTable("PRODUCTOS");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = sqlcon;
                sql1.CommandText = "spbuscar_producto_serie";
                sql1.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextobuscar = new SqlParameter();
                parTextobuscar.ParameterName = "@buscartexto";
                parTextobuscar.SqlDbType = SqlDbType.VarChar;
                parTextobuscar.Size = 50;
                parTextobuscar.Value = Producto.TextoBuscar;
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
