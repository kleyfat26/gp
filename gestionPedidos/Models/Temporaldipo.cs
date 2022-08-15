using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Temporaldipo
    {
        public string? ProductReference { get; set; }
        public string? Barcode { get; set; }
        public string? Feature { get; set; }
        public int? Quantity { get; set; }
        public int? Unit { get; set; }
        public float? Price { get; set; }
    }
}
