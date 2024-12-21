namespace Gestion_de_Reservas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPrecio.Clear();
            DtpFechaHasta.Text = string.Empty;
            cmbTipoHab.SelectedIndex = -1;

        }

        public class Reserva
        {
            public string cliente { get; set; }

            public string tipoHab { get; set; }
            public DateTime fechaDesde { get; set; }

            public DateTime fechaHasta { get; set; }
            public double precio { get; set; }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Reserva reserva = new Reserva();

            reserva.cliente = txtCliente.Text;

            reserva.fechaDesde = dtpFechadesde.Value;

            reserva.fechaHasta = DtpFechaHasta.Value;

            if (cmbTipoHab.SelectedItem != null)
            {
                reserva.tipoHab = cmbTipoHab.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una habitacion");
            }



            TimeSpan multiprecio = reserva.fechaHasta - reserva.fechaDesde;


            if (reserva.tipoHab == "Habitacion normal")
            {
                reserva.precio = multiprecio.Days * 50;
            }
            else if (reserva.tipoHab == "Habitacion doble")
            {
                reserva.precio = multiprecio.Days * 100;
            }
            else if (reserva.tipoHab == "Habitacion suite")
            {
                reserva.precio = multiprecio.Days * 150;
            }


            ltb_reserva.Items.Add($"Cliente: {reserva.cliente} \n " +
                                  $"Fecha desde: {reserva.fechaDesde} \n " +
                                  $"Fecha hasta: {reserva.fechaHasta} \n " +
                                  $"tipo de habitacion: {reserva.tipoHab}  \n " +
                                  $"precio total: {reserva.precio}");






        }

        private void btnlEliminar_Click(object sender, EventArgs e)
        {
          
            if (ltb_reserva.SelectedItem != null)
            {
                
                ltb_reserva.Items.Remove(ltb_reserva.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
