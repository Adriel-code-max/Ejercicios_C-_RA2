namespace _06_Desafio_GUI
{
    partial class frm_mProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mProducto));
            lbl_titulo = new Label();
            lbl_categoria = new Label();
            lbl_precio = new Label();
            lbl_stock = new Label();
            lbl_nombre = new Label();
            btn_agregar = new Button();
            btn_limpiar = new Button();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btn_salir = new Button();
            dtgw_productos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btn_elimina = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_edit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgw_productos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Berlin Sans FB", 20F);
            lbl_titulo.ForeColor = SystemColors.Control;
            lbl_titulo.Location = new Point(80, 20);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(248, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestion de Productos";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Century Gothic", 12.25F);
            lbl_categoria.ForeColor = Color.DimGray;
            lbl_categoria.Location = new Point(216, 128);
            lbl_categoria.Margin = new Padding(4, 0, 4, 0);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(96, 21);
            lbl_categoria.TabIndex = 2;
            lbl_categoria.Text = "Categoria";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Century Gothic", 12.25F);
            lbl_precio.ForeColor = Color.DimGray;
            lbl_precio.Location = new Point(33, 196);
            lbl_precio.Margin = new Padding(4, 0, 4, 0);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(61, 21);
            lbl_precio.TabIndex = 3;
            lbl_precio.Text = "Precio";
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Century Gothic", 12.25F);
            lbl_stock.ForeColor = Color.DimGray;
            lbl_stock.Location = new Point(217, 196);
            lbl_stock.Margin = new Padding(4, 0, 4, 0);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(56, 21);
            lbl_stock.TabIndex = 4;
            lbl_stock.Text = "Stock";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Century Gothic", 12.25F);
            lbl_nombre.ForeColor = Color.DimGray;
            lbl_nombre.Location = new Point(33, 128);
            lbl_nombre.Margin = new Padding(4, 0, 4, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(77, 21);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(96, 103, 144);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 110, 175);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 110, 175);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Cascadia Code", 12F);
            btn_agregar.ForeColor = SystemColors.ControlLightLight;
            btn_agregar.Location = new Point(33, 290);
            btn_agregar.Margin = new Padding(4, 5, 4, 5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(160, 35);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(96, 103, 144);
            btn_limpiar.FlatAppearance.BorderSize = 0;
            btn_limpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 110, 175);
            btn_limpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 110, 175);
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Cascadia Code", 12F);
            btn_limpiar.ForeColor = SystemColors.ControlLightLight;
            btn_limpiar.Location = new Point(217, 290);
            btn_limpiar.Margin = new Padding(4, 5, 4, 5);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(159, 35);
            btn_limpiar.TabIndex = 7;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 151);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(216, 151);
            txtCategoria.Margin = new Padding(4, 5, 4, 5);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(160, 23);
            txtCategoria.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(33, 222);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(160, 23);
            txtPrecio.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(216, 222);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(160, 23);
            txtStock.TabIndex = 11;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.White;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Center;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(0, 36);
            btn_salir.Margin = new Padding(4, 5, 4, 5);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 40);
            btn_salir.TabIndex = 12;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dtgw_productos
            // 
            dtgw_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_productos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, Precio, Stock });
            dtgw_productos.Location = new Point(70, 44);
            dtgw_productos.Margin = new Padding(4, 5, 4, 5);
            dtgw_productos.Name = "dtgw_productos";
            dtgw_productos.ReadOnly = true;
            dtgw_productos.Size = new Size(408, 200);
            dtgw_productos.TabIndex = 13;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 90F;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 80;
            // 
            // Precio
            // 
            Precio.FillWeight = 80F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 70;
            // 
            // Stock
            // 
            Stock.FillWeight = 70F;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 65;
            // 
            // btn_elimina
            // 
            btn_elimina.BackColor = Color.FromArgb(128, 138, 192);
            btn_elimina.FlatAppearance.BorderSize = 0;
            btn_elimina.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 110, 175);
            btn_elimina.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 110, 175);
            btn_elimina.FlatStyle = FlatStyle.Flat;
            btn_elimina.Font = new Font("Cascadia Code", 12F);
            btn_elimina.ForeColor = SystemColors.ControlLightLight;
            btn_elimina.Location = new Point(385, 270);
            btn_elimina.Margin = new Padding(4, 5, 4, 5);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(93, 35);
            btn_elimina.TabIndex = 14;
            btn_elimina.Text = "Eliminar ";
            btn_elimina.UseVisualStyleBackColor = false;
            btn_elimina.Click += btn_elimina_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(128, 138, 192);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 110, 175);
            btn_edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 110, 175);
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Cascadia Code", 12F);
            btn_edit.ForeColor = SystemColors.ControlLightLight;
            btn_edit.Location = new Point(272, 270);
            btn_edit.Margin = new Padding(4, 5, 4, 5);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(93, 35);
            btn_edit.TabIndex = 15;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(191, 196, 223);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_agregar);
            panel1.Controls.Add(lbl_nombre);
            panel1.Controls.Add(lbl_stock);
            panel1.Controls.Add(lbl_precio);
            panel1.Controls.Add(lbl_categoria);
            panel1.Location = new Point(50, 86);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 386);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 138, 192);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_titulo);
            panel2.Location = new Point(50, 86);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(409, 70);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(103, 96, 144);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_edit);
            panel3.Controls.Add(btn_elimina);
            panel3.Controls.Add(dtgw_productos);
            panel3.Location = new Point(424, 125);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 330);
            panel3.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(103, 96, 144);
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, mantenimientoToolStripMenuItem, inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(993, 33);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            salirToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
           
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
        
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(189, 30);
            productosToolStripMenuItem.Text = "Productos";
            
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            inicioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(70, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            
            // 
            // frm_mProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 523);
            Controls.Add(panel2);
            Controls.Add(btn_salir);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frm_mProducto";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dtgw_productos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_categoria;
        private Label lbl_precio;
        private Label lbl_stock;
        private Label lbl_nombre;
        private Button btn_agregar;
        private Button btn_limpiar;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btn_salir;
        private DataGridView dtgw_productos;
        private Button btn_elimina;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_edit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}