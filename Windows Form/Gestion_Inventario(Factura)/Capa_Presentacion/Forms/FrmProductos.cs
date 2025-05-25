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
    public partial class FrmProductos : Form
    {

        private readonly CN_Productos negocioProductos = new CN_Productos();
        private readonly CN_Categorias negocioCategorias = new CN_Categorias();
        private readonly CN_Proveedores negocioProveedores = new CN_Proveedores();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
            LoadTheme();

            btnAgregar.Click += btnAgregar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnBorrar.Click += btnBorrar_Click;
            dgvProductos.CellClick += dgvProductos_CellClick;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
        }
        private void CargarProductos()
        {
            DataTable productos = negocioProductos.MostrarProductos();
            dgvProductos.DataSource = productos;

            // Mostrar los nombres de las columnas en un MessageBox (solo para depuración)
            string columnas = "";
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columnas += columna.HeaderText + "\n";
            }
            
        }
        private void CargarCategorias()
        {
            try
            {
                // Obtener las categorías desde la capa de negocio
                DataTable categorias = negocioCategorias.ObtenerCategorias();

                // Configurar el ComboBox
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría
                cmbCategoria.ValueMember = "IdCategoria"; // Usar el ID como valor
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
                // Obtener los proveedores desde la capa de negocio
                DataTable proveedores = negocioProveedores.ObtenerProveedores();

                // Configurar el ComboBox
                cmbProveedor.DataSource = proveedores;
                cmbProveedor.DisplayMember = "Nombre";  // Mostrar el nombre del proveedor
                cmbProveedor.ValueMember = "IdProveedor"; // Usar el ID como valor
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

                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que el Label tenga un valor válido
                if (string.IsNullOrEmpty(lblIdProducto.Text) || !int.TryParse(lblIdProducto.Text, out int idProducto))
                {
                    MessageBox.Show("Selecciona un producto válido para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los datos del formulario
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precio;
                int stock;
                int idCategoria;
                int idProveedor;

                // Validar campos obligatorios
                if (string.IsNullOrEmpty(nombre))
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

                // Actualizar el producto
                negocioProductos.ActualizarProducto(idProducto, nombre, descripcion, precio, stock, idCategoria, idProveedor);
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la lista de productos
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado una fila válida (no el encabezado)
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                    // Asignar los valores de las celdas a los TextBox
                    txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? string.Empty;
                    txtPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? string.Empty;
                    txtStock.Text = fila.Cells["Stock"].Value?.ToString() ?? string.Empty;

                    // Asignar el ID de la categoría al ComboBox
                    if (fila.Cells["IdCategoria"].Value != null)
                    {
                        cmbCategoria.SelectedValue = fila.Cells["IdCategoria"].Value; // Usar el ID de la categoría
                    }

                    // Asignar el ID del proveedor al ComboBox
                    if (fila.Cells["IdProveedor"].Value != null)
                    {
                        cmbProveedor.SelectedValue = fila.Cells["IdProveedor"].Value; // Usar el ID del proveedor
                    }

                    // Asignar el ID del producto al Label
                    lblIdProducto.Text = fila.Cells["IdProducto"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                BuscarProducto(textoBusqueda);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


    }
}
