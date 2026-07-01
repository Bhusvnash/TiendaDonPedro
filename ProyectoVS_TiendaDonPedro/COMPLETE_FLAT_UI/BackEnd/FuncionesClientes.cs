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
				public static List<Cliente> GetClientes(int id =0)
				{
						List<Cliente> clientes = new List<Cliente>();
						try
						{
								using (MySqlConnection conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = id == 0
												? "select * from  tbl_cliente limit 10"
												: "select * from tbl_cliente where id_cliente = @id";

										using (var sql = new MySqlCommand(consulta, conexion))
										{
												sql.Parameters.AddWithValue("@id", id);

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

				public static bool UpdateCliente(Cliente user)
				{
						try
						{
								using (var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"UPDATE tbl_cliente
                                SET nombre_cliente = @nombre,
                                    direccion_cliente = @direccion,
                                    email_cliente = @correo 
                                WHERE id_cliente = @id";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@id", user.id_cliente);
												cmd.Parameters.AddWithValue("@nombre", user.nombre_cliente);
												cmd.Parameters.AddWithValue("@direccion", user.direccion_cliente);
												cmd.Parameters.AddWithValue("@correo", user.email_cliente);

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

				public static bool DeleteCliente(Cliente client)
				{
						try
						{
								using (MySqlConnection cnn = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										cnn.Open();
										string consulta = @"Delete from  tbl_cliente where id_cliente = @id ";
										using (var sql = new MySqlCommand(consulta, cnn))
										{
												sql.Parameters.AddWithValue("@id", client.id_cliente);
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
