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
        private bool isnuevo=false;;
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

        }
    }
}
