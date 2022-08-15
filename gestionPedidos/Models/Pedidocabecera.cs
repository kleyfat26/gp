using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pedidocabecera
    {
        public int Pedidocodigo { get; set; }
        public string CodCliente { get; set; } = null!;
        public string? Namecliente { get; set; }
        public string? CodRepresentante { get; set; }
        public string? Representante { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public string? Pedidokey { get; set; }
        public int? Enviado { get; set; }
        public int? Unir { get; set; }
        public int? Borrado { get; set; }
        public string? Comentario { get; set; }
        public float? Total { get; set; }
        public string Pedidokey2 { get; set; } = null!;
        public int? Numero { get; set; }
        public int? Estado { get; set; }
    }
}
