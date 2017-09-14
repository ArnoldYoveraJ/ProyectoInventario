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
        public static string insertar_movimiento(DateTime fecha, string condicion, int cod_usu,
            int cod_trabajador, int cod_producto, string estado, string motivo, DateTime fecha_dev,
            string condicion_rec)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Fecha = fecha;
            objmov.Condicion = condicion;
            objmov.Cod_usu = cod_usu;
            objmov.Cod_trabajador = cod_trabajador;
            objmov.Cod_producto = cod_producto;
            objmov.Estado = estado;
            objmov.Motivo = motivo;
            objmov.Fecha_dev = fecha_dev;
            objmov.Condicion_recibido = condicion_rec;
            return objmov.insertar_movimiento(objmov);
        }

        public static string editar_movimiento(int cod_mov,DateTime fecha, string condicion, int cod_usu,
            int cod_trabajador, int cod_producto, string estado, string motivo, DateTime fecha_dev,
            string condicion_rec)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Cod_mov = cod_mov;
            objmov.Fecha = fecha;
            objmov.Condicion = condicion;
            objmov.Cod_usu = cod_usu;
            objmov.Cod_trabajador = cod_trabajador;
            objmov.Cod_producto = cod_producto;
            objmov.Estado = estado;
            objmov.Motivo = motivo;
            objmov.Fecha_dev = fecha_dev;
            objmov.Condicion_recibido = condicion_rec;
            return objmov.editar_movimiento(objmov);
        }

        public static string anular_movimiento(int cod_mov, int cod_pro, string cond_rec)
        {
            DMovimiento objmov = new DMovimiento();
            objmov.Cod_mov = cod_mov;
            objmov.Cod_producto = cod_pro;
            objmov.Condicion_recibido = cond_rec;
            return objmov.anular_movimiento(objmov);
        }

        public static DataTable mostrar_movimiento()
        {
            return new DMovimiento().Mostrar();
        }

        public static DataTable mostrar_productos_por_trabajador()//Muestra los productos asignados por trabajador
        {
            return new DMovimiento().Mostrar_productos_por_trabajador();
        }

        public static DataTable buscar_movimiento(DateTime fecha_ini, DateTime fecha_fin)
        {
            return new DMovimiento().Buscar_por_fechas(fecha_ini,fecha_fin);
        }
    }
}
