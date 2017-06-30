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
    public partial class FrmVistaProductoIngreso : Form
    {
        public FrmVistaProductoIngreso()
        {
            InitializeComponent();
        }
        //ocultar columnas
        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
            this.dgvlistado.Columns[12].Visible = false;
            this.dgvlistado.Columns[14].Visible = false;
            //corregir el procedimiento almacenado para traer el nombre la categoria y el nombre del trabajador. 
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource =NProducto.Mostrar();
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
        private void FrmVistaProductoIngreso_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar_nombre();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngresos form = FrmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_producto"].Value);
            par2 = Convert.ToString(dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            form.setProducto(par1, par2);
            this.Hide();
        }
    }
}
