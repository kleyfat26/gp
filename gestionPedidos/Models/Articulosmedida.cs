using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Articulosmedida
    {
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public int? Largo { get; set; }
        public int? Alto { get; set; }
        public int? Ancho { get; set; }
    }
}
