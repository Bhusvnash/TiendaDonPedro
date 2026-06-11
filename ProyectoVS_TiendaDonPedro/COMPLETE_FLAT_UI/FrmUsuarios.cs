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
		public partial class FrmUsuarios : Form
		{
				public FrmUsuarios()
				{
						InitializeComponent();
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
						TxtNombres.Text = "";
						if (string.IsNullOrWhiteSpace(TxtIDUsuario.Text))
						{
								MessageBox.Show("Falta el campo ID Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtIDUsuario.Focus();
								return;
						}

						if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
						{
								MessageBox.Show("Falta el campo Usuario (Alias)", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtUsuario.Focus();
								return;
						}

						if (string.IsNullOrWhiteSpace(TxtNombres.Text))
						{
								MessageBox.Show("Falta el campo Nombres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtNombres.Focus();
								return;
						}

						if (string.IsNullOrWhiteSpace(TxtApellidos.Text))
						{
								MessageBox.Show("Falta el campo Apellidos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtApellidos.Focus();
								return;
						}

						if (string.IsNullOrWhiteSpace(TxtContraseña.Text))
						{
								MessageBox.Show("Falta el campo Contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtContraseña.Focus();
								return;
						}

						if (CbxRol.SelectedIndex < 0)
						{
								MessageBox.Show("Falta seleccionar el Rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								CbxRol.Focus();
								return;
						}

						// Si llegamos aquí, todos los campos están completos
						MessageBox.Show("Datos validados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						// Aquí va tu lógica para guardar en base de datos
				}
		}
}