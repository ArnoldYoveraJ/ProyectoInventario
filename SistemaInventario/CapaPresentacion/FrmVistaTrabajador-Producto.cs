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
    public partial class FrmVistaTrabajador_Producto : Form
    {
       /* private bool IsNuevo = false;
        private bool IsEditar = false;*/

        
        public FrmVistaTrabajador_Producto()
        {
            InitializeComponent();
        }
        //ocultar columnas
        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NTrabajador.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar_nombre()
        {
            this.dgvlistado.DataSource = NTrabajador.Buscar(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }
        private void FrmVistaTrabajador_Producto_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_nombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar_nombre();
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            //codigo Nuevo
            FrmProducto frm = FrmProducto.GetInstancia();
            string p1, p2;

            p1 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["COD_TRABAJADOR"].Value);
            p2 = Convert.ToString(this.dgvlistado.CurrentRow.Cells["NOMBRES"].Value);
            frm.setTrabajador(p1, p2);
            this.Hide();//para ocultar este formulario
        }
    }
}
