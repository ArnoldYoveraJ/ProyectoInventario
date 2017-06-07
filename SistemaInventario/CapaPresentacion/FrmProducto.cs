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
    public partial class FrmProducto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmProducto()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnom, "Ingrese el Nombre del Producto");
            this.ttmensaje.SetToolTip(this.pxImagen, "Seleccione la Imagen del Producto");
            this.ttmensaje.SetToolTip(this.cbocategoria, "Seleccione el Trabajador");
            this.ttmensaje.SetToolTip(this.cboestado, "Seleccione el estado del Producto");
            this.txtcod_pro.Visible = false;
            this.txttrabajador.ReadOnly = true;
            this.LlenarComboCategoria();
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
            this.txtnom.Text = string.Empty;
            this.txtcod_pro.Text = string.Empty;
            this.txtmarca.Text = string.Empty;
            this.txtmodeloplaca.Text = string.Empty;
            this.txtserie.Text = string.Empty;
            this.txtprocesador.Text=string.Empty;
            this.txtdd.Text=string.Empty;
            this.txtram.Text=string.Empty;
            this.txtdesc.Text=string.Empty;
            this.txtserie.Text=string.Empty;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.img_transpa;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_pro.ReadOnly = !valor;
            this.txtnom.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtmarca.ReadOnly = !valor;
            this.txtmodeloplaca.ReadOnly=
            this.txtserie.ReadOnly = !valor;
            this.txtprocesador.ReadOnly = !valor;
            this.txtdd.ReadOnly = !valor;
            this.txtram.ReadOnly = !valor;
            this.txtdesc.ReadOnly = !valor;
            this.txtserie.ReadOnly = !valor;
            this.cboestado.Enabled = valor;
            this.txttrabajador.ReadOnly = !valor;
            this.txtcodtra.ReadOnly = !valor;
            this.cbocategoria.Enabled = valor;
            this.btnagregar.Enabled = valor;
            btnCargar.Enabled = valor;
            btnLimpiar.Enabled = valor;
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
            this.dgvlistado.Columns[12].Visible = false;
            this.dgvlistado.Columns[14].Visible = false;
            //corregir el procedimiento almacenado para traer el nombre la categoria y el nombre del trabajador. 
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NProducto.Mostrar();
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
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.mostrar();
            this.Botones();
            this.habilitar(false);
            this.IsNuevo = false;
            this.IsEditar = false;
        }

        private void LlenarComboCategoria()
        {
            cbocategoria.DataSource = NCategoria.Mostrar();
            cbocategoria.ValueMember = "cod_cat";
            cbocategoria.DisplayMember = "nom_cat";
        }

        private void pxImagen_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.mostrar();
            this.Botones();
            this.habilitar(false);
            this.IsNuevo = false;
            this.IsEditar = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if(result== DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;//Adecua el Tamaño de la imagen al picturebox
                this.pxImagen.Image = Image.FromFile(dialog.FileName);//obtiene un archivo de FRomfile. yu lo envia al dialog 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.img_transpa;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar_nombre();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if (this.txtnom.Text == string.Empty || this.txtcodtra.Text == string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Valor");
                    erroricono.SetError(txtcodtra, "Ingrese un Valor");
                }
                else
                {
                    System.IO.MemoryStream ms= new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen= ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rpta = NProducto.Insertar(this.txtnom.Text.Trim(),this.txtmarca.Text.Trim(),this.txtmodeloplaca.Text.Trim(),this.txtserie.Text.Trim(),
                            this.txtprocesador.Text.Trim(), this.txtdd.Text.Trim(), this.txtram.Text.Trim(), this.txtso.Text.Trim(), imagen,
                           Convert.ToInt16(this.cboestado.SelectedValue), this.txtdesc.Text.Trim(), Convert.ToInt16(this.cbocategoria.SelectedValue), Convert.ToInt16(this.txtcodtra.Text.Trim()));// borra espacios y convierte en mayuscula
                        MensajeOK("Se Inserto Correctamente");
                    }
                    else
                    {
                        rpta = NProducto.Editar(Convert.ToInt16(this.txtcod_pro.Text.Trim()), this.txtnom.Text.Trim(), this.txtmarca.Text.Trim(), this.txtmodeloplaca.Text.Trim(), this.txtserie.Text.Trim(),
                            this.txtprocesador.Text.Trim(), this.txtdd.Text.Trim(), this.txtram.Text.Trim(), this.txtso.Text.Trim(), imagen,
                           Convert.ToInt16(this.cboestado.SelectedValue), this.txtdesc.Text.Trim(), Convert.ToInt16(this.cbocategoria.SelectedValue), Convert.ToInt16(this.txtcodtra.Text.Trim()));
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtcod_pro.Text.Equals(""))
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
                opcion = MessageBox.Show("Realmente desea Eliminar los Registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) //SI usuario dice OK
                {
                    string cod, rpta = "";
                    foreach (DataGridViewRow row in dgvlistado.Rows)//Recorre todas las filas del DataGridView
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //Revisa si la fila está activada
                        {
                            cod = Convert.ToString(row.Cells[1].Value);
                            rpta = NProducto.Eliminar(Convert.ToInt32(cod));

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
            this.txtcod_pro.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_pro"].Value);//Current ROw: fila actual
            this.txtnom.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            this.txtmarca.Text=Convert.ToString(this.dgvlistado.CurrentRow.Cells["marca"].Value);
            this.txtmodeloplaca.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["modelo_placa"].Value);
            this.txtserie.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["serie"].Value);
            byte[] imagenBuffer = (byte[])this.dgvlistado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtprocesador.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["procesador"].Value);
            this.txtdd.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["dd"].Value);
            this.txtram.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["ram"].Value);
            this.cboestado.SelectedValue = Convert.ToString(this.dgvlistado.CurrentRow.Cells["estado"].Value);
            this.txtdesc.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["descripcion"].Value);
            this.txtso.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["so"].Value);

            this.txtcodtra.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_tra"].Value);//Current ROw: fila actual
            this.txttrabajador.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["Trabajador"].Value);//Current ROw: fila actual
            this.cbocategoria.SelectedValue = this.dgvlistado.CurrentRow.Cells["cod_cat"].Value;
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
