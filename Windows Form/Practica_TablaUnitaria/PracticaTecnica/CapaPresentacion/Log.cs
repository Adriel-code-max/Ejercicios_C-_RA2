using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class Log : Form
    {
        private CN_Usuarios cn_usuarios = new CN_Usuarios();

        public Log()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;

                if (string.IsNullOrEmpty(usuario))
                {
                    MostrarError("Por favor ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña))
                {
                    MostrarError("Por favor ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                DataTable usuarioData = cn_usuarios.Login(usuario, contraseña);

                if (usuarioData.Rows.Count > 0)
                {
                    // Guardar información del usuario en una clase estática para uso global
                    UserLoginCache.IdUsuario = Convert.ToInt32(usuarioData.Rows[0]["IdUsuario"]);
                    UserLoginCache.NombreUsuario = usuarioData.Rows[0]["NombreUsuario"].ToString();
                    UserLoginCache.NombreCompleto = usuarioData.Rows[0]["NombreCompleto"].ToString();
                    UserLoginCache.Rol = usuarioData.Rows[0]["Rol"].ToString();
                    UserLoginCache.IdRol = Convert.ToInt32(usuarioData.Rows[0]["IdRol"]);

                    Form1 principal = new Form1();
                    principal.Show();
                    principal.FormClosed += CerrarSesion;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Focus();
            }
        }

        private void MostrarError(string mensaje)
        {
            lblErrorMensage.Text = "      " + mensaje;
            lblErrorMensage.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            // Limpiar cache de usuario
            UserLoginCache.Logout();

            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.DimGray;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;
            lblErrorMensage.Visible = false;

            this.Show();
            txtUsuario.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
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
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Log_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnkCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrarLog registroForm = new RegistrarLog();
            registroForm.FormClosed += (s, args) => this.Close();
            registroForm.Show();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !cbVer.Checked;
        }
    }

    // Clase estática para almacenar información del usuario logueado
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }
        public static int IdRol { get; set; }

        public static void Logout()
        {
            IdUsuario = 0;
            NombreUsuario = "";
            NombreCompleto = "";
            Rol = "";
            IdRol = 0;
        }
    }
}