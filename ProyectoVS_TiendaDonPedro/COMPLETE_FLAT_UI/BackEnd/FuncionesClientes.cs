using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace COMPLETE_FLAT_UI.BackEnd
{
		internal class Func_Clientes
		{
				public static List<Cliente> GetClientes()
				{
						List<Cliente> clientes = new List<Cliente>();
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = "select * from  tbl_cliente limit 10";
										var cmd = new MySqlCommand(consulta, conexion);
										var lector = cmd.ExecuteReader();

										while (lector.Read())
										{
												clientes.Add(new Cliente(Convert.ToInt64(lector["id_cliente"]),
														lector["nombre_cliente"].ToString(),
														lector["direccion_cliente"].ToString(),
														lector["email_cliente"].ToString()));
										}  
										return clientes;
								}
						}
						catch
						{
								return null;
						}
				}

				public static bool NewCliente(Cliente user)
				{
						using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
						{
								try
								{
										conexion.Open();

										string consulta = @"
										 INSERT INTO tbl_cliente
										(nombre_cliente, direccion_cliente, email_cliente)
										VALUES
										(@NombreCliente, @DireccionCliente, @EmailCliente)";

										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@NombreCliente", user.nombre_cliente);
												cmd.Parameters.AddWithValue("@DireccionCliente", user.direccion_cliente);
												cmd.Parameters.AddWithValue("@EmailCliente", user.email_cliente);
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
		}
}
