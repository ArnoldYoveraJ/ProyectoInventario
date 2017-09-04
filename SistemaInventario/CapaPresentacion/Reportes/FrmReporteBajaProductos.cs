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
    public partial class FrmReporteBajaProductos : Form
    {
        public FrmReporteBajaProductos()
        {
            InitializeComponent();
            //comentario
        }

        private void FrmReporteBajaProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.spmostrar_baja_producto' table. You can move, or remove it, as needed.
            this.spmostrar_baja_productoTableAdapter.Fill(this.dsPrincipal.spmostrar_baja_producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
