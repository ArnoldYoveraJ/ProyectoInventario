namespace CapaPresentacion
{
    partial class FrmVistaBajaProductoMovimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboElegir = new System.Windows.Forms.ComboBox();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblfechaini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // cboElegir
            // 
            this.cboElegir.FormattingEnabled = true;
            this.cboElegir.Items.AddRange(new object[] {
            "...",
            "Trabajador",
            "Fechas"});
            this.cboElegir.Location = new System.Drawing.Point(86, 9);
            this.cboElegir.Name = "cboElegir";
            this.cboElegir.Size = new System.Drawing.Size(108, 21);
            this.cboElegir.TabIndex = 12;
            this.cboElegir.Text = "...";
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(214, 9);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(117, 20);
            this.txtApe.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movimientos de Equipos";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 338);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cboElegir);
            this.tabPage1.Controls.Add(this.txtApe);
            this.tabPage1.Controls.Add(this.lblfechafin);
            this.tabPage1.Controls.Add(this.dtfecha2);
            this.tabPage1.Controls.Add(this.dtfecha1);
            this.tabPage1.Controls.Add(this.dgvlistado);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.lblfechaini);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Location = new System.Drawing.Point(211, 49);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(57, 13);
            this.lblfechafin.TabIndex = 10;
            this.lblfechafin.Text = "Fecha Fin:";
            // 
            // dtfecha2
            // 
            this.dtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha2.Location = new System.Drawing.Point(274, 45);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(96, 20);
            this.dtfecha2.TabIndex = 9;
            // 
            // dtfecha1
            // 
            this.dtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha1.Location = new System.Drawing.Point(93, 45);
            this.dtfecha1.Name = "dtfecha1";
            this.dtfecha1.Size = new System.Drawing.Size(96, 20);
            this.dtfecha1.TabIndex = 8;
            // 
            // dgvlistado
            // 
            this.dgvlistado.AllowUserToAddRows = false;
            this.dgvlistado.AllowUserToDeleteRows = false;
            this.dgvlistado.AllowUserToOrderColumns = true;
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvlistado.Location = new System.Drawing.Point(18, 94);
            this.dgvlistado.MultiSelect = false;
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.ReadOnly = true;
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(657, 209);
            this.dgvlistado.TabIndex = 7;
            this.dgvlistado.DoubleClick += new System.EventHandler(this.dgvlistado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(536, 78);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "label2";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar11;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(600, 49);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblfechaini
            // 
            this.lblfechaini.AutoSize = true;
            this.lblfechaini.Location = new System.Drawing.Point(19, 49);
            this.lblfechaini.Name = "lblfechaini";
            this.lblfechaini.Size = new System.Drawing.Size(68, 13);
            this.lblfechaini.TabIndex = 0;
            this.lblfechaini.Text = "Fecha Inicio:";
            // 
            // FrmVistaBajaProductoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmVistaBajaProductoMovimiento";
            this.Text = "Seleccionar Equipo de Movimiento";
            this.Load += new System.EventHandler(this.FrmVistaBajaProductoMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboElegir;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.DateTimePicker dtfecha1;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblfechaini;
    }
}