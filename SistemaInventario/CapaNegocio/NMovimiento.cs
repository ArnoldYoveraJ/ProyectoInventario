using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NMovimiento
    {
        public static string insertar_movimiento(DateTime fecha,string condicion,int cod_usu,int cod_trabajador,int cod_producto)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Fecha = fecha;
            objmov.Condicion =condicion;
            objmov.Cod_usu = cod_usu;
            objmov.Cod_trabajador = cod_trabajador;
            objmov.Cod_producto = cod_producto;
            return objmov.insertar_movimiento(objmov);
        }

        public static string editar_movimiento(int cod_mov,DateTime fecha, string condicion, int cod_usu, int cod_trabajador, int cod_producto)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Cod_mov = cod_mov;
            objmov.Fecha = fecha;
            objmov.Condicion = condicion;
            objmov.Cod_usu = cod_usu;
            objmov.Cod_trabajador = cod_trabajador;
            objmov.Cod_producto = cod_producto;
            return objmov.editar_movimiento(objmov);
        }

        public static string eliminar_movimiento(int cod_mov)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Cod_mov = cod_mov;
            return objmov.eliminar_movimiento(objmov);
        }

        public static DataTable mostrar_movimiento()
        {
            return new DMovimiento().Mostrar();
        }

        public static DataTable mostrar_movimiento(string fecha_ini,string fecha_fin)
        {
            return new DMovimiento().Buscar_por_fechas(fecha_ini,fecha_fin);
        }
    }
}
