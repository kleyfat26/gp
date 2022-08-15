using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Atencioncliente1
    {
        public int IdAtencion { get; set; }
        public string? Pedidokey { get; set; }
        public int? LlamadaCliente { get; set; }
        public int? EnvioMensaje { get; set; }
        public int? EnvioWechat { get; set; }
        public int? Avisocomercial { get; set; }
        public int? EnvioCorreo { get; set; }
        public string? Obs { get; set; }
        public int? EstadoAtencion { get; set; }
        public DateTime? FechaLlamada { get; set; }
        public string? Formapago { get; set; }
        public string? Banco { get; set; }
        public string? Usuario { get; set; }
        public int? AutorizaSalida { get; set; }
        public int? Clienteconfirmado { get; set; }
        public string? Codcliente { get; set; }
        public string? Codvendedor { get; set; }
        public string NoFactura { get; set; } = null!;
    }
}
