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
    public partial class FrmReporte_BajaProducto : Form
    {
        public FrmReporte_BajaProducto()
        {
            InitializeComponent();
        }

        private void FrmReporte_BajaProducto_Load(object sender, EventArgs e)
        {
            this.spmostrar_baja_productoTableAdapter.Fill(this.dsPrincipal.spmostrar_baja_producto);
            this.reportViewer1.RefreshReport();
        }
    }
}
