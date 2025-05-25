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
           
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.obtenerProductosConDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionIventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_IventarioDataSet = new Capa_Presentacion.Gestion_IventarioDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.obtenerProductosConDetallesTableAdapter = new Capa_Presentacion.Gestion_IventarioDataSetTableAdapters.ObtenerProductosConDetallesTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerProductosConDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionIventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_IventarioDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // obtenerProductosConDetallesBindingSource
            // 
            this.obtenerProductosConDetallesBindingSource.DataMember = "ObtenerProductosConDetalles";
            this.obtenerProductosConDetallesBindingSource.DataSource = this.gestionIventarioDataSetBindingSource;
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chart1);
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
            // obtenerProductosConDetallesTableAdapter
            // 
            this.obtenerProductosConDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(955, 459);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.gestionIventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_IventarioDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}