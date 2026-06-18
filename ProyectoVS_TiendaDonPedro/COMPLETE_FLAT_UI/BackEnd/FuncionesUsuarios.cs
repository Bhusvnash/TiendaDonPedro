using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace COMPLETE_FLAT_UI.BackEnd
{
		internal class FuncUsuarios
		{
				public static List<Usuario> GetUsuarios()
				{
						List<Usuario> usuarios = new List<Usuario>();
						try
						{
								using (var conexion = new MySqlConnection(Func_Login.cadenaConexion))
								{
										conexion.Open();
										string consulta = "select * from  tbl_usuario limit 10";
										var cmd = new MySqlCommand(consulta, conexion);
										var lector = cmd.ExecuteReader();

										while (lector.Read())
										{
												usuarios.Add(new Usuario(Convert.ToInt64(lector["id_usuario"]),
														lector["alias_usuario"].ToString(),
														lector["nombre_usuario"].ToString(),
														lector["apellido_usuario"].ToString(),
														lector["password_usuario"].ToString(),
														lector["rol_usuario"].ToString()));
										}
										return usuarios;
								}
						}
						catch
						{
								return null;
						}
				}

				public static bool NewUsuario(Usuario user)
				{
						using (var conexion = new MySqlConnection(Func_Login.cadenaConexion))
						{
								try
								{
										conexion.Open();

										string consulta = @"
										 INSERT INTO tbl_usuario
										(alias_usuario, nombre_usuario, apellido_usuario, password_usuario, rol_usuario)
										VALUES
										(@AliasUsuario, @NombreUsuario, @ApellidoUsuario, @PasswordUsuario, @RolUsuario)";

										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@AliasUsuario", user.alias_usuario);
												cmd.Parameters.AddWithValue("@NombreUsuario", user.nombre_usuario);
												cmd.Parameters.AddWithValue("@ApellidoUsuario", user.apellido_usuario);
												cmd.Parameters.AddWithValue("@PasswordUsuario", user.password_usuario);
												cmd.Parameters.AddWithValue("@RolUsuario", user.rol_usuario);
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

				public static bool UpdateUsuario(Usuario user)
				{
						try
						{
								using (var conexion = new MySqlConnection(Func_Login.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"UPDATE tbl_usuario
                                SET alias_usuario = @alias,
                                    nombre_usuario = @nombre,
                                    apellido_usuario = @apellido,
                                    password_usuario = @pass,
                                    rol_usuario = @rol
                                WHERE id_usuario = @id";
										using (var cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@id", user.id_usuario);
												cmd.Parameters.AddWithValue("@alias", user.alias_usuario);
												cmd.Parameters.AddWithValue("@nombre", user.nombre_usuario);
												cmd.Parameters.AddWithValue("@apellido", user.apellido_usuario);
												cmd.Parameters.AddWithValue("@pass", user.password_usuario);
												cmd.Parameters.AddWithValue("@rol", user.rol_usuario);

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

				public static bool DeleteUsuario(Usuario user)
				{
						try
						{
								using (MySqlConnection cnn = new MySqlConnection(Func_Login.cadenaConexion))
								{
										cnn.Open();
										string consulta = @"Delete from  tbl_usuario where id_usuario = @id ";
										using (var sql = new MySqlCommand(consulta, cnn))
										{
												sql.Parameters.AddWithValue("@id", user.id_usuario);
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