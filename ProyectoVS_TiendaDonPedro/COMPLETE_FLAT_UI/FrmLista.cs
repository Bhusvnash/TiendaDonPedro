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

								// Obtenemos el objeto Usuario vinculado a la fila seleccionada
								var usuarioSeleccionado = DGVDatos.CurrentRow?.DataBoundItem as Usuario;
								if (usuarioSeleccionado == null)
								{
										MessageBox.Show("Por favor seleccione un usuario para editar", "Selección de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								// Llenamos el formulario con las propiedades del objeto directamente
								FrmUsuarios f = new FrmUsuarios();
								f.TxtApellidos.Text = usuarioSeleccionado.apellido_usuario;
								f.TxtContraseña.Text = usuarioSeleccionado.password_usuario;
								f.TxtNombres.Text = usuarioSeleccionado.nombre_usuario;
								f.TxtUsuario.Text = usuarioSeleccionado.alias_usuario;
								f.CbxRol.Text = usuarioSeleccionado.rol_usuario;
								f.TxtIDUsuario.Text = usuarioSeleccionado.id_usuario.ToString();
								f.editando = true;
								f.ShowDialog();
								VerUsuarios();

								#endregion EditarUsuario
						}

						if (LblTitulo.Text == "Lista de Clientes")
						{
								// Obtenemos el objeto Cliente vinculado a la fila seleccionada
								var clienteSeleccionado = DGVDatos.CurrentRow?.DataBoundItem as Cliente;
								if (clienteSeleccionado == null)
								{
										MessageBox.Show("Por favor seleccione un cliente para editar", "Selección de Cliente",
												MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								FrmClientes f = new FrmClientes();
								f.TxtNombre.Text = clienteSeleccionado.nombre_cliente;
								f.TxtDireccion.Text = clienteSeleccionado.direccion_cliente;
								f.TxtCorreo.Text = clienteSeleccionado.email_cliente;
								f.id_cliente.Text = clienteSeleccionado.id_cliente.ToString();
								f.editando = true;
								f.ShowDialog();
								verClientes();
						}

						if (LblTitulo.Text == "Lista de Productos")
						{
								#region EditarProducto

								// Obtenemos el objeto Producto vinculado a la fila seleccionada
								var productoSeleccionado = DGVDatos.CurrentRow?.DataBoundItem as Producto;
								if (productoSeleccionado == null)
								{
										MessageBox.Show("Por favor seleccione un producto para editar", "Selección de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								FrmProductos formProducto = new FrmProductos();
								var categorias = FuncCategorias.GetCategorias();
								// any = existe elementos => true/false
								// el ? dice: aplicar lo siguiente solo si no es null
								if (categorias?.Any() == true || categorias != null)
								{
										var objCategoria = categorias.FirstOrDefault(item => item.id_categoria == productoSeleccionado.id_categoria);
										formProducto.CbxCategoria.SelectedValue = objCategoria?.des_categoria;
										foreach (var item in categorias)
												formProducto.CbxCategoria.Items.Add(item.des_categoria);
								}
								else
								{
										formProducto.CbxCategoria.Items.Add("N/A");
								}

								formProducto.TxtNombre.Text = productoSeleccionado.nombre_producto;
								formProducto.TxtPrecio.Text = productoSeleccionado.precio_producto.ToString();
								formProducto.TxtStock.Text = productoSeleccionado.stock_producto.ToString();
								formProducto.CbxCategoria.Text = productoSeleccionado.id_categoria.ToString();
								formProducto.TxtIVA.Text = productoSeleccionado.iva_producto.ToString();
								formProducto.editando = true;
								formProducto.ShowDialog();
								VerProductos();

								#endregion EditarProducto
						}

						if (LblTitulo.Text == "Lista de Categorias")
						{
								#region EditarCategorias

								// Obtenemos el objeto Categoria vinculado a la fila seleccionada
								var categoriaSeleccionada = DGVDatos.CurrentRow?.DataBoundItem as Categoria;
								if (categoriaSeleccionada == null)
								{
										MessageBox.Show("Por favor seleccione una categoría para editar", "Selección de Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}

								var fmCategorias = new FrmCategorias();
								fmCategorias.TxtDescripcion.Text = categoriaSeleccionada.des_categoria;
								fmCategorias.TxtIDCategoria.Text = categoriaSeleccionada.id_categoria.ToString();
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

										// Obtenemos el objeto Usuario vinculado a la fila seleccionada
										var user = DGVDatos.CurrentRow?.DataBoundItem as Usuario;
										if (user == null) break;

										try
										{
												var rpt = MessageBox.Show($"Desea eliminar a : {user.nombre_usuario} {user.apellido_usuario}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
												if (rpt != DialogResult.Yes) break;
												if (FuncUsuarios.DeleteUsuario(user))
														MessageBox.Show("El usuario ha sido eliminado", "Info",
														MessageBoxButtons.OK, MessageBoxIcon.Information);
												else
														MessageBox.Show("El usuario No se pudo eliminar", "ERROR",
														MessageBoxButtons.OK, MessageBoxIcon.Error);
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
										if (DGVDatos.CurrentRow == null)
										{
												MessageBox.Show("Seleccione un cliente para eliminar.", "Alerta",
														MessageBoxButtons.OK, MessageBoxIcon.Warning);
												return;
										}

										// Obtenemos el objeto Cliente vinculado a la fila seleccionada
										var client = DGVDatos.CurrentRow?.DataBoundItem as Cliente;
										if (client == null) break;

										try
										{
												var rpt = MessageBox.Show($"Desea eliminar a : {client.nombre_cliente}?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
												if (rpt != DialogResult.Yes) break;
												if (Func_Clientes.DeleteCliente(client))
														MessageBox.Show("El cliente ha sido eliminado", "Info",
														MessageBoxButtons.OK, MessageBoxIcon.Information);
												else
														MessageBox.Show("El cliente No se pudo eliminar", "ERROR",
														MessageBoxButtons.OK, MessageBoxIcon.Error);
												verClientes();
										}
										catch (Exception ex)
										{
												MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error",
												MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										break;

								case "Lista de Categorias":

										try
										{
												// Obtenemos el objeto Categoria vinculado a la fila seleccionada
												Categoria categoria = DGVDatos.CurrentRow?.DataBoundItem as Categoria;
												if (categoria == null) break;
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

								case "Lista de Productos":
										try { } catch { }
										VerProductos();
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
						DGVDatos.DataSource = Func_Clientes.GetClientes(0);
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