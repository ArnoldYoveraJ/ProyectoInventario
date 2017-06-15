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
    public partial class FrmCategoria : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmCategoria()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnom, "Ingrese el Nombre de la Categoría");
            
        }
        //Mostrar Mensaje de Confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventsario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar botones
        private void LimpiarBotones()
        {
           this.txtnom.Text=string.Empty;
           this.txtcod_cat.Text=string.Empty;//Empty:vacío
        }

        //Activar botones

        private void habilitar (bool valor)
        {
            this.txtcod_cat.ReadOnly = !valor;
            this.txtnom.ReadOnly=!valor; //ReadOnly:para hacerla de solo lectura
        }

         //Desactivar botones
        private void Botones ()
        {
          if(this.IsNuevo || this.IsEditar)
          {
              this.habilitar(true);
              this.btnnuevo.Enabled=false;
              this.btnguardar.Enabled= true;
              this.btneditar.Enabled=false;
              this.btncancelar.Enabled= true;
          }else
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
            this.dgvlistado.DataSource = NCategoria.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar_nombre()
        {
            this.dgvlistado.DataSource = NCategoria.BuscarNombre(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Top=0;
            this.Left=0;
            this.mostrar();
            this.Botones();
            this.habilitar(false);
            this.IsNuevo = false;
            this.IsEditar = false;
            this.txtcod_cat.Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar_nombre();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
                this.mostrar();
            else
                this.buscar_nombre();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarBotones();
            this.habilitar(true);
            this.txtnom.Focus();
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if ( this.chkeliminar.Checked)
                this.dgvlistado.Columns[0].Visible = true;
            else
                this.dgvlistado.Columns[0].Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if(this.txtnom.Text==string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Nombre");
                }else
                {
                    if(this.IsNuevo)
                    {
                        rpta = NCategoria.Insertar(this.txtnom.Text.Trim());// borra espacios y convierte en mayuscula
                        MensajeOK("Se inserto Correctamente");
                    }
                    else
                    {
                        rpta = NCategoria.Editar(Convert.ToInt32(this.txtcod_cat.Text),this.txtnom.Text.Trim().ToUpper());
                        MensajeOK("Se Edito Correctamente");
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

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
           this.txtcod_cat.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_cat"].Value);//Current ROw: fila actual
           this.txtcod_cat.Visible = false;//deshabilitar el código cuando edite
           this.txtnom.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nom_cat"].Value);
           this.tabControl1.SelectedIndex = 1;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(!this.txtcod_cat.Text.Equals(""))
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion=MessageBox.Show("Realmente desea Eliminar los Registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(opcion == DialogResult.OK) //SI usuario dice OK
                {
                    string cod,rpta="";
                    foreach (DataGridViewRow row in dgvlistado.Rows)//Recorre todas las filas del DataGridView
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //Revisa si la fila está activada
                        {
                            cod = Convert.ToString(row.Cells[1].Value);
                            rpta = NCategoria.Eliminar(Convert.ToInt32(cod));
                        
                            if(rpta.Equals("OK"))
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

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== dgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =(DataGridViewCheckBoxCell)dgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }


    }
}
