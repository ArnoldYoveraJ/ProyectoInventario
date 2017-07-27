using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTrabajador
    {
        //Verificar en caso error: Insertar es INT y Editar static string 
        public static string Insertar(string nom, string ape, string dni, string email, string anexo, int cod_area, int cod_emp)
        {
            DTrabajador dt = new DTrabajador();
            dt.Nombres = nom;
            dt.Apellidos = ape;
            dt.DNI = dni;
            dt.Email = email;
            dt.Anexo = anexo;
            dt.Cod_Area = cod_area;
            dt.Cod_Empresa = cod_emp;
            return dt.Insertar_Trabajador(dt);
        }

        public static string Editar(int cod_tra,string nom, string ape, string dni, string email, string anexo, int cod_area, int cod_emp)
        {
            DTrabajador objt = new DTrabajador();
            objt.Cod_Trabajador = cod_tra;
            objt.Nombres = nom;
            objt.Apellidos = ape;
            objt.DNI = dni;
            objt.Email = email;
            objt.Anexo = anexo;
            objt.Cod_Area = cod_area;
            objt.Cod_Empresa = cod_emp;
            return objt.Editar_Trabajador(objt);
        }

        public static string Eliminar(int cod_tra)
        {
            DTrabajador objt = new DTrabajador();
            objt.Cod_Trabajador = cod_tra;
            return objt.Eliminar_Trabajador(objt);
        }

        public static DataTable Mostrar()
        {
            /*DTrabajador objt = new DTrabajador();
            return objt.Mostrar();*/
            return new DTrabajador().Mostrar();
        }

        public static DataTable Buscar(string textob)
        {
            DTrabajador objt = new DTrabajador();
            objt.Textobuscar=textob;
            return objt.Buscar(objt);
        }

        public static DataTable Mostar_empresa()
        {
            return new DTrabajador().Mostrar_Empresa();
        }
    }
}