using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Clientevip
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public string? Usuario { get; set; }
        public int? Valor { get; set; }
    }
}
