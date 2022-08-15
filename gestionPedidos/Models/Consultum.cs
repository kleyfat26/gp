using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Consultum
    {
        public string? ClientId { get; set; }
        public string? ProductModel { get; set; }
        public float? ProductQuantity { get; set; }
    }
}
