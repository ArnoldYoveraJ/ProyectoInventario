using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NArea
    {
        public static string Insertar(string nombre)
        {
            DArea obja = new DArea();
            obja.Nom_Area = nombre;
            return obja.Ingresar(obja);
        }

        public static string Editar(int cod,string nom)
        {
            DArea obja = new DArea();
            obja.Cod_Area = cod;
            obja.Nom_Area = nom;
            return obja.Editar(obja);
        }

        public static string Eliminar(int cod)
        {
            DArea obja = new DArea();
            obja.Cod_Area = cod;
            return obja.Eliminar(obja);
        }

        public static DataTable Mostrar()
        {
            DArea obja = new DArea();
            return obja.Mostrar();
        }

        public static DataTable Buscar(string texto_b) //static
        {
            DArea obja = new DArea();
            obja.Texto_buscar = texto_b;
            return obja.Buscar(obja);
        }
    }
}
