namespace CapaPresentacion
{
    partial class FrmReporteBajaProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.spmostrar_baja_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_baja_productoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spmostrar_baja_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_baja_productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spmostrar_baja_productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptBajaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostrar_baja_productoBindingSource
            // 
            this.spmostrar_baja_productoBindingSource.DataMember = "spmostrar_baja_producto";
            this.spmostrar_baja_productoBindingSource.DataSource = this.dsPrincipal;
            // 
            // spmostrar_baja_productoTableAdapter
            // 
            this.spmostrar_baja_productoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteBajaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 382);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteBajaProductos";
            this.Text = "Reporte de Baja de Productos";
            this.Load += new System.EventHandler(this.FrmReporteBajaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_baja_productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_baja_productoBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spmostrar_baja_productoTableAdapter spmostrar_baja_productoTableAdapter;
    }
}