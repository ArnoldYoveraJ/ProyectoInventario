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
    public partial class FrmReporteUsuarios : Form
    {
        public FrmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void FrmReporteUsuarios_Load(object sender, EventArgs e)
        {
            this.spmostrar_usuarioTableAdapter.Fill(this.dsPrincipal.spmostrar_usuario);
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spmostrar_usuarioTableAdapter.Fill(this.dsPrincipal.spmostrar_usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
