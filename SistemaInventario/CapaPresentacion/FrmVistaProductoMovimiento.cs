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
    public partial class FrmVistaProductoMovimiento : Form
    {
        public FrmVistaProductoMovimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nombre();
            }
            else if (cboelegir.Text.Equals("Marca"))
            {
                buscar_producto_marca();
            }
            else if (cboelegir.Text.Equals("Serie"))
            {
                buscar_producto_serie();
            }
        }

        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
            this.dgvlistado.Columns[12].Visible = false;
            this.dgvlistado.Columns[14].Visible = false;           
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NProducto.Mostrar_Prod_Dispo();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar_nombre()
        {
            this.dgvlistado.DataSource = NProducto.Buscar_Nombre(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        public void buscar_producto_marca()
        {
            this.dgvlistado.DataSource = NProducto.Buscar_Producto_Marca(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        public void buscar_producto_serie()
        {
            this.dgvlistado.DataSource = NProducto.Buscar_Producto_Serie(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }
        private void FrmVistaProductoIngreso_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void FrmVistaProductoMovimiento_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nombre();
            }
            else if (cboelegir.Text.Equals("Marca"))
            {
                buscar_producto_marca();
            }
            else if (cboelegir.Text.Equals("Serie"))
            {
                buscar_producto_serie();
            }
        }

        private void FrmVistaProductoMovimiento_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            //Muestra en Formulario FrmMovimiento
            FrmMovimiento frmmov = FrmMovimiento.GetInstancia();
            string a1, a2;
            a1 = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_producto"].Value);
            a2 = Convert.ToString(dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            frmmov.setProducto(a1, a2);
            this.Hide();
        }
    }
}
