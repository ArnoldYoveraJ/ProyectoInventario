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
    public partial class FrmMovimiento : Form
    {
        public int cod_usu;//para enviar el codigo de usuario al frmprincipal
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static FrmMovimiento _Instancia;
        Validar v = new Validar();//instanciar la clase validar

        //código Nuevo
        public static FrmMovimiento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmMovimiento();
            }
            return _Instancia;
        }
        //código Nuevo

        public FrmMovimiento()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(txtusuario, "Seleccione un Usuario");
            this.ttmensaje.SetToolTip(txttrabajador, "Seleccione un Trabajador");
            this.ttmensaje.SetToolTip(txtproducto, "Seleccione un Producto");
            this.ttmensaje.SetToolTip(txtcondicion, "Explique las condiciones en que se entrega el Equipo");
            this.ttmensaje.SetToolTip(txtmot, "Explique el motivo");
            this.txtusuario.ReadOnly = true;
            this.txtcod_mov.Visible = false;

        }

        private void btnbuscar_usuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.mostrar();
            this.Botones();
            this.habilitar(false);
            this.IsNuevo = false;
            this.IsEditar = false;
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
            this.txtcod_mov.Text = string.Empty;
            this.txtcod_usu.Text = string.Empty;
            this.txtusuario.Text = string.Empty;
            this.txtcod_tra.Text = string.Empty;
            this.txttrabajador.Text = string.Empty;
            this.txtcod_pro.Text = string.Empty;
            this.txtproducto.Text = string.Empty;
            this.txtcondicion.Text = string.Empty;
            this.txtmot.Text = string.Empty;
        }

        //Activar botones

        private void habilitar(bool valor)
        {
            this.txtcod_mov.ReadOnly = !valor;
            this.txtcod_usu.ReadOnly = !valor; //ReadOnly:para hacerla de solo lectura
            this.txtusuario.ReadOnly = !valor;
            this.txtcod_tra.ReadOnly = !valor;
            this.txttrabajador.ReadOnly = !valor;
            this.txtcod_pro.ReadOnly = !valor;
            this.txtproducto.ReadOnly = !valor;
            this.txtcondicion.ReadOnly = !valor;
            this.txtmot.ReadOnly = !valor;
            this.btnbuscar_usuario.Enabled = valor;
            this.btnbuscar_producto.Enabled = valor;
            this.btnbuscar_trabajador.Enabled = valor;
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
            this.dgvlistado.Columns[10].Visible = false;
            this.dgvlistado.Columns[12].Visible = false;
            this.dgvlistado.Columns[13].Visible = false;
        }

        //Mostrar
        private void mostrar()
        {
            this.dgvlistado.DataSource = NMovimiento.mostrar_movimiento();
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        //Buscar Categoria por nombre
        private void buscar()
        {
            this.dgvlistado.DataSource = NMovimiento.buscar_movimiento(Convert.ToDateTime(this.dtfecha1.Text), Convert.ToDateTime(this.dtfecha2.Text));
            this.ocultarcolumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvlistado.Rows.Count);
        }

        public void setProducto(string cod_pro, string nombre)
        {
            this.txtcod_pro.Text = cod_pro;
            this.txtproducto.Text = nombre;
        }

        public void setTrabajador(string cod_tra,string nom_tra)
        {
            this.txtcod_tra.Text = cod_tra;
            this.txttrabajador.Text = nom_tra;
        }

        private void btnbuscar_producto_Click(object sender, EventArgs e)
        {
            FrmVistaProductoIngreso objmov = new FrmVistaProductoIngreso();
            objmov.ShowDialog();
        }

        private void btnbuscar_trabajador_Click(object sender, EventArgs e)
        {
            FrmVistaTrabajador_Producto objmov = new FrmVistaTrabajador_Producto();
            objmov.ShowDialog();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarBotones();
            this.habilitar(true);
            this.txtcod_usu.Focus();
            this.txtcod_usu.Text=Convert.ToString(cod_usu);//revisar línea para envíar el código de usuario
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtcod_mov.Text.Equals(""))
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

        private void dgvlistadomov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkeliminar.Checked)
                this.dgvlistado.Columns[0].Visible = true;
            else
                this.dgvlistado.Columns[0].Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string rpta;
            try
            {
                if (this.txtcondicion.Text == string.Empty) //si la caja de texto está vacía
                {
                    MensajeError("Faltan Ingresar Datos");
                    erroricono.SetError(txtcondicion, "Ingrese una condición");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NMovimiento.insertar_movimiento(this.dtfecha.Value, this.txtcondicion.Text.Trim(), cod_usu,
                            Convert.ToInt16(this.txtcod_tra.Text.Trim()), Convert.ToInt16(this.txtcod_pro.Text.Trim()), "EMITIDO",
                            this.txtmot.Text.Trim(), DateTime.Today, "No tiene");// borra espacios y convierte en mayuscula
                        MensajeOK("Se Inserto Correctamente");
                    }
                    else
                    {
                        //Falta el campo: cod_usu en editar. 
                        rpta = NMovimiento.editar_movimiento(Convert.ToInt16(this.txtcod_mov.Text), this.dtfecha.Value, this.txtcondicion.Text.Trim(), Convert.ToInt16(this.txtcod_usu.Text.Trim()),
                            Convert.ToInt16(this.txtcod_tra.Text.Trim()), Convert.ToInt16(this.txtcod_pro.Text.Trim()), "EMITIDO",
                            this.txtmot.Text.Trim(), DateTime.Today, "No tiene");// borra espacios y convierte en mayuscula
                        MensajeOK("Se Editó Correctamente");
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

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcod_mov.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_mov"].Value);
            this.txtcod_usu.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_usu"].Value);
            this.txtusuario.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["usuario"].Value);
            this.txtcod_tra.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_trabajador"].Value);
            this.txttrabajador.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["trabajador"].Value);
            this.txtcod_pro.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_producto"].Value);
            this.txtproducto.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["nom_producto"].Value);
            this.txtcondicion.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["condicion"].Value);
            this.txtmot.Text = Convert.ToString(dgvlistado.CurrentRow.Cells["motivo"].Value);
            this.dtfecha.Value = Convert.ToDateTime(dgvlistado.CurrentRow.Cells["fecha"].Value);
            this.txtcod_mov.ReadOnly = false;
            tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string est;
            est = Convert.ToString(dgvlistado.CurrentRow.Cells["estado"].Value);

            if (est.Equals("ANULADO"))
            {
                MensajeError("El Movimiento ya se encuentra anulado");
            }
            else
            {
                //Para enviar los datos a FrmDevolver_Artículo
                FrmDevolver_Articulo form1 = FrmDevolver_Articulo.GetInstancia();
                form1.Show();
                string p1, p2, p3, p4, p5;
                int p7;
                DateTime p6;
                p1 = Convert.ToString(dgvlistado.CurrentRow.Cells["cod_mov"].Value);
                p2 = Convert.ToString(dgvlistado.CurrentRow.Cells["usuario"].Value);
                p3 = Convert.ToString(dgvlistado.CurrentRow.Cells["trabajador"].Value);
                p4 = Convert.ToString(dgvlistado.CurrentRow.Cells["nom_producto"].Value);
                p5 = Convert.ToString(dgvlistado.CurrentRow.Cells["condicion"].Value);
                p6 = Convert.ToDateTime(dgvlistado.CurrentRow.Cells["fecha"].Value);
                p7 = Convert.ToInt32(dgvlistado.CurrentRow.Cells["COD_PRODUCTO"].Value);
                form1.setMovimiento(p1, p2, p3, p4, p5, p6, p7);
            }
            /*
            try
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
                            rpta = NMovimiento.anular_movimiento(Convert.ToInt32(cod),cod_pro);

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
              */
        }

        private void FrmMovimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporteMovimientos objrm = new FrmReporteMovimientos();
            objrm.ShowDialog();
        }

        private void txtmot_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }
    }
}
