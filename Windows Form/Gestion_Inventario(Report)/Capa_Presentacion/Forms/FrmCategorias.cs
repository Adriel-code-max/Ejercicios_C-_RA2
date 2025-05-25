using Capa_Negocios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Presentacion.Forms
{
    public partial class FrmCategorias : Form
    {
        private CN_Categorias negocioCategoria = new CN_Categorias();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = negocioCategoria.ObtenerCategorias();
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarCategoria.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                CargarCategorias();
            }
            else
            {
                dgvCategorias.DataSource = negocioCategoria.BuscarCategoria(filtro);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            negocioCategoria.InsertarCategoria(nombre, descripcion);
            MessageBox.Show("Categoría agregada correctamente.");
            CargarCategorias();

            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(lblIdCategoria.Text);

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                negocioCategoria.EliminarCategoria(idCategoria);
                MessageBox.Show("Categoría eliminada correctamente.");
                CargarCategorias();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el Label tenga un valor válido
                if (string.IsNullOrEmpty(lblIdCategoria.Text) || !int.TryParse(lblIdCategoria.Text, out int idCategoria))
                {
                    MessageBox.Show("Selecciona una categoría válida para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los datos del formulario
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                // Validar campos obligatorios
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la categoría
                negocioCategoria.ActualizarCategoria(idCategoria, nombre, descripcion);
                MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de categorías
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LoadTheme();

            dgvCategorias.CellClick += dgvCategorias_CellClick;
            btnActualizar.Click += btnActualizar_Click;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
           
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                lblIdCategoria.Text = fila.Cells["IdCategoria"].Value.ToString();
            }
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


    }
    
}
