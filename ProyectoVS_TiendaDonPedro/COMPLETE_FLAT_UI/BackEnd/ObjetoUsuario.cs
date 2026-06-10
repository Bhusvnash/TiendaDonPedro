using System;

namespace COMPLETE_FLAT_UI
{
		internal class Usuario
		{
				public long id_usuario { get; private set; }
				public string alias_usuario { get; private set; }
				public string nombre_usuario { get; private set; }
				public string apellido_usuario { get; private set; }
				public string password_usuario { get; private set; }
				public string rol_usuario { get; private set; }

				public Usuario(int id, string alias, string nombre, string apellido, string password, string rol)
				{
						id_usuario = id;
						alias_usuario = alias;
						nombre_usuario = nombre;
						apellido_usuario = apellido;
						password_usuario = password;
						rol_usuario = rol;
				}
		}
}