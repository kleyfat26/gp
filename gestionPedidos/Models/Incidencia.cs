using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Incidencia
    {
        public int IdIncidencias { get; set; }
        public DateTime? FechaIncidencia { get; set; }
        public string? DescriIncidencia { get; set; }
        public string? ClienteIncidencia { get; set; }
        public string? CodCliente { get; set; }
        public string? Empresa { get; set; }
        public string? ComercialIncidencia { get; set; }
        public DateTime? FecharesueltoInci { get; set; }
        public string? UsuarioIncidencia { get; set; }
        public string? UsuariofinIncidencia { get; set; }
        public string? EstadoIncidencia { get; set; }
        public string? TipoIncidencia { get; set; }
        public string? FaltaMercancia { get; set; }
        public string? Firmorecibo { get; set; }
        public string? ErrorEnvio { get; set; }
        public string? ErrorEnviocliente { get; set; }
        public string? Devolucion { get; set; }
        public string? Reclamacion { get; set; }
        public string? RetrasoEntrega { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public int? Numero { get; set; }
        public string? IncidenciaNumero { get; set; }
    }
}
