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
    public partial class FrmFacturacion : Form
    {

        private readonly CN_Clientes negocioClientes = new CN_Clientes();
        private readonly CN_Productos negocioProductos = new CN_Productos();
        private readonly CN_Facturas negocioFacturas = new CN_Facturas();


        private DataTable detallesFactura = new DataTable();
        public FrmFacturacion()
        {
            InitializeComponent();
            InicializarTablaDetalles();
        }


        private void InicializarTablaDetalles()
        {
            detallesFactura = new DataTable();
            detallesFactura.Columns.Add("IdProducto", typeof(int));
            detallesFactura.Columns.Add("Producto", typeof(string));
            detallesFactura.Columns.Add("Cantidad", typeof(int));
            detallesFactura.Columns.Add("PrecioUnitario", typeof(decimal));
            detallesFactura.Columns.Add("Subtotal", typeof(decimal));

            dgvDetalles.DataSource = detallesFactura;
            ConfigurarColumnasDetalles();
        }

        private void ConfigurarColumnasDetalles()
        {
            dgvDetalles.Columns["IdProducto"].Visible = false;
            dgvDetalles.Columns["Producto"].HeaderText = "Producto";
            dgvDetalles.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDetalles.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dgvDetalles.Columns["Subtotal"].HeaderText = "Subtotal";

            dgvDetalles.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            LoadTheme();
            dtpFecha.Value = DateTime.Now;
        }

        private void CargarClientes()
        {
            cmbClientes.DataSource = negocioClientes.ObtenerClientes();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "IdCliente";
            cmbClientes.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            cmbProductos.DataSource = negocioProductos.MostrarProductos();
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "IdProducto";
            cmbProductos.SelectedIndex = -1;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex != -1)
            {
                DataRowView producto = (DataRowView)cmbProductos.SelectedItem;
                txtPrecio.Text = Convert.ToDecimal(producto["Precio"]).ToString("C2");
                txtStockDisponible.Text = producto["Stock"].ToString();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView producto = (DataRowView)cmbProductos.SelectedItem;
            int idProducto = Convert.ToInt32(producto["IdProducto"]);
            string nombreProducto = producto["Nombre"].ToString();
            decimal precio = Convert.ToDecimal(producto["Precio"]);
            int stockDisponible = Convert.ToInt32(producto["Stock"]);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el producto ya está en los detalles
            bool productoExistente = false;
            foreach (DataRow row in detallesFactura.Rows)
            {
                if (Convert.ToInt32(row["IdProducto"]) == idProducto)
                {
                    row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + cantidad;
                    row["Subtotal"] = Convert.ToInt32(row["Cantidad"]) * Convert.ToDecimal(row["PrecioUnitario"]);
                    productoExistente = true;
                    break;
                }
            }

            if (!productoExistente)
            {
                detallesFactura.Rows.Add(
                    idProducto,
                    nombreProducto,
                    cantidad,
                    precio,
                    cantidad * precio
                );
            }

            CalcularTotal();
            txtCantidad.Text = "1";
            cmbProductos.Focus();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataRow row in detallesFactura.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = total.ToString("C2");
        }


        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.SelectedRows)
                {
                    detallesFactura.Rows.RemoveAt(row.Index);
                }
                CalcularTotal();
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detallesFactura.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);

            // Crear DataTable para enviar a la base de datos
            DataTable dtDetallesDB = new DataTable();
            dtDetallesDB.Columns.Add("IdProducto", typeof(int));
            dtDetallesDB.Columns.Add("Cantidad", typeof(int));
            dtDetallesDB.Columns.Add("PrecioUnitario", typeof(decimal));

            foreach (DataRow row in detallesFactura.Rows)
            {
                dtDetallesDB.Rows.Add(
                    row["IdProducto"],
                    row["Cantidad"],
                    row["PrecioUnitario"]
                );
            }

            string mensaje;
            int idFactura = negocioFacturas.CrearFactura(idCliente, dtDetallesDB, out mensaje);

            if (idFactura > 0)
            {
                MessageBox.Show($"Factura #{idFactura} generada correctamente\n{mensaje}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFactura();
            }
            else
            {

                MessageBox.Show($"Factura #{idFactura} generada correctamente\n{mensaje}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFactura();
                //MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FrmFactura frmReporte = new FrmFactura();
            frmReporte.ShowDialog();
        }

        private void LimpiarFactura()
        {
            detallesFactura.Rows.Clear();
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            txtCantidad.Text = "1";
            lblTotal.Text = "$0.00";
            dtpFecha.Value = DateTime.Now;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarFactura();
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

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            FrmFactura frmReporte = new FrmFactura();
            frmReporte.ShowDialog();
        }


    }
}

