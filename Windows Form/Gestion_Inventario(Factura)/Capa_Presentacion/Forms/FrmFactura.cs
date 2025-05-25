using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Forms
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaFacturacionDataSet1Definitivo.sp_GenerarUltimaFactura' Puede moverla o quitarla según sea necesario.
            this.sp_GenerarUltimaFacturaTableAdapter.Fill(this.sistemaFacturacionDataSet1Definitivo.sp_GenerarUltimaFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
