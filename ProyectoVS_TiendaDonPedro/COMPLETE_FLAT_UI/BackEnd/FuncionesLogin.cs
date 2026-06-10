using COMPLETE_FLAT_UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace COMPLETE_FLAT_UI
{
		internal class Func_Login
		{
				private static string cadenaConexion = "Server=127.0.0.1;Port=3306;Database=tienda_don_pedro;Uid=root;Pwd=;";

				/*
				 Variable global para comunicar los forms y saber el roll
				 */
				public static Usuario Sesion;

				public static Usuario InicialSesion(string alias)
				{
						try
						{
								using (var conexion = new MySqlConnection(cadenaConexion))
								{
										conexion.Open();
										var consulta = "SELECT * FROM tbl_usuario WHERE alias_usuario = @alias";

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
																Sesion = new Usuario(
																		 Convert.ToInt64(lector["id_usuario"]),
																		 lector["alias_usuario"].ToString(),
																		 lector["nombre_usuario"].ToString(),
																		 lector["apellido_usuario"].ToString(),
																		 lector["password_usuario"].ToString(),
																		 lector["rol_usuario"].ToString());
																return Sesion;
														}
												}
										}
								}
						}
						catch (Exception ex)
						{
								Console.WriteLine("Error al traer usuarios: " + ex.Message);
						}
						return null;
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