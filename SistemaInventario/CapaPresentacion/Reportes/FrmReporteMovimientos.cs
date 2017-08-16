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
    public partial class FrmReporteMovimientos : Form
    {
        public FrmReporteMovimientos()
        {
            InitializeComponent();
        }

        private void FrmReporteMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SP_MOSTRAR_MOVIMIENTO' Puede moverla o quitarla según sea necesario.
            this.SP_MOSTRAR_MOVIMIENTOTableAdapter.Fill(this.dsPrincipal.SP_MOSTRAR_MOVIMIENTO);

            this.reportViewer1.RefreshReport();
        }
    }
}
