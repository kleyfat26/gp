using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Ubicacion
    {
        public int CodUbicacion { get; set; }
        public int? Descripcion { get; set; }
        public string? DescripcionLarga { get; set; }
    }
}
