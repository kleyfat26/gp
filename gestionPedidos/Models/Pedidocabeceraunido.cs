using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pedidocabeceraunido
    {
        public int Pedidocodigo { get; set; }
        public string? CodCliente { get; set; }
        public string? Namecliente { get; set; }
        public string? CodRepresentante { get; set; }
        public string? Representante { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Pedidokey { get; set; }
        public int? Enviado { get; set; }
        public string? Comentario { get; set; }
        public float? Total { get; set; }
        public int? Numero { get; set; }
        public int? Estado { get; set; }
        public int? Dejapedido { get; set; }
    }
}
