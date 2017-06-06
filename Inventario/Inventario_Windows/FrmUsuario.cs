using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Entidades;
using Inventario.Negocio;

namespace Inventario_Windows
{
    public partial class FrmUsuario : Form
    {
        List<Usuario> lista = new List<Usuario>();
        NUsuario n_usu = new NUsuario();
        Usuario us;
        bool _nuevo=false;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            lista = n_usu.Listar();
            if(lista.Count>0)
            {
                dgvdatos.Rows.Clear();
                for(int i=0; i<lista.Count;i++)
                {
                    dgvdatos.Rows.Add(lista[i].Cod_usu, lista[i].Nom_usu,
                        lista[i].Tipo, lista[i].Estado);
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = -1;
            /*Usuario u = new Usuario(txtnom.Text, txtcontra.Text,
                cbotipo.int, cboest.int);*/
            NUsuario nu= new NUsuario();
            n=nu.Registrar(txtnom.Text, txtcontra.Text,
                cbotipo, cboest);
        }
    }
}
