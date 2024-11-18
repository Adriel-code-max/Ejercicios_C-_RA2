using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_de_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldoBruto, afp, sfs, isr, sueldoNeto;
            double afpRate = 0.0287;
            double sfsRate = 0.0304;
            double exentoISR = 499884.00;
            double tramo1 = 749822.00;
            double tramo2 = 1041224.00;


            sueldoBruto = Convert.ToDouble(bxSueldo.Text);


            afp = sueldoBruto * afpRate;
            sfs = sueldoBruto * sfsRate;


            double sueldoAnual = sueldoBruto * 12;


            isr = 0;


            if (sueldoAnual > exentoISR)
            {
                if (sueldoAnual <= tramo1)
                {
                    isr = (sueldoAnual - exentoISR) * 0.15;
                }
                else if (sueldoAnual <= tramo2)
                {
                    isr = (sueldoAnual - tramo1) * 0.20 + 37_491.00;
                }
                else
                {
                    isr = (sueldoAnual - tramo2) * 0.25 + 75_082.00;
                }
            }

            // Incentivo por cantidad de hijos

            int cantidadHijos = int.TryParse(BxHijo.Text, out int hijos) ? hijos : 0;

            double incentivoHijo = 500;
            double totalIncentivo = cantidadHijos * incentivoHijo;

            sueldoNeto = sueldoBruto - afp - sfs - (isr / 12) + totalIncentivo;

            BxIncentivo.Text = totalIncentivo.ToString();
            bxNeto.Text = sueldoNeto.ToString();


            double isrdividido = isr / 12;


            if (isr > 0)
            {
                bxISR.Text = isrdividido.ToString();
            }
            else
            {
                bxISR.Text = "ISR NO APLICA";
            }


            bxAFP.Text = afp.ToString();
            bxSFS.Text = sfs.ToString();

            // (AFP + SFS + ISR mensual)
            double totalDescuentos = afp + sfs + (isr / 12);
            bxDescuento.Text = totalDescuentos.ToString();




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bxDescuento.Clear();
            bxAFP.Clear();
            bxSFS.Clear();
            bxCargo.Clear();
            bxISR.Clear();
            bxNeto.Clear();
            bxSueldo.Clear();
            bxNombre.Clear();
            BxHijo.Clear();
            BxIncentivo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
