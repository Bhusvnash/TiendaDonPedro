namespace COMPLETE_FLAT_UI
{
    partial class FrmCategorias
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
						this.BarraTitulo = new System.Windows.Forms.Panel();
						this.LblTituloFormCategoria = new System.Windows.Forms.Label();
						this.BtnCerrar = new System.Windows.Forms.Button();
						this.BtnSalir = new System.Windows.Forms.Button();
						this.BtnGuardar = new System.Windows.Forms.Button();
						this.TxtDescripcion = new System.Windows.Forms.TextBox();
						this.label5 = new System.Windows.Forms.Label();
						this.TxtIDCategoria = new System.Windows.Forms.TextBox();
						this.BarraTitulo.SuspendLayout();
						this.SuspendLayout();
						// 
						// BarraTitulo
						// 
						this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BarraTitulo.Controls.Add(this.LblTituloFormCategoria);
						this.BarraTitulo.Controls.Add(this.BtnCerrar);
						this.BarraTitulo.Location = new System.Drawing.Point(0, -1);
						this.BarraTitulo.Name = "BarraTitulo";
						this.BarraTitulo.Size = new System.Drawing.Size(391, 38);
						this.BarraTitulo.TabIndex = 36;
						// 
						// LblTituloFormCategoria
						// 
						this.LblTituloFormCategoria.AutoSize = true;
						this.LblTituloFormCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.LblTituloFormCategoria.ForeColor = System.Drawing.Color.White;
						this.LblTituloFormCategoria.Location = new System.Drawing.Point(137, 11);
						this.LblTituloFormCategoria.Name = "LblTituloFormCategoria";
						this.LblTituloFormCategoria.Size = new System.Drawing.Size(105, 17);
						this.LblTituloFormCategoria.TabIndex = 15;
						this.LblTituloFormCategoria.Text = "Form Categoria";
						// 
						// BtnCerrar
						// 
						this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnCerrar.FlatAppearance.BorderSize = 0;
						this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
						this.BtnCerrar.Location = new System.Drawing.Point(353, 0);
						this.BtnCerrar.Name = "BtnCerrar";
						this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
						this.BtnCerrar.TabIndex = 4;
						this.BtnCerrar.UseVisualStyleBackColor = true;
						this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
						// 
						// BtnSalir
						// 
						this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnSalir.FlatAppearance.BorderSize = 0;
						this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnSalir.ForeColor = System.Drawing.Color.White;
						this.BtnSalir.Location = new System.Drawing.Point(215, 97);
						this.BtnSalir.Name = "BtnSalir";
						this.BtnSalir.Size = new System.Drawing.Size(100, 35);
						this.BtnSalir.TabIndex = 46;
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
						this.BtnGuardar.Location = new System.Drawing.Point(86, 97);
						this.BtnGuardar.Name = "BtnGuardar";
						this.BtnGuardar.Size = new System.Drawing.Size(100, 35);
						this.BtnGuardar.TabIndex = 45;
						this.BtnGuardar.Text = "Guardar";
						this.BtnGuardar.UseVisualStyleBackColor = false;
						this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
						// 
						// TxtDescripcion
						// 
						this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtDescripcion.Location = new System.Drawing.Point(110, 51);
						this.TxtDescripcion.Name = "TxtDescripcion";
						this.TxtDescripcion.Size = new System.Drawing.Size(248, 23);
						this.TxtDescripcion.TabIndex = 41;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label5.ForeColor = System.Drawing.Color.LightGray;
						this.label5.Location = new System.Drawing.Point(18, 54);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(86, 17);
						this.label5.TabIndex = 42;
						this.label5.Text = "Descripcion:";
						// 
						// TxtIDCategoria
						// 
						this.TxtIDCategoria.Location = new System.Drawing.Point(154, 193);
						this.TxtIDCategoria.Name = "TxtIDCategoria";
						this.TxtIDCategoria.Size = new System.Drawing.Size(100, 20);
						this.TxtIDCategoria.TabIndex = 47;
						// 
						// FrmCategorias
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.ClientSize = new System.Drawing.Size(393, 188);
						this.Controls.Add(this.TxtIDCategoria);
						this.Controls.Add(this.BarraTitulo);
						this.Controls.Add(this.BtnSalir);
						this.Controls.Add(this.BtnGuardar);
						this.Controls.Add(this.TxtDescripcion);
						this.Controls.Add(this.label5);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						this.Name = "FrmCategorias";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "FrmCategorias";
						this.BarraTitulo.ResumeLayout(false);
						this.BarraTitulo.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        public System.Windows.Forms.Label LblTituloFormCategoria;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
				public System.Windows.Forms.TextBox TxtIDCategoria;
		}
}