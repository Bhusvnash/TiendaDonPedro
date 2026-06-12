using COMPLETE_FLAT_UI.BackEnd;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
		public partial class FrmLista : Form
		{
				public FrmLista()
				{
						InitializeComponent();
						//permisos segun rol 
				}

				private void btnCerrar_Click(object sender, EventArgs e)
				{
						this.Close();
				}

				private void BtnCerrar_Click_1(object sender, EventArgs e)
				{
						this.Close();
				}

				private void btnEditar_Click(object sender, EventArgs e)
				{
						DGVDatos.Focus();
						if (LblTitulo.Text == "Lista de Usuarios")
						{
								Usuario user=null;
								try
								{
										user = new Usuario(Convert.ToInt64(DGVDatos.CurrentRow.Cells["ID_USUARIO"].Value),
												DGVDatos.CurrentRow.Cells["ALIAS_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["NOMBRE_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["APELLIDO_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["PASSWORD_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["ROL_USUARIO"].Value.ToString());
												FrmUsuarios f = new FrmUsuarios();
												f.TxtApellidos.Text = user.apellido_usuario;
												f.TxtContraseña.Text = user.password_usuario;
												f.TxtNombres.Text = user.nombre_usuario;
												f.TxtUsuario.Text = user.alias_usuario;
												f.CbxRol.Text = user.rol_usuario;
												f.TxtIDUsuario.Text = user.id_usuario.ToString();
												f.ShowDialog();
								}
								catch
								{
										MessageBox.Show("Por favor seleccione un usuario para editar", "Selección de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
						}
				}

				private void btnNuevo_Click(object sender, EventArgs e)
				{
						if (LblTitulo.Text == "Lista de Usuarios")
						{
								FrmUsuarios f = new FrmUsuarios();
								f.ShowDialog();
								verUsuarios();
						}
				}
				public void verUsuarios()
				{

					// DGVDatos.Rows.Clear();
						DGVDatos.Columns.Clear();
						DGVDatos.DataSource = FuncUsuarios.GetUsuarios();
						DGVDatos.ReadOnly = true;
						DGVDatos.Columns["id_usuario"].Visible = false;
						DGVDatos.Columns["password_usuario"].Visible = false;
						DGVDatos.Columns["alias_usuario"].HeaderText = "Alias";
						DGVDatos.Columns["nombre_usuario"].HeaderText = "Nombre";
						DGVDatos.Columns["apellido_usuario"].HeaderText = "Apellido";
						DGVDatos.Columns["rol_usuario"].HeaderText = "Rol";
						DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
		}
}