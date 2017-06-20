using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NUsuario
    {
        public static string Insertar(string nom, string usu, string contra, string tipo, int est)
        {
            DUsuario obju = new DUsuario();
            obju.Nom_completo = nom;
            obju.Usuario = usu;
            obju.Contra = contra;
            obju.Tipo = tipo;
            obju.Estado = est;
            return obju.Insertar(obju);
        }

        public static string Editar(int cod, string nom, string usu, string contra, string tipo, int est)
        {
            DUsuario obju = new DUsuario();
            obju.Cod_usu = cod;
            obju.Nom_completo = nom;
            obju.Usuario = usu;
            obju.Contra = contra;
            obju.Tipo = tipo;
            obju.Estado = est;
            return obju.Insertar(obju);
        }

        public static string Eliminar(int cod)
        {
            DUsuario obju = new DUsuario();
            obju.Cod_usu = cod;
            return obju.Eliminar(obju);
        }

        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        public static DataTable Buscar_nombre(string texto)
        {
            DUsuario obju = new DUsuario();
            obju.Textobuscar = texto;
            return obju.Buscar_nombre(obju);
        }

        public static DataTable Buscar_usuario(string texto)
        {
            DUsuario obju = new DUsuario();
            obju.Textobuscar = texto;
            return obju.Buscar_usuario(obju);
        }
    }
}
