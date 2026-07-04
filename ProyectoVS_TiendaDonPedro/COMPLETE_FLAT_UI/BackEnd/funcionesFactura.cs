using COMPLETE_FLAT_UI.BackEnd.modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BackEnd
{
		internal class funcionesFactura
		{
				public static bool newFactura(Factura factura)
				{
						//conexion

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
		}
}