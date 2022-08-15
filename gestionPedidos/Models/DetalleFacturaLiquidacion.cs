using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class DetalleFacturaLiquidacion
    {
        public int IdFacturapago { get; set; }
        public string? Pedidokey { get; set; }
        public string? Cliente { get; set; }
        public string? Namecliente { get; set; }
        public string? NroFactura { get; set; }
        public float? Importe { get; set; }
        public float? Descuento { get; set; }
        public float? ImporteConDes { get; set; }
        public float? ImporteCobrado { get; set; }
        public float? ImportePendiente { get; set; }
        public string? SituacionPago { get; set; }
        public int? EstadoLiqui { get; set; }
        public string? Vendedor { get; set; }
        public int? Comision { get; set; }
        public float? ImporteComision { get; set; }
        public int? EstadoAceptado { get; set; }
        public string? LiquiOsbpago { get; set; }
        public string? UsuarioAutorizaconta { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? FinalizadoParcial { get; set; }
        public int? EstadoEtiquetado { get; set; }
        public int? EstadoEnviado { get; set; }
        public int? Color { get; set; }
        public int? DejarPedido { get; set; }
        public string? Conductor { get; set; }
        public string? Matricula { get; set; }
        public int? Kmsalidaempresa { get; set; }
        public int? Kmllegadaempresa { get; set; }
        public string? Horasalidaempresa { get; set; }
        public string? Horallegadaempresa { get; set; }
    }
}
