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
    public partial class FrmTrabajador : Form
    {
        private bool isnuevo=false;
        private bool iseditar=false;
        Validar v = new Validar(); // Instanciar la clase Validar

        public FrmTrabajador()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnom,"Ingrese un Nombre de Trabajador");
            this.ttmensaje.SetToolTip(this.mktdni,"Ingrese un DNI de Trabajador");
            this.ttmensaje.SetToolTip(this.cboarea,"Selecione un Area");
            this.ttmensaje.SetToolTip(this.cboempresa,"Seleccione una Empresa");
            this.txtcod_tra.Visible=false;
            llenarComboArea();
            llenarComboEmpresa();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Inventario",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Inventario",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void limpiar()
        {
            this.txtcod_tra.Text=string.Empty;
            this.txtnom.Text=string.Empty;
            this.txtape.Text=string.Empty;
            this.mktdni.Text=string.Empty;
            this.txtemail.Text=string.Empty;
            this.mktanexo.Text=string.Empty;
        }

        private void habilitar(bool valor){
            this.txtcod_tra.ReadOnly=!valor;
            this.txtnom.ReadOnly=!valor;
            this.txtape.ReadOnly=!valor;
            this.mktdni.ReadOnly=!valor;
            this.txtemail.ReadOnly=!valor;
            this.mktanexo.ReadOnly=!valor;
            this.cboarea.Enabled = valor;
            this.cboempresa.Enabled = valor;
        }

        private void Activar_botones()
        {
            if(this.isnuevo || this.iseditar)
            {
                this.habilitar(true);
                this.btnnuevo.Enabled=false;
                this.btneditar.Enabled=false;
                this.btnguardar.Enabled=true;
                this.btncancelar.Enabled=true;
            }else{
                this.habilitar(false);
                this.btnnuevo.Enabled=true;
                this.btneditar.Enabled=true;
                this.btnguardar.Enabled=false;
                this.btncancelar.Enabled = false;
            }
        }

        private void ocultarcolumanas(){
            this.dgvlistado.Columns[0].Visible=false;
            this.dgvlistado.Columns[1].Visible=false;
            this.dgvlistado.Columns[7].Visible = false;
            this.dgvlistado.Columns[9].Visible = false;
        }

        private void mostrar(){
            this.dgvlistado.DataSource=NTrabajador.Mostrar();
            this.ocultarcolumanas();
            this.lbltotal.Text="Total: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void buscar(){
            this.dgvlistado.DataSource=NTrabajador.Buscar(this.txtbuscar.Text);
            this.ocultarcolumanas();
            this.lbltotal.Text="Total: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        private void buscar_trabajador_dni()
        {
            this.dgvlistado.DataSource = NTrabajador.Buscar_Trabajador_dni(this.txtbuscar.Text);
            this.ocultarcolumanas();
            this.lbltotal.Text="Total: " + dgvlistado.Rows.Count;
        }

        private void llenarComboArea()
        {
            cboarea.DataSource = NArea.Mostrar();
            cboarea.ValueMember = "cod_area";
            cboarea.DisplayMember = "nom_area";
        }

        private void llenarComboEmpresa()
        {
            cboempresa.DataSource = NTrabajador.Mostar_empresa();
            cboempresa.ValueMember = "cod_empresa";
            cboempresa.DisplayMember = "nom_empresa";
        }
        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            this.Top=0;
            this.Left=0;
            this.mostrar();
            this.Activar_botones();
            this.habilitar(false);
            this.isnuevo = false;
            this.iseditar = false;
            this.txtcod_tra.Visible = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo=true;
            this.iseditar=false;
            this.limpiar();
            this.habilitar(false);
            this.Activar_botones();
            this.txtcod_tra.Focus();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta="";
            try
            {
                if (this.txtnom.Text==string.Empty || this.mktdni.Text==string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Nombre");
                    erroricono.SetError(mktdni,"Ingrese un DNI");
                }
                //else{
                   // DataTable Trabajador = NTrabajador.validar_existe_trabajador(this.mktdni.Text);

                  /*  if (Trabajador != null)
                    {
                        MensajeOK("El DNI ya se encuentra Registrado");
                        //rpta = "El DNI ya se encuentra Registrado";
                        erroricono.SetError(mktdni, "El DNI ya se encuentra Registrado");
                        this.mktdni.Focus();
                        //return;
                    }*/

                    if (this.isnuevo)
                       {

                           DataTable Trabajador = NTrabajador.validar_existe_trabajador(this.mktdni.Text);

                            if (mktdni.Text.Equals(Trabajador.Rows[0][0].ToString())/*Trabajador != null*/)
                            {
                               // MensajeOK("El DNI ya se encuentra Registrado");
                                rpta = "El DNI ya se encuentra Registrado";
                                erroricono.SetError(mktdni, "El DNI ya se encuentra Registrado");
                                this.mktdni.Focus();
                        //return;
                            }
                            else
                            { 
                                rpta = NTrabajador.Insertar(this.txtnom.Text.Trim(), this.txtape.Text.Trim(), this.mktdni.Text.Trim(), this.txtemail.Text.Trim(),
                                this.mktanexo.Text.Trim(), Convert.ToInt32(this.cboarea.SelectedValue), Convert.ToInt32(this.cboempresa.SelectedValue));// borra espacios y convierte en mayuscula
                                MensajeOK("Se inserto Correctamente");
                                UtilGuardar();
                            }

                       }else
                       {
                            rpta = NTrabajador.Editar(Convert.ToInt32(this.txtcod_tra.Text.Trim()),this.txtnom.Text.Trim(),this.txtape.Text.Trim(),this.mktdni.Text.Trim(),this.txtemail.Text.Trim(),
                            this.mktanexo.Text.Trim(), Convert.ToInt16(this.cboarea.SelectedValue), Convert.ToInt16(this.cboempresa.SelectedValue));
                            MensajeOK("Se Edito Correctamente");
                            UtilGuardar();
                       }
                        this.MensajeError(rpta);

                //}
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UtilGuardar()
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.limpiar();
            this.Activar_botones();
            this.tabControl1.SelectedIndex = 0;
            this.mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(cbobuscar.Text.Equals("DNI"))
            {
                buscar_trabajador_dni();
            }
            else if (cbobuscar.Text.Equals("Apellidos"))
            {
                buscar();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbobuscar.Text.Equals("DNI"))
            {
                buscar_trabajador_dni();
            }
            else if (cbobuscar.Text.Equals("Apellidos"))
            {
                buscar();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo=false;
            this.iseditar=false;
            this.Activar_botones();         
            this.habilitar(false);
            this.limpiar();
           
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(!this.txtcod_tra.Text.Equals(""))
            {
                this.iseditar = true;
                this.Activar_botones();
                this.habilitar(true);
            }
            else
            {
                this.MensajeError("Seleccione primero un registro");
            }
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         if(e.ColumnIndex== dgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =(DataGridViewCheckBoxCell)dgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcod_tra.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["cod_trabajador"].Value);
            this.txtnom.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["nombres"].Value);
            this.txtape.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["apellidos"].Value);
            this.mktdni.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["dni"].Value);
            this.txtemail.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["email"].Value);
            this.mktanexo.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["anexo"].Value);
            this.cboarea.SelectedValue=Convert.ToString(dgvlistado.CurrentRow.Cells["cod_area"].Value);
            this.cboempresa.SelectedValue = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_empresa"].Value);
            this.txtcod_tra.ReadOnly = false;
            this.tabControl1.SelectedIndex=1;
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkeliminar.Checked)
            {
                dgvlistado.Columns[0].Visible = true;
            }else
            {
                dgvlistado.Columns[0].Visible = false;
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
                            rpta = NTrabajador.Eliminar(Convert.ToInt32(cod));

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

        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtcod_tra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void mktdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.Numeros(e);
        }

        private void mktanexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.Numeros(e);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporteTrabajadores frmtra = new FrmReporteTrabajadores();
            frmtra.ShowDialog();
        }
    }
}
