using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pedidosdetalle
    {
        public int Codigodetalle { get; set; }
        public string Pedidokey { get; set; } = null!;
        public string Pedidokey2 { get; set; } = null!;
        public int? Linea { get; set; }
        public string? Codigo { get; set; }
        public string? CodBarras { get; set; }
        public string? Ubicacion { get; set; }
        public int? Caja { get; set; }
        public int? Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public float? Descuento { get; set; }
        public string? CodCliente { get; set; }
        public int? Pedidocodigo { get; set; }
        public int? Borrado { get; set; }
        public float? Importe { get; set; }
    }
}
