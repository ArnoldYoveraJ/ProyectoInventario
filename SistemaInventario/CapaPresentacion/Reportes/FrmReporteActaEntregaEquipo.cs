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
    public partial class FrmReporteActaEntregaEquipo : Form
    {
        int cod;
        public FrmReporteActaEntregaEquipo(int parcod)
        {
            InitializeComponent();
            cod = parcod;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmReporteActaEntregaEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.ReporteGenerarActaEntregaEquipo' Puede moverla o quitarla según sea necesario.
            this.reporteGenerarActaEntregaEquipoTableAdapter.Fill(this.dsPrincipal.ReporteGenerarActaEntregaEquipo,cod);
            this.reportViewer1.RefreshReport();
        }
    }
}
