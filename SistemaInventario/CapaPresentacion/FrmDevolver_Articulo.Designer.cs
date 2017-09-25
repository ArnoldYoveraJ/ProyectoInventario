namespace CapaPresentacion
{
    partial class FrmDevolver_Articulo
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
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcod_prod = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfec = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcod_mov = new System.Windows.Forms.TextBox();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtconrec = new System.Windows.Forms.TextBox();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcod_prod);
            this.groupBox1.Controls.Add(this.txtcon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpfec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcod_mov);
            this.groupBox1.Controls.Add(this.txtpro);
            this.groupBox1.Controls.Add(this.txtusu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 228);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Equipo";
            // 
            // txtcod_prod
            // 
            this.txtcod_prod.Location = new System.Drawing.Point(295, 111);
            this.txtcod_prod.Name = "txtcod_prod";
            this.txtcod_prod.Size = new System.Drawing.Size(48, 20);
            this.txtcod_prod.TabIndex = 15;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(119, 143);
            this.txtcon.Multiline = true;
            this.txtcon.Name = "txtcon";
            this.txtcon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcon.Size = new System.Drawing.Size(214, 50);
            this.txtcon.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cód. Movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // dtpfec
            // 
            this.dtpfec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfec.Location = new System.Drawing.Point(119, 199);
            this.dtpfec.Name = "dtpfec";
            this.dtpfec.Size = new System.Drawing.Size(100, 20);
            this.dtpfec.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trabajador:";
            // 
            // txtcod_mov
            // 
            this.txtcod_mov.Location = new System.Drawing.Point(119, 25);
            this.txtcod_mov.Name = "txtcod_mov";
            this.txtcod_mov.Size = new System.Drawing.Size(100, 20);
            this.txtcod_mov.TabIndex = 5;
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(119, 111);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(170, 20);
            this.txtpro.TabIndex = 11;
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(119, 52);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(100, 20);
            this.txtusu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha:";
            // 
            // txttra
            // 
            this.txttra.Location = new System.Drawing.Point(119, 82);
            this.txttra.Name = "txttra";
            this.txttra.Size = new System.Drawing.Size(170, 20);
            this.txttra.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Condición:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Equipo:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(270, 344);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(189, 344);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 19;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtconrec
            // 
            this.txtconrec.Location = new System.Drawing.Point(131, 267);
            this.txtconrec.Multiline = true;
            this.txtconrec.Name = "txtconrec";
            this.txtconrec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtconrec.Size = new System.Drawing.Size(214, 58);
            this.txtconrec.TabIndex = 18;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Condición de Equi. Recibido:";
            // 
            // FrmDevolver_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtconrec);
            this.Controls.Add(this.label1);
            this.Name = "FrmDevolver_Articulo";
            this.Text = "Devolver Equipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDevolver_Articulo_FormClosing);
            this.Load += new System.EventHandler(this.FrmDevolver_Artíiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcod_mov;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtconrec;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod_prod;

    }
}