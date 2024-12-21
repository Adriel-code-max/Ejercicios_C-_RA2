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
    public partial class frm_proveedores : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();

            prov.nombre = txtNombre.Text;

            prov.rnc = txtRnc.Text;

            prov.telefono = txtTelefono.Text;

            prov.correo = txtCorreo.Text;

            prov.ciudad = txtCiudad.Text;


        }

        private void dtgw_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_proveedores proveedores = new frm_proveedores();
            proveedores.ShowDialog();
            proveedores.Parent = this;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Principal pricipal = new frm_Principal();
            principal.ShowDialog();
            principal.Parent = this;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_proveedores_Load(object sender, EventArgs e)
        {

        }

        public static implicit operator frm_proveedores(frm_mProducto v)
        {
            throw new NotImplementedException();
        }
    }

#pragma warning disable CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    internal class proveedores
#pragma warning restore CS8981 // El nombre de tipo solo contiene caracteres ASCII en minúsculas. Estos nombres pueden reservarse para el idioma.
    {
        public string? nombre {  get; set; }

        public string? rnc { get; set; }

        public string? telefono { get; set; }

        public  string? direccion { get; set; }

        public string? correo { get; set; }

        public string? ciudad {  get; set; }

             
    }


}

