using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Desafio_GUI
{
    public partial class frm_mProducto : Form
    {
        int Fila = 0;
        public frm_mProducto()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }


       

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.nombre = txtNombre.Text;
            producto.categoria = txtCategoria.Text;
            producto.precio = int.Parse(txtPrecio.Text);
            producto.stock = int.Parse(txtStock.Text);



            if (string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                !double.TryParse(txtPrecio.Text, out double n) ||
                !int.TryParse(txtStock.Text, out int a))
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                Fila = dtgw_productos.Rows.Add();

                dtgw_productos.Rows[Fila].Cells[0].Value = txtNombre.Text;
                dtgw_productos.Rows[Fila].Cells[1].Value = txtCategoria.Text;
                dtgw_productos.Rows[Fila].Cells[2].Value = n.ToString("C2");
                dtgw_productos.Rows[Fila].Cells[3].Value = txtStock.Text;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgw_productos.ReadOnly = false;
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (dtgw_productos.SelectedRows.Count > 0)
            {

                DialogResult = MessageBox.Show("Estas seguro de que deseas eliminar", "advertencia", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    dtgw_productos.Rows.RemoveAt(dtgw_productos.SelectedRows[0].Index);
                    MessageBox.Show("Registro eliminado con exito");
                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("De acuerdo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        class Producto
        {

            public string? nombre { get; set; }
            public string? categoria { get; set; }
            public double precio { get; set; }
            public int stock { get; set; }
        }
    }


}
