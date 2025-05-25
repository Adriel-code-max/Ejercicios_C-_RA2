using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Capa_Negocios;
using Proyecto;


namespace CapaPresentacion
{
    public partial class Log : Form
    {
        private readonly CN_Usuarios _cnUsuarios = new CN_Usuarios();

        public Log()
        {
            InitializeComponent();
            lblErrorMensaje.Visible = false;
        }

        private void MostrarError(string mensaje)
        {
            lblErrorMensaje.Text = "    " + mensaje;
            lblErrorMensaje.ForeColor = Color.FromArgb(255, 128, 128); // Rojo
            lblErrorMensaje.Visible = true;
        }

        private void MostrarExito(string mensaje)
        {
            lblErrorMensaje.Text = "    " + mensaje;
            lblErrorMensaje.ForeColor = Color.FromArgb(112, 232, 181); // Verde
            lblErrorMensaje.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorMensaje.Visible = false;

                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text.Trim();

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

                DataTable resultado = _cnUsuarios.Login(usuario, contraseña);

                if (resultado.Rows.Count > 0)
                {
                    DataRow user = resultado.Rows[0];
                    UserLoginCache.IdUsuario = Convert.ToInt32(user["IdUsuario"]);
                    UserLoginCache.NombreUsuario = user["NombreUsuario"].ToString();
                    UserLoginCache.NombreCompleto = user["NombreCompleto"].ToString();
                    UserLoginCache.Rol = user["Rol"].ToString();
                    UserLoginCache.IdRol = Convert.ToInt32(user["IdRol"]);

                    MostrarExito($"Bienvenido {UserLoginCache.NombreCompleto}");

                    Timer timer = new Timer { Interval = 1500 };
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                        principal.FormClosed += (se, ev) => this.Close();
                        this.Hide();
                    };
                    timer.Start();
                }
                else
                {
                    MostrarError("Usuario o contraseña incorrectos");
                    ResetearCampoContraseña();
                }
            }
            catch (SqlException sqlEx)
            {
                MostrarError($"Error de base de datos: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MostrarError($"Error: {ex.Message}");
            }
        }



        private void ResetearCampoContraseña()
        {
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            UserLoginCache.Clear();
            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.DimGray;
            ResetearCampoContraseña();
            lblErrorMensaje.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        #region Placeholders
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
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                ResetearCampoContraseña();
            }
        }

        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA")
            {
                txtContraseña.UseSystemPasswordChar = !cbVer.Checked;
            }
        }
        #endregion

        #region Teclado
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
        #endregion

        #region Controles
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
           
        }
        #endregion

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void pnlBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
