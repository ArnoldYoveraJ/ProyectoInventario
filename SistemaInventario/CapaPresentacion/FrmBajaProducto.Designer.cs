namespace CapaPresentacion
{
    partial class FrmBajaProducto
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtexplicacion = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcod_pro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcod_baja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblserie = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtcod_mov = new System.Windows.Forms.TextBox();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.btnbuscar_producto = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Explicación...";
            // 
            // txtexplicacion
            // 
            this.txtexplicacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtexplicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexplicacion.Location = new System.Drawing.Point(36, 205);
            this.txtexplicacion.MaxLength = 70;
            this.txtexplicacion.Multiline = true;
            this.txtexplicacion.Name = "txtexplicacion";
            this.txtexplicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtexplicacion.Size = new System.Drawing.Size(303, 58);
            this.txtexplicacion.TabIndex = 51;
            // 
            // txtproducto
            // 
            this.txtproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproducto.Location = new System.Drawing.Point(63, 55);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(121, 20);
            this.txtproducto.TabIndex = 49;
            this.txtproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproducto_KeyPress);
            // 
            // txtcod_pro
            // 
            this.txtcod_pro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_pro.Location = new System.Drawing.Point(63, 25);
            this.txtcod_pro.Name = "txtcod_pro";
            this.txtcod_pro.Size = new System.Drawing.Size(53, 20);
            this.txtcod_pro.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Equipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Código:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Fecha Fin:";
            // 
            // dtfecha2
            // 
            this.dtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha2.Location = new System.Drawing.Point(136, 32);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(96, 20);
            this.dtfecha2.TabIndex = 9;
            // 
            // dtfecha1
            // 
            this.dtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha1.Location = new System.Drawing.Point(18, 32);
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
            this.dgvlistado.Location = new System.Drawing.Point(18, 78);
            this.dgvlistado.MultiSelect = false;
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.ReadOnly = true;
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(657, 199);
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
            this.lbltotal.Location = new System.Drawing.Point(528, 51);
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
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(420, 243);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(115, 20);
            this.dtfecha.TabIndex = 38;
            // 
            // txtcod_baja
            // 
            this.txtcod_baja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_baja.Location = new System.Drawing.Point(82, 28);
            this.txtcod_baja.Name = "txtcod_baja";
            this.txtcod_baja.Size = new System.Drawing.Size(53, 20);
            this.txtcod_baja.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. Baja:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Baja de Equipos";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 331);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.dtfecha2);
            this.tabPage1.Controls.Add(this.dtfecha1);
            this.tabPage1.Controls.Add(this.dgvlistado);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.chkeliminar);
            this.tabPage1.Controls.Add(this.btnimprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::CapaPresentacion.Properties.Resources.imprimir1;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(598, 22);
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
            this.btnEliminar.Location = new System.Drawing.Point(517, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Anular";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar11;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(436, 23);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(15, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(68, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Fecha Inicio:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pxImagen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtexplicacion);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtcod_baja);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja_Equipos";
            // 
            // txtserie
            // 
            this.txtserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserie.Location = new System.Drawing.Point(256, 81);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(121, 20);
            this.txtserie.TabIndex = 57;
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(213, 83);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(34, 13);
            this.lblserie.TabIndex = 56;
            this.lblserie.Text = "Serie:";
            // 
            // txtmarca
            // 
            this.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmarca.Location = new System.Drawing.Point(63, 81);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(121, 20);
            this.txtmarca.TabIndex = 55;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(14, 83);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 54;
            this.lblmarca.Text = "Marca:";
            // 
            // txtcod_mov
            // 
            this.txtcod_mov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_mov.Location = new System.Drawing.Point(324, 19);
            this.txtcod_mov.Name = "txtcod_mov";
            this.txtcod_mov.Size = new System.Drawing.Size(53, 20);
            this.txtcod_mov.TabIndex = 53;
            // 
            // pxImagen
            // 
            this.pxImagen.BackgroundImage = global::CapaPresentacion.Properties.Resources.img_transpa;
            this.pxImagen.Location = new System.Drawing.Point(420, 57);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(115, 115);
            this.pxImagen.TabIndex = 11;
            this.pxImagen.TabStop = false;
            // 
            // btnbuscar_producto
            // 
            this.btnbuscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar_producto.Image = global::CapaPresentacion.Properties.Resources.icono_adicionar1;
            this.btnbuscar_producto.Location = new System.Drawing.Point(148, 21);
            this.btnbuscar_producto.Name = "btnbuscar_producto";
            this.btnbuscar_producto.Size = new System.Drawing.Size(36, 24);
            this.btnbuscar_producto.TabIndex = 50;
            this.btnbuscar_producto.UseVisualStyleBackColor = true;
            this.btnbuscar_producto.Click += new System.EventHandler(this.btnbuscar_producto_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::CapaPresentacion.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(574, 115);
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
            this.btneditar.Location = new System.Drawing.Point(574, 86);
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
            this.btnguardar.Location = new System.Drawing.Point(574, 57);
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
            this.btnnuevo.Location = new System.Drawing.Point(574, 28);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbuscar_producto);
            this.groupBox2.Controls.Add(this.txtcod_mov);
            this.groupBox2.Controls.Add(this.txtserie);
            this.groupBox2.Controls.Add(this.txtproducto);
            this.groupBox2.Controls.Add(this.lblserie);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtcod_pro);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblmarca);
            this.groupBox2.Location = new System.Drawing.Point(19, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 115);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Equipo";
            // 
            // FrmBajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmBajaProducto";
            this.Text = "Mantenimiento de Baja de Equipos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBajaProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmBajaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtexplicacion;
        private System.Windows.Forms.Button btnbuscar_producto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcod_pro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.DateTimePicker dtfecha1;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtcod_baja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.TextBox txtcod_mov;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}