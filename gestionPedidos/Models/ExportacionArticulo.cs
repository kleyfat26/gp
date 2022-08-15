using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class ExportacionArticulo
    {
        public string? Referencia { get; set; }
        public string? Codigbarra { get; set; }
        public string? Estado { get; set; }
        public int? Longitud { get; set; }
        public string? Ean { get; set; }
    }
}
