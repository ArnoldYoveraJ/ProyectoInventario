namespace CapaPresentacion
{
    partial class FrmProducto
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
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboelegir = new System.Windows.Forms.ComboBox();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcod_pro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbram = new System.Windows.Forms.MaskedTextBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboso = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.txttrabajador = new System.Windows.Forms.TextBox();
            this.txtcodtra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprocesador = new System.Windows.Forms.TextBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtmodeloplaca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboelegir);
            this.tabPage1.Controls.Add(this.dgvlistado);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.chkeliminar);
            this.tabPage1.Controls.Add(this.btnimprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboelegir
            // 
            this.cboelegir.FormattingEnabled = true;
            this.cboelegir.Items.AddRange(new object[] {
            "Nombre",
            "Marca",
            "Serie"});
            this.cboelegir.Location = new System.Drawing.Point(82, 24);
            this.cboelegir.Name = "cboelegir";
            this.cboelegir.Size = new System.Drawing.Size(121, 21);
            this.cboelegir.TabIndex = 8;
            this.cboelegir.Text = "Nombre";
            this.cboelegir.SelectedIndexChanged += new System.EventHandler(this.cboelegir_SelectedIndexChanged);
            // 
            // dgvlistado
            // 
            this.dgvlistado.AllowUserToAddRows = false;
            this.dgvlistado.AllowUserToDeleteRows = false;
            this.dgvlistado.AllowUserToOrderColumns = true;
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvlistado.Location = new System.Drawing.Point(18, 78);
            this.dgvlistado.MultiSelect = false;
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.ReadOnly = true;
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(814, 224);
            this.dgvlistado.TabIndex = 7;
            this.dgvlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistado_CellContentClick);
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
            this.lbltotal.Location = new System.Drawing.Point(690, 62);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "label2";
            // 
            // chkeliminar
            // 
            this.chkeliminar.AutoSize = true;
            this.chkeliminar.Location = new System.Drawing.Point(18, 58);
            this.chkeliminar.Name = "chkeliminar";
            this.chkeliminar.Size = new System.Drawing.Size(62, 17);
            this.chkeliminar.TabIndex = 5;
            this.chkeliminar.Text = "Eliminar";
            this.chkeliminar.UseVisualStyleBackColor = true;
            this.chkeliminar.CheckedChanged += new System.EventHandler(this.chkeliminar_CheckedChanged);
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::CapaPresentacion.Properties.Resources.imprimir1;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(693, 24);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 4;
            this.btnimprimir.Text = "&Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.Eliminar2;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(612, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar11;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(531, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Location = new System.Drawing.Point(209, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(183, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(15, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(61, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Buscar por:";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::CapaPresentacion.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(369, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::CapaPresentacion.Properties.Resources.Editar;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(270, 217);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "E&ditar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::CapaPresentacion.Properties.Resources.guardar11;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(178, 217);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::CapaPresentacion.Properties.Resources.Nuevo;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(85, 217);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnom.Location = new System.Drawing.Point(310, 28);
            this.txtnom.MaxLength = 30;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(284, 20);
            this.txtnom.TabIndex = 4;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // txtcod_pro
            // 
            this.txtcod_pro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_pro.Location = new System.Drawing.Point(85, 28);
            this.txtcod_pro.Name = "txtcod_pro";
            this.txtcod_pro.Size = new System.Drawing.Size(100, 20);
            this.txtcod_pro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbram);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cboso);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.cbocategoria);
            this.groupBox1.Controls.Add(this.txttrabajador);
            this.groupBox1.Controls.Add(this.txtcodtra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtdesc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtdd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtprocesador);
            this.groupBox1.Controls.Add(this.txtserie);
            this.groupBox1.Controls.Add(this.txtmodeloplaca);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.pxImagen);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtcod_pro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // mtbram
            // 
            this.mtbram.Location = new System.Drawing.Point(494, 84);
            this.mtbram.Mask = "99GB";
            this.mtbram.Name = "mtbram";
            this.mtbram.Size = new System.Drawing.Size(56, 20);
            this.mtbram.TabIndex = 41;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "Ocupado",
            "Disponible"});
            this.cboestado.Location = new System.Drawing.Point(85, 148);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(103, 21);
            this.cboestado.TabIndex = 40;
            this.cboestado.Text = "Disponible";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Tipo Estado:";
            // 
            // cboso
            // 
            this.cboso.FormattingEnabled = true;
            this.cboso.Items.AddRange(new object[] {
            "Windows XP (32 Bits)",
            "Windows Vista (32 Bits)",
            "Windows Vista (64 Bits)",
            "Windows 7 (32 Bits)",
            "Windows 7 (64 Bits)",
            "Windows 8 (32 Bits)",
            "Windows 8 (64 Bits)",
            "Windows 8.1 (32 Bits)",
            "Windows 8.1 (64 Bits)",
            "Windows 10(32 Bits)",
            "Windows 10 (64 Bits)",
            "Windows Server",
            "No Tiene"});
            this.cboso.Location = new System.Drawing.Point(85, 175);
            this.cboso.Name = "cboso";
            this.cboso.Size = new System.Drawing.Size(178, 21);
            this.cboso.TabIndex = 38;
            this.cboso.Text = "Windows 7 (64 Bits)";
            // 
            // btnagregar
            // 
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Image = global::CapaPresentacion.Properties.Resources.icono_adicionar1;
            this.btnagregar.Location = new System.Drawing.Point(739, 183);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(36, 24);
            this.btnagregar.TabIndex = 37;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cbocategoria
            // 
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(654, 239);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(121, 21);
            this.cbocategoria.TabIndex = 36;
            // 
            // txttrabajador
            // 
            this.txttrabajador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttrabajador.Location = new System.Drawing.Point(654, 213);
            this.txttrabajador.Name = "txttrabajador";
            this.txttrabajador.Size = new System.Drawing.Size(121, 20);
            this.txttrabajador.TabIndex = 35;
            // 
            // txtcodtra
            // 
            this.txtcodtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodtra.Location = new System.Drawing.Point(654, 187);
            this.txtcodtra.Name = "txtcodtra";
            this.txtcodtra.Size = new System.Drawing.Size(75, 20);
            this.txtcodtra.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(572, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Trabajador";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(578, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Categoria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Código";
            // 
            // txtdesc
            // 
            this.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc.Location = new System.Drawing.Point(310, 125);
            this.txtdesc.MaxLength = 50;
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdesc.Size = new System.Drawing.Size(240, 71);
            this.txtdesc.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Descripción:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sist. Operativo:";
            // 
            // txtdd
            // 
            this.txtdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdd.Location = new System.Drawing.Point(310, 88);
            this.txtdd.MaxLength = 6;
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(58, 20);
            this.txtdd.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Memoria RAM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Disco Duro:";
            // 
            // txtprocesador
            // 
            this.txtprocesador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprocesador.Location = new System.Drawing.Point(85, 88);
            this.txtprocesador.MaxLength = 10;
            this.txtprocesador.Name = "txtprocesador";
            this.txtprocesador.Size = new System.Drawing.Size(100, 20);
            this.txtprocesador.TabIndex = 20;
            // 
            // txtserie
            // 
            this.txtserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserie.Location = new System.Drawing.Point(494, 56);
            this.txtserie.MaxLength = 30;
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 19;
            // 
            // txtmodeloplaca
            // 
            this.txtmodeloplaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmodeloplaca.Location = new System.Drawing.Point(310, 56);
            this.txtmodeloplaca.MaxLength = 30;
            this.txtmodeloplaca.Name = "txtmodeloplaca";
            this.txtmodeloplaca.Size = new System.Drawing.Size(100, 20);
            this.txtmodeloplaca.TabIndex = 18;
            // 
            // txtmarca
            // 
            this.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmarca.Location = new System.Drawing.Point(85, 56);
            this.txtmarca.MaxLength = 30;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 17;
            this.txtmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmarca_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Procesador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Serie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.Eliminar_1___copia22;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(710, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Image = global::CapaPresentacion.Properties.Resources.Agregar_img;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(629, 140);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pxImagen
            // 
            this.pxImagen.BackgroundImage = global::CapaPresentacion.Properties.Resources.img_transpa;
            this.pxImagen.Location = new System.Drawing.Point(654, 19);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(113, 115);
            this.pxImagen.TabIndex = 10;
            this.pxImagen.TabStop = false;
            this.pxImagen.Click += new System.EventHandler(this.pxImagen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 336);
            this.tabControl1.TabIndex = 3;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(875, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProducto";
            this.Text = "Mantenimiento de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcod_pro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprocesador;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtmodeloplaca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.TextBox txttrabajador;
        private System.Windows.Forms.TextBox txtcodtra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboelegir;
        private System.Windows.Forms.ComboBox cboso;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mtbram;
    }
}