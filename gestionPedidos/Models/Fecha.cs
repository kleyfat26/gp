using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Fecha
    {
        public string? Pedidokey { get; set; }
        public string? Cliente { get; set; }
        public string? Namecliente { get; set; }
        public string? Vendedor { get; set; }
        public string? Namevendedor { get; set; }
        public DateTime? Fechaenvio { get; set; }
        public float? Jinez { get; set; }
    }
}
