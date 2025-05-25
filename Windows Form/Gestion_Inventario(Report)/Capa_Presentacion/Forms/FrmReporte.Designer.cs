namespace Capa_Presentacion.Forms
{
    partial class FrmReporte
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
            this.obtenerProductosConDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gestionIventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_IventarioDataSet = new Capa_Presentacion.Gestion_IventarioDataSet();
            this.obtenerProductosConDetallesTableAdapter = new Capa_Presentacion.Gestion_IventarioDataSetTableAdapters.ObtenerProductosConDetallesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerProductosConDetallesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionIventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_IventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // obtenerProductosConDetallesBindingSource
            // 
            this.obtenerProductosConDetallesBindingSource.DataMember = "ObtenerProductosConDetalles";
            this.obtenerProductosConDetallesBindingSource.DataSource = this.gestionIventarioDataSetBindingSource;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(55, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 459);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(46, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 49);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reportes";
            // 
            // gestionIventarioDataSetBindingSource
            // 
            this.gestionIventarioDataSetBindingSource.DataSource = this.gestion_IventarioDataSet;
            this.gestionIventarioDataSetBindingSource.Position = 0;
            // 
            // gestion_IventarioDataSet
            // 
            this.gestion_IventarioDataSet.DataSetName = "Gestion_IventarioDataSet";
            this.gestion_IventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerProductosConDetallesTableAdapter
            // 
            this.obtenerProductosConDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(955, 459);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporte";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obtenerProductosConDetallesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gestionIventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_IventarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Gestion_IventarioDataSet gestion_IventarioDataSet;
        private System.Windows.Forms.BindingSource gestionIventarioDataSetBindingSource;
        private System.Windows.Forms.BindingSource obtenerProductosConDetallesBindingSource;
        private Gestion_IventarioDataSetTableAdapters.ObtenerProductosConDetallesTableAdapter obtenerProductosConDetallesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}