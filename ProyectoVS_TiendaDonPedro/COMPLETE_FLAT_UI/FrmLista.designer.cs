namespace COMPLETE_FLAT_UI
{
    partial class FrmLista
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
						System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
						System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
						System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
						this.LblTitulo = new System.Windows.Forms.Label();
						this.DGVDatos = new System.Windows.Forms.DataGridView();
						this.BtnCerrar = new System.Windows.Forms.Button();
						this.btnEditar = new System.Windows.Forms.Button();
						this.BtnEliminar = new System.Windows.Forms.Button();
						this.btnNuevo = new System.Windows.Forms.Button();
						this.BtnExcel = new System.Windows.Forms.Button();
						((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
						this.SuspendLayout();
						// 
						// LblTitulo
						// 
						this.LblTitulo.AutoSize = true;
						this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.LblTitulo.ForeColor = System.Drawing.Color.White;
						this.LblTitulo.Location = new System.Drawing.Point(49, 12);
						this.LblTitulo.Name = "LblTitulo";
						this.LblTitulo.Size = new System.Drawing.Size(146, 20);
						this.LblTitulo.TabIndex = 0;
						this.LblTitulo.Text = "Lista de XXXXXXX";
						// 
						// DGVDatos
						// 
						this.DGVDatos.AllowUserToAddRows = false;
						this.DGVDatos.AllowUserToDeleteRows = false;
						this.DGVDatos.AllowUserToResizeColumns = false;
						this.DGVDatos.AllowUserToResizeRows = false;
						this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
						this.DGVDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
						this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.DGVDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
						this.DGVDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
						dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
						dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
						dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
						dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
						dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
						this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
						this.DGVDatos.ColumnHeadersHeight = 30;
						dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
						dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
						dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
						dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
						dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
						dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
						this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle2;
						this.DGVDatos.EnableHeadersVisualStyles = false;
						this.DGVDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.DGVDatos.Location = new System.Drawing.Point(24, 56);
						this.DGVDatos.Name = "DGVDatos";
						this.DGVDatos.ReadOnly = true;
						this.DGVDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
						dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
						dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
						dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
						dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
						dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
						this.DGVDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
						this.DGVDatos.RowHeadersWidth = 51;
						this.DGVDatos.Size = new System.Drawing.Size(711, 377);
						this.DGVDatos.TabIndex = 2;
						// 
						// BtnCerrar
						// 
						this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnCerrar.FlatAppearance.BorderSize = 0;
						this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
						this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
						this.BtnCerrar.Name = "BtnCerrar";
						this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
						this.BtnCerrar.TabIndex = 3;
						this.BtnCerrar.UseVisualStyleBackColor = true;
						this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
						// 
						// btnEditar
						// 
						this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
						this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.btnEditar.ForeColor = System.Drawing.Color.Silver;
						this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.btnEditar.Location = new System.Drawing.Point(749, 92);
						this.btnEditar.Name = "btnEditar";
						this.btnEditar.Size = new System.Drawing.Size(100, 30);
						this.btnEditar.TabIndex = 4;
						this.btnEditar.Text = "Editar";
						this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.btnEditar.UseVisualStyleBackColor = false;
						this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
						// 
						// BtnEliminar
						// 
						this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
						this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnEliminar.ForeColor = System.Drawing.Color.Silver;
						this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.BtnEliminar.Location = new System.Drawing.Point(749, 128);
						this.BtnEliminar.Name = "BtnEliminar";
						this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
						this.BtnEliminar.TabIndex = 5;
						this.BtnEliminar.Text = "Eliminar";
						this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.BtnEliminar.UseVisualStyleBackColor = false;
						// 
						// btnNuevo
						// 
						this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
						this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
						this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.btnNuevo.ForeColor = System.Drawing.Color.Silver;
						this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.btnNuevo.Location = new System.Drawing.Point(749, 56);
						this.btnNuevo.Name = "btnNuevo";
						this.btnNuevo.Size = new System.Drawing.Size(100, 30);
						this.btnNuevo.TabIndex = 6;
						this.btnNuevo.Text = "Nuevo";
						this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.btnNuevo.UseVisualStyleBackColor = false;
						this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
						// 
						// BtnExcel
						// 
						this.BtnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.BtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
						this.BtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
						this.BtnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.BtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
						this.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.BtnExcel.ForeColor = System.Drawing.Color.Silver;
						this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.BtnExcel.Location = new System.Drawing.Point(749, 165);
						this.BtnExcel.Name = "BtnExcel";
						this.BtnExcel.Size = new System.Drawing.Size(100, 30);
						this.BtnExcel.TabIndex = 7;
						this.BtnExcel.Text = "Mostrar Excel";
						this.BtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.BtnExcel.UseVisualStyleBackColor = false;
						// 
						// FrmLista
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
						this.ClientSize = new System.Drawing.Size(870, 457);
						this.Controls.Add(this.BtnExcel);
						this.Controls.Add(this.btnNuevo);
						this.Controls.Add(this.BtnEliminar);
						this.Controls.Add(this.btnEditar);
						this.Controls.Add(this.BtnCerrar);
						this.Controls.Add(this.DGVDatos);
						this.Controls.Add(this.LblTitulo);
						this.Name = "FrmLista";
						this.Text = "FormLista";
						((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnExcel;
    }
}