namespace CapaPresentacion
{
    partial class FrmProveedores
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodoc = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtnum_doc = new System.Windows.Forms.TextBox();
            this.txtsectorc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtrazons = new System.Windows.Forms.TextBox();
            this.txtcod_prov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 332);
            this.tabControl1.TabIndex = 5;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboelegir
            // 
            this.cboelegir.FormattingEnabled = true;
            this.cboelegir.Items.AddRange(new object[] {
            "Razon Social",
            "Numero"});
            this.cboelegir.Location = new System.Drawing.Point(18, 23);
            this.cboelegir.Name = "cboelegir";
            this.cboelegir.Size = new System.Drawing.Size(101, 21);
            this.cboelegir.TabIndex = 8;
            this.cboelegir.Text = "Razon Social";
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
            this.dgvlistado.Size = new System.Drawing.Size(605, 211);
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
            this.lbltotal.Location = new System.Drawing.Point(507, 59);
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
            this.btnimprimir.Location = new System.Drawing.Point(548, 24);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 4;
            this.btnimprimir.Text = "&Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.Eliminar2;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(467, 25);
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
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.erroricono.SetIconAlignment(this.btnbuscar, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btnbuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar11;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(384, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Location = new System.Drawing.Point(125, 23);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(146, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbotipodoc);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdir);
            this.groupBox1.Controls.Add(this.txtnum_doc);
            this.groupBox1.Controls.Add(this.txtsectorc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtrazons);
            this.groupBox1.Controls.Add(this.txtcod_prov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbotipodoc
            // 
            this.cbotipodoc.FormattingEnabled = true;
            this.cbotipodoc.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cbotipodoc.Location = new System.Drawing.Point(270, 81);
            this.cbotipodoc.Name = "cbotipodoc";
            this.cbotipodoc.Size = new System.Drawing.Size(121, 21);
            this.cbotipodoc.TabIndex = 25;
            this.cbotipodoc.Text = "RUC";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(84, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(307, 20);
            this.txtemail.TabIndex = 24;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Location = new System.Drawing.Point(271, 107);
            this.txttel.MaxLength = 9;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(120, 20);
            this.txttel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Teléfono";
            // 
            // txtdir
            // 
            this.txtdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdir.Location = new System.Drawing.Point(85, 107);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(122, 20);
            this.txtdir.TabIndex = 20;
            // 
            // txtnum_doc
            // 
            this.txtnum_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_doc.Location = new System.Drawing.Point(471, 82);
            this.txtnum_doc.MaxLength = 11;
            this.txtnum_doc.Name = "txtnum_doc";
            this.txtnum_doc.Size = new System.Drawing.Size(126, 20);
            this.txtnum_doc.TabIndex = 19;
            // 
            // txtsectorc
            // 
            this.txtsectorc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsectorc.Location = new System.Drawing.Point(84, 82);
            this.txtsectorc.Name = "txtsectorc";
            this.txtsectorc.Size = new System.Drawing.Size(123, 20);
            this.txtsectorc.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número_doc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo_doc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sector Comer.";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::CapaPresentacion.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(381, 161);
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
            this.btneditar.Location = new System.Drawing.Point(282, 161);
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
            this.btnguardar.Location = new System.Drawing.Point(190, 161);
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
            this.btnnuevo.Location = new System.Drawing.Point(97, 161);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtrazons
            // 
            this.txtrazons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazons.Location = new System.Drawing.Point(84, 54);
            this.txtrazons.Name = "txtrazons";
            this.txtrazons.Size = new System.Drawing.Size(284, 20);
            this.txtrazons.TabIndex = 4;
            // 
            // txtcod_prov
            // 
            this.txtcod_prov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_prov.Location = new System.Drawing.Point(85, 28);
            this.txtcod_prov.Name = "txtcod_prov";
            this.txtcod_prov.Size = new System.Drawing.Size(100, 20);
            this.txtcod_prov.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proveedores";
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(666, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedores";
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtnum_doc;
        private System.Windows.Forms.TextBox txtsectorc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtrazons;
        private System.Windows.Forms.TextBox txtcod_prov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.ComboBox cbotipodoc;
        private System.Windows.Forms.ComboBox cboelegir;
        private System.Windows.Forms.Button btnbuscar;
    }
}