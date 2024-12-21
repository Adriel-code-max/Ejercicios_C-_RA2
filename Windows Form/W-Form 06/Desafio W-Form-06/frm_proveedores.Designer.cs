namespace _06_Desafio_GUI
{
    partial class frm_proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_proveedores));
            lbl_titulo = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            lbl_Nombre = new Label();
            lbl_rnc = new Label();
            lbl_direccion = new Label();
            lbl_telefono = new Label();
            lbl_correo = new Label();
            lbl_ciudad = new Label();
            txtRnc = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtCiudad = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dtgw_proveedores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            RNC = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgw_proveedores).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Berlin Sans FB", 20F);
            lbl_titulo.ForeColor = SystemColors.Control;
            lbl_titulo.Location = new Point(71, 20);
            lbl_titulo.Margin = new Padding(3, 0, 10, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(274, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestion de Proveedores\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 183, 150);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(132, 183, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(36, 380);
            button1.Name = "button1";
            button1.Size = new Size(154, 44);
            button1.TabIndex = 2;
            button1.Text = "Aregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.Transparent;
            lbl_Nombre.Font = new Font("Century Gothic", 12F);
            lbl_Nombre.ForeColor = Color.DimGray;
            lbl_Nombre.Location = new Point(36, 103);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(73, 21);
            lbl_Nombre.TabIndex = 4;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_rnc
            // 
            lbl_rnc.AutoSize = true;
            lbl_rnc.BackColor = Color.Transparent;
            lbl_rnc.Font = new Font("Century Gothic", 12F);
            lbl_rnc.ForeColor = Color.DimGray;
            lbl_rnc.Location = new Point(36, 169);
            lbl_rnc.Name = "lbl_rnc";
            lbl_rnc.Size = new Size(45, 21);
            lbl_rnc.TabIndex = 5;
            lbl_rnc.Text = "RNC";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.BackColor = Color.Transparent;
            lbl_direccion.Font = new Font("Century Gothic", 12F);
            lbl_direccion.ForeColor = Color.DimGray;
            lbl_direccion.Location = new Point(36, 295);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(83, 21);
            lbl_direccion.TabIndex = 6;
            lbl_direccion.Text = "Direccion";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.BackColor = Color.Transparent;
            lbl_telefono.Font = new Font("Century Gothic", 12F);
            lbl_telefono.ForeColor = Color.DimGray;
            lbl_telefono.Location = new Point(225, 169);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(76, 21);
            lbl_telefono.TabIndex = 7;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.BackColor = Color.Transparent;
            lbl_correo.Font = new Font("Century Gothic", 12F);
            lbl_correo.ForeColor = Color.DimGray;
            lbl_correo.Location = new Point(225, 103);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(63, 21);
            lbl_correo.TabIndex = 8;
            lbl_correo.Text = "Correo";
            // 
            // lbl_ciudad
            // 
            lbl_ciudad.AutoSize = true;
            lbl_ciudad.BackColor = Color.Transparent;
            lbl_ciudad.Font = new Font("Century Gothic", 12F);
            lbl_ciudad.ForeColor = Color.DimGray;
            lbl_ciudad.Location = new Point(36, 234);
            lbl_ciudad.Name = "lbl_ciudad";
            lbl_ciudad.Size = new Size(69, 21);
            lbl_ciudad.TabIndex = 9;
            lbl_ciudad.Text = "Ciudad";
            // 
            // txtRnc
            // 
            txtRnc.Location = new Point(36, 193);
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(154, 23);
            txtRnc.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(225, 193);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(154, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(36, 319);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(343, 23);
            txtDireccion.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(225, 127);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(154, 23);
            txtCorreo.TabIndex = 13;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(36, 258);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(343, 23);
            txtCiudad.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 183, 150);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(132, 183, 150);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(225, 380);
            button2.Name = "button2";
            button2.Size = new Size(154, 44);
            button2.TabIndex = 15;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 36);
            button3.Name = "button3";
            button3.Size = new Size(52, 46);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            // 
            // dtgw_proveedores
            // 
            dtgw_proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_proveedores.Columns.AddRange(new DataGridViewColumn[] { Nombre, RNC, Telefono, Direccion, Correo });
            dtgw_proveedores.Location = new Point(65, 45);
            dtgw_proveedores.Name = "dtgw_proveedores";
            dtgw_proveedores.ReadOnly = true;
            dtgw_proveedores.Size = new Size(543, 266);
            dtgw_proveedores.TabIndex = 17;
            dtgw_proveedores.CellContentClick += dtgw_proveedores_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // RNC
            // 
            RNC.HeaderText = "RNC";
            RNC.Name = "RNC";
            RNC.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Ciudad";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtCiudad);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtRnc);
            panel1.Controls.Add(lbl_ciudad);
            panel1.Controls.Add(lbl_correo);
            panel1.Controls.Add(lbl_telefono);
            panel1.Controls.Add(lbl_direccion);
            panel1.Controls.Add(lbl_rnc);
            panel1.Controls.Add(lbl_Nombre);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(35, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 455);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_titulo);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 71);
            panel3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dtgw_proveedores);
            panel2.Location = new Point(410, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 358);
            panel2.TabIndex = 17;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, mantenimientoToolStripMenuItem, inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1088, 33);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            salirToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem, productosToolStripMenuItem });
            mantenimientoToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            mantenimientoToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(153, 29);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(189, 30);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(189, 30);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            inicioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(70, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // frm_proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1088, 591);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frm_proveedores";
            Text = "Formulario de Proveedores";
            Load += frm_proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgw_proveedores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button button1;
        private TextBox txtNombre;
        private Label lbl_Nombre;
        private Label lbl_rnc;
        private Label lbl_direccion;
        private Label lbl_telefono;
        private Label lbl_correo;
        private Label lbl_ciudad;
        private TextBox txtRnc;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtCiudad;
        private Button button2;
        private Button button3;
        private DataGridView dtgw_proveedores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn RNC;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
    }
}