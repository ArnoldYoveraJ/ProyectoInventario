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
    public partial class FrmVistaBajaProductoMovimiento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmVistaBajaProductoMovimiento()
        {
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //ocultar columnas
        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
            this.dgvlistado.Columns[8].Visible = false;
            this.dgvlistado.Columns[10].Visible = false;
            this.dgvlistado.Columns[11].Visible = false;
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NMovimiento.Mostrar_Movimiento_Vista();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar()
        {
            this.dgvlistado.DataSource = NMovimiento.buscar_movimientos_por_trabajador(this.txtApe.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros" + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmVistaBajaProductoMovimiento_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            FrmBajaProducto objbaja = FrmBajaProducto.GetInstancia();
            string p1, p2, p3, p4, p5;
            byte[] imagenBuffer;

            p1 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_mov"].Value);
            p2 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_producto"].Value);
            p3 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            p4 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["marca"].Value);
            p5 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["serie"].Value);
            imagenBuffer = (byte[])this.dgvlistado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            objbaja.setMovimientosEquipos(p1, p2, p3, p4, p5,imagenBuffer);
            this.Hide();
        }
    }
}
