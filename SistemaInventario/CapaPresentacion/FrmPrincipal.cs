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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string cod_usu="";
        public string nom_com = "";
        public string tipo = "";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          FrmProducto frmp = FrmProducto.GetInstancia();
            //FrmProducto frmp = new FrmProducto();
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            string G;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmpro = new FrmProveedores();
            frmpro.MdiParent = this;
            frmpro.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajador frmtra = new FrmTrabajador();
            frmtra.MdiParent = this;
            frmtra.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusu = new FrmUsuario();
            frmusu.MdiParent = this;
            frmusu.Show();
        }

        private void GestionUsuario()
        {
            if (tipo == "Administrador")
            {
                this.mnuconsultas.Enabled = true;
                this.mnumantenimiento.Enabled = true;
                this.mnuSistema.Enabled=true;
                this.mnureportes.Enabled = true;
                this.mnuherramientas.Enabled = true;
            }else if(tipo == "Invitado")
            {
                this.mnuconsultas.Enabled = true;
                this.mnumantenimiento.Enabled = false;
                this.mnuSistema.Enabled = true;
                this.mnureportes.Enabled = false;
                this.mnuherramientas.Enabled = true;
            }else
            {
                this.mnuconsultas.Enabled = false;
                this.mnumantenimiento.Enabled = false;
                this.mnuSistema.Enabled = false;
                this.mnureportes.Enabled = false;
                this.mnuherramientas.Enabled = false;
            }
        }

       /* private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmp = new FrmProveedores();
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajador frmt = new FrmTrabajador();
            frmt.MdiParent = this;
            frmt.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmu = new FrmUsuario();
            frmu.MdiParent = this;
            frmu.Show();
        }*/

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmc = new FrmCategoria();
            frmc.MdiParent = this;
            frmc.Show();
        }

        private void ingresoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos frm = FrmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.cod_usu = Convert.ToInt32(this.cod_usu);
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArea frma = new FrmArea();
            frma.MdiParent = this;
            frma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmProducto frmp = FrmProducto.GetInstancia();
            //FrmProducto frmp = new FrmProducto();
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProducto frmp = FrmProducto.GetInstancia();
            //FrmProducto frmp = new FrmProducto();
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProveedores frmpro = new FrmProveedores();
            frmpro.MdiParent = this;
            frmpro.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusu = new FrmUsuario();
            frmusu.MdiParent = this;
            frmusu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmCategoria frmc = new FrmCategoria();
            frmc.MdiParent = this;
            frmc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmArea frma = new FrmArea();
            frma.MdiParent = this;
            frma.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
            string G;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTrabajador frmtra = new FrmTrabajador();
            frmtra.MdiParent = this;
            frmtra.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmIngresos frm = FrmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.cod_usu = Convert.ToInt32(this.cod_usu);
        }
    }
}
