using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTrabajador
    {
        //Verificar en caso error: Insertar es INT y Editar static string 
        public int Insertar(DTrabajador trabajador)
        {
            DTrabajador dt = new DTrabajador();
            return Convert.ToInt32(dt.Insertar_Trabajador(trabajador));
        }

        public static string Editar(DTrabajador trabajador)
        {
            DTrabajador objt = new DTrabajador();
            return objt.Editar_Trabajador(trabajador);
        }

        public static string Eliminar(int cod_tra)
        {
            DTrabajador objt = new DTrabajador();
            objt.Cod_Trabajador = cod_tra;
            return objt.Eliminar_Trabajador(objt);
        }

        public static DataTable Mostrar()
        {
            DTrabajador objt = new DTrabajador();
            return objt.Mostrar();
        }

        public static DataTable Buscar(string textob)
        {
            DTrabajador objt = new DTrabajador();
            objt.Textobuscar=textob;
            return objt.Buscar(objt);
        }
    }
}