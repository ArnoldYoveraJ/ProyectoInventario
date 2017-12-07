namespace CapaPresentacion
{
    partial class FrmReporteActaEntregaEquipo
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
            this.reporteGenerarActaEntregaEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteGenerarActaEntregaEquipoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ReporteGenerarActaEntregaEquipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGenerarActaEntregaEquipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporteGenerarActaEntregaEquipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptActaEntregaEquipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 418);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteGenerarActaEntregaEquipoBindingSource
            // 
            this.reporteGenerarActaEntregaEquipoBindingSource.DataMember = "ReporteGenerarActaEntregaEquipo";
            this.reporteGenerarActaEntregaEquipoBindingSource.DataSource = this.dsPrincipal;
            // 
            // reporteGenerarActaEntregaEquipoTableAdapter
            // 
            this.reporteGenerarActaEntregaEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteActaEntregaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteActaEntregaEquipo";
            this.Text = "Reporte de Acta Entrega de Equipos";
            this.Load += new System.EventHandler(this.FrmReporteActaEntregaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGenerarActaEntregaEquipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource reporteGenerarActaEntregaEquipoBindingSource;
        private dsPrincipalTableAdapters.ReporteGenerarActaEntregaEquipoTableAdapter reporteGenerarActaEntregaEquipoTableAdapter;
    }
}