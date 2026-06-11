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
		internal class Func_Usuarios
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
		}
}