namespace CapaPresentacion
{
    partial class FrmReporteMovimientos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.SP_MOSTRAR_MOVIMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_MOSTRAR_MOVIMIENTOTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.SP_MOSTRAR_MOVIMIENTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MOSTRAR_MOVIMIENTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_MOSTRAR_MOVIMIENTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptMovimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_MOSTRAR_MOVIMIENTOBindingSource
            // 
            this.SP_MOSTRAR_MOVIMIENTOBindingSource.DataMember = "SP_MOSTRAR_MOVIMIENTO";
            this.SP_MOSTRAR_MOVIMIENTOBindingSource.DataSource = this.dsPrincipal;
            // 
            // SP_MOSTRAR_MOVIMIENTOTableAdapter
            // 
            this.SP_MOSTRAR_MOVIMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteMovimientos";
            this.Text = "Reporte de Movimiento de Artículos";
            this.Load += new System.EventHandler(this.FrmReporteMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MOSTRAR_MOVIMIENTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_MOSTRAR_MOVIMIENTOBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.SP_MOSTRAR_MOVIMIENTOTableAdapter SP_MOSTRAR_MOVIMIENTOTableAdapter;
    }
}