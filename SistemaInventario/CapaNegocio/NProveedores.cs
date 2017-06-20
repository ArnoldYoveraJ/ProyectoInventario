using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NProveedores
    {
        public static string Insertar(string raz_soc, string sect_com, string tip_doc, string num_doc, string dir, string tel, string email)
        {
            DProveedor objp = new DProveedor();
            objp.Razon_social = raz_soc;
            objp.Sector_comercial = sect_com;
            objp.Tipo_doc = tip_doc;
            objp.Num_doc = num_doc;
            objp.Direccion = dir;
            objp.Telefono = tel;
            objp.Email = email;
            return objp.Insertar(objp);
        }

        public static string Editar(int cod_prov, string raz_soc, string sect_com, string tip_doc, string num_doc, string dir, string tel, string email)
        {
            DProveedor objp = new DProveedor();
            objp.Cod_prov = cod_prov;
            objp.Razon_social = raz_soc;
            objp.Sector_comercial = sect_com;
            objp.Tipo_doc = tip_doc;
            objp.Num_doc = num_doc;
            objp.Direccion = dir;
            objp.Telefono = tel;
            objp.Email = email;
            return objp.Insertar(objp);
        }

        public static string Eliminar(int cod_prov)
        {
              DProveedor objp = new DProveedor();
              objp.Cod_prov=cod_prov;
              return objp.Eliminar(objp);
        }

        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DProveedor objc = new DProveedor();
            objc.Texto_buscar = textobuscar;
            return objc.Buscar(objc);
        }

    }
}
