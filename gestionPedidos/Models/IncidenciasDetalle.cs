using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class IncidenciasDetalle
    {
        public int Item { get; set; }
        public string? IncidenciaNumero { get; set; }
        public int? IdIncidencias { get; set; }
        public string? Articulo { get; set; }
        public string? Descripcion { get; set; }
        public int? Cantidad { get; set; }
    }
}
