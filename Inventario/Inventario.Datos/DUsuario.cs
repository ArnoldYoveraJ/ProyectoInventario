using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Inventario.Datos
{
    public class DUsuario
    {
        //Usuario us ;
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            CadenaConexion cn = new CadenaConexion();
            
            using (SqlConnection con = new SqlConnection(cn.cad_conex))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LISTAR_USUARIO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario us = new Usuario((int)dr["COD_USU"], (string)dr["NOM_USU"],
                             (int)dr["TIPO"], (int)dr["ESTADO"]);
                        lista.Add(us);
                    }
                }
            }
            return lista;
        }

        public int RegistrarUsuario(Usuario us)
        {
            CadenaConexion cn= new CadenaConexion();
            int n = -1;
            using(SqlConnection con= new SqlConnection(cn.cad_conex))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOM", us.Nom_usu);
                cmd.Parameters.AddWithValue("@CONTRA", us.Contra);
                cmd.Parameters.AddWithValue("@TIPO", us.Tipo);
                cmd.Parameters.AddWithValue("@ESTADO", us.Estado);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }


    }
}
