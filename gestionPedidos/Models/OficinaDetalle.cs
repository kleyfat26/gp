using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class OficinaDetalle
    {
        public uint Id { get; set; }
        public string Pedidokey { get; set; } = null!;
        public int Linea { get; set; }
        public string CodArticulo { get; set; } = null!;
        public string? CodBarras { get; set; }
        public string? Ubicacion { get; set; }
        public int Caja { get; set; }
        public int Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public float? Descuento { get; set; }
        public float Importe { get; set; }
    }
}
