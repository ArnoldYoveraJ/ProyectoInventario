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
            return new DTrabajador().Mostrar();
        }

        public static DataTable Buscar(string textob)
        {
            DTrabajador objt = new DTrabajador();
            objt.Textobuscar=textob;
            return objt.Buscar(objt);
        }

        public static DataTable Buscar_Trabajador_dni(string texto)
        {
            DTrabajador objtra = new DTrabajador();
            objtra.Textobuscar = texto;
            return objtra.Buscar_Trabajador_dni(objtra);
        }

        public static DataTable Mostar_empresa()
        {
            return new DTrabajador().Mostrar_Empresa();
        }
        public static DataTable buscar_productos_por_trabajador(string texto)
        {
            return new DTrabajador().Buscar_Productos_por_Trabajador(texto);
        }

        public static DataTable validar_existe_trabajador(string dni)
        {
            DTrabajador objt = new DTrabajador();
            objt.DNI = dni;
            return objt.Validar_existe_Trabajador(objt);
        }


        public static DataTable ObtenerContrasena(string usu)
        {
            DUsuario obju = new DUsuario();
            obju.Usuario = usu;
            return obju.ObtenerContrasena(obju);
        }
    }
}