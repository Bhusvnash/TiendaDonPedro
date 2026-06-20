using COMPLETE_FLAT_UI.BackEnd;
using COMPLETE_FLAT_UI.BackEnd.modelos;
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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
				public bool editando = false;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

				private void BtnGuardar_Click(object sender, EventArgs e)
				{
						if (string.IsNullOrEmpty(TxtDescripcion.Text))
						{
								MessageBox.Show("Falta el campo Descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtDescripcion.Focus();
								return;
						}
						#region Nuevo
						if (!editando)
						{
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtDescripcion.Text.Trim()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								 
								if (FuncCategorias.NewCategoria(TxtDescripcion.Text.Trim()))
								{
										MessageBox.Show("Categoría registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtDescripcion.Clear();
								}
								else
								{
										MessageBox.Show("Error: No se pudo registrar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtDescripcion.Focus();
								}
						}
						#endregion
						#region Editar
						if (editando)
						{
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtDescripcion.Text.Trim()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								if (FuncCategorias.UpdateCategoria(new Categoria(Convert.ToInt64(TxtIDCategoria.Text), TxtDescripcion.Text.Trim())))
								{
										MessageBox.Show("Categoría actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtDescripcion.Clear();
								}
								else
								{
										MessageBox.Show("Error: No se pudo actualizar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtDescripcion.Focus();
								}
						}
						#endregion
				}
		}
}
