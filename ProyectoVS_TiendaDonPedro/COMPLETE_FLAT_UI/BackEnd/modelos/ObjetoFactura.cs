using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
		internal  class Factura
		{
				// id_factura | fecha_factura | id_cliente | total_factura | estado_factura
			public	long id_factura { get; set; }
				public DateTime fecha_factura { get; set; }
				public long id_cliente { get; set; }
				public double total_factura { get; set; }
				public string estado_factura { get; set; }
				//constructor
				public Factura(long id_factura, DateTime fecha_factura, long id_cliente, double total_factura, string estado_factura)
				{
						this.id_factura = id_factura;
						this.fecha_factura = fecha_factura;
						this.id_cliente = id_cliente;
						this.total_factura = total_factura;
						this.estado_factura = estado_factura;
				}

		}
}
