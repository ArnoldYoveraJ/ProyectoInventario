namespace CapaPresentacion
{
    partial class FrmReporteProveedores
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
            this.spmostrar_proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spmostrar_proveedorTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spmostrar_proveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spmostrar_proveedorBindingSource
            // 
            this.spmostrar_proveedorBindingSource.DataMember = "spmostrar_proveedor";
            this.spmostrar_proveedorBindingSource.DataSource = this.dsPrincipal;
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
            reportDataSource1.Value = this.spmostrar_proveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 419);
            this.reportViewer1.TabIndex = 1;
            // 
            // spmostrar_proveedorTableAdapter
            // 
            this.spmostrar_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 419);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteProveedores";
            this.Text = "Reporte de Trabajadores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spmostrar_proveedorTableAdapter spmostrar_proveedorTableAdapter;
        private System.Windows.Forms.BindingSource spmostrar_proveedorBindingSource;
    }
}