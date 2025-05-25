using Capa_Presentacion;
using Capa_Presentacion.Forms;
using CapaPresentacion;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmPrincipal : Form
    {
        private Form activeForm;
        private Random random;
        private Button currentButton;
        private int tempIndex;

        public FrmPrincipal()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SeleccionarColores()
        {
            int index = random.Next(Colores.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Colores.ColorList.Count);
            }
            tempIndex = index;
            string color = Colores.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SeleccionarColores();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = Colores.ChangeColorBrightness(color, -0.3);
                    Colores.PrimaryColor = color;
                    Colores.SecondaryColor = Colores.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            lblTitle.Text = "Inicio";
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProductos(), sender);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCategorias(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProveedores(), sender);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReporte(), sender);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            RegistrarLog frm = new RegistrarLog();
            frm.ShowDialog();

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarAccesoSegunRol();
        }


        private void ConfigurarAccesoSegunRol()
        {
            string rol = UserLoginCache.Rol;


            lblUsuario.Text = $"Usuario: {UserLoginCache.NombreCompleto}";
             lblRol.Text = $"Rol: {UserLoginCache.Rol}"; 

            switch (UserLoginCache.Rol)
            {
                case "Administrador":
                    
                    btnProductos.Visible = true;
                    btnCategoria.Visible = true;
                    btnProveedores.Visible = true;
                    btnReporte.Visible = true;
                    btnUsuario.Visible = true;
                    break;

                case "Inventario":
                   
                    btnProductos.Visible = true;
                    btnCategoria.Visible = true;
                
                    btnProveedores.Visible = false;
                    btnReporte.Visible = false;
                    btnUsuario.Visible = false;
                    break;

                case "Consulta":
                  
                    btnProductos.Visible = false;
                    btnCategoria.Visible = false;
                    btnProveedores.Visible = false;

                    btnReporte.Visible = true; 

                    btnUsuario.Visible = false;
                    break;

                default:
                    MessageBox.Show("Rol no reconocido. Acceso denegado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}
