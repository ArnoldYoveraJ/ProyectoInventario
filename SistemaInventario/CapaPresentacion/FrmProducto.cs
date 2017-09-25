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

        private static FrmProducto _Instancia;
        Validar v = new Validar(); // Instanciar la clase Validar

        //código Nuevo
        public static FrmProducto GetInstancia()
        { 
            if(_Instancia==null)
            {
                _Instancia = new FrmProducto();
            }
            return _Instancia;
        }
        //código Nuevo

        public FrmProducto()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnom, "Ingrese el Nombre del Equipo");
            this.ttmensaje.SetToolTip(this.pxImagen, "Seleccione la Imagen del Equipo");
            this.txtcod_pro.Visible = false;
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
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar botones
        private void LimpiarBotones()
        {
            this.txtnom.Text = string.Empty;
            this.txtcod_pro.Text = string.Empty;
            this.txtmarca.Text = string.Empty;
            this.mtbram.Text = string.Empty;
            this.txtmodeloplaca.Text = string.Empty;
            this.txtserie.Text = string.Empty;
            this.txtprocesador.Text=string.Empty;
            this.txtdd.Text=string.Empty;
            this.txtdesc.Text=string.Empty;
            this.txtserie.Text=string.Empty;
           // this.txttrabajador.Text = string.Empty;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.img_transpa;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_pro.ReadOnly = !valor;
            this.txtnom.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtmarca.ReadOnly = !valor;
            this.txtmodeloplaca.ReadOnly=!valor;
            this.txtserie.ReadOnly = !valor;
            this.txtprocesador.ReadOnly = !valor;
            this.txtdd.ReadOnly = !valor;
            this.mtbram.ReadOnly = !valor;

            this.txtdesc.ReadOnly = !valor;
            this.txtserie.ReadOnly = !valor;
            this.cboestado.Enabled = valor;
            this.cboso.Enabled = valor;
            this.cbocategoria.Enabled = valor;

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
           this.dgvlistado.Columns[13].Visible = false;
            /*this.dgvlistado.Columns[14].Visible = false;*/
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

        public void buscar_producto_marca()
        {
            this.dgvlistado.DataSource = NProducto.Buscar_Producto_Marca(this.txtbuscar.Text);
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        public void buscar_producto_serie()
        {
            this.dgvlistado.DataSource = NProducto.Buscar_Producto_Serie(this.txtbuscar.Text);
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
                this.pxImagen.Image = Image.FromFile(dialog.FileName);//obtiene un archivo de FRomfile y lo envia al dialog 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.img_transpa;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nombre();
            }
            else if (cboelegir.Text.Equals("Marca"))
            {
                buscar_producto_marca();
            }
            else if (cboelegir.Text.Equals("Serie"))
            {
                buscar_producto_serie();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cboelegir.Text.Equals("Nombre"))
            {
                buscar_nombre();
            }
            else if (cboelegir.Text.Equals("Marca"))
            {
                buscar_producto_marca();
            }  
            else if(cboelegir.Text.Equals("Serie"))
            {
                buscar_producto_serie();
            }
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
                if (this.txtnom.Text == string.Empty ||this.txtmarca.Text==string.Empty
                   ||this.txtserie.Text==string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Valor");
                    erroricono.SetError(txtmarca, "Ingrese un Valor");
                    erroricono.SetError(txtserie, "Ingrese un Valor");
                }
                else
                {
                    System.IO.MemoryStream ms= new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen= ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rpta = NProducto.Insertar(this.txtnom.Text.Trim(), this.txtmarca.Text.Trim(), this.txtmodeloplaca.Text.Trim(), this.txtserie.Text.Trim(),
                            this.txtprocesador.Text.Trim(), this.txtdd.Text.Trim(), this.mtbram.Text.Trim(), Convert.ToString(this.cboso.Text), imagen, this.cboestado.Text,
                           1, this.txtdesc.Text.Trim(), Convert.ToInt16(this.cbocategoria.SelectedValue));// borra espacios y convierte en mayuscula
                        MensajeOK("Se Inserto Correctamente");
                    }
                    else
                    {
                        rpta = NProducto.Editar(Convert.ToInt16(this.txtcod_pro.Text.Trim()), this.txtnom.Text.Trim(), this.txtmarca.Text.Trim(), this.txtmodeloplaca.Text.Trim(), this.txtserie.Text.Trim(),
                            this.txtprocesador.Text.Trim(), this.txtdd.Text.Trim(), this.mtbram.Text.Trim(), Convert.ToString(this.cboso.Text), imagen, this.cboestado.Text,
                          1, this.txtdesc.Text.Trim(), Convert.ToInt16(this.cbocategoria.SelectedValue));
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
            this.txtcod_pro.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_producto"].Value);//Current ROw: fila actual
            this.txtnom.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            this.txtmarca.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["marca"].Value);
            this.txtmodeloplaca.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["modelo_placa"].Value);
            this.txtserie.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["serie"].Value);
            byte[] imagenBuffer = (byte[])this.dgvlistado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;//para que la img se adeque al tamaño de toda la pantalla

            this.txtprocesador.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["procesador"].Value);
            this.txtdd.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["dd"].Value);
            this.mtbram.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["ram"].Value);
            this.cboestado.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["tipo_estado"].Value);
            this.txtdesc.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["descripcion"].Value);
            this.cboso.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["so"].Value);

            /*this.txtcodtra.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["cod_trabajador"].Value);//Current ROw: fila actual
            this.txttrabajador.Text = Convert.ToString(this.dgvlistado.CurrentRow.Cells["Trabajador"].Value);//Current ROw: fila actual*/
            this.cbocategoria.SelectedValue = this.dgvlistado.CurrentRow.Cells["cod_cat"].Value;
            this.txtcod_pro.ReadOnly = false;
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //código Nuevo. 
            FrmVistaTrabajador_Producto form = new FrmVistaTrabajador_Producto();
            form.ShowDialog();
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null; //Cuando Cierre el Formulario se termine la instancia y posteriormente se vuelve a crear otra. 
        }

        private void cboelegir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporteArticulos obja = new FrmReporteArticulos();
            obja.ShowDialog();
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }
    }
}
