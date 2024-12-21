namespace Gestion_de_Reservas
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCliente = new Label();
            lblPrecio = new Label();
            dtpFechadesde = new DateTimePicker();
            lbl_desde = new Label();
            txtCliente = new TextBox();
            cmbTipoHab = new ComboBox();
            lblTipo_hab = new Label();
            txtPrecio = new TextBox();
            lblF_Hasta = new Label();
            DtpFechaHasta = new DateTimePicker();
            btnAgregar = new Button();
            btnlEliminar = new Button();
            btnSalir = new Button();
            bindingSource1 = new BindingSource(components);
            ltb_reserva = new ListBox();
            btnLimpiar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(70, 132);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Century Gothic", 11.25F);
            lblPrecio.ForeColor = SystemColors.MenuHighlight;
            lblPrecio.Location = new Point(70, 435);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio ";
            // 
            // dtpFechadesde
            // 
            dtpFechadesde.Format = DateTimePickerFormat.Short;
            dtpFechadesde.Location = new Point(70, 308);
            dtpFechadesde.Name = "dtpFechadesde";
            dtpFechadesde.Size = new Size(202, 23);
            dtpFechadesde.TabIndex = 3;
            dtpFechadesde.Value = new DateTime(2024, 11, 25, 8, 9, 32, 0);
            dtpFechadesde.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_desde
            // 
            lbl_desde.AutoSize = true;
            lbl_desde.BackColor = Color.Transparent;
            lbl_desde.Font = new Font("Century Gothic", 11.25F);
            lbl_desde.ForeColor = SystemColors.MenuHighlight;
            lbl_desde.Location = new Point(70, 285);
            lbl_desde.Name = "lbl_desde";
            lbl_desde.Size = new Size(109, 20);
            lbl_desde.TabIndex = 4;
            lbl_desde.Text = "Fecha desde ";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(70, 155);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(202, 23);
            txtCliente.TabIndex = 5;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // cmbTipoHab
            // 
            cmbTipoHab.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHab.FormattingEnabled = true;
            cmbTipoHab.Items.AddRange(new object[] { "Habitacion estandar : 5000", "Habitacion Doble : 10000", "Habitacion Suite : 15000" });
            cmbTipoHab.Location = new Point(70, 237);
            cmbTipoHab.Name = "cmbTipoHab";
            cmbTipoHab.Size = new Size(202, 23);
            cmbTipoHab.TabIndex = 6;
            // 
            // lblTipo_hab
            // 
            lblTipo_hab.AutoSize = true;
            lblTipo_hab.BackColor = Color.Transparent;
            lblTipo_hab.Font = new Font("Century Gothic", 11.25F);
            lblTipo_hab.ForeColor = SystemColors.MenuHighlight;
            lblTipo_hab.Location = new Point(70, 214);
            lblTipo_hab.Name = "lblTipo_hab";
            lblTipo_hab.Size = new Size(83, 20);
            lblTipo_hab.TabIndex = 7;
            lblTipo_hab.Text = "Tipo_Hab :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(70, 458);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(202, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblF_Hasta
            // 
            lblF_Hasta.AutoSize = true;
            lblF_Hasta.BackColor = Color.Transparent;
            lblF_Hasta.Font = new Font("Century Gothic", 11.25F);
            lblF_Hasta.ForeColor = SystemColors.MenuHighlight;
            lblF_Hasta.Location = new Point(70, 365);
            lblF_Hasta.Name = "lblF_Hasta";
            lblF_Hasta.Size = new Size(104, 20);
            lblF_Hasta.TabIndex = 9;
            lblF_Hasta.Text = "Fecha Hasta ";
            // 
            // DtpFechaHasta
            // 
            DtpFechaHasta.Format = DateTimePickerFormat.Short;
            DtpFechaHasta.Location = new Point(70, 388);
            DtpFechaHasta.Name = "DtpFechaHasta";
            DtpFechaHasta.Size = new Size(202, 23);
            DtpFechaHasta.TabIndex = 10;
            DtpFechaHasta.Value = new DateTime(2024, 11, 25, 0, 0, 0, 0);
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuHighlight;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(70, 516);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnlEliminar
            // 
            btnlEliminar.BackColor = SystemColors.MenuHighlight;
            btnlEliminar.FlatStyle = FlatStyle.Popup;
            btnlEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnlEliminar.ForeColor = SystemColors.ControlLightLight;
            btnlEliminar.Location = new Point(351, 438);
            btnlEliminar.Name = "btnlEliminar";
            btnlEliminar.Size = new Size(83, 31);
            btnlEliminar.TabIndex = 12;
            btnlEliminar.Text = "Eliminar";
            btnlEliminar.UseVisualStyleBackColor = false;
            btnlEliminar.Click += btnlEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(12, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(53, 41);
            btnSalir.TabIndex = 14;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ltb_reserva
            // 
            ltb_reserva.FormattingEnabled = true;
            ltb_reserva.ItemHeight = 15;
            ltb_reserva.Location = new Point(84, 308);
            ltb_reserva.Name = "ltb_reserva";
            ltb_reserva.Size = new Size(350, 124);
            ltb_reserva.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.MenuHighlight;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(189, 516);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 31);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ltb_reserva);
            panel1.Controls.Add(btnlEliminar);
            panel1.Location = new Point(343, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 628);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12.25F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(193, 115);
            label2.Name = "label2";
            label2.Size = new Size(241, 63);
            label2.TabIndex = 18;
            label2.Text = "Lorem ipsum dolor sit amet, \r\nconsectetur adipiscing elit. \r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18.25F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 76);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Reservas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(840, 627);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(DtpFechaHasta);
            Controls.Add(lblF_Hasta);
            Controls.Add(txtPrecio);
            Controls.Add(lblTipo_hab);
            Controls.Add(cmbTipoHab);
            Controls.Add(txtCliente);
            Controls.Add(lbl_desde);
            Controls.Add(dtpFechadesde);
            Controls.Add(lblPrecio);
            Controls.Add(lblCliente);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblPrecio;
        private DateTimePicker dtpFechadesde;
        private Label lbl_desde;
        private TextBox txtCliente;
        private ComboBox cmbTipoHab;
        private Label lblTipo_hab;
        private TextBox txtPrecio;
        private Label lblF_Hasta;
        private DateTimePicker DtpFechaHasta;
        private Button btnAgregar;
        private Button btnlEliminar;
        private Button btnSalir;
        private BindingSource bindingSource1;
        private ListBox ltb_reserva;
        private Button btnLimpiar;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}
