using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Negocios;

namespace CapaPresentacion
{
    public partial class RegistrarLog : Form
    {
        private readonly CN_Usuarios _cnUsuarios = new CN_Usuarios();
        private readonly Color _colorError = Color.FromArgb(255, 128, 128);
        private readonly Color _colorExito = Color.FromArgb(112, 232, 181);

        public RegistrarLog()
        {
            InitializeComponent();
            lblErrorMensage.Visible = false;

            if (UserLoginCache.IdRol != 1)
            {
                MessageBox.Show("Solo los administradores pueden registrar nuevos usuarios",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarRoles();
        }

        #region Funcionalidad para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void RegistrarLog_MouseDown(object sender, MouseEventArgs e)
        {
            pnlBar_MouseDown(sender, e);
        }
        #endregion

        #region Cargar Roles
        private void CargarRoles()
        {
            try
            {
                DataTable roles = _cnUsuarios.ObtenerRoles();

                if (UserLoginCache.IdRol != 1)
                {
                    roles = roles.AsEnumerable()
                                 .Where(row => row.Field<int>("IdRol") != 1)
                                 .CopyToDataTable();
                }

                cmbRoles.DataSource = roles;
                cmbRoles.DisplayMember = "Nombre";
                cmbRoles.ValueMember = "IdRol";
                cmbRoles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar roles: " + ex.Message);
            }
        }
        #endregion

        #region Botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;
                string confirmacion = txtConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA" ? "" : txtConfirmarContraseña.Text;
                string nombreCompleto = txtNombreCompleto.Text == "NOMBRE COMPLETO" ? "" : txtNombreCompleto.Text;

                if (!int.TryParse(cmbRoles.SelectedValue?.ToString(), out int idRol))
                {
                    MostrarError("Seleccione un rol válido");
                    return;
                }

                if (string.IsNullOrEmpty(usuario) || usuario.Length < 4)
                {
                    MostrarError("El nombre de usuario debe tener al menos 4 caracteres");
                    txtUsuario.Focus();
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]+$"))
                {
                    MostrarError("El usuario solo puede contener letras, números y guiones bajos");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(nombreCompleto) || nombreCompleto.Length < 6)
                {
                    MostrarError("Ingrese un nombre completo válido (mínimo 6 caracteres)");
                    txtNombreCompleto.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña) || contraseña.Length < 6)
                {
                    MostrarError("La contraseña debe tener al menos 6 caracteres");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña != confirmacion)
                {
                    MostrarError("Las contraseñas no coinciden");
                    txtConfirmarContraseña.Focus();
                    return;
                }

                int nuevoId = _cnUsuarios.RegistrarUsuario(usuario, contraseña, nombreCompleto, idRol);

                MostrarExito($"Usuario registrado exitosamente con ID: {nuevoId}");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        #endregion

        #region Métodos Auxiliares
        private void LimpiarCampos()
        {
            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.DimGray;

            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;

            txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
            txtConfirmarContraseña.ForeColor = Color.DimGray;
            txtConfirmarContraseña.UseSystemPasswordChar = false;

            txtNombreCompleto.Text = "NOMBRE COMPLETO";
            txtNombreCompleto.ForeColor = Color.DimGray;

            cmbRoles.SelectedIndex = 0;
            lblErrorMensage.Visible = false;
        }

        private void MostrarError(string mensaje)
        {
            lblErrorMensage.Text = "      " + mensaje;
            lblErrorMensage.ForeColor = _colorError;
            lblErrorMensage.Visible = true;
        }

        private void MostrarExito(string mensaje)
        {
            lblErrorMensage.Text = "      " + mensaje;
            lblErrorMensage.ForeColor = _colorExito;
            lblErrorMensage.Visible = true;
        }
        #endregion

        #region Placeholders y Entradas
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmarContraseña.Text = "";
                txtConfirmarContraseña.ForeColor = Color.White;
                txtConfirmarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmarContraseña.Text))
            {
                txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtNombreCompleto_Enter(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "NOMBRE COMPLETO")
            {
                txtNombreCompleto.Text = "";
                txtNombreCompleto.ForeColor = Color.White;
            }
        }

        private void txtNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCompleto.Text))
            {
                txtNombreCompleto.Text = "NOMBRE COMPLETO";
                txtNombreCompleto.ForeColor = Color.DimGray;
            }
        }

        private void cbVer1_CheckedChanged(object sender, EventArgs e)
        {
            bool ver = cbVer1.Checked;
            if (txtContraseña.Text != "CONTRASEÑA")
                txtContraseña.UseSystemPasswordChar = !ver;

            if (txtConfirmarContraseña.Text != "CONFIRMAR CONTRASEÑA")
                txtConfirmarContraseña.UseSystemPasswordChar = !ver;
        }
        #endregion

        #region Manejo de Teclas y Botones
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNombreCompleto.Focus();
                e.Handled = true;
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbRoles.Focus();
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtConfirmarContraseña.Focus();
                e.Handled = true;
            }
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void pnlBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
