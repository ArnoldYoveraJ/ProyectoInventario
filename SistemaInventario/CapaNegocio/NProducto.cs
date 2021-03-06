﻿using System;
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
        string ram, string so, byte[] imagen, string tipo_estado, int estado, string desc, int cod_cat,string nom_equi,string mac,
            string dom, string licencia_win,string licencia_of,string licencia_aut)
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
            objp.Tipo_Estado = tipo_estado;
            objp.Estado = estado;
            objp.Descripcion = desc;
            objp.Cod_Cat = cod_cat;

            objp.Nombre_Equi = nom_equi;
            objp.Mac = mac;
            objp.Dominio = dom;
            objp.Licencia_Win = licencia_win;
            objp.Licencia_Of = licencia_of;
            objp.Licencia_Aut = licencia_aut;

            return objp.Insertar(objp);
        }

        public static string Editar(int cod, string nom_prod, string marca, string modelo, string serie, string procesador, string dd,
     string ram, string so, byte[] imagen, string tipo_estado, int estado, string desc, int cod_cat, string nom_equi, string mac,
            string dom, string licencia_win, string licencia_of, string licencia_aut)
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
            objp1.Tipo_Estado = tipo_estado;
            objp1.Estado = estado;
            objp1.Descripcion = desc;
            objp1.Cod_Cat = cod_cat;

            objp1.Nombre_Equi = nom_equi;
            objp1.Mac = mac;
            objp1.Dominio = dom;
            objp1.Licencia_Win = licencia_win;
            objp1.Licencia_Of = licencia_of;
            objp1.Licencia_Aut = licencia_aut;
            return objp1.Editar(objp1);
        }

        public static string Eliminar(int cod)
        {
            DProducto obj1 = new DProducto();
            obj1.Cod_producto = cod;
            return obj1.Eliminar(obj1);
        }

        public static DataTable Mostrar()
        { 
            return new DProducto().Mostrar();
        }

        public static DataTable Buscar_Nombre(string texto)
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar(obj1);
        }

        public static DataTable Buscar_Producto_Marca(string texto)
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar_producto_marca(obj1);
        }

        public static DataTable Buscar_Producto_Serie(string texto)
        {
            DProducto obj1 = new DProducto();
            obj1.TextoBuscar = texto;
            return obj1.Buscar_producto_serie(obj1);
        }

        public static DataTable Mostrar_Prod_Dispo()
        { 
            return new DProducto().Mostrar_Productos_disponibles();
        }
    }
}
