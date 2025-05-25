using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {

        private readonly CN_Productos negocioProductos = new CN_Productos();
        private readonly CN_Categorias negocioCategorias = new CN_Categorias();
        private readonly CN_Proveedores negocioProveedores = new CN_Proveedores();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        private void CargarProductos()
        {
            
            dgvProductos.DataSource = negocioProductos.MostrarProductos();
            DataTable dtProductos = negocioProductos.MostrarProductos();
            dgvProductos.DataSource = dtProductos;
           

        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = negocioCategorias.ObtenerCategorias();
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";  // Mostrar el nombre
                cmbCategoria.ValueMember = "IdCategoria"; // Guardar el ID
                cmbCategoria.SelectedIndex = -1; // No seleccionar nada por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }


        private void CargarProveedores()
        {
            try
            {
                DataTable proveedores = negocioProveedores.ObtenerProveedores();
                cmbProveedor.DataSource = proveedores;
                cmbProveedor.DisplayMember = "Nombre";  // Mostrar el nombre
                cmbProveedor.ValueMember = "IdProveedor"; // Guardar el ID
                cmbProveedor.SelectedIndex = -1; // No seleccionar nada por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
          "¿Estás seguro de que deseas agregar este producto?",
          "Confirmar Agregado",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio;
                int stock;
                int idCategoria;
                int idProveedor;

               



                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido y mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
                {
                    MessageBox.Show("El stock debe ser un número entero positivo o 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cmbCategoria.SelectedValue?.ToString(), out idCategoria))
                {
                    MessageBox.Show("Selecciona una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cmbProveedor.SelectedValue?.ToString(), out idProveedor))
                {
                    MessageBox.Show("Selecciona un proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                negocioProductos.InsertarProducto(nombre, descripcion, precio, stock, idCategoria, idProveedor);
                CargarProductos();
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                // Obtener los datos del formulario
                int idProducto = int.Parse(dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString()); // Obtener el ID del producto desde el DataGridView
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                int idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                int idProveedor = int.Parse(cmbProveedor.SelectedValue.ToString());

               
                negocioProductos.ActualizarProducto(idProducto, nombre, descripcion, precio, stock, idCategoria, idProveedor);
                CargarProductos();
                LimpiarCampos();

                
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hubo un error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            
            cmbCategoria.SelectedIndex = -1; 
            cmbProveedor.SelectedIndex = -1; 
        }

        
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();

                // Asignar valores a los ComboBox
                cmbCategoria.SelectedValue = filaSeleccionada.Cells["IdCategoria"].Value; // Usar el ID de la categoría
                cmbProveedor.SelectedValue = filaSeleccionada.Cells["IdProveedor"].Value; // Usar el ID del proveedor
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
            if (dgvProductos.SelectedRows.Count > 0)
            {
                
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        
                        int idProducto = int.Parse(dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString());

                        
                        negocioProductos.EliminarProducto(idProducto);
                        CargarProductos();
                        LimpiarCampos();
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarProducto(string textoBusqueda)
        {
            try
            {

                DataTable dtProductos = negocioProductos.BuscarProductos(textoBusqueda);


                dgvProductos.DataSource = dtProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProducto.Text.Trim();

            // Si el TextBox está vacío, cargar todos los productos
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos(); // Método para cargar todos los productos sin filtro
            }
            else
            {
                // Si hay texto, buscar productos que contengan el texto ingresado
                BuscarProducto(textoBusqueda);
            }
        }
    }
}

