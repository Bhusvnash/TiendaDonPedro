using COMPLETE_FLAT_UI.BackEnd;
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
						//msg-> continua ?
						DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtUsuario.Text}, {TxtNombres.Text}, {TxtApellidos.Text}?"
						,"Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (result == DialogResult.Yes)
						{
								if (FuncUsuarios.NewUsuario(new Usuario(-1, TxtUsuario.Text, TxtNombres.Text, TxtApellidos.Text, TxtContraseña.Text, CbxRol.Text)))
								{
										MessageBox.Show("Usuario registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtUsuario.Clear();
										TxtNombres.Clear();
										TxtApellidos.Clear();
										TxtContraseña.Clear();
										CbxRol.SelectedIndex = -1;
								}
								else
								{
										MessageBox.Show("Error: No se pudo registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtUsuario.Focus();
								}
						}
						else if (result == DialogResult.No)
						{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
				}
		}
}