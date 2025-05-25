namespace CapaPresentacion
{
    partial class RegistrarLog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLog));
            this.pnlBar = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorMensage = new System.Windows.Forms.Label();
            this.cbVer1 = new System.Windows.Forms.CheckBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(47)))), ((int)(((byte)(112)))));
            this.pnlBar.Controls.Add(this.picMinimizar);
            this.pnlBar.Controls.Add(this.picCerrar);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(743, 33);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBar_Paint);
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(655, 7);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(16, 16);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 10;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(677, 7);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(16, 16);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 9;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(244, 513);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(335, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "____________________________________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(338, 207);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(316, 16);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Black;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(338, 255);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(316, 16);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(335, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "____________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(395, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Regístrate";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(11)))), ((int)(((byte)(62)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(47)))), ((int)(((byte)(112)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(47)))), ((int)(((byte)(112)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Silver;
            this.btnRegistrar.Location = new System.Drawing.Point(338, 451);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(316, 31);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(11)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 513);
            this.panel2.TabIndex = 1;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BackColor = System.Drawing.Color.Black;
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(338, 303);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(316, 16);
            this.txtConfirmarContraseña.TabIndex = 3;
            this.txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
            this.txtConfirmarContraseña.Enter += new System.EventHandler(this.txtConfirmarContraseña_Enter);
            this.txtConfirmarContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            this.txtConfirmarContraseña.Leave += new System.EventHandler(this.txtConfirmarContraseña_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(335, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "____________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(320, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // lblErrorMensage
            // 
            this.lblErrorMensage.AutoSize = true;
            this.lblErrorMensage.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMensage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(87)))), ((int)(((byte)(76)))));
            this.lblErrorMensage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMensage.Image")));
            this.lblErrorMensage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMensage.Location = new System.Drawing.Point(334, 413);
            this.lblErrorMensage.Name = "lblErrorMensage";
            this.lblErrorMensage.Size = new System.Drawing.Size(106, 19);
            this.lblErrorMensage.TabIndex = 10;
            this.lblErrorMensage.Text = "Error Mensage";
            this.lblErrorMensage.Visible = false;
            // 
            // cbVer1
            // 
            this.cbVer1.AutoSize = true;
            this.cbVer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVer1.ForeColor = System.Drawing.Color.DimGray;
            this.cbVer1.Location = new System.Drawing.Point(521, 388);
            this.cbVer1.Name = "cbVer1";
            this.cbVer1.Size = new System.Drawing.Size(133, 21);
            this.cbVer1.TabIndex = 4;
            this.cbVer1.Text = "Ver Contraseñas";
            this.cbVer1.UseVisualStyleBackColor = true;
            this.cbVer1.CheckedChanged += new System.EventHandler(this.cbVer1_CheckedChanged);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.Black;
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCompleto.Location = new System.Drawing.Point(338, 159);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(316, 16);
            this.txtNombreCompleto.TabIndex = 0;
            this.txtNombreCompleto.Text = "NOMBRE COMPLETO";
            this.txtNombreCompleto.Enter += new System.EventHandler(this.txtNombreCompleto_Enter);
            this.txtNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCompleto_KeyPress);
            this.txtNombreCompleto.Leave += new System.EventHandler(this.txtNombreCompleto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(335, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "____________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(335, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "____________________________________________________";
            // 
            // cmbRoles
            // 
            this.cmbRoles.BackColor = System.Drawing.Color.Black;
            this.cmbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.ForeColor = System.Drawing.Color.DimGray;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(338, 356);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(316, 25);
            this.cmbRoles.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(338, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rol:";
            // 
            // RegistrarLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(743, 546);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbVer1);
            this.Controls.Add(this.lblErrorMensage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarLog";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarLog_MouseDown);
            this.pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorMensage;
        private System.Windows.Forms.CheckBox cbVer1;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label8;
    }
}