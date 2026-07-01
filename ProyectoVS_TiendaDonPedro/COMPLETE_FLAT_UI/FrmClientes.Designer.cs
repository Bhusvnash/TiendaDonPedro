namespace COMPLETE_FLAT_UI
{
    partial class FrmClientes
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
						this.BtnCerrar = new System.Windows.Forms.Button();
						this.BarraTitulo = new System.Windows.Forms.Panel();
						this.LblTituloFormCliente = new System.Windows.Forms.Label();
						this.BtnSalir = new System.Windows.Forms.Button();
						this.BtnGuardar = new System.Windows.Forms.Button();
						this.TxtCorreo = new System.Windows.Forms.TextBox();
						this.label3 = new System.Windows.Forms.Label();
						this.TxtNombre = new System.Windows.Forms.TextBox();
						this.label5 = new System.Windows.Forms.Label();
						this.TxtDireccion = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.id_cliente = new System.Windows.Forms.TextBox();
						this.BarraTitulo.SuspendLayout();
						this.SuspendLayout();
						// 
						// BtnCerrar
						// 
						this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnCerrar.FlatAppearance.BorderSize = 0;
						this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
						this.BtnCerrar.Location = new System.Drawing.Point(468, 0);
						this.BtnCerrar.Name = "BtnCerrar";
						this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
						this.BtnCerrar.TabIndex = 4;
						this.BtnCerrar.UseVisualStyleBackColor = true;
						this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
						// 
						// BarraTitulo
						// 
						this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BarraTitulo.Controls.Add(this.LblTituloFormCliente);
						this.BarraTitulo.Controls.Add(this.BtnCerrar);
						this.BarraTitulo.Location = new System.Drawing.Point(0, 2);
						this.BarraTitulo.Name = "BarraTitulo";
						this.BarraTitulo.Size = new System.Drawing.Size(506, 38);
						this.BarraTitulo.TabIndex = 25;
						// 
						// LblTituloFormCliente
						// 
						this.LblTituloFormCliente.AutoSize = true;
						this.LblTituloFormCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.LblTituloFormCliente.ForeColor = System.Drawing.Color.White;
						this.LblTituloFormCliente.Location = new System.Drawing.Point(236, 13);
						this.LblTituloFormCliente.Name = "LblTituloFormCliente";
						this.LblTituloFormCliente.Size = new System.Drawing.Size(87, 17);
						this.LblTituloFormCliente.TabIndex = 15;
						this.LblTituloFormCliente.Text = "Form Cliente";
						// 
						// BtnSalir
						// 
						this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnSalir.FlatAppearance.BorderSize = 0;
						this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnSalir.ForeColor = System.Drawing.Color.White;
						this.BtnSalir.Location = new System.Drawing.Point(273, 150);
						this.BtnSalir.Name = "BtnSalir";
						this.BtnSalir.Size = new System.Drawing.Size(100, 35);
						this.BtnSalir.TabIndex = 35;
						this.BtnSalir.Text = "Salir";
						this.BtnSalir.UseVisualStyleBackColor = false;
						this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
						// 
						// BtnGuardar
						// 
						this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnGuardar.FlatAppearance.BorderSize = 0;
						this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnGuardar.ForeColor = System.Drawing.Color.White;
						this.BtnGuardar.Location = new System.Drawing.Point(144, 150);
						this.BtnGuardar.Name = "BtnGuardar";
						this.BtnGuardar.Size = new System.Drawing.Size(100, 35);
						this.BtnGuardar.TabIndex = 34;
						this.BtnGuardar.Text = "Guardar";
						this.BtnGuardar.UseVisualStyleBackColor = false;
						this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
						// 
						// TxtCorreo
						// 
						this.TxtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtCorreo.Location = new System.Drawing.Point(110, 110);
						this.TxtCorreo.Name = "TxtCorreo";
						this.TxtCorreo.Size = new System.Drawing.Size(357, 23);
						this.TxtCorreo.TabIndex = 32;
						this.TxtCorreo.Validated += new System.EventHandler(this.TxtCorreo_Validated);
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label3.ForeColor = System.Drawing.Color.LightGray;
						this.label3.Location = new System.Drawing.Point(18, 114);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(55, 17);
						this.label3.TabIndex = 33;
						this.label3.Text = "Correo:";
						// 
						// TxtNombre
						// 
						this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtNombre.Location = new System.Drawing.Point(110, 44);
						this.TxtNombre.Name = "TxtNombre";
						this.TxtNombre.Size = new System.Drawing.Size(357, 23);
						this.TxtNombre.TabIndex = 30;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label5.ForeColor = System.Drawing.Color.LightGray;
						this.label5.Location = new System.Drawing.Point(18, 50);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(69, 17);
						this.label5.TabIndex = 31;
						this.label5.Text = "Nombres:";
						// 
						// TxtDireccion
						// 
						this.TxtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(147, 95);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(475, 26);
            this.TxtDireccion.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Direccion:";
            // 
            // id_cliente
            // 
            this.id_cliente.Location = new System.Drawing.Point(154, 291);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(468, 22);
            this.id_cliente.TabIndex = 36;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClientes";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
						this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtDireccion.Location = new System.Drawing.Point(110, 77);
						this.TxtDireccion.Name = "TxtDireccion";
						this.TxtDireccion.Size = new System.Drawing.Size(357, 23);
						this.TxtDireccion.TabIndex = 27;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label1.ForeColor = System.Drawing.Color.LightGray;
						this.label1.Location = new System.Drawing.Point(18, 80);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(71, 17);
						this.label1.TabIndex = 29;
						this.label1.Text = "Direccion:";
						// 
						// id_cliente
						// 
						this.id_cliente.Location = new System.Drawing.Point(116, 236);
						this.id_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
						this.id_cliente.Name = "id_cliente";
						this.id_cliente.Size = new System.Drawing.Size(352, 20);
						this.id_cliente.TabIndex = 36;
						// 
						// FrmClientes
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.ClientSize = new System.Drawing.Size(506, 300);
						this.Controls.Add(this.id_cliente);
						this.Controls.Add(this.BtnSalir);
						this.Controls.Add(this.BtnGuardar);
						this.Controls.Add(this.TxtCorreo);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.TxtNombre);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.TxtDireccion);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.BarraTitulo);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						this.Name = "FrmClientes";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "FrmClientes";
						this.BarraTitulo.ResumeLayout(false);
						this.BarraTitulo.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();
>>>>>>> 57bb8ce (Update Productos)

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblTituloFormCliente;
				public System.Windows.Forms.TextBox id_cliente;
		}
}