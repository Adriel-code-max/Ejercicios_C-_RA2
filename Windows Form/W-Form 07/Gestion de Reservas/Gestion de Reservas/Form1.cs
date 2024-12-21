using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Reservas
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }


       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            DateTime fechaEntrada = dtpDesde.Value;
            DateTime fechaSalida = dtpHasta.Value;

    
            if (fechaSalida < fechaEntrada)
            {
                MessageBox.Show("Que pendjo/a la fecha de salida no puede ser antes de la fecha de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int duracion = (fechaSalida - fechaEntrada).Days;

            
            if (duracion <= 0)
            {
                duracion = 1; 
            }

            decimal precioPorNoche;
            

            switch (cboHabitacion.SelectedItem.ToString())
            {
                case "Familiar":
                    precioPorNoche = 3000; 
                    break;
                case "Matrimonial":
                    precioPorNoche = 2500; 
                    break;
                case "Doble":
                    precioPorNoche = 1000; 
                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de habitacion buen idiota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            decimal precioTotal = duracion * precioPorNoche;

            txtDuracion.Text = duracion.ToString() + " Noches";
            txtPrecio.Text = precioTotal.ToString();

            
            ListViewItem lista = new ListViewItem(txtCliente.Text);
            lista.SubItems.Add(dtpDesde.Text); 
            lista.SubItems.Add(dtpHasta.Text); 
            lista.SubItems.Add(cboHabitacion.Text); 
            lista.SubItems.Add(txtDuracion.Text);
            lista.SubItems.Add(txtPrecio.Text); 
            lvGestion.Items.Add(lista);

            
           
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {


            
            foreach (ListViewItem lista in lvGestion.SelectedItems)
            {
                lista.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvGestion.Items.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtDuracion.Clear();
            txtPrecio.Clear();
            cboHabitacion.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

