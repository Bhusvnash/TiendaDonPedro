namespace COMPLETE_FLAT_UI
{
    partial class FrmProductos
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
						this.BtnSalir = new System.Windows.Forms.Button();
						this.BtnGuardar = new System.Windows.Forms.Button();
						this.label3 = new System.Windows.Forms.Label();
						this.TxtNombre = new System.Windows.Forms.TextBox();
						this.label5 = new System.Windows.Forms.Label();
						this.TxtPrecio = new System.Windows.Forms.TextBox();
						this.TxtStock = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.BarraTitulo = new System.Windows.Forms.Panel();
						this.LblTituloForm = new System.Windows.Forms.Label();
						this.BtnCerrar = new System.Windows.Forms.Button();
						this.TxtIVA = new System.Windows.Forms.TextBox();
						this.label4 = new System.Windows.Forms.Label();
						this.CbxCategoria = new System.Windows.Forms.ComboBox();
						this.BarraTitulo.SuspendLayout();
						this.SuspendLayout();
						// 
						// BtnSalir
						// 
						this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnSalir.FlatAppearance.BorderSize = 0;
						this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnSalir.ForeColor = System.Drawing.Color.White;
						this.BtnSalir.Location = new System.Drawing.Point(275, 207);
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
						this.BtnGuardar.Location = new System.Drawing.Point(146, 207);
						this.BtnGuardar.Name = "BtnGuardar";
						this.BtnGuardar.Size = new System.Drawing.Size(100, 35);
						this.BtnGuardar.TabIndex = 45;
						this.BtnGuardar.Text = "Guardar";
						this.BtnGuardar.UseVisualStyleBackColor = false;
						this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label3.ForeColor = System.Drawing.Color.LightGray;
						this.label3.Location = new System.Drawing.Point(19, 134);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(73, 17);
						this.label3.TabIndex = 44;
						this.label3.Text = "Categoria:";
						// 
						// TxtNombre
						// 
						this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtNombre.BackColor = System.Drawing.Color.White;
						this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtNombre.Location = new System.Drawing.Point(111, 43);
						this.TxtNombre.Name = "TxtNombre";
						this.TxtNombre.Size = new System.Drawing.Size(357, 23);
						this.TxtNombre.TabIndex = 41;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label5.ForeColor = System.Drawing.Color.LightGray;
						this.label5.Location = new System.Drawing.Point(19, 49);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(62, 17);
						this.label5.TabIndex = 42;
						this.label5.Text = "Nombre:";
						// 
						// TxtPrecio
						// 
						this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtPrecio.Location = new System.Drawing.Point(111, 72);
						this.TxtPrecio.Name = "TxtPrecio";
						this.TxtPrecio.Size = new System.Drawing.Size(357, 23);
						this.TxtPrecio.TabIndex = 37;
						this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
						// 
						// TxtStock
						// 
						this.TxtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtStock.Location = new System.Drawing.Point(111, 102);
						this.TxtStock.Name = "TxtStock";
						this.TxtStock.Size = new System.Drawing.Size(357, 23);
						this.TxtStock.TabIndex = 38;
						this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label1.ForeColor = System.Drawing.Color.LightGray;
						this.label1.Location = new System.Drawing.Point(19, 105);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(47, 17);
						this.label1.TabIndex = 40;
						this.label1.Text = "Stock:";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label2.ForeColor = System.Drawing.Color.LightGray;
						this.label2.Location = new System.Drawing.Point(19, 75);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(52, 17);
						this.label2.TabIndex = 39;
						this.label2.Text = "Precio:";
						// 
						// BarraTitulo
						// 
						this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BarraTitulo.Controls.Add(this.LblTituloForm);
						this.BarraTitulo.Controls.Add(this.BtnCerrar);
						this.BarraTitulo.Location = new System.Drawing.Point(1, 1);
						this.BarraTitulo.Name = "BarraTitulo";
						this.BarraTitulo.Size = new System.Drawing.Size(506, 38);
						this.BarraTitulo.TabIndex = 36;
						// 
						// LblTituloForm
						// 
						this.LblTituloForm.AutoSize = true;
						this.LblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.LblTituloForm.ForeColor = System.Drawing.Color.White;
						this.LblTituloForm.Location = new System.Drawing.Point(217, 11);
						this.LblTituloForm.Name = "LblTituloForm";
						this.LblTituloForm.Size = new System.Drawing.Size(108, 17);
						this.LblTituloForm.TabIndex = 15;
						this.LblTituloForm.Text = "Form Productos";
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
						// TxtIVA
						// 
						this.TxtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtIVA.Location = new System.Drawing.Point(111, 160);
						this.TxtIVA.Name = "TxtIVA";
						this.TxtIVA.Size = new System.Drawing.Size(357, 23);
						this.TxtIVA.TabIndex = 47;
						this.TxtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label4.ForeColor = System.Drawing.Color.LightGray;
						this.label4.Location = new System.Drawing.Point(19, 163);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(33, 17);
						this.label4.TabIndex = 48;
						this.label4.Text = "IVA:";
						// 
						// CbxCategoria
						// 
						this.CbxCategoria.FormattingEnabled = true;
						this.CbxCategoria.Location = new System.Drawing.Point(111, 132);
						this.CbxCategoria.Name = "CbxCategoria";
						this.CbxCategoria.Size = new System.Drawing.Size(357, 21);
						this.CbxCategoria.TabIndex = 49;
						// 
						// FrmProductos
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.ClientSize = new System.Drawing.Size(512, 255);
						this.Controls.Add(this.CbxCategoria);
						this.Controls.Add(this.TxtIVA);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.BtnSalir);
						this.Controls.Add(this.BtnGuardar);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.TxtNombre);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.TxtPrecio);
						this.Controls.Add(this.TxtStock);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.BarraTitulo);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						this.Name = "FrmProductos";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "FrmProductos";
						this.BarraTitulo.ResumeLayout(false);
						this.BarraTitulo.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BarraTitulo;
        public System.Windows.Forms.Label LblTituloForm;
        public System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CbxCategoria;
    }
}