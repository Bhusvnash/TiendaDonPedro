using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
		public class DetalleFactura
		{
				public long id_detalle { get; set; }
				public long? id_factura { get; set; }
				public long id_producto { get; set; }
				public string nombre_producto { get; set; }
				public long cantidad { get; set; }
				public long precioUnit { get; set; }
				public double valorIva { get; set; }

				public DetalleFactura(
						long id_detalle,
						long id_factura,
						long id_producto,
						string nombre_producto,
						long cantidad,
						long preciounit,
						double valoriva
				)
				{
						this.id_detalle = id_detalle;
						this.id_factura = id_factura;
						this.id_producto = id_producto;
						this.nombre_producto = nombre_producto;
						this.cantidad = cantidad;
						this.precioUnit = preciounit;
						this.valorIva = valoriva;
				}
		}
}