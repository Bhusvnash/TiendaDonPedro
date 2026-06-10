using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace COMPLETE_FLAT_UI.BackEnd.modelos
{
		internal class ClassUsuario
		{
				public static readonly string cadenaConexion = "Server=localhost;Port=3306;Database=Tienda_Don_pedro;Uid=root;Pwd= ;Charset=utf8;SslMode=None;";

				public static Usuario Func_traerUsuario(string alias)
				{
						try
						{
								using (var conexion = new MySqlConnection(cadenaConexion))
								{
										conexion.Open();
										string consulta = @"SELECT * FROM tbl_usuario WHERE alias_ususario";
										return null;
								}
						}
						catch
						{
								return null;
						}
				}

				/*

				 using System;
using MySql.Data.MySqlClient;
using COMPLETE_FLAT_UI;

namespace COMPLETE_FLAT_UI.BackEnd.modelos
{
    internal class ClassUsuario
    {
        public static readonly string cadenaConexion = "Server=localhost;Port=3306;Database=mi_base_de_datos;Uid=mi_usuario;Pwd=mi_contraseña;Charset=utf8;SslMode=None;";

        public static Usuario Func_traerUsuario(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias))
                return null;

            try
            {
                using (var conn = new MySqlConnection(cadenaConexion))
                {
                    conn.Open();

                    const string sql = @"
                        SELECT id_usuario, alias_usuario, nombre_usuario, apellido_usuario, password_usuario, rol_usuario
                        FROM usuarios
                        WHERE alias_usuario = @alias
                        LIMIT 1;
                    ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@alias", alias);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                long id = Convert.ToInt64(reader["id_usuario"]);
                                string aliasDb = reader["alias_usuario"]?.ToString();
                                string nombre = reader["nombre_usuario"]?.ToString();
                                string apellido = reader["apellido_usuario"]?.ToString();
                                string password = reader["password_usuario"]?.ToString();
                                string rol = reader["rol_usuario"]?.ToString();

                                return new Usuario(id, aliasDb, nombre, apellido, password, rol);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Sustituye por tu mecanismo de logging (no dejar en producción Console.WriteLine)
                Console.WriteLine("Error al traer usuario: " + ex.Message);
            }

            return null;
        }
    }
}

				 */
		}
}