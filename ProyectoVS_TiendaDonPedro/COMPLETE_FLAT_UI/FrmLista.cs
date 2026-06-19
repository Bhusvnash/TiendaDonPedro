using COMPLETE_FLAT_UI.BackEnd;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace COMPLETE_FLAT_UI
{
		public partial class FrmLista : Form
		{
				public FrmLista()
				{
						InitializeComponent();
						//permisos segun rol
						if (FuncLogin.Sesion.rol_usuario != "Admin")
						{
								btnEditar.Enabled = false;
								btnNuevo.Enabled = false;
								BtnEliminar.Enabled = false;
								btnEditar.Enabled = false;
						}


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
								Usuario user = null;
								try
								{
										//llenamos el obejo con lo que tenga selecionado el usuario
										user = new Usuario(Convert.ToInt64(DGVDatos.CurrentRow.Cells["ID_USUARIO"].Value),
												DGVDatos.CurrentRow.Cells["ALIAS_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["NOMBRE_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["APELLIDO_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["PASSWORD_USUARIO"].Value.ToString(),
												DGVDatos.CurrentRow.Cells["ROL_USUARIO"].Value.ToString());
										//instancia del fromulario usuarios
										FrmUsuarios f = new FrmUsuarios();
										//llenamos los txt con la info del usuario que se quiere editar
										f.TxtApellidos.Text = user.apellido_usuario;
										f.TxtContraseña.Text = user.password_usuario;
										f.TxtNombres.Text = user.nombre_usuario;
										f.TxtUsuario.Text = user.alias_usuario;
										f.CbxRol.Text = user.rol_usuario;
										f.TxtIDUsuario.Text = user.id_usuario.ToString();


										f.editando = true;
										f.ShowDialog();

										FrmClientes a = new FrmClientes();
										a.editando = true;
								}
								catch
								{
										MessageBox.Show("Por favor seleccione un usuario para editar", "Selección de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								verUsuarios();
						}
						else if (LblTitulo.Text == "Lista de Clientes")
						{
								FrmClientes f = new FrmClientes();
								f.editando = true;

								f.TxtNombre.Text = DGVDatos.CurrentRow.Cells["nombre_cliente"].Value.ToString();
								f.TxtDireccion.Text = DGVDatos.CurrentRow.Cells["direccion_cliente"].Value.ToString();
								f.TxtCorreo.Text = DGVDatos.CurrentRow.Cells["email_cliente"].Value.ToString();

								MessageBox.Show("Por favor seleccione un usuario para editar", "Selección de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
						if (LblTitulo.Text == "Lista de Clientes")
						{
								FrmClientes f = new FrmClientes();
								f.ShowDialog();
								verClientes();
						}
				}

				private void BtnEliminar_Click(object sender, EventArgs e)
				{
						switch (LblTitulo.Text)
						{
								case "Lista de Usuarios":
										// Validar que hay una fila seleccionada
										if (DGVDatos.CurrentRow == null)
										{
												MessageBox.Show("Seleccione un usuario para eliminar.", "Alerta",
														MessageBoxButtons.OK, MessageBoxIcon.Warning);
												return;
										}

										try
										{
												var user = new Usuario(Convert.ToInt64(DGVDatos.CurrentRow.Cells["ID_USUARIO"].Value),
																								Convert.ToString(DGVDatos.CurrentRow.Cells["alias_usuario"].Value),
																								Convert.ToString(DGVDatos.CurrentRow.Cells["nombre_usuario"].Value),
																								Convert.ToString(DGVDatos.CurrentRow.Cells["apellido_usuario"].Value),
																								null,
																								Convert.ToString(DGVDatos.CurrentRow.Cells["rol_usuario"].Value));
												var rpt = MessageBox.Show($"Desea eliminar ha : {user.nombre_usuario} {user.apellido_usuario}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
												if (rpt != DialogResult.Yes) break;
												if (FuncUsuarios.DeleteUsuario(user))
														MessageBox.Show("El usuario ha sido eliminado", "Info",
														MessageBoxButtons.OK, MessageBoxIcon.Information);
												else
														MessageBox.Show("El usuario No se pudo eliminar", "ERROR",
														MessageBoxButtons.OK, MessageBoxIcon.Error);
												//
												verUsuarios();
										}
										catch (Exception ex)
										{
												MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error",
												MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										break;
								case "Lista de Clientes":
										verClientes();
										break;

								default:
										break;
						}

						DGVDatos.Focus();
				}

				public void verUsuarios()
				{
						//limpiamos el Datas Grid View
						//DGVDatos.Rows.Clear();
						DGVDatos.Columns.Clear();
						DGVDatos.DataSource = FuncUsuarios.GetUsuarios();
						DGVDatos.ReadOnly = true;
						DGVDatos.Columns["id_usuario"].Visible = false;
						DGVDatos.Columns["password_usuario"].Visible = false;
						DGVDatos.Columns["alias_usuario"].HeaderText = "Alias";
						DGVDatos.Columns["nombre_usuario"].HeaderText = "Nombre";
						DGVDatos.Columns["apellido_usuario"].HeaderText = "Apellido";
						DGVDatos.Columns["rol_usuario"].HeaderText = "Rol";
				}

				public void verClientes()
				{
						//limpiamos el Datas Grid View
						//DGVDatos.Rows.Clear();
						DGVDatos.Columns.Clear();
						DGVDatos.DataSource = Func_Clientes.GetClientes();
						DGVDatos.ReadOnly = true;
						DGVDatos.Columns["id_cliente"].Visible = false;
						DGVDatos.Columns["nombre_cliente"].HeaderText = "Nombre";
						DGVDatos.Columns["direccion_cliente"].HeaderText = "Direccion";
						DGVDatos.Columns["email_cliente"].HeaderText = "Email";
				}
		}
}