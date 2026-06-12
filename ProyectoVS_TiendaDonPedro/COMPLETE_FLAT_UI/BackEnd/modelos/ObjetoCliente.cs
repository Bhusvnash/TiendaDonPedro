using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
		internal class Cliente
		{
				public long id_cliente { get; private set; }
				public string nombre_cliente { get; private set; }
				public string direccion_cliente { get; private set; }
				public string email_cliente { get; private set; }

				public Cliente(long id, string nombre, string direccion, string email)
				{
						id_cliente = id;
						nombre_cliente = nombre;
						direccion_cliente = direccion;
						email_cliente = email;
				}
		}
}
