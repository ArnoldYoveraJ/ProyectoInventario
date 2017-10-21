namespace CapaPresentacion
{
    partial class FrmReporte_BajaProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spmostrar_baja_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spmostrar_baja_productoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spmostrar_baja_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_baja_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spmostrar_baja_productoBindingSource
            // 
            this.spmostrar_baja_productoBindingSource.DataMember = "spmostrar_baja_producto";
            this.spmostrar_baja_productoBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrar_baja_productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptBajaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // spmostrar_baja_productoTableAdapter
            // 
            this.spmostrar_baja_productoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte_BajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte_BajaProducto";
            this.Text = "Reporte Baja de Equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporte_BajaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_baja_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_baja_productoBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spmostrar_baja_productoTableAdapter spmostrar_baja_productoTableAdapter;
    }
}