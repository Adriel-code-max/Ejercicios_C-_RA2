namespace Desafio_de_formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtHijos = new System.Windows.Forms.Label();
            this.txtIncentivo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.Label();
            this.txtSFS = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.bxNombre = new System.Windows.Forms.TextBox();
            this.bxCargo = new System.Windows.Forms.TextBox();
            this.bxSueldo = new System.Windows.Forms.TextBox();
            this.BxHijo = new System.Windows.Forms.TextBox();
            this.BxIncentivo = new System.Windows.Forms.TextBox();
            this.bxAFP = new System.Windows.Forms.TextBox();
            this.bxSFS = new System.Windows.Forms.TextBox();
            this.bxISR = new System.Windows.Forms.TextBox();
            this.bxDescuento = new System.Windows.Forms.TextBox();
            this.bxNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(62, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(47, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtHijos
            // 
            this.txtHijos.AutoSize = true;
            this.txtHijos.Location = new System.Drawing.Point(62, 177);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(38, 13);
            this.txtHijos.TabIndex = 1;
            this.txtHijos.Text = "Hijo/s:";
            // 
            // txtIncentivo
            // 
            this.txtIncentivo.AutoSize = true;
            this.txtIncentivo.Location = new System.Drawing.Point(334, 69);
            this.txtIncentivo.Name = "txtIncentivo";
            this.txtIncentivo.Size = new System.Drawing.Size(114, 13);
            this.txtIncentivo.TabIndex = 2;
            this.txtIncentivo.Text = "Total sueldo incentivo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.AutoSize = true;
            this.txtSueldo.Location = new System.Drawing.Point(62, 146);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(43, 13);
            this.txtSueldo.TabIndex = 3;
            this.txtSueldo.Text = "Sueldo:";
            // 
            // txtCargo
            // 
            this.txtCargo.AutoSize = true;
            this.txtCargo.Location = new System.Drawing.Point(62, 102);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(38, 13);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.Text = "Cargo:";
            // 
            // txtAFP
            // 
            this.txtAFP.AutoSize = true;
            this.txtAFP.Location = new System.Drawing.Point(79, 253);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(30, 13);
            this.txtAFP.TabIndex = 5;
            this.txtAFP.Text = "AFP:";
            // 
            // txtNeto
            // 
            this.txtNeto.AutoSize = true;
            this.txtNeto.Location = new System.Drawing.Point(277, 285);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(69, 13);
            this.txtNeto.TabIndex = 6;
            this.txtNeto.Text = "Sueldo Neto:";
            // 
            // txtISR
            // 
            this.txtISR.AutoSize = true;
            this.txtISR.Location = new System.Drawing.Point(81, 315);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(28, 13);
            this.txtISR.TabIndex = 7;
            this.txtISR.Text = "ISR:";
            // 
            // txtSFS
            // 
            this.txtSFS.AutoSize = true;
            this.txtSFS.Location = new System.Drawing.Point(79, 285);
            this.txtSFS.Name = "txtSFS";
            this.txtSFS.Size = new System.Drawing.Size(30, 13);
            this.txtSFS.TabIndex = 8;
            this.txtSFS.Text = "SFS:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.AutoSize = true;
            this.txtDescuento.Location = new System.Drawing.Point(277, 253);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(89, 13);
            this.txtDescuento.TabIndex = 9;
            this.txtDescuento.Text = "Total Descuento:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(123, 401);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(550, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(337, 401);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // bxNombre
            // 
            this.bxNombre.Location = new System.Drawing.Point(123, 69);
            this.bxNombre.Name = "bxNombre";
            this.bxNombre.Size = new System.Drawing.Size(100, 20);
            this.bxNombre.TabIndex = 13;
            // 
            // bxCargo
            // 
            this.bxCargo.Location = new System.Drawing.Point(123, 102);
            this.bxCargo.Name = "bxCargo";
            this.bxCargo.Size = new System.Drawing.Size(100, 20);
            this.bxCargo.TabIndex = 14;
            // 
            // bxSueldo
            // 
            this.bxSueldo.Location = new System.Drawing.Point(123, 139);
            this.bxSueldo.Name = "bxSueldo";
            this.bxSueldo.Size = new System.Drawing.Size(100, 20);
            this.bxSueldo.TabIndex = 15;
            // 
            // BxHijo
            // 
            this.BxHijo.Location = new System.Drawing.Point(123, 174);
            this.BxHijo.Name = "BxHijo";
            this.BxHijo.Size = new System.Drawing.Size(100, 20);
            this.BxHijo.TabIndex = 16;
            // 
            // BxIncentivo
            // 
            this.BxIncentivo.Location = new System.Drawing.Point(451, 66);
            this.BxIncentivo.Name = "BxIncentivo";
            this.BxIncentivo.Size = new System.Drawing.Size(100, 20);
            this.BxIncentivo.TabIndex = 17;
            // 
            // bxAFP
            // 
            this.bxAFP.Location = new System.Drawing.Point(123, 250);
            this.bxAFP.Name = "bxAFP";
            this.bxAFP.Size = new System.Drawing.Size(100, 20);
            this.bxAFP.TabIndex = 18;
            // 
            // bxSFS
            // 
            this.bxSFS.Location = new System.Drawing.Point(123, 282);
            this.bxSFS.Name = "bxSFS";
            this.bxSFS.Size = new System.Drawing.Size(100, 20);
            this.bxSFS.TabIndex = 19;
            // 
            // bxISR
            // 
            this.bxISR.Location = new System.Drawing.Point(123, 312);
            this.bxISR.Name = "bxISR";
            this.bxISR.Size = new System.Drawing.Size(100, 20);
            this.bxISR.TabIndex = 20;
            // 
            // bxDescuento
            // 
            this.bxDescuento.Location = new System.Drawing.Point(372, 250);
            this.bxDescuento.Name = "bxDescuento";
            this.bxDescuento.Size = new System.Drawing.Size(100, 20);
            this.bxDescuento.TabIndex = 21;
            // 
            // bxNeto
            // 
            this.bxNeto.Location = new System.Drawing.Point(372, 282);
            this.bxNeto.Name = "bxNeto";
            this.bxNeto.Size = new System.Drawing.Size(100, 20);
            this.bxNeto.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bxNeto);
            this.Controls.Add(this.bxDescuento);
            this.Controls.Add(this.bxISR);
            this.Controls.Add(this.bxSFS);
            this.Controls.Add(this.bxAFP);
            this.Controls.Add(this.BxIncentivo);
            this.Controls.Add(this.BxHijo);
            this.Controls.Add(this.bxSueldo);
            this.Controls.Add(this.bxCargo);
            this.Controls.Add(this.bxNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSFS);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtIncentivo);
            this.Controls.Add(this.txtHijos);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtHijos;
        private System.Windows.Forms.Label txtIncentivo;
        private System.Windows.Forms.Label txtSueldo;
        private System.Windows.Forms.Label txtCargo;
        private System.Windows.Forms.Label txtAFP;
        private System.Windows.Forms.Label txtNeto;
        private System.Windows.Forms.Label txtISR;
        private System.Windows.Forms.Label txtSFS;
        private System.Windows.Forms.Label txtDescuento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox bxNombre;
        private System.Windows.Forms.TextBox bxCargo;
        private System.Windows.Forms.TextBox bxSueldo;
        private System.Windows.Forms.TextBox BxHijo;
        private System.Windows.Forms.TextBox BxIncentivo;
        private System.Windows.Forms.TextBox bxAFP;
        private System.Windows.Forms.TextBox bxSFS;
        private System.Windows.Forms.TextBox bxISR;
        private System.Windows.Forms.TextBox bxDescuento;
        private System.Windows.Forms.TextBox bxNeto;
    }
}

