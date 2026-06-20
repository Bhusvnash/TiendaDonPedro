namespace COMPLETE_FLAT_UI
{
		internal class Producto
		{
				public long id_producto { get; set; }
				public string nombre_producto { get; set; }
				public long precio_producto { get; set; }
				public int stock_producto { get; set; }
				public double iva_producto { get; set; }

				public long id_categoria { get; set; }

				public Producto(
			long id_producto,

			string nombre_producto,
			long precio_producto,
			int stock_producto,
			double iva_producto,
			long id_categoria)
				{
						this.id_producto = id_producto;
						this.nombre_producto = nombre_producto;
						this.precio_producto = precio_producto;
						this.stock_producto = stock_producto;
						this.iva_producto = iva_producto;
						this.id_categoria = id_categoria;
				}
		}
}