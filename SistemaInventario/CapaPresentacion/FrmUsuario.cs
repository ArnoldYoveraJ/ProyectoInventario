﻿using System;
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
    public partial class FrmUsuario : Form
    {
        private bool IsNuevo ;
        private bool IsEditar ;
        public FrmUsuario()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(txtnomcom, "Debe ingresar un Nombre Completo");
            this.ttmensaje.SetToolTip(txtusu, "Debe ingresar un Usuario");
            this.ttmensaje.SetToolTip(txtcon, "Debe ingresar una Contraseña");
            this.ttmensaje.SetToolTip(cbotipousu, "Debe seleccionar un Tipo de Usuario");
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar botones
        private void LimpiarBotones()
        {
            this.txtcod_usu.Text = string.Empty;
            this.txtnomcom.Text = string.Empty;
            this.txtusu.Text = string.Empty;
            this.txtcon.Text = string.Empty;
            //this.cbotipousu.Text = string.Empty; los combobox no se dejan en blanco.
            this.rbact.Text = string.Empty;
            this.rbdes.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_usu.ReadOnly = valor;
            this.txtnomcom.ReadOnly = !valor;
            this.txtusu.ReadOnly = !valor;
            this.txtcon.ReadOnly = !valor;
            this.cbotipousu.Enabled = !valor;
            this.rbact.Enabled = !valor;
            this.rbdes.Enabled = !valor;//ReadOnly:para hacerla de solo lectura
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
                this.habilitar(true);
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
            this.dgvlistado.DataSource = NUsuario.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Usuario por nombre Completo
        private void buscar_nom_completo()
        {
            this.dgvlistado.DataSource = NUsuario.Buscar_nombre(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Usuario por nombre de Usuario
        private void buscar_usuario()
        {
            this.dgvlistado.DataSource = NUsuario.Buscar_usuario(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            mostrar();
            habilitar(false);
            Botones();
            IsNuevo = false;
            IsNuevo = false;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nom_completo();
            }
            else if (cboelegir.Text.Equals("Usuario"))
            {
                buscar_usuario();
            }  
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nom_completo();
            }
            else if (cboelegir.Text.Equals("Usuario"))
            {
                buscar_usuario();
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
                            rpta = NUsuario.Eliminar(Convert.ToInt32(cod));

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
            this.txtcod_usu.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_usu"].Value);
            this.txtnomcom.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nombre_completo"].Value);
            this.txtusu.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["usuario"].Value);
            this.txtcon.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["contra"].Value);
            //probar con selecttext en el combobox.. // text
            this.cbotipousu.SelectedValue = Convert.ToString(this.dgvlistado.CurrentRow.Cells["tipo"].Value);

            //modificar 
            this.rbact.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["estado"].Value);
            this.rbdes.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["estado"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            habilitar(true);
            Botones();
            LimpiarBotones();
            this.txtnomcom.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            
            try
            {
                if (this.txtnomcom.Text == string.Empty || this.cbotipousu.SelectedValue == string.Empty || this.txtcon.Text == string.Empty) //si la caja de texto está vacía--Se cambio la fila de enmedio
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(this.txtnomcom, "Ingrese un Nombre Completo");
                    erroricono.SetError(this.cbotipousu, "Ingrese un Tipo Usuario");
                    erroricono.SetError(this.txtcon, "Ingrese una Contraseña");
                }
                else
                {
                        string act="";
                        if (rbact.Checked)
                        {
                            act = this.rbact.Text.Trim();
                        }
                        else if (rbdes.Checked)
                        {
                            act = this.rbdes.Text.Trim();
                        }
                    if (this.IsNuevo)
                    {  
                        rpta = NUsuario.Insertar(this.txtnomcom.Text.Trim(), this.txtusu.Text.Trim(), this.txtcon.Text.Trim(),
                            this.cbotipousu.SelectedText.Trim(),Convert.ToInt32(act));// borra espacios 
                        MensajeOK("Se inserto Correctamente el Registro");
                    }
                    else
                    {
                        rpta = NUsuario.Editar(Convert.ToInt32(this.txtcod_usu.Text.Trim()),this.txtnomcom.Text.Trim(), this.txtusu.Text.Trim(), 
                            this.txtcon.Text.Trim(),this.cbotipousu.SelectedText.Trim(), Convert.ToInt32(act));// borra espacios 
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
            if (!this.txtcod_usu.Text.Equals(""))
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
            IsNuevo = false;
            IsEditar = false;
            Botones();
            habilitar(false);
            LimpiarBotones();

            
        }
    }
}