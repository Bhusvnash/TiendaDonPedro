using System;

namespace TiendaDonPedro.backend.modelos
{
    /// <summary>
    /// Modelo que representa la tabla tbl_facturaventa en la base de datos.
    /// </summary>
    public class Factura
    {
        /// <summary>
        /// Identificador único de la factura (PK, auto_increment).
        /// </summary>
        public long id_factura { get; set; }

        /// <summary>
        /// Fecha y hora en que se generó la factura.
        /// </summary>
        public DateTime? fecha_factura { get; set; }

        /// <summary>
        /// Identificador del cliente asociado a la factura (FK).
        /// </summary>
        public long? id_cliente { get; set; }

        /// <summary>
        /// Total monetario de la factura.
        /// </summary>
        public long? total_factura { get; set; }

        /// <summary>
        /// Estado actual de la factura (ej. "Pagada", "Pendiente", "Anulada").
        /// </summary>
        public string? estado_factura { get; set; }
    }
}
