using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pedidodetalleunido
    {
        public int Id { get; set; }
        public string? Pedidokey { get; set; }
        public int? Linea { get; set; }
        public string? CodArticulo { get; set; }
        public string? CodBarras { get; set; }
        public string? Ubicacion { get; set; }
        public int? Caja { get; set; }
        public int? Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public float? Descuento { get; set; }
        public float? Importe { get; set; }
    }
}
