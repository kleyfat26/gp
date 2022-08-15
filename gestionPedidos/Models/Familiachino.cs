using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Familiachino
    {
        public int Id { get; set; }
        public string MuluId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Py { get; set; } = null!;
        public int Px { get; set; }
        public string Beizhu { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Jinyong { get; set; }
    }
}
