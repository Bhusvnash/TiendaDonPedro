using COMPLETE_FLAT_UI.BackEnd;
using COMPLETE_FLAT_UI.BackEnd.modelos;
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
using System.Runtime.InteropServices;
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
						if (LblTitulo.Text == "Lista de Usuarios")
						{
								#region EditarUsuario

								try
								{
										//instancia del fromulario usuarios
										FrmUsuarios f = new FrmUsuarios();
										//llenamos los txt con la info del usuario que se quiere editar
										f.TxtApellidos.Text = DGVDatos.CurrentRow.Cells["APELLIDO_USUARIO"].Value.ToString();
										f.TxtContraseña.Text = DGVDatos.CurrentRow.Cells["PASSWORD_USUARIO"].Value.ToString();
										f.TxtNombres.Text = DGVDatos.CurrentRow.Cells["NOMBRE_USUARIO"].Value.ToString();
										f.TxtUsuario.Text = DGVDatos.CurrentRow.Cells["ALIAS_USUARIO"].Value.ToString();
										f.CbxRol.Text = DGVDatos.CurrentRow.Cells["ROL_USUARIO"].Value.ToString();
										f.TxtIDUsuario.Text = DGVDatos.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
										f.editando = true;
										f.ShowDialog();
								}
								catch
								{
										MessageBox.Show("Por favor seleccione un usuario para editar", "Selección de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								VerUsuarios();

								#endregion EditarUsuario
						}

						if (LblTitulo.Text == "Lista de Clientes")
						{
								try
								{
										FrmClientes f = new FrmClientes();

										f.TxtNombre.Text = DGVDatos.CurrentRow.Cells["nombre_cliente"].Value.ToString();
										f.TxtDireccion.Text = DGVDatos.CurrentRow.Cells["direccion_cliente"].Value.ToString();
										f.TxtCorreo.Text = DGVDatos.CurrentRow.Cells["email_cliente"].Value.ToString();
										f.editando = true;
										f.ShowDialog();
										verClientes();
								}
								catch
								{
										MessageBox.Show("Por favor seleccione un cliente para editar", "Selección de Cliente",
												MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
						}

						if (LblTitulo.Text == "Lista de Productos")
						{
								#region EditarProducto

								try
								{
										FrmProductos formProducto = new FrmProductos();
										//id_categoria
										long idCategoria = Convert.ToInt64(DGVDatos.CurrentRow.Cells["id_categoria"].Value.ToString());
										var categorias = FuncCategorias.GetCategorias();
										//any = existe elementos => true/false
										// el ? dice : aplicar lo lo siguiente solo si no es null

										if (categorias?.Any() == true || categorias != null)
										{
												var objCategoria = categorias.FirstOrDefault(item => item.id_categoria == idCategoria);
												formProducto.CbxCategoria.SelectedValue = objCategoria.des_categoria;
												foreach (var item in categorias)
												{
														formProducto.CbxCategoria.Items.Add(item);
												}
										}
										else
										{
												formProducto.CbxCategoria.Items.Add("N/A");
										}
										formProducto.TxtNombre.Text = DGVDatos.CurrentRow.Cells["nombre_producto"].Value.ToString();
										formProducto.TxtPrecio.Text = DGVDatos.CurrentRow.Cells["precio_producto"].Value.ToString();
										formProducto.TxtStock.Text = DGVDatos.CurrentRow.Cells["stock_producto"].Value.ToString();
										formProducto.CbxCategoria.Text = DGVDatos.CurrentRow.Cells["id_categoria"].Value.ToString();
										formProducto.TxtIVA.Text = DGVDatos.CurrentRow.Cells["iva_producto"].Value.ToString();
										formProducto.editando = true;
										formProducto.ShowDialog();
										VerProductos();
								}
								catch
								{
										MessageBox.Show("Por favor seleccione un producto para editar", "Selección de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								#endregion EditarProducto
						}

						if (LblTitulo.Text == "Lista de Categorias")
						{
								#region EditarCategorias

								var fmCategorias = new FrmCategorias();
								fmCategorias.TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["des_categoria"].Value.ToString();
								fmCategorias.TxtIDCategoria.Text = DGVDatos.CurrentRow.Cells["id_categoria"].Value.ToString();
								fmCategorias.editando = true;
								fmCategorias.ShowDialog();
								VerCategorias();

								#endregion EditarCategorias
						}
						DGVDatos.Focus();
				}

				private void btnNuevo_Click(object sender, EventArgs e)
				{
						if (LblTitulo.Text == "Lista de Usuarios")
						{
								FrmUsuarios formUsuarios = new FrmUsuarios();
								formUsuarios.ShowDialog();
								VerUsuarios();
						}
						if (LblTitulo.Text == "Lista de Clientes")
						{
								FrmClientes f = new FrmClientes();
								f.ShowDialog();
								verClientes();
						}
						if (LblTitulo.Text == "Lista de Productos")
						{
								var formProductos = new FrmProductos();
								//llenamos el ComboBox con categorias
								var categorias = FuncProductos.TemGetCategorias();
								//any = existe elementos => true/false
								// el ? dice : aplicar lo lo siguiente solo si no es null
								if (categorias?.Any() == true)
										formProductos.CbxCategoria.Items.AddRange(categorias.ToArray());
								else
										formProductos.CbxCategoria.Items.Add("N/A");
								formProductos.ShowDialog();
								VerProductos();
						}
						if (LblTitulo.Text == "Lista de Categorias")
						{
								var fmCategoria = new FrmCategorias();
								fmCategoria.editando = false;
								fmCategoria.ShowDialog();
								VerCategorias();
						}
						//linea necesaria para evitar errores por perdida de focus
						DGVDatos.Focus();
				}

				private void BtnEliminar_Click(object sender, EventArgs e)
				{
						switch (LblTitulo.Text)
						{
								case "Lista de Usuarios":

										#region EliminarUsuario

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
												VerUsuarios();
										}
										catch (Exception ex)
										{
												MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error",
												MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										break;

										#endregion EliminarUsuario

								case "Lista de Clientes":
										verClientes();
										break;

								case "Lista de Categorias":

										try
										{
												//objeto de lo que este selecionando el usuario
												Categoria categoria = new Categoria(
												Convert.ToInt64(DGVDatos.CurrentRow.Cells["id_categoria"].Value),
												Convert.ToString(DGVDatos.CurrentRow.Cells["des_categoria"].Value));
												//preguntamos si quiere continuar con esos datos
												DialogResult rpt = new DialogResult();
												rpt = MessageBox.Show($"Desea Eliminar La Categoria: {categoria.des_categoria}?", "ELIMINAR",
														MessageBoxButtons.YesNo, MessageBoxIcon.Question);

												if (rpt == DialogResult.Yes)
												{
														if (FuncCategorias.DeleteCategoria(categoria))
																MessageBox.Show("La categoria ha sido eliminada", "Info",
																MessageBoxButtons.OK, MessageBoxIcon.Information);
														else
																MessageBox.Show("La categoria No se pudo eliminar", "ERROR",
																MessageBoxButtons.OK, MessageBoxIcon.Error);
												}
												else
												{
														MessageBox.Show("Operacion Cancelada", "Cancelada", MessageBoxButtons.OK,
																MessageBoxIcon.Information);
												}
										}
										catch
										{
												MessageBox.Show("Error al elminiar la categoria", "Error",
														MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										VerCategorias();
										break;
								default:
										break;
						}

						DGVDatos.Focus();
				}

				public void VerUsuarios()
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

				public void VerProductos()
				{
						DGVDatos.Columns.Clear();
						DGVDatos.DataSource = FuncProductos.GetProductos();
						DGVDatos.ReadOnly = true;
						// Ocultar columnas
						DGVDatos.Columns["id_producto"].Visible = false;
						DGVDatos.Columns["id_categoria"].Visible = false;
						// Cambiar títulos
						DGVDatos.Columns["nombre_producto"].HeaderText = "Producto";
						DGVDatos.Columns["precio_producto"].HeaderText = "Precio";
						DGVDatos.Columns["stock_producto"].HeaderText = "Stock";
						DGVDatos.Columns["iva_producto"].HeaderText = "IVA";
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

				public void VerCategorias()
				{
						var categorias = FuncCategorias.GetCategorias();
						DGVDatos.DataSource = categorias;
						DGVDatos.Columns["id_categoria"].Visible = false;
						DGVDatos.Columns["des_categoria"].HeaderText = "Categoria";
				}
		}
}