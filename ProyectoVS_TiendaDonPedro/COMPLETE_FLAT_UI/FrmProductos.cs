  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
				public bool editando = false;
				public long idProducto = -1;
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

				private void BtnGuardar_Click(object sender, EventArgs e)
				{
						#region TxtNotNull
						if (string.IsNullOrWhiteSpace(TxtNombre.Text))
						{
								MessageBox.Show("Falta el campo Nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtNombre.Focus();
								return;
						}
						if (string.IsNullOrWhiteSpace(TxtPrecio.Text))
						{
								MessageBox.Show("Falta el campo Precio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtPrecio.Focus();
								return;
						}
						if (string.IsNullOrWhiteSpace(TxtStock.Text))
						{
								MessageBox.Show("Falta el campo Stock", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtStock.Focus();
								return;
						}
						if (string.IsNullOrWhiteSpace(TxtIVA.Text))
						{
								MessageBox.Show("Falta el campo IVA", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtIVA.Focus();
								return;
						}
						if (CbxCategoria.SelectedIndex < 0)
						{
								MessageBox.Show("Falta seleccionar la Categoría", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								CbxCategoria.Focus();
								return;
						}
						#endregion

						long idCategoria = CbxCategoria.SelectedIndex + 1;

						
						if (!editando)
						{
								#region Nuevo
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtNombre.Text}, Precio: {TxtPrecio.Text}, Stock: {TxtStock.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								
								Producto prod = new Producto(-1, TxtNombre.Text, Convert.ToInt64(TxtPrecio.Text), Convert.ToInt32(TxtStock.Text), Convert.ToDouble(TxtIVA.Text), idCategoria);

								if (FuncionesProdutos.NewProducto(prod))
								{
										MessageBox.Show("Producto registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtNombre.Clear(); TxtPrecio.Clear(); TxtStock.Clear(); TxtIVA.Clear(); CbxCategoria.SelectedIndex = -1;
								}
								else
								{
										MessageBox.Show("Error: No se pudo registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtNombre.Focus();
								}
								#endregion
						}


						if (editando)
						{
								#region Editando 
								
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtNombre.Text}, Precio: {TxtPrecio.Text}, Stock: {TxtStock.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								
								Producto prod = new Producto(idProducto, TxtNombre.Text, Convert.ToInt64(TxtPrecio.Text), Convert.ToInt32(TxtStock.Text), Convert.ToDouble(TxtIVA.Text), idCategoria);
								if (FuncionesProdutos.UpdateProducto(prod))
								{
										MessageBox.Show("Producto actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtNombre.Clear(); TxtPrecio.Clear(); TxtStock.Clear(); TxtIVA.Clear(); CbxCategoria.SelectedIndex = -1;
								}
								else
								{
										MessageBox.Show("Error: No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtNombre.Focus();
								}
								#endregion
						}
				}
		}
}
