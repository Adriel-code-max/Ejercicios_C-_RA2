using Capa_Negocios;
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
    public partial class FrmProveedores : Form
    {

        private CN_Proveedores negocioProveedor = new CN_Proveedores();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = negocioProveedor.ObtenerProveedores();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            LoadTheme();

        }

        private void txtBuscarProveedores_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarProveedores.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                CargarProveedores();
            }
            else
            {
                dgvProveedores.DataSource = negocioProveedor.BuscarProveedor(filtro);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            negocioProveedor.InsertarProveedor(nombre, telefono, correo, direccion);
            MessageBox.Show("Proveedor agregado correctamente.");
            CargarProveedores();

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(lblIdProveedor.Text);

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                negocioProveedor.EliminarProveedor(idProveedor);
                MessageBox.Show("Proveedor eliminado correctamente.");
                CargarProveedores();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el Label tenga un valor válido
                if (string.IsNullOrEmpty(lblIdProveedor.Text) || !int.TryParse(lblIdProveedor.Text, out int idProveedor))
                {
                    MessageBox.Show("Selecciona un proveedor válido para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los datos del formulario
                string nombre = txtNombre.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                // Validar campos obligatorios
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar el proveedor
                negocioProveedor.ActualizarProveedor(idProveedor, nombre, telefono, correo, direccion);
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de proveedores
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
           
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado una fila válida (no el encabezado)
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                    // Asignar los valores de las celdas a los TextBox
                    txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                    txtCorreo.Text = fila.Cells["Correo"].Value?.ToString() ?? string.Empty;
                    txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? string.Empty;

                    // Asignar el ID del proveedor al Label
                    lblIdProveedor.Text = fila.Cells["IdProveedor"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
