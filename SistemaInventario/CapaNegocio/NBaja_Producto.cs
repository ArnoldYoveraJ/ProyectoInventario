using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public  class NBaja_Producto
    {
        public static string Insertar(DateTime fecha, string explicacion, string estado, int cod_producto)
        {
            DBaja_Producto objbp = new DBaja_Producto();
            objbp.Fecha = fecha;
            objbp.Explicacion = explicacion;
            objbp.Estado = estado;
            objbp.Cod_Producto = cod_producto;
            return objbp.Insertar(objbp);
        }

        public static string Editar(int cod_baja,DateTime fecha, string explicacion, string estado, int cod_producto)
        {
            DBaja_Producto objbp = new DBaja_Producto();
            objbp.Cod_Baja = cod_baja;
            objbp.Fecha = fecha;
            objbp.Explicacion = explicacion;
            objbp.Estado = estado;
            objbp.Cod_Producto = cod_producto;
            return objbp.Editar(objbp);
        }

        public static string Eliminar(int cod_baja,int cod_pro)
        {
            DBaja_Producto objbp = new DBaja_Producto();
            objbp.Cod_Baja = cod_baja;
            objbp.Cod_Producto = cod_pro;
            return objbp.Eliminar(objbp);
        }

        public static DataTable Mostrar()
        {
            return new DBaja_Producto().Mostrar();
        }

        public static DataTable Buscar_Baja_Productos(DateTime fecha_ini, DateTime fecha_fin)
        {
            return new DBaja_Producto().Buscar_Baja_Productos(fecha_ini, fecha_fin);
        }

    }
}
