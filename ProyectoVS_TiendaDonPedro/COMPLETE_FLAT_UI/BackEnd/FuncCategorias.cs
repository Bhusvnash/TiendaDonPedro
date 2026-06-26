using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.BackEnd.modelos;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Misc;

namespace COMPLETE_FLAT_UI.BackEnd
{
		internal class FuncCategorias
		{
				public static List<Categoria> GetCategorias()
				{
						try
						{
								var categorias = new List<Categoria>();
								using (MySqlConnection conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"SELECT * FROM tbl_categoria";
										using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
										{
												var reader = cmd.ExecuteReader();
												while (reader.Read())
												{
														categorias.Add(
																new Categoria(
																		Convert.ToInt64(reader["id_categoria"].ToString()),
																			reader["des_categoria"].ToString()
																)
														);
												}
												return categorias;
										}
								}
						}
						catch
						{
								return null;
						}
				}

				public static bool NewCategoria(string descripcion)
				{
						try
						{
								using (MySqlConnection conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"INSERT INTO tbl_categoria (des_categoria) VALUES (@des_categoria)";
										using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@des_categoria", descripcion);
												int response = cmd.ExecuteNonQuery();
												return response > 0;
										}
								}
						}
						catch
						{
								return false;
						}
				}

				public static bool UpdateCategoria(Categoria categoria)
				{
						try
						{
								using (MySqlConnection conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consulta = @"Update tbl_categoria set des_categoria = @des_categoria where id_categoria = @id_categoria";
										using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
										{
												cmd.Parameters.AddWithValue("@id_categoria", categoria.id_categoria);
												cmd.Parameters.AddWithValue("@des_categoria", categoria.des_categoria);
												int response = cmd.ExecuteNonQuery();
												return response > 0;
										}
								}
						}
						catch
						{
								return false;
						}
				}

				public static bool DeleteCategoria(Categoria categoria)
				{
						try
						{

								using(var conexion = new MySqlConnection(FuncLogin.cadenaConexion))
								{
										conexion.Open();
										string consula = @"Delete FROM tbl_categoria where id_categoria = @id";
										using(var cmd = new MySqlCommand(consula, conexion))
										{
												 cmd.Parameters.AddWithValue("@id", categoria.id_categoria);
												  int rows = cmd.ExecuteNonQuery();
												return rows > 0;
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