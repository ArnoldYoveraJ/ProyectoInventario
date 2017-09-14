using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmBuscarProductos_Trabajador : Form
    {
        public FrmBuscarProductos_Trabajador()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarProductos();
        }

        public void Mostrar() //Muestra los productos asignados por trabajador
        {
            this.dgvlistado.DataSource = NMovimiento.mostrar_productos_por_trabajador();
            this.ocultarcolumnas();
            this.lbltotal.Text = "Total de Registros: " + dgvlistado.Rows.Count;
        }

        public void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
        }

        public void buscarProductos()
        {
            this.dgvlistado.DataSource = NTrabajador.buscar_productos_por_trabajador(this.txtbuscar.Text);
            this.ocultarcolumnas();
            this.lbltotal.Text = "Total de Registros : " + dgvlistado.Rows.Count;
        }

        private void FrmBuscarProductos_Trabajador_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarProductos();
        }
    }
}
