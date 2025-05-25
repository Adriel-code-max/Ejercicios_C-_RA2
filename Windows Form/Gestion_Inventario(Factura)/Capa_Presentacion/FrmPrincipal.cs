using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmPrincipal : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmPrincipal()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
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
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmProductos(),sender );
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmCategorias(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmProveedores(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmClientes(), sender);
        }


        private void btnVenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmFacturacion(), sender);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            //OpenChildForm(new Forms.FrmReporte(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
