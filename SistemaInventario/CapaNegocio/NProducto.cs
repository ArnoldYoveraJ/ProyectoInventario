using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NProducto
    {
        public static string Insertar(string nom_prod, string marca, string modelo, string serie, string procesador, string dd, 
        string ram, string so, byte[] imagen, int estado, string desc, int cod_cat,int cod_tra)
        {
            DProducto objp = new DProducto();
            objp.Nom_Producto = nom_prod;
            objp.Marca = marca;
            objp.Modelo_Placa = modelo;
            objp.Serie = serie;
            objp.Procesador = procesador;
            objp.DD = dd;
            objp.Ram = ram;
            objp.SO = so;
            objp.Imagen = imagen;
            objp.Estado = estado;
            objp.Descripcion = desc;
            objp.Cod_Cat = cod_cat;
            objp.Cod_Trabajador = cod_tra;
            return objp.Insertar(objp);
        }

        public static string Editar(int cod, string nom_prod, string marca, string modelo, string serie, string procesador, string dd,
     string ram, string so, byte[] imagen, int estado, string desc, int cod_cat, int cod_tra)
        {
            DProducto objp1 = new DProducto();
            objp1.Cod_producto = cod;
            objp1.Nom_Producto = nom_prod;
            objp1.Marca = marca;
            objp1.Modelo_Placa = modelo;
            objp1.Serie = serie;
            objp1.Procesador = procesador;
            objp1.DD = dd;
            objp1.Ram = ram;
            objp1.SO = so;
            objp1.Imagen = imagen;
            objp1.Estado = estado;
            objp1.Descripcion = desc;
            objp1.Cod_Cat = cod_cat;
            objp1.Cod_Trabajador = cod_tra;
            return objp1.Editar(objp1);
        }

        public static string Eliminar(int cod)
        {
            DProducto obj1 = new DProducto();
            obj1.Cod_producto = cod;
            return obj1.Eliminar(obj1);
        }

        public static DataTable Mostrar()
        { //agregar static
           /* DProducto obj1= new DProducto();
            return obj1.Mostrar();
            */
            return new DProducto().Mostrar();
        }

        public static DataTable Buscar_Nombre(string texto)//agregar static
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar(obj1);
        }

        public static DataTable Buscar_Producto_Marca(string texto)//agregar static
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar_producto_marca(obj1);
        }

        public static DataTable Buscar_Producto_Serie(string texto)//agregar static
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar_producto_serie(obj1);
        }
    }
}
