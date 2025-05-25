using Capa_Negocios;
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
    public partial class FrmClientes : Form
    {
        private readonly CN_Clientes negocioClientes = new CN_Clientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LoadTheme();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = negocioClientes.ObtenerClientes();
         
        }

   

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                negocioClientes.InsertarCliente(
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim());

                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIdCliente.Text) || !int.TryParse(lblIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Seleccione un cliente para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                negocioClientes.ActualizarCliente(
                    idCliente,
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim());

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIdCliente.Text) || !int.TryParse(lblIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    negocioClientes.EliminarCliente(idCliente);
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                lblIdCliente.Text = fila.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString() ?? "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            dgvClientes.DataSource = negocioClientes.BuscarCliente(filtro);
        }

        private void LimpiarCampos()
        {
            lblIdCliente.Text = "";
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
