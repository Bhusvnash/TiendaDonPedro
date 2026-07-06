using COMPLETE_FLAT_UI.BackEnd.modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
		internal class FuncFactura
		{

				public static bool newDetalleFactura(DetalleFactura detalle)
				{
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"Insert Into tbl_detallefactura
										 (id_factura, id_producto, nombre_producto, cantidad, precioUnit, valorIva)
										 values  (@id_factura, @id_producto, @nombre_producto, @cantidad, @precioUnit, @valorIva)";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@id_factura", detalle.id_factura);
												cmd.Parameters.AddWithValue("@id_producto", detalle.id_producto);
												cmd.Parameters.AddWithValue("@nombre_producto", detalle.nombre_producto);
												cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
												cmd.Parameters.AddWithValue("@precioUnit", detalle.precioUnit);
												cmd.Parameters.AddWithValue("@valorIva", detalle.valorIva);
												var a = cmd.ExecuteNonQuery();
												return true;
										}
								}
						}
						catch
						{
								return false;
						}
				}
				public static bool newFactura(Factura factura)
				{
						

						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"Insert Into tbl_facturaventa
									   (fecha_factura, id_cliente, total_factura, estado_factura)
									   values  (@fecha, @id_cliente, @total, @estado)";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@fecha", factura.fecha_factura);
												cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
												cmd.Parameters.AddWithValue("@total", factura.total_factura);
												cmd.Parameters.AddWithValue("@estado", factura.estado_factura);
												var a = cmd.ExecuteNonQuery();
												return true;
										}
								}
						}
						catch
						{
								return false;
						}
				}

				public static long GetMAxId()
				{
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"SELECT MAX(id_factura) FROM tbl_facturaventa";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												var result = cmd.ExecuteScalar();
												if (result != DBNull.Value)
												{
														return Convert.ToInt64(result);
												}
												else
												{
														return 1; // No hay registros en la tabla
												}
										}
								}
						}
						catch (Exception ex)
						{
								Console.WriteLine("Error al obtener el máximo ID de factura: " + ex.Message);
								return 0; // En caso de error, se devuelve 0
						}
				}
		}
}