namespace _06_Desafio_GUI
{
    partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            pl_Principio = new Panel();
            label1 = new Label();
            lbl_Principal = new Label();
            miniToolStrip = new MenuStrip();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem1 = new ToolStripMenuItem();
            proveedoresToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            pl_Principio.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pl_Principio
            // 
            pl_Principio.BackColor = Color.FromArgb(77, 59, 85);
            pl_Principio.BackgroundImage = (Image)resources.GetObject("pl_Principio.BackgroundImage");
            pl_Principio.BackgroundImageLayout = ImageLayout.Stretch;
            pl_Principio.Controls.Add(label1);
            pl_Principio.Controls.Add(lbl_Principal);
            pl_Principio.Dock = DockStyle.Fill;
            pl_Principio.ForeColor = SystemColors.Control;
            pl_Principio.Location = new Point(0, 33);
            pl_Principio.Name = "pl_Principio";
            pl_Principio.Size = new Size(800, 417);
            pl_Principio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(206, 205);
            label1.Name = "label1";
            label1.Size = new Size(407, 84);
            label1.TabIndex = 2;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\nDuis condimentum tempor eros, vel condimentum tortor \r\ninterdum at. Pellentesque hendrerit arcu dui, vel sodales \r\ntortor aliquam ut. \r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Principal
            // 
            lbl_Principal.AutoSize = true;
            lbl_Principal.BackColor = Color.Transparent;
            lbl_Principal.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Principal.ForeColor = SystemColors.ControlLightLight;
            lbl_Principal.Location = new Point(239, 106);
            lbl_Principal.Name = "lbl_Principal";
            lbl_Principal.Size = new Size(341, 66);
            lbl_Principal.TabIndex = 1;
            lbl_Principal.Text = "Sistema de Gestion \r\nInventario y Proveedores";
            lbl_Principal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.BackColor = Color.Transparent;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            miniToolStrip.ForeColor = Color.White;
            miniToolStrip.GripMargin = new Padding(0, 5, 0, 10);
            miniToolStrip.Location = new Point(11, 102);
            miniToolStrip.Margin = new Padding(0, 0, 0, 10);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(143, 106);
            miniToolStrip.TabIndex = 0;
            miniToolStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(52, 52, 78);
            menuStrip1.Font = new Font("Segoe UI", 14F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem1, mantenimientoToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.ForeColor = Color.White;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(61, 29);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // mantenimientoToolStripMenuItem1
            // 
            mantenimientoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem1, productosToolStripMenuItem1 });
            mantenimientoToolStripMenuItem1.ForeColor = Color.White;
            mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            mantenimientoToolStripMenuItem1.Size = new Size(153, 29);
            mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem1.Click += mantenimientoToolStripMenuItem1_Click;
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(189, 30);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            proveedoresToolStripMenuItem1.Click += proveedoresToolStripMenuItem1_Click_1;
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(189, 30);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 29, 85);
            ClientSize = new Size(800, 450);
            Controls.Add(pl_Principio);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = miniToolStrip;
            MaximizeBox = false;
            Name = "frm_Principal";
            Text = "Gestion de Inventario";
            pl_Principio.ResumeLayout(false);
            pl_Principio.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pl_Principio;
        private Label lbl_Principal;
        private MenuStrip miniToolStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private Label label1;
    }
}
