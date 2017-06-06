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
            this.ttmensaje.SetToolTip(this.cbotrabajador, "Seleccione el Trabajador");
            this.ttmensaje.SetToolTip(this.cboestado, "Seleccione el estado del Producto");
            this.txtcod_pro.Visible = false;
            this.txtcategoria.ReadOnly = true;
            this.LlenarCombo();
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
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources;
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
            this.txtcategoria.ReadOnly = !valor;
            this.txtcodcat.ReadOnly = !valor;
            this.cbotrabajador.Enabled = valor;
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

        private void LlenarCombo()
        {
            cbotrabajador.DataSource = NProducto.Mostrar();
            cbotrabajador.ValueMember = "idproducto";
            cbotrabajador.DisplayMember = "nom_producto";
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
                this.pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.pxImagen.Image bajar una imagen .pgn transparente
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
                if (this.txtnom.Text == string.Empty || this.txtcodcat.Text == string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtnom, "Ingrese un Valor");
                    erroricono.SetError(txtcodcat, "Ingrese un Valor");
                }
                else
                {

                    if (this.IsNuevo)
                    {
                        rpta = NCategoria.Insertar(this.txtnom.Text.Trim());// borra espacios y convierte en mayuscula
                        MensajeOK("Se inserto Correctamente");
                    }
                    else
                    {
                        rpta = NCategoria.Editar(Convert.ToInt32(this.txtcod_cat.Text), this.txtnom.Text.Trim().ToUpper());
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
    }
}
