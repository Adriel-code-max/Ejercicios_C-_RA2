using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3();
            form.Show();
            form.BringToFront();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(txtNombreP.Text);
            lista.SubItems.Add(txtRNC.Text);
            lista.SubItems.Add(txtDireccion.Text);
            lista.SubItems.Add(txtTelefono.Text);
            lista.SubItems.Add(txtCorreo.Text);
            lista.SubItems.Add(cboCiudad.Text);
            lvTabla.Items.Add(lista);
            txtNombreP.Clear();
            txtRNC.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas eliminar este registro?", "Confirma eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                foreach (ListViewItem lista in lvTabla.SelectedItems)
                {
                    lista.Remove();
                }

                MessageBox.Show("Eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas eliminar toda la tabla?", "Confirma eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                lvTabla.Items.Clear(); 

                MessageBox.Show("Eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
