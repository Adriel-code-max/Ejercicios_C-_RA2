using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Forms
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {


            LoadTheme();

            // TODO: esta línea de código carga datos en la tabla 'gestion_IventarioDataSet.ObtenerProductosConDetalles' Puede moverla o quitarla según sea necesario.
            this.obtenerProductosConDetallesTableAdapter.Fill(this.gestion_IventarioDataSet.ObtenerProductosConDetalles);

            
        }



        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Colores.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Colores.SecondaryColor;
                }
            }

            label5.ForeColor = Colores.PrimaryColor;
        }
    }
}
