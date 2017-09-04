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
    public partial class FrmDevolver_Articulo : Form
    {
        private bool IsNuevo = false;
        Validar v = new Validar();//instanciar la clase validar
        public FrmDevolver_Articulo()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(txtconrec, "Explique la condición recibida");
        }

        private static FrmDevolver_Articulo _instancia;
        public static FrmDevolver_Articulo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmDevolver_Articulo();
            }
            return _instancia;
        }

        public void setMovimiento(string cod_mov, string usu, string trab, string prod, string con, DateTime fecha,int cod_prod)
        {
            this.txtcod_mov.Text = cod_mov;
            this.txtusu.Text = usu;
            this.txttra.Text = trab;
            this.txtpro.Text = prod;
            this.txtcon.Text = con;
            this.dtpfec.Value = fecha;
            this.txtcod_prod.Text = Convert.ToString(cod_prod);
        }
        private void FrmDevolver_Artíiculo_Load(object sender, EventArgs e)
        {
            this.txtcod_prod.Visible = false;
            habilitar(false);
        }

        private void FrmDevolver_Articulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            _instancia = null;
            Close();
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
            this.txtconrec.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_mov.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtusu.ReadOnly = !valor;
            this.txttra.ReadOnly = !valor;
            this.txtpro.ReadOnly = !valor;
            this.txtcon.ReadOnly = !valor;
            this.dtpfec.Enabled = valor;
        }

        //Desactivar botones
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.habilitar(true);
                this.btnguardar.Enabled = true;
                this.btncancelar.Enabled = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if (this.txtconrec.Text == string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtconrec, "Ingrese una condición del producto recibido");
                }
                else
                {
                    rpta = NMovimiento.anular_movimiento(Convert.ToInt32(this.txtcod_mov.Text.Trim()), Convert.ToInt32(this.txtcod_prod.Text), this.txtconrec.Text);// borra espacios y convierte en mayuscula
                    MensajeOK("Se Inserto Correctamente");
                    this.MensajeError(rpta);
                    this.Botones();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
