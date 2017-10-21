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
    public partial class FrmReporteProveedores : Form
    {
        public FrmReporteProveedores()
        {
            InitializeComponent();
        }

        private void FrmReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spmostrar_proveedor' Puede moverla o quitarla según sea necesario.
            this.spmostrar_proveedorTableAdapter.Fill(this.dsPrincipal.spmostrar_proveedor);
            this.reportViewer1.RefreshReport();

        }
    }
}
