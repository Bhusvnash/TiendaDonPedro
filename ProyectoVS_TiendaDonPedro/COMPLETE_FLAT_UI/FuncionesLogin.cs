using COMPLETE_FLAT_UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace COMPLETE_FLAT_UI
{
		internal class ClassUsuario
		{
				private static string cadenaConexion = "Server=127.0.0.1;Port=3306;Database=tienda_don_pedro;Uid=root;Pwd=;";

				public static Usuario Sesion;

				public static List<Usuario> Fuc_TraerUsuarios(string alias)
				{
						var usuarios = new List<Usuario>();
						try
						{
								using (var conexion = new MySqlConnection(cadenaConexion))
								{
										conexion.Open();
										var consulta = alias == null
											? "SELECT * FROM tbl_usuario"
											: "SELECT * FROM tbl_usuario WHERE alias_usuario = @alias";

										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												if (alias != null)
												{
														cmd.Parameters.AddWithValue("@alias", alias);
												}
												using (var lector = cmd.ExecuteReader())
												{
														while (lector.Read())
														{
																var usuario = new Usuario(
																		Convert.ToInt64(lector["id_usuario"]),
																		lector["alias_usuario"].ToString(),
																		lector["nombre_usuario"].ToString(),
																		lector["apellido_usuario"].ToString(),
																		lector["password_usuario"].ToString(),
																		lector["rol_usuario"].ToString());
																usuarios.Add(usuario);
														}
												}
										}
								}
						}
						catch (Exception ex)
						{
								Console.WriteLine("Error al traer usuarios: " + ex.Message);
						}
						Sesion = usuarios.Count > 0 ? usuarios[0] : null;
						return usuarios;
				}

				public static bool ComprovarPassword(string password)
				{
						if (Sesion != null)
						{
								return Sesion.password_usuario == password;
						}
						return false;
				}
		}
}