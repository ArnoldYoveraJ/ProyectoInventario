using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inventario.Entidades
{
    public class Usuario : Inventario.Entidades.IUsuario
    {
       int cod_usu;
        public int Cod_usu
        {
            get { return cod_usu; }
            set { cod_usu = value; }
        }

        string nom_usu;

        public string Nom_usu
        {
            get { return nom_usu; }
            set { nom_usu = value; }
        }
        string contra;

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }
        int tipo;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Usuario(int cod_usu,string Nom_usu,string Contra,int Tipo,int Estado)
        {
            this.Cod_usu = cod_usu;
            this.Nom_usu = Nom_usu;
            this.Contra = Contra;
            this.Tipo = Tipo;
            this.Estado = Estado;
        }

        public Usuario(int cod_usu, string Nom_usu, int Tipo, int Estado)
        {
            this.Cod_usu = cod_usu;
            this.Nom_usu = Nom_usu;
            this.Tipo = Tipo;
            this.Estado = Estado;
        }
        public Usuario(string _nom_usu,string _contra, int _tipo, int _estado)
        {
            this.Nom_usu = _nom_usu;
            this.contra = _contra;
            this.Tipo = Tipo;
            this.Estado = Estado;
        }
    }
}
