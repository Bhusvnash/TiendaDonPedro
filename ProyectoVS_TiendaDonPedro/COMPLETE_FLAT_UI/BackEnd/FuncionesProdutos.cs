using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace COMPLETE_FLAT_UI
{
		internal class FuncionesProdutos
		{
				public static List<Producto> GetProductos()
				{
						List<Producto> productos = new List<Producto>();
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = "SELECT * FROM tbl_producto";
										var cmd = new MySqlCommand(consulta, conexion);
										var lector = cmd.ExecuteReader();

										while (lector.Read())
										{
												productos.Add(new Producto(
														Convert.ToInt64(lector["id_producto"]),
														lector["nombre_producto"].ToString(),
														Convert.ToInt64(lector["precio_producto"]),
														Convert.ToInt32(lector["stock_producto"]),
														Convert.ToDouble(lector["iva_producto"]),
														Convert.ToInt64(lector["id_categoria"])
												));
										}
										return productos;
								}
						}
						catch
						{
								return null;
						}
				}

				public static bool NewProducto(Producto producto)
				{
						using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
						{
								try
								{
										conexion.Open();

										string consulta = @"
										 INSERT INTO tbl_producto
										(nombre_producto, precio_producto, stock_producto, iva_producto, id_categoria)
										VALUES
										(@Nombre, @Precio, @Stock, @Iva, @IdCategoria)";

										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@Nombre", producto.nombre_producto);
												cmd.Parameters.AddWithValue("@Precio", producto.precio_producto);
												cmd.Parameters.AddWithValue("@Stock", producto.stock_producto);
												cmd.Parameters.AddWithValue("@Iva", producto.iva_producto);
												cmd.Parameters.AddWithValue("@IdCategoria", producto.id_categoria);
												int response = cmd.ExecuteNonQuery();
												return response > 0;
										}
								}
								catch
								{
										return false;
								}
						}
				}

				public static bool UpdateProducto(Producto producto)
				{
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"UPDATE tbl_producto
                                SET nombre_producto = @Nombre,
                                    precio_producto = @Precio,
                                    stock_producto = @Stock,
                                    iva_producto = @Iva,
                                    id_categoria = @IdCategoria
                                WHERE id_producto = @Id";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@Id", producto.id_producto);
												cmd.Parameters.AddWithValue("@Nombre", producto.nombre_producto);
												cmd.Parameters.AddWithValue("@Precio", producto.precio_producto);
												cmd.Parameters.AddWithValue("@Stock", producto.stock_producto);
												cmd.Parameters.AddWithValue("@Iva", producto.iva_producto);
												cmd.Parameters.AddWithValue("@IdCategoria", producto.id_categoria);

												int rpt = cmd.ExecuteNonQuery();
												return rpt > 0;
										}
								}
						}
						catch
						{
								return false;
						}
				}

				public static bool DeleteProducto(Producto producto)
				{
						try
						{
								using (MySqlConnection cnn = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										cnn.Open();
										string consulta = @"DELETE FROM tbl_producto WHERE id_producto = @Id";
										using (var sql = new MySqlCommand(consulta, cnn))
										{
												sql.Parameters.AddWithValue("@Id", producto.id_producto);
												return 0 < sql.ExecuteNonQuery();
										}
								}
						}
						catch
						{
								return false;
						}
				}
		}
}
