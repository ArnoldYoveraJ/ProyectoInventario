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
    public partial class FrmIngresos : Form
    {
        public int cod_usu;
        private bool IsNuevo;
        private DataTable dtDetalle;

        private static FrmIngresos _instancia;
        public static FrmIngresos GetInstancia()
        {
            if(_instancia==null)
            {
                _instancia = new FrmIngresos();
            }
            return _instancia;
        }

        public FrmIngresos()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtproveedor, "Seleccione un Proveedor");
            this.ttmensaje.SetToolTip(this.txtpro, "Seleccione un Producto");
            this.ttmensaje.SetToolTip(this.cbotipo_compro, "Seleccione un Comprobante");
            this.ttmensaje.SetToolTip(this.txtstock, "Ingrese un Stock");
            this.txtcod_prov.Visible = false;
            this.txtcod_orden.Visible = false;
            this.txtproveedor.ReadOnly = true;
            this.txtpro.ReadOnly = true;
        }

        //Mostrar Mensaje de Confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventsario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar botones
        private void LimpiarBotones()
        {
            this.txtcod_orden.Text = string.Empty;
            this.txtcod_prov.Text = string.Empty;
            this.txtproveedor.Text = string.Empty;
            
        }

        private void LimpiarDetalle()
        {
            this.txtcod_pro.Text = string.Empty;
            this.txtpro.Text = string.Empty;
            this.txtstock.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_pro.ReadOnly = !valor;
            this.txtcod_orden.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtcod_prov.ReadOnly = !valor;
            this.txtproveedor.ReadOnly = !valor;
            this.txtpro.ReadOnly = !valor;
            this.txtstock.ReadOnly = !valor;
            this.cbotipo_compro.Enabled = valor;
            this.dtfecha.Enabled = valor;
            this.btnbuscar_pro.Enabled = valor;
            this.btnbuscar_producto.Enabled = valor;
            this.btnagre.Enabled = valor;
            this.btnquitar.Enabled = valor;
        }

        //Desactivar botones
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.habilitar(true);
                this.btnnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btncancelar.Enabled = true;
            }
            else
            {
                this.habilitar(false);
                this.btnnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btncancelar.Enabled = false;
            }
        }

        //ocultar columnas
        private void ocultarcolumnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
            //corregir el procedimiento almacenado para traer el nombre la categoria y el nombre del trabajador. 
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NOrden.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar_por_Fechas()
        {
            this.dgvlistado.DataSource = NOrden.BuscarFechas(this.dtfecha1.Value.ToString("dd/MM/yyyy"), this.dtfecha2.Value.ToString("dd/MM/yyyy"));
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void Mostrar_Detalle()
        {
            this.dgvlistado.DataSource = NOrden.Mostrar_Detalle(this.txtcod_orden.Text);
        }
        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            this.txtcod_orden.Visible = false;
        }

        private void FrmIngresos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        public void setProveedor(string cod_prov, string nombre)
        {
            this.txtcod_prov.Text = cod_prov;
            this.txtproveedor.Text = nombre;
        }
        public void setProducto(string cod_pro, string nombre)
        {
            this.txtcod_pro.Text = cod_pro;
            this.txtpro.Text = nombre;
        }

        private void btnbuscar_pro_Click(object sender, EventArgs e)
        {
            FrmVistaProveedorIngreso frm = new FrmVistaProveedorIngreso();
            frm.ShowDialog();
        }

        private void btnbuscar_producto_Click(object sender, EventArgs e)
        {
            FrmVistaProductoIngreso frm = new FrmVistaProductoIngreso();
            frm.ShowDialog();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar_por_Fechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Anular los Registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) //SI usuario dice OK
                {
                    string cod, rpta = "";
                    foreach (DataGridViewRow row in dgvlistado.Rows)//Recorre todas las filas del DataGridView
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //Revisa si la fila está activada
                        {
                            cod = Convert.ToString(row.Cells[1].Value);
                            rpta = NOrden.Anular(Convert.ToInt32(cod));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Anuló correctamente el Registro");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
                this.dgvlistado.Columns[0].Visible = true;
            else
                this.dgvlistado.Columns[0].Visible = false;
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
    }
}
