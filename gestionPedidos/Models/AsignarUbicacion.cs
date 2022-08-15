using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class AsignarUbicacion
    {
        public int CodAsignar { get; set; }
        public int? CodNave { get; set; }
        public int? CodPasillo { get; set; }
        public int? CodEstanteria { get; set; }
        public int? CodUbicacion { get; set; }
        public int? Activo { get; set; }
        public int? Ocupado { get; set; }
        public string? Pedido { get; set; }
        public string? Matricula { get; set; }
        public string? Cliente { get; set; }
    }
}
