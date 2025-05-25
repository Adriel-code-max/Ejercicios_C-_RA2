using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class RegistrarLog : Form
    {
        private CN_Usuarios cn_usuarios = new CN_Usuarios();
        private readonly Color SuccessColor = Color.FromArgb(0x70, 0xE8, 0xB5);

        public RegistrarLog()
        {
            InitializeComponent();
            label5.Text = "";
        }

     

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void RegistrarLog_MouseDown(object sender, MouseEventArgs e)
        {
            pnlBar_MouseDown(sender, e);
        }

        // Métodos para manejar los placeholders
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
                txtContraseña.ForeColor = Color.White;
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
            if (txtConfirmarContraseña.Text == "")
            {
                txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;
            }
        }

    

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;
                string confirmacion = txtConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA" ? "" : txtConfirmarContraseña.Text;
              

                // Validaciones
                if (string.IsNullOrEmpty(usuario))
                {
                    MostrarError("Ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

              
                if (string.IsNullOrEmpty(contraseña))
                {
                    MostrarError("Ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña.Length < 4)
                {
                    MostrarError("La contraseña debe tener al menos 4 caracteres");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña != confirmacion)
                {
                    MostrarError("Las contraseñas no coinciden");
                    txtConfirmarContraseña.Focus();
                    return;
                }

              

                // Registrar el usuario
                

                

                // Limpiar campos después del registro exitoso
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

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
        
        }

        private void MostrarError(string mensaje)
        {
            lblErrorMensage.Text = "      " + mensaje;
            lblErrorMensage.ForeColor = Color.FromArgb(255, 128, 128); // Rojo claro
            lblErrorMensage.Visible = true;
        }

        private void MostrarExito(string mensaje)
        {
            lblErrorMensage.Text = "      " + mensaje;
            lblErrorMensage.ForeColor = SuccessColor;
            lblErrorMensage.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegresarALogin();
        }

        private void RegresarALogin()
        {
            this.Hide();
            Log loginForm = new Log();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        // Manejo de tecla Enter para navegación
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
              
                e.Handled = true;
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
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

        // Mostrar/ocultar contraseñas
        private void cbVer1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !cbVer1.Checked;
            txtConfirmarContraseña.UseSystemPasswordChar = !cbVer1.Checked;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}