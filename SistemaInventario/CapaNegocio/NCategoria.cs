using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCategoria
    {
        //llamamos al metodo insertar de la capa datos
        public static string Insertar(string nombre)
        {
           DCategoria objc = new DCategoria();
           objc.Nom_cat = nombre;
           return objc.Insertar(objc);
        }

        public static string Editar(int cod_cat, string nombre)
        {
            DCategoria objc = new DCategoria();
            objc.Cod_cat = cod_cat;
            objc.Nom_cat = nombre;
            return objc.Editar(objc);
        }

        public static string Eliminar(int cod_cat)
        {
            DCategoria objc = new DCategoria();
            objc.Cod_cat = cod_cat;
            return objc.Eliminar(objc);
        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria objc = new DCategoria();
            objc.TextoBuscar = textobuscar;
            return objc.Buscar(objc);
        }


    }

}
