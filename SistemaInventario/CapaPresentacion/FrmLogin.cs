using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblhora.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            DataTable datos = CapaNegocio.NUsuario.Login(this.txtusu.Text, this.txtcon.Text);
            //validar di esxiste el usuario

            if(datos.Rows.Count==0)
            {
                MessageBox.Show("No tiene acceso al Sistema", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.cod_usu = datos.Rows[0][0].ToString();
                frm.nom_com = datos.Rows[0][1].ToString();
                frm.tipo = datos.Rows[0][2].ToString();
                frm.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comentario
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btningresar.PerformClick();
            }
        }

    }
}
