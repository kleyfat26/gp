using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pasillo
    {
        public int CodPasillo { get; set; }
        public string? DescripcionCorta { get; set; }
        public string? DescripcionLarga { get; set; }
    }
}
