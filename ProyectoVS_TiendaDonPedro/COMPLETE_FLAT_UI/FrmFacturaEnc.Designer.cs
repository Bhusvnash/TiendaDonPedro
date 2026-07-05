namespace COMPLETE_FLAT_UI
{
    partial class FrmFacturaEnc
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
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaEnc));
						this.BarraTitulo = new System.Windows.Forms.Panel();
						this.LblTituloFormCliente = new System.Windows.Forms.Label();
						this.BtnCerrar = new System.Windows.Forms.Button();
						this.BtnSalir = new System.Windows.Forms.Button();
						this.BtnGuardar = new System.Windows.Forms.Button();
						this.TxtSubTotal = new System.Windows.Forms.TextBox();
						this.label3 = new System.Windows.Forms.Label();
						this.label5 = new System.Windows.Forms.Label();
						this.TxtIdent = new System.Windows.Forms.TextBox();
						this.TxtNombreCliente = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.DGVDetalle = new System.Windows.Forms.DataGridView();
						this.label4 = new System.Windows.Forms.Label();
						this.label6 = new System.Windows.Forms.Label();
						this.TxtIVA = new System.Windows.Forms.TextBox();
						this.label7 = new System.Windows.Forms.Label();
						this.TxtTotal = new System.Windows.Forms.TextBox();
						this.BtnAddProd = new System.Windows.Forms.Button();
						this.BtnDelProd = new System.Windows.Forms.Button();
						this.BtnNuevo = new System.Windows.Forms.Button();
						this.BtnCancelar = new System.Windows.Forms.Button();
						this.DTPFecha = new System.Windows.Forms.DateTimePicker();
						this.CbxProductos = new System.Windows.Forms.ComboBox();
						this.label8 = new System.Windows.Forms.Label();
						this.TxtPrecioProducto = new System.Windows.Forms.TextBox();
						this.label9 = new System.Windows.Forms.Label();
						this.label10 = new System.Windows.Forms.Label();
						this.TxtCantidad = new System.Windows.Forms.TextBox();
						this.BarraTitulo.SuspendLayout();
						((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
						this.SuspendLayout();
						// 
						// BarraTitulo
						// 
						this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BarraTitulo.Controls.Add(this.LblTituloFormCliente);
						this.BarraTitulo.Controls.Add(this.BtnCerrar);
						this.BarraTitulo.Location = new System.Drawing.Point(-1, 1);
						this.BarraTitulo.Name = "BarraTitulo";
						this.BarraTitulo.Size = new System.Drawing.Size(704, 38);
						this.BarraTitulo.TabIndex = 36;
						// 
						// LblTituloFormCliente
						// 
						this.LblTituloFormCliente.AutoSize = true;
						this.LblTituloFormCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.LblTituloFormCliente.ForeColor = System.Drawing.Color.White;
						this.LblTituloFormCliente.Location = new System.Drawing.Point(236, 13);
						this.LblTituloFormCliente.Name = "LblTituloFormCliente";
						this.LblTituloFormCliente.Size = new System.Drawing.Size(117, 17);
						this.LblTituloFormCliente.TabIndex = 15;
						this.LblTituloFormCliente.Text = "Factura de Venta";
						// 
						// BtnCerrar
						// 
						this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnCerrar.FlatAppearance.BorderSize = 0;
						this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
						this.BtnCerrar.Location = new System.Drawing.Point(666, 0);
						this.BtnCerrar.Name = "BtnCerrar";
						this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
						this.BtnCerrar.TabIndex = 4;
						this.BtnCerrar.UseVisualStyleBackColor = true;
						// 
						// BtnSalir
						// 
						this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnSalir.FlatAppearance.BorderSize = 0;
						this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnSalir.ForeColor = System.Drawing.Color.White;
						this.BtnSalir.Location = new System.Drawing.Point(356, 372);
						this.BtnSalir.Name = "BtnSalir";
						this.BtnSalir.Size = new System.Drawing.Size(69, 35);
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
						this.BtnGuardar.Location = new System.Drawing.Point(131, 372);
						this.BtnGuardar.Name = "BtnGuardar";
						this.BtnGuardar.Size = new System.Drawing.Size(100, 35);
						this.BtnGuardar.TabIndex = 45;
						this.BtnGuardar.Text = "Guardar";
						this.BtnGuardar.UseVisualStyleBackColor = false;
						this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
						// 
						// TxtSubTotal
						// 
						this.TxtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtSubTotal.Location = new System.Drawing.Point(554, 294);
						this.TxtSubTotal.Name = "TxtSubTotal";
						this.TxtSubTotal.Size = new System.Drawing.Size(125, 23);
						this.TxtSubTotal.TabIndex = 43;
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label3.ForeColor = System.Drawing.Color.LightGray;
						this.label3.Location = new System.Drawing.Point(177, 55);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(135, 24);
						this.label3.TabIndex = 44;
						this.label3.Text = "Detalle Factura";
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label5.ForeColor = System.Drawing.Color.LightGray;
						this.label5.Location = new System.Drawing.Point(8, 49);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(47, 17);
						this.label5.TabIndex = 42;
						this.label5.Text = "Fecha";
						// 
						// TxtIdent
						// 
						this.TxtIdent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtIdent.Location = new System.Drawing.Point(463, 81);
						this.TxtIdent.Name = "TxtIdent";
						this.TxtIdent.Size = new System.Drawing.Size(10, 23);
						this.TxtIdent.TabIndex = 37;
						this.TxtIdent.TextChanged += new System.EventHandler(this.TxtIdent_TextChanged);
						this.TxtIdent.Validated += new System.EventHandler(this.TxtIdent_Validated);
						// 
						// TxtNombreCliente
						// 
						this.TxtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtNombreCliente.Location = new System.Drawing.Point(463, 52);
						this.TxtNombreCliente.Name = "TxtNombreCliente";
						this.TxtNombreCliente.ReadOnly = true;
						this.TxtNombreCliente.Size = new System.Drawing.Size(103, 23);
						this.TxtNombreCliente.TabIndex = 38;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label1.ForeColor = System.Drawing.Color.LightGray;
						this.label1.Location = new System.Drawing.Point(367, 54);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(58, 17);
						this.label1.TabIndex = 40;
						this.label1.Text = "Nombre";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label2.ForeColor = System.Drawing.Color.LightGray;
						this.label2.Location = new System.Drawing.Point(366, 81);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(90, 17);
						this.label2.TabIndex = 39;
						this.label2.Text = "Identificacion";
						// 
						// DGVDetalle
						// 
						this.DGVDetalle.AllowUserToAddRows = false;
						this.DGVDetalle.AllowUserToDeleteRows = false;
						this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.DGVDetalle.Location = new System.Drawing.Point(20, 110);
						this.DGVDetalle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
						this.DGVDetalle.Name = "DGVDetalle";
						this.DGVDetalle.ReadOnly = true;
						this.DGVDetalle.RowHeadersWidth = 51;
						this.DGVDetalle.RowTemplate.Height = 24;
						this.DGVDetalle.Size = new System.Drawing.Size(662, 147);
						this.DGVDetalle.TabIndex = 47;
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label4.ForeColor = System.Drawing.Color.LightGray;
						this.label4.Location = new System.Drawing.Point(486, 296);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(60, 17);
						this.label4.TabIndex = 48;
						this.label4.Text = "Subtotal";
						// 
						// label6
						// 
						this.label6.AutoSize = true;
						this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label6.ForeColor = System.Drawing.Color.LightGray;
						this.label6.Location = new System.Drawing.Point(512, 326);
						this.label6.Name = "label6";
						this.label6.Size = new System.Drawing.Size(29, 17);
						this.label6.TabIndex = 50;
						this.label6.Text = "IVA";
						// 
						// TxtIVA
						// 
						this.TxtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtIVA.Location = new System.Drawing.Point(554, 322);
						this.TxtIVA.Name = "TxtIVA";
						this.TxtIVA.Size = new System.Drawing.Size(125, 23);
						this.TxtIVA.TabIndex = 49;
						// 
						// label7
						// 
						this.label7.AutoSize = true;
						this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label7.ForeColor = System.Drawing.Color.LightGray;
						this.label7.Location = new System.Drawing.Point(451, 352);
						this.label7.Name = "label7";
						this.label7.Size = new System.Drawing.Size(94, 17);
						this.label7.TabIndex = 52;
						this.label7.Text = "Total a Pagar";
						// 
						// TxtTotal
						// 
						this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtTotal.Location = new System.Drawing.Point(554, 349);
						this.TxtTotal.Name = "TxtTotal";
						this.TxtTotal.Size = new System.Drawing.Size(125, 23);
						this.TxtTotal.TabIndex = 51;
						// 
						// BtnAddProd
						// 
						this.BtnAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnAddProd.FlatAppearance.BorderSize = 0;
						this.BtnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnAddProd.ForeColor = System.Drawing.Color.White;
						this.BtnAddProd.Location = new System.Drawing.Point(20, 322);
						this.BtnAddProd.Name = "BtnAddProd";
						this.BtnAddProd.Size = new System.Drawing.Size(100, 35);
						this.BtnAddProd.TabIndex = 53;
						this.BtnAddProd.Text = "Agregar Producto";
						this.BtnAddProd.UseVisualStyleBackColor = false;
						this.BtnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
						// 
						// BtnDelProd
						// 
						this.BtnDelProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnDelProd.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnDelProd.FlatAppearance.BorderSize = 0;
						this.BtnDelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnDelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnDelProd.ForeColor = System.Drawing.Color.White;
						this.BtnDelProd.Location = new System.Drawing.Point(126, 322);
						this.BtnDelProd.Name = "BtnDelProd";
						this.BtnDelProd.Size = new System.Drawing.Size(115, 35);
						this.BtnDelProd.TabIndex = 54;
						this.BtnDelProd.Text = "Eliminar Producto";
						this.BtnDelProd.UseVisualStyleBackColor = false;
						this.BtnDelProd.Click += new System.EventHandler(this.BtnDelProd_Click);
						// 
						// BtnNuevo
						// 
						this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnNuevo.FlatAppearance.BorderSize = 0;
						this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnNuevo.ForeColor = System.Drawing.Color.White;
						this.BtnNuevo.Location = new System.Drawing.Point(20, 372);
						this.BtnNuevo.Name = "BtnNuevo";
						this.BtnNuevo.Size = new System.Drawing.Size(100, 35);
						this.BtnNuevo.TabIndex = 55;
						this.BtnNuevo.Text = "Nuevo";
						this.BtnNuevo.UseVisualStyleBackColor = false;
						this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
						// 
						// BtnCancelar
						// 
						this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
						this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnCancelar.FlatAppearance.BorderSize = 0;
						this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnCancelar.ForeColor = System.Drawing.Color.White;
						this.BtnCancelar.Location = new System.Drawing.Point(241, 372);
						this.BtnCancelar.Name = "BtnCancelar";
						this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
						this.BtnCancelar.TabIndex = 56;
						this.BtnCancelar.Text = "Cancelar";
						this.BtnCancelar.UseVisualStyleBackColor = false;
						this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
						// 
						// DTPFecha
						// 
						this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
						this.DTPFecha.Location = new System.Drawing.Point(55, 49);
						this.DTPFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
						this.DTPFecha.Name = "DTPFecha";
						this.DTPFecha.Size = new System.Drawing.Size(101, 20);
						this.DTPFecha.TabIndex = 57;
						// 
						// CbxProductos
						// 
						this.CbxProductos.FormattingEnabled = true;
						this.CbxProductos.Location = new System.Drawing.Point(91, 266);
						this.CbxProductos.Name = "CbxProductos";
						this.CbxProductos.Size = new System.Drawing.Size(150, 21);
						this.CbxProductos.TabIndex = 58;
						// 
						// label8
						// 
						this.label8.AutoSize = true;
						this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label8.ForeColor = System.Drawing.Color.LightGray;
						this.label8.Location = new System.Drawing.Point(22, 270);
						this.label8.Name = "label8";
						this.label8.Size = new System.Drawing.Size(65, 17);
						this.label8.TabIndex = 59;
						this.label8.Text = "Producto";
						// 
						// TxtPrecioProducto
						// 
						this.TxtPrecioProducto.Location = new System.Drawing.Point(554, 264);
						this.TxtPrecioProducto.Name = "TxtPrecioProducto";
						this.TxtPrecioProducto.Size = new System.Drawing.Size(125, 20);
						this.TxtPrecioProducto.TabIndex = 60;
						// 
						// label9
						// 
						this.label9.AutoSize = true;
						this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label9.ForeColor = System.Drawing.Color.LightGray;
						this.label9.Location = new System.Drawing.Point(476, 266);
						this.label9.Name = "label9";
						this.label9.Size = new System.Drawing.Size(73, 17);
						this.label9.TabIndex = 61;
						this.label9.Text = "Precio Uni";
						// 
						// label10
						// 
						this.label10.AutoSize = true;
						this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label10.ForeColor = System.Drawing.Color.LightGray;
						this.label10.Location = new System.Drawing.Point(247, 268);
						this.label10.Name = "label10";
						this.label10.Size = new System.Drawing.Size(64, 17);
						this.label10.TabIndex = 63;
						this.label10.Text = "Cantidad";
						// 
						// TxtCantidad
						// 
						this.TxtCantidad.Location = new System.Drawing.Point(325, 267);
						this.TxtCantidad.Name = "TxtCantidad";
						this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
						this.TxtCantidad.TabIndex = 62;
						this.TxtCantidad.Enter += new System.EventHandler(this.TxtCantidad_Enter);
						// 
						// FrmFacturaEnc
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.ClientSize = new System.Drawing.Size(707, 470);
						this.Controls.Add(this.label10);
						this.Controls.Add(this.TxtCantidad);
						this.Controls.Add(this.label9);
						this.Controls.Add(this.TxtPrecioProducto);
						this.Controls.Add(this.label8);
						this.Controls.Add(this.CbxProductos);
						this.Controls.Add(this.DTPFecha);
						this.Controls.Add(this.BtnCancelar);
						this.Controls.Add(this.BtnNuevo);
						this.Controls.Add(this.BtnDelProd);
						this.Controls.Add(this.BtnAddProd);
						this.Controls.Add(this.label7);
						this.Controls.Add(this.TxtTotal);
						this.Controls.Add(this.label6);
						this.Controls.Add(this.TxtIVA);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.DGVDetalle);
						this.Controls.Add(this.BarraTitulo);
						this.Controls.Add(this.BtnSalir);
						this.Controls.Add(this.BtnGuardar);
						this.Controls.Add(this.TxtSubTotal);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.TxtIdent);
						this.Controls.Add(this.TxtNombreCliente);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.label2);
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
						this.Name = "FrmFacturaEnc";
						this.Text = "FrmFacturaEnc";
						this.BarraTitulo.ResumeLayout(false);
						this.BarraTitulo.PerformLayout();
						((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        public System.Windows.Forms.Label LblTituloFormCliente;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtIdent;
        public System.Windows.Forms.TextBox TxtNombreCliente;
				private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnAddProd;
        private System.Windows.Forms.Button BtnDelProd;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DTPFecha;
				private System.Windows.Forms.ComboBox CbxProductos;
				private System.Windows.Forms.Label label8;
				private System.Windows.Forms.TextBox TxtPrecioProducto;
				private System.Windows.Forms.Label label9;
				private System.Windows.Forms.Label label10;
				private System.Windows.Forms.TextBox TxtCantidad;
		}
}