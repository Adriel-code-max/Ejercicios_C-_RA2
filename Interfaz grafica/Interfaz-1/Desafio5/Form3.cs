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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem lista = new ListViewItem(txtNombrePr.Text);
            lista.SubItems.Add(cboCategoria.Text);
            lista.SubItems.Add(txtPrecio.Text);
            lista.SubItems.Add(txtStock.Text);
            lvTabla.Items.Add(lista);
            txtNombrePr.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
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

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.BringToFront();
        }
    }
}
