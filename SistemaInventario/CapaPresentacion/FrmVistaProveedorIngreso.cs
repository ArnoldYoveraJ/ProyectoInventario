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
    public partial class FrmVistaProveedorIngreso : Form
    {
        public FrmVistaProveedorIngreso()
        {
            InitializeComponent();
        }
        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NProveedor.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar_razon_social()
        {
            //Video 18: modificar en caso error

            this.dgvlistado.DataSource = NProveedor.Buscar_razon_social(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void buscar_num_doc()
        {
            this.dgvlistado.DataSource = NProveedor.Buscar_numdoc(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }
        private void FrmVistaProveedorIngreso_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Documento"))
            {
                buscar_razon_social();
            }
            else if (cboelegir.Text.Equals("Numero"))
            {
                buscar_num_doc();
            }  
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngresos form = FrmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_prov"].Value);
            par2 = Convert.ToString(dgvlistado.CurrentRow.Cells["razon_social"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }

        private void cboelegir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
