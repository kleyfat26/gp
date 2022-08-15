using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Contadorpedido
    {
        public int Id { get; set; }
        public string? Pedidokey { get; set; }
        public int? Estado { get; set; }
    }
}
