namespace Capa_Presentacion.Forms
{
    partial class FrmFactura
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
            this.sistemaFacturacionDataSet1xdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaFacturacionDataSet1xd = new Capa_Presentacion.SistemaFacturacionDataSet1xd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaFacturacionDataSet1Definitivo = new Capa_Presentacion.SistemaFacturacionDataSet1Definitivo();
            this.sistemaFacturacionDataSet1DefinitivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerarUltimaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarUltimaFacturaTableAdapter = new Capa_Presentacion.SistemaFacturacionDataSet1DefinitivoTableAdapters.sp_GenerarUltimaFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1xdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1xd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1Definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1DefinitivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaFacturacionDataSet1xdBindingSource
            // 
            this.sistemaFacturacionDataSet1xdBindingSource.DataSource = this.sistemaFacturacionDataSet1xd;
            this.sistemaFacturacionDataSet1xdBindingSource.Position = 0;
            // 
            // sistemaFacturacionDataSet1xd
            // 
            this.sistemaFacturacionDataSet1xd.DataSetName = "SistemaFacturacionDataSet1xd";
            this.sistemaFacturacionDataSet1xd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FacturaDefinitiva";
            reportDataSource1.Value = this.spGenerarUltimaFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.FacturaDefinitiva.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(749, 735);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaFacturacionDataSet1Definitivo
            // 
            this.sistemaFacturacionDataSet1Definitivo.DataSetName = "SistemaFacturacionDataSet1Definitivo";
            this.sistemaFacturacionDataSet1Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaFacturacionDataSet1DefinitivoBindingSource
            // 
            this.sistemaFacturacionDataSet1DefinitivoBindingSource.DataSource = this.sistemaFacturacionDataSet1Definitivo;
            this.sistemaFacturacionDataSet1DefinitivoBindingSource.Position = 0;
            // 
            // spGenerarUltimaFacturaBindingSource
            // 
            this.spGenerarUltimaFacturaBindingSource.DataMember = "sp_GenerarUltimaFactura";
            this.spGenerarUltimaFacturaBindingSource.DataSource = this.sistemaFacturacionDataSet1DefinitivoBindingSource;
            // 
            // sp_GenerarUltimaFacturaTableAdapter
            // 
            this.sp_GenerarUltimaFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 735);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1xdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1xd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1Definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFacturacionDataSet1DefinitivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sistemaFacturacionDataSet1xdBindingSource;
        private SistemaFacturacionDataSet1xd sistemaFacturacionDataSet1xd;
        private System.Windows.Forms.BindingSource sistemaFacturacionDataSet1DefinitivoBindingSource;
        private SistemaFacturacionDataSet1Definitivo sistemaFacturacionDataSet1Definitivo;
        private System.Windows.Forms.BindingSource spGenerarUltimaFacturaBindingSource;
        private SistemaFacturacionDataSet1DefinitivoTableAdapters.sp_GenerarUltimaFacturaTableAdapter sp_GenerarUltimaFacturaTableAdapter;
    }
}