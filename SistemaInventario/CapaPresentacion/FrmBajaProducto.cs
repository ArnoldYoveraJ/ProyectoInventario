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
    public partial class FrmBajaProducto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static FrmBajaProducto _Instancia;
        Validar v = new Validar(); // Instanciar la clase Validar

        //código Nuevo
        public static FrmBajaProducto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmBajaProducto();
            }
            return _Instancia;
        }
        public FrmBajaProducto()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtcod_pro, "Seleccione un Producto");
            this.ttmensaje.SetToolTip(this.txtexplicacion, "Registre una explicación");
            this.txtcod_baja.Visible = false;
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
            this.txtcod_baja.Text = string.Empty;
            this.txtcod_pro.Text = string.Empty;
            this.txtproducto.Text = string.Empty;
            this.txtexplicacion.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_baja.ReadOnly = !valor;
            this.txtcod_pro.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtproducto.ReadOnly = !valor;
            this.txtexplicacion.ReadOnly = !valor;
            this.btnbuscar_producto.Enabled = valor;
            this.dtfecha.Enabled = valor;
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
            this.dgvlistado.Columns[7].Visible = false;
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NBaja_Producto.Mostrar();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar()
        {
            this.dgvlistado.DataSource = NBaja_Producto.Buscar_Baja_Productos(Convert.ToDateTime(this.dtfecha1.Text), Convert.ToDateTime(this.dtfecha2.Text));
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        public void setProducto(string cod_pro, string nombre)
        {
            this.txtcod_pro.Text = cod_pro;
            this.txtproducto.Text = nombre;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarBotones();
            this.habilitar(true);
            this.txtcod_baja.Focus();
            this.txtcod_pro.Enabled = false; //deshabilitar el código de producto
           // this.txtcod_usu.Text = Convert.ToString(cod_usu);//revisar línea para envíar el código de usuario
        }

        private void FrmBajaProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.mostrar();
            this.Botones();
            this.habilitar(false);
            this.IsNuevo = false;
            this.IsEditar = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtcod_baja.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.habilitar(true);
                this.txtcod_pro.Enabled = false;//deshabilitar el código de producto
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

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
                this.dgvlistado.Columns[0].Visible = true;
            else
                this.dgvlistado.Columns[0].Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void FrmBajaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               string est;
               est = Convert.ToString(dgvlistado.CurrentRow.Cells["estado"].Value);
               if (est.Equals("ANULADO"))
               {
                   MensajeError("La Baja del Producto ya está anulado");
               }
               else
               {
                   DialogResult opcion;
                   opcion = MessageBox.Show("Realmente desea Anular los Registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                   if (opcion == DialogResult.OK) //SI usuario dice OK
                   {
                       string cod, rpta = "";
                       int cod_pro;//para el codigo de producto
                       foreach (DataGridViewRow row in dgvlistado.Rows)//Recorre todas las filas del DataGridView
                       {
                           if (Convert.ToBoolean(row.Cells[0].Value)) //Revisa si la fila está activada
                           {
                               cod = Convert.ToString(row.Cells[1].Value);
                               //Para traer el código de producto del movimiento que se a seleccionado en el DataGridView
                               cod_pro = Convert.ToInt16(dgvlistado.CurrentRow.Cells["cod_producto"].Value);

                               rpta = NBaja_Producto.Eliminar(Convert.ToInt32(cod), cod_pro);

                               if (rpta.Equals("OK"))
                               {
                                   this.MensajeOK("Se Anuló correctamente el Registro");
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if (this.txtexplicacion.Text == string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtexplicacion, "Ingrese una condición");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NBaja_Producto.Insertar(this.dtfecha.Value, this.txtexplicacion.Text.Trim(),"EMITIDO",
                               Convert.ToInt16(this.txtcod_pro.Text.Trim()));// borra espacios y convierte en mayuscula
                        MensajeOK("Se Inserto Correctamente");
                    }
                    else
                    {
                        //Falta el campo: cod_usu en editar. 
                        rpta = NBaja_Producto.Editar(Convert.ToInt32(this.txtcod_baja.Text),this.dtfecha.Value, this.txtexplicacion.Text.Trim(), "EMITIDO",
                                Convert.ToInt16(this.txtcod_pro.Text.Trim()));// borra espacios y convierte en mayuscula
                        MensajeOK("Se Editó Correctamente");
                    }
                    this.MensajeError(rpta);

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.LimpiarBotones();
                    this.Botones();
                    this.tabControl1.SelectedIndex = 0;
                    this.mostrar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnbuscar_producto_Click(object sender, EventArgs e)
        {
            FrmVistaProductoIngreso objbaja = new FrmVistaProductoIngreso();
            objbaja.ShowDialog();
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcod_baja.Text =Convert.ToString(dgvlistado.CurrentRow.Cells["cod_baja"].Value);
            this.txtcod_baja.Visible = false;//deshabilitar el código cuando edite
            this.txtcod_pro.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_producto"].Value);
            this.txtproducto.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["producto"].Value);
            this.txtexplicacion.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["explicacion"].Value);
            this.dtfecha.Value = Convert.ToDateTime(dgvlistado.CurrentRow.Cells["fecha"].Value);

            byte[] imagenBuffer = (byte[])this.dgvlistado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;//para que la img se adeque al tamaño de toda la pantalla

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporte_BajaProducto objbp = new FrmReporte_BajaProducto();
            objbp.ShowDialog();
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }
    }
}
