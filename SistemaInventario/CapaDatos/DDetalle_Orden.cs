using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DDetalle_Orden
    {
        private int _Cod_Detorde;

        public int Cod_Detorde
        {
            get { return _Cod_Detorde; }
            set { _Cod_Detorde = value; }
        }
        private int _Stock_Inicial;

        public int Stock_Inicial
        {
            get { return _Stock_Inicial; }
            set { _Stock_Inicial = value; }
        }
        private int _Stock_Actual;

        public int Stock_Actual
        {
            get { return _Stock_Actual; }
            set { _Stock_Actual = value; }
        }
        private int _Cod_Orden;

        public int Cod_Orden
        {
            get { return _Cod_Orden; }
            set { _Cod_Orden = value; }
        }
        private int _Cod_Pro;

        public int Cod_Pro
        {
            get { return _Cod_Pro; }
            set { _Cod_Pro = value; }
        }

        public DDetalle_Orden() { }

        public DDetalle_Orden(int cod_detord, int stock_ini, int stock_act, int cod_orden, int cod_pro)
        {
            this.Cod_Detorde = cod_detord;
            this.Stock_Inicial = stock_ini;
            this.Stock_Actual = stock_act;
            this.Cod_Orden = cod_orden;
            this.Cod_Pro = cod_pro;
        }

        public string Insertar(DDetalle_Orden Detalle_Orden,ref SqlConnection SqlCon,ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand sql1 = new SqlCommand();
                sql1.Connection = SqlCon;
                sql1.Transaction = SqlTra;
                sql1.CommandText = "spingresar_detalle_orden";
                sql1.CommandType = CommandType.StoredProcedure;

                //modificar el BD el campo cod_detord como campo de salida.
                SqlParameter parcod_det= new SqlParameter();
                parcod_det.ParameterName = "@cod_detord";
                parcod_det.SqlDbType = SqlDbType.Int;
                parcod_det.Direction = ParameterDirection.Output;
                sql1.Parameters.Add(parcod_det);

                sql1.Parameters.AddWithValue("@stock_ini", Detalle_Orden.Stock_Inicial);
                sql1.Parameters.AddWithValue("@stock_act", Detalle_Orden.Stock_Actual);
                sql1.Parameters.AddWithValue("@cod_orden", Detalle_Orden.Cod_Orden);
                sql1.Parameters.AddWithValue("@cod_pro", Detalle_Orden.Cod_Pro);
                rpta = sql1.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            return rpta;
        }
    }
}
