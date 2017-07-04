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
    public partial class FrmProveedores : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmProveedores()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtrazons, "Ingrese una Razon Social");
            this.ttmensaje.SetToolTip(this.cbotipodoc, "Debe Seleccionar un Número de Documento");
            this.ttmensaje.SetToolTip(this.txtnum_doc, "Ingrese un Número de Documento");
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
            this.txtcod_prov.Text = string.Empty;
            this.txtrazons.Text = string.Empty;
            this.txtsectorc.Text = string.Empty;
            this.cbotipodoc.Text = string.Empty;
            this.txtnum_doc.Text = string.Empty;
            this.txtdir.Text = string.Empty;
            this.txttel.Text = string.Empty;
            this.txtemail.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_prov.ReadOnly = !valor;
            this.txtrazons.ReadOnly = !valor;
            this.txtsectorc.ReadOnly = !valor;
            this.cbotipodoc.Enabled = valor;
            this.txtnum_doc.ReadOnly = !valor;
            this.txtdir.ReadOnly = !valor;
            this.txttel.ReadOnly = !valor;
            this.txtemail.ReadOnly = !valor;//ReadOnly:para hacerla de solo lectura
        }

        //Desactivar botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.habilitar(true);
                this.btnnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;
            }
            else
            {
                this.habilitar(false);
                this.btnnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }
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

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Botones();
            this.habilitar(false);
            this.mostrar();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.txtcod_prov.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cboelegir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Razon Social"))
            {
                buscar_razon_social();
            }
            else if (cboelegir.Text.Equals("Numero"))
            {
                buscar_num_doc();
            }  
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Razon Social"))
            {
                buscar_razon_social();
            }
            else if (cboelegir.Text.Equals("Numero"))
            {
                buscar_num_doc();
            }  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Eliminar los Registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) //SI usuario dice OK
                {
                    string cod, rpta = "";
                    foreach (DataGridViewRow row in dgvlistado.Rows)//Recorre todas las filas del DataGridView
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //Revisa si la fila está activada
                        {
                            cod = Convert.ToString(row.Cells[1].Value);
                            rpta = NProveedor.Eliminar(Convert.ToInt32(cod));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó correctamente el Registro");
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar=false;
            this.LimpiarBotones();
            this.habilitar(false);
            this.Botones();
            this.txtcod_prov.Focus();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if (this.txtrazons.Text == string.Empty ||this.txtnum_doc.Text==string.Empty  ) //si la caja de texto está vacía--Se cambio la fila de enmedio
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(this.txtrazons, "Ingrese una Razón Social");
                    erroricono.SetError(this.cbotipodoc, "Ingrese un Sector Comercial");
                    erroricono.SetError(this.txtnum_doc, "Ingrese un Número de Documento");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProveedor.Insertar(this.txtrazons.Text.Trim(), this.txtsectorc.Text.Trim(), Convert.ToString(this.cbotipodoc.Text),
                            this.txtnum_doc.Text.Trim(), this.txtdir.Text.Trim(), this.txttel.Text.Trim(), this.txtemail.Text.Trim());// borra espacios 
                        MensajeOK("Se inserto Correctamente el Registro");
                    }
                    else
                    {
                        rpta = NProveedor.Editar(Convert.ToInt16(this.txtcod_prov.Text.Trim()),this.txtrazons.Text.Trim(), this.txtsectorc.Text.Trim(), this.cbotipodoc.Text,
                             this.txtnum_doc.Text.Trim(), this.txtdir.Text.Trim(), this.txttel.Text.Trim(), this.txtemail.Text.Trim());// borra espacios 
                        MensajeOK("Se edito Correctamente el Registro");
                    }
                    this.MensajeError(rpta);
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.LimpiarBotones();
                this.Botones();
                this.tabControl1.SelectedIndex = 0;
                this.mostrar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtcod_prov.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.habilitar(true);
            }
            else
            {
                this.MensajeError("Seleccione primero un registro");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarBotones();
            this.habilitar(false);
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
            this.txtcod_prov.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_prov"].Value);
            this.txtrazons.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["razon_social"].Value);
            this.txtsectorc.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["sector_comercial"].Value);
            //probar con selecttext en el combobox.. 
            this.cbotipodoc.SelectedText = Convert.ToString(this.dgvlistado.CurrentRow.Cells["tipo_doc"].Value);
            this.txtnum_doc.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["num_doc"].Value);
            this.txtdir.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["direccion"].Value);
            this.txttel.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["telefono"].Value);
            this.txtemail.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["email"].Value);
            this.tabControl1.SelectedIndex = 1;

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
