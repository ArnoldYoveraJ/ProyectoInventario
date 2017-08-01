using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMovimiento : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static FrmMovimiento _Instancia;


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
        public void setTrabajador(string cod_tra, string nom_tra)
        {
            this.txtcodtra.Text = cod_tra;
            this.txttrabajador.Text = nom_tra;
        }


        public FrmMovimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_usuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
