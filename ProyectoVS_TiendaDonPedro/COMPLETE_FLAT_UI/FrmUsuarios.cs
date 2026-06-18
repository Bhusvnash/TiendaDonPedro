using COMPLETE_FLAT_UI.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

				public bool editando = false;

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
						//si no esta editando editando
						if (!editando)
						{
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtUsuario.Text}, {TxtNombres.Text}, {TxtApellidos.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
								Usuario user = new Usuario(-1, TxtUsuario.Text, TxtNombres.Text, TxtApellidos.Text, TxtContraseña.Text, CbxRol.Text);

								if (FuncUsuarios.NewUsuario(user))
								{
										MessageBox.Show("Usuario registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										//limpiamos los campos
										TxtUsuario.Clear(); TxtNombres.Clear(); TxtApellidos.Clear(); TxtContraseña.Clear(); CbxRol.SelectedIndex = -1;
								}
								else
								{
										MessageBox.Show("Error: No se pudo registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtUsuario.Focus();
								}
						}
						//esta editando
						if (editando)
						{
								//preguntamos si quiera continuar con los datos que tiene
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtUsuario.Text}, {TxtNombres.Text}, {TxtApellidos.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								Usuario user = new Usuario(Convert.ToInt64(TxtIDUsuario.Text), TxtUsuario.Text, TxtNombres.Text, TxtApellidos.Text, TxtContraseña.Text, CbxRol.Text);
								if (FuncUsuarios.UpdateUsuario(user))
								{
										MessageBox.Show("Usuario actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtUsuario.Clear(); TxtNombres.Clear(); TxtApellidos.Clear(); TxtContraseña.Clear(); CbxRol.SelectedIndex = -1;
								}
								else
								{
										MessageBox.Show("Error: No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtUsuario.Focus();
								}
						}
				}
		}
}