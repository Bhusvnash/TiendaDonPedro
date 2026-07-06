using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
		public partial class FrmFacturaEnc : Form
		{
				//variables Globales
				private List<Producto> productos = FuncProductos.GetProductos();

				private List<DetalleFactura> carritoCompra = new List<DetalleFactura>();

				private Cliente CLIENTE = null;

				public FrmFacturaEnc()
				{
						InitializeComponent();

						CambiarEstadoBtns(false, false);
				}

				private void BtnSalir_Click(object sender, EventArgs e)
				{
						// Preguntar si desea dalir de la aplicacion
						DialogResult result = MessageBox.Show(
								"¿Desea Salir De La Aplicación?",
								"Confirmación",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question
						);
						if (result == DialogResult.Yes)
						{
								Application.Exit();
						}
				}

				private void TxtIdent_TextChanged(object sender, EventArgs e)
				{
				}

				private void TxtIdent_Validated(object sender, EventArgs e)
				{
						long id = Convert.ToInt64(TxtIdent.Text);
						CLIENTE = Func_Clientes.GetClientes(id).FirstOrDefault();
						//CLIENETE == NULL ERROR
						if (CLIENTE == null)
						{
								MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								CambiarEstadoBtns(false, false);
								return;
						}
						TxtNombreCliente.Text = CLIENTE.nombre_cliente;
				}

				private void BtnGuardar_Click(object sender, EventArgs e)
				{
						//Creamos factura
						double total = 0;
						if (!double.TryParse(TxtTotal.Text, out total))
						{
								MessageBox.Show("Error al guardar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
						} 
						Factura factura = new Factura
						(
								 0,
								 DateTime.Now,
								 CLIENTE.id_cliente,
								 total,
								"Pendiente"
						);
						// Watashi wa neko dayo o((>ω< ))o
						//se pregunta si continuar
						var continuar = MessageBox.Show("Desea Continuar Con El Pago ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.No == continuar)
						{
								return;
						}
						//se llama fun.Pagar y insert in Dian ( a futuro)

						//se inserta en la bd 
						//if (!FuncFactura.newFactura(factura))
						//		MessageBox.Show("Error al guardar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						//		return;
						

						factura.id_factura = FuncFactura.GetMAxId();
						foreach (var item in carritoCompra)
						{
								item.id_factura = factura.id_factura;
								if (!FuncFactura.newDetalleFactura(item))
								{
										
										MessageBox.Show($"No se pudo Guardar {item.nombre_producto}"
										 ,"Error",
										 MessageBoxButtons.OK,
										 MessageBoxIcon.Error
										);
										return;
								}
						}

						CambiarEstadoBtns(false);

				}

				private void BtnAddProd_Click(object sender, EventArgs e)
				{
						var productoSeleccionado = CbxProductos.SelectedItem?.ToString();

						if (string.IsNullOrWhiteSpace(productoSeleccionado))
						{
								MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
						}

						if (!long.TryParse(TxtCantidad.Text, out long cantidad) || cantidad <= 0)
						{
								MessageBox.Show("Debe ingresar una cantidad válida (número entero mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								TxtCantidad.Focus();
								return;
						}

						// LOS VALORES DE LA LISTA PRODUCTOS
						var producto = productos.FirstOrDefault(item => item.nombre_producto == productoSeleccionado);
						carritoCompra.Add(new DetalleFactura(
								id_detalle: 0,
								id_factura: FuncFactura.GetMAxId(),
								id_producto: producto.id_producto,
								nombre_producto: producto.nombre_producto,
								cantidad: cantidad,
								preciounit: producto.precio_producto,
								valoriva: producto.iva_producto
						));
						renderDgvDatalle();
						carcularTotales();
						//limpiamos los campos
						TxtCantidad.Text = "";
						TxtPrecioProducto.Text = "";
						CbxProductos.SelectedText = "";

						return;
				}

				private void BtnNuevo_Click(object sender, EventArgs e)
				{
						if (TxtIdent.Text == "")
						{
								MessageBox.Show("Debe ingresar un numero de identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
						}

						CambiarEstadoBtns(true);

						CbxProductos.Items.Clear();
						foreach (var item in productos)
						{
								CbxProductos.Items.Add(item.nombre_producto);
						}
				}

				private void TxtCantidad_Enter(object sender, EventArgs e)
				{
						string productoSeleccionado = CbxProductos.SelectedItem?.ToString();
						//
						TxtPrecioProducto.Text = productos.FirstOrDefault(item
						=> item.nombre_producto == productoSeleccionado)?.precio_producto.ToString();
				}

				public void carcularTotales()
				{
						double subTotal = 0;
						double iva = 0;
						double total = 0;
						// 1. Calculamos el subtotal (precio * cantidad de cada ítem)
						subTotal = carritoCompra.Sum(item => item.precioUnit * item.cantidad);
						iva = carritoCompra.Sum(item => (item.precioUnit * item.cantidad) * (item.valorIva / 100));
						total = subTotal + iva;
						TxtIVA.Text = iva.ToString();
						TxtSubTotal.Text = subTotal.ToString();
						TxtTotal.Text = total.ToString();
						return;
				}

				private void BtnCancelar_Click(object sender, EventArgs e)
				{
						CambiarEstadoBtns(false);
				}

				private void BtnDelProd_Click(object sender, EventArgs e)
				{
						// Obtenemos la fila actualmente seleccionada en el DataGridView y la convertimos a DetalleFactura.
						// DGVDetalle.CurrentRow  → la fila que el usuario tiene seleccionada en este momento.
						// ?.DataBoundItem        → el operador '?.' evita un NullReferenceException:
						//                          si CurrentRow es null (ninguna fila seleccionada),
						//                          la expresión completa devuelve null sin lanzar error.
						//                          DataBoundItem es el objeto original de la lista (carritoCompra)
						//                          que está vinculado a esa fila.
						// as DetalleFactura      → intenta convertir el objeto a DetalleFactura.
						//                          Si la conversión falla (tipo incorrecto), devuelve null en lugar de lanzar excepción.
						var detalleSeleccionado = DGVDetalle.CurrentRow?.DataBoundItem as DetalleFactura;
						var rpt = MessageBox.Show($"Desea Elminar {detalleSeleccionado.nombre_producto} de la factura ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.Yes == rpt)
						{
								carritoCompra.Remove(detalleSeleccionado);
								renderDgvDatalle();
								carcularTotales();
						}
				}

				private void renderDgvDatalle()
				{
						// Usamos BindingList para que el DataGridView genere las columnas correctamente
						var bindingList = new System.ComponentModel.BindingList<DetalleFactura>(carritoCompra);
						DGVDetalle.DataSource = bindingList;
						DGVDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						// Verificamos que las columnas existan antes de acceder a ellas
						if (DGVDetalle.Columns["id_detalle"] != null)
								DGVDetalle.Columns["id_detalle"].Visible = false;
						if (DGVDetalle.Columns["id_factura"] != null)
								DGVDetalle.Columns["id_factura"].Visible = false;
						if (DGVDetalle.Columns["id_producto"] != null)
								DGVDetalle.Columns["id_producto"].Visible = false;
						if (DGVDetalle.Columns["nombre_producto"] != null)
								DGVDetalle.Columns["nombre_producto"].HeaderText = "Producto";
						if (DGVDetalle.Columns["cantidad"] != null)
								DGVDetalle.Columns["cantidad"].HeaderText = "Cantidad";
						if (DGVDetalle.Columns["precioUnit"] != null)
								DGVDetalle.Columns["precioUnit"].HeaderText = "Precio Unitario";
						if (DGVDetalle.Columns["valorIva"] != null)
								DGVDetalle.Columns["valorIva"].HeaderText = "IVA %";
				}
				private void CambiarEstadoBtns(bool activo, bool limpiar = true)
				{
						//true edita false crear 
						// Habilitar/Deshabilitar según el estado activo
						TxtIdent.Enabled = !activo;
						TxtNombreCliente.Enabled = !activo;
						BtnSalir.Enabled = !activo;
						BtnNuevo.Enabled = !activo;

						BtnGuardar.Enabled = activo;
						BtnCancelar.Enabled = activo;
						BtnAddProd.Enabled = activo;
						BtnDelProd.Enabled = activo;

						// Limpiar datos si no está activo y se solicita limpiar
						if (!activo && limpiar)
						{
								if (carritoCompra != null) carritoCompra.Clear();
								else carritoCompra = new List<DetalleFactura>();
								
								CLIENTE = null;

								TxtIdent.Text = "";
								TxtNombreCliente.Text = "";
								TxtCantidad.Text = "";
								TxtPrecioProducto.Text = "";
								TxtSubTotal.Text = "";
								TxtIVA.Text = "";
								TxtTotal.Text = "";

								CbxProductos.Items.Clear();
								CbxProductos.SelectedIndex = -1;
								DGVDetalle.DataSource = null;
						}
				}
		}
}