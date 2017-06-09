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
    public partial class FrmTrabajador : Form
    {
        private bool isnuevo=false;
        private bool iseditar=false;

        public FrmTrabajador()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnom,"No se ingreso el Nombre");
            this.ttmensaje.SetToolTip(this.txtdni,"No se ingreso el DNI");
            this.ttmensaje.SetToolTip(this.cboarea,"Selecione un Area");
            this.ttmensaje.SetToolTip(this.cboempresa,"Selecciones un Empresa");
            this.txtcod_tra.Visible=false;
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
            this.txtdni.Text=string.Empty;
            this.txtemail.Text=string.Empty;
            this.txtanexo.Text=string.Empty;
        }

        private void habilitar(bool valor){
            this.txtcod_tra.ReadOnly=!valor;
            this.txtnom.ReadOnly=!valor;
            this.txtape.ReadOnly=!valor;
            this.txtdni.ReadOnly=!valor;
            this.txtemail.ReadOnly=!valor;
            this.txtanexo.ReadOnly=!valor;
        }

        private void Activar_botones()
        {
            if(isnuevo || iseditar)
            {
                this.habilitar(true);
                this.btnnuevo.Enabled=false;
                this.btneditar.Enabled=false;
                this.btnguardar.Enabled=true;
                this.btnguardar.Enabled=true;
            }else{
                this.habilitar(true);
                this.btnnuevo.Enabled=true;
                this.btneditar.Enabled=true;
                this.btnguardar.Enabled=false;
                this.btnguardar.Enabled=false;
            }
        }

        private void ocultarcolumanas(){
            this.dgvlistado.Columns[0].Visible=false;
            this.dgvlistado.Columns[1].Visible=false;
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
        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            this.Top=0;
            this.Left=0;
            this.mostrar();
            this.Activar_botones();
            this.habilitar(false);
            this.isnuevo = false;
            this.iseditar = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo=false;
            this.iseditar=true;
            this.Activar_botones();
            this.habilitar(true);
            this.txtcod_tra.Focus();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if(this.txtnom.Text==string.Empty || this.txtdni.Text==string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Nombre");
                    erroricono.SetError(txtdni,"Ingrese un DNI");
                }else
                {
                    if(this.isnuevo)
                    {
                        rpta = NTrabajador.Insertar(this.txtnom.Text.Trim(),this.txtape.Text.Trim(),this.txtdni.Text.Trim(),this.txtemail.Text.Trim(),
                        this.txtanexo.Text.Trim(),Convert.ToInt32(this.cboarea.SelectedValue),Convert.ToInt32(this.cboempresa.SelectedValue));// borra espacios y convierte en mayuscula
                        MensajeOK("Se inserto Correctamente");
                    }
                    else
                    {
                        rpta = NTrabajador.Editar(Convert.ToInt32(this.txtcod_tra.Text.Trim()),this.txtnom.Text.Trim(),this.txtape.Text.Trim(),this.txtdni.Text.Trim(),this.txtemail.Text.Trim(),
                        this.txtanexo.Text.Trim(),Convert.ToInt32(this.cboarea.SelectedValue),Convert.ToInt32(this.cboempresa.SelectedValue));
                        MensajeOK("Se Edito Correctamente");
                    }
                    this.MensajeError(rpta);
                }
                this.isnuevo = false;
                this.iseditar = false;
                this.limpiar();
                this.Activar_botones();
                this.tabControl1.SelectedIndex = 0;
                this.mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar();
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
            this.txtcod_tra.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["cod_tra"].Value);
            this.txtnom.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["nom"].Value);
            this.txtape.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["ape"].Value);
            this.txtdni.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["dni"].Value);
            this.txtemail.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["email"].Value);
            this.txtanexo.Text= Convert.ToString(dgvlistado.CurrentRow.Cells["anexo"].Value);
            this.cboarea.SelectedText=Convert.ToString(dgvlistado.CurrentRow.Cells["area"].Value);
            this.cboempresa.SelectedText=Convert.ToString(dgvlistado.CurrentRow.Cells["empresa"].Value);
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

            /* if(this.dgvlistado.CurrentRow()
             {

             }*/
        }
    }
}
