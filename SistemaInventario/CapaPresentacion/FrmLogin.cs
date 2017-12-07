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
        public static string Nombre_Usuario;//para enviar el Nombre de usuario al frmprincipal
        public static string Tipo_Usuario;//para enviar el Tipo de usuario al frmprincipal
        Validar v = new Validar(); // Instanciar la clase Validar
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
          /*  if (txtusu.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Usuario", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(txtcon.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una Contraseña", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            //obtener contraseña a través del Usuario
            DataTable datos1 = CapaNegocio.NUsuario.ObtenerContrasena(txtusu.Text);

           /* string contra,contraIng;
            contra = datos1.Rows[0][0].ToString(); //contraseña de BD
            contraIng = Seguridad.Encriptar(txtcon.Text);//Encriptar contraseña ingresada*/

         /*  if(contraIng!= contra) //si contra encriptada es igual a la obtenida en la BD
            {
                MessageBox.Show("Error al autenticarse", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            //obtener Usuario a traves del usuario y la contraseña encriptada ingresada. 
            DataTable datos = CapaNegocio.NUsuario.Login(this.txtusu.Text, this.txtcon.Text/* contraIng*/);
            //validar si esxiste el usuario

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al Sistema", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bienvenido al Sistema " + "'" + datos.Rows[0][1].ToString() + "'", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPrincipal frm = new FrmPrincipal();
                frm.cod_usu = datos.Rows[0][0].ToString();
                frm.nom_com = datos.Rows[0][1].ToString();
                frm.tipo = datos.Rows[0][2].ToString();
                Nombre_Usuario= datos.Rows[0][1].ToString();//Obtenemos el Nombre de usuario para pasarlo a FrmPrincipal
                Tipo_Usuario = frm.tipo;//Obtenemos el Tipo de usuario para pasarlo a FrmPrincipal
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

        private void txtusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

    }
}
