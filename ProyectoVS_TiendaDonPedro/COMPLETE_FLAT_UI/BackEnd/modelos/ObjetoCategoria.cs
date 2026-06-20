using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BackEnd.modelos
{
		internal class Categoria
		{
				public long id_categoria { get; set; }
				public string des_categoria { get; set; }
		
				public Categoria (long id_categoria, string des_categoria)
				{
						this.id_categoria = id_categoria;
						this.des_categoria = des_categoria;
				}
		}
}
