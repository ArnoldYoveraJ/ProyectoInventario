using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NOrden
    {
        public static string Ingresar(DateTime fecha,string tipo_comp, int cod_usu,int cod_prov,string estado,DataTable dtdet)
        {
            DOrden objo = new DOrden();
            objo.Fecha = fecha;
            objo.Tipo_Comprobante = tipo_comp;
            objo.Cod_Usu = cod_usu;
            objo.Cod_Prov = cod_prov;
            objo.Estado = estado;
            List<DDetalle_Orden> det = new List<DDetalle_Orden>();
            foreach(DataRow row in dtdet.Rows)
            {
                DDetalle_Orden detalle = new DDetalle_Orden();
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_ini"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_ini"].ToString());
                //detalle.Cod_Orden = Convert.ToInt32(row["cod_orden"].ToString());
                detalle.Cod_Pro = Convert.ToInt32(row["cod_pro"].ToString());
                det.Add(detalle);
            }
            return objo.Insertar(objo,det);
        }

        public static string Anular(int cod_ord)
        {
            DOrden objo = new DOrden();
            objo.Cod_Orden = cod_ord;
            return objo.Anular(objo);
        }

        public static DataTable Mostrar()
        {
            return new DOrden().Mostrar();
        }

        public static DataTable BuscarFechas(string fecha1, string fecha2)
        {
            DOrden objo = new DOrden();
            return objo.Buscar_orden_ingreso_porfecha(fecha1, fecha2);
        }

        public static DataTable Mostrar_Detalle(string fecha1)
        {
            DOrden objo = new DOrden();
            return objo.Mostrar_Detalle_Ingreso(fecha1);
        }
    }
}
