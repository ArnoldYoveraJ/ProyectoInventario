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
    public partial class FrmArea : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        Validar v = new Validar(); // Instanciar la clase Validar
        public FrmArea()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnom, "Ingrese el Nombre del Area");

        }

        //Mostrar mensajes de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensajes de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar Cajas de Texto
        private void Limpiar()
        {
            this.txtnom.Text = string.Empty;
            this.txtcod.Text = string.Empty;
        }

        //HAbilitar controles
        private void Habilitar(bool valor)
        {
            this.txtnom.ReadOnly = !valor;
            this.txtcod.ReadOnly = !valor;
         }

        //HAbilitar Botones
        private void Botones()
        {
            if(this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;      
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;   
            }
        }

        //ocultar columnas

        private void ocultar_columnas()
        {
            this.dgvlistado.Columns[0].Visible = false;
            this.dgvlistado.Columns[1].Visible = false;
        }

        //Mostrar
            
         private void Mostrar()
        {
            this.dgvlistado.DataSource = NArea.Mostrar();
            this.ocultar_columnas();
            this.lbltotal.Text ="Total de Registros: "+ Convert.ToString(dgvlistado.Rows.Count);
        }

        //BUscar por Nombre
         private void BuscarNombre()
         {
             this.dgvlistado.DataSource = NArea.Buscar(this.txtbuscar.Text);
             this.ocultar_columnas();
             this.lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
         }
        private void FrmArea_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Botones();
            this.Habilitar(false);
            IsNuevo = false;
            IsEditar = false;
            this.txtcod.Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
            
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btneliminar_Click(object sender, EventArgs e)
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
                            rpta = NArea.Eliminar(Convert.ToInt32(cod));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó correctamente el Registro");
                                //chkeliminar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Habilitar(true);
            this.Botones();
            this.Limpiar();
            this.txtnom.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(this.txtnom.Text==string.Empty)
                {
                    this.MensajeError("Faltan ingresar Datos");
                    this.erroricono.SetError(txtnom, "Ingrese un Nombre");

                }
                else
                {
                    if(this.IsNuevo)
                    {
                        rpta = NArea.Insertar(this.txtnom.Text.Trim().ToUpper());
                        MensajeOk("Se Inserto Correctamente");
                    }else
                    {
                        rpta = NArea.Editar(Convert.ToInt32(this.txtcod.Text),this.txtnom.Text.Trim().ToUpper());
                        MensajeOk("Se Actualizó Correctamente");
                    }
                    this.MensajeError(rpta);
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcod.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_area"].Value);
            if(this.txtnom.Text==string.Empty)
            {
                this.txtnom.Text = "-";
            }
            else
            {
                this.txtnom.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nom_area"].Value);
            }
            this.txtcod.ReadOnly = false;
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!this.txtcod.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
            {
                dgvlistado.Columns[0].Visible = true;
            }else
            {
                this.dgvlistado.Columns[0].Visible=false;
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

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }
    }
}
