using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Datos;
using Inventario.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Inventario.Negocio
{
    public class NUsuario
    {
        public List<Usuario> Listar()
        {
            DUsuario us = new DUsuario();
            return us.Listar();
        }
        public int Registrar(Usuario us)
        {
            DUsuario dus = new DUsuario();
            return dus.RegistrarUsuario(us);
        }

    }


}
