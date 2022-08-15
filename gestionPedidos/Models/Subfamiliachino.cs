using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Subfamiliachino
    {
        public int Id { get; set; }
        public string MuluId { get; set; } = null!;
        public string SubMuluId { get; set; } = null!;
        public string? Name { get; set; }
        public int Px { get; set; }
        public int Jinyong { get; set; }
    }
}
