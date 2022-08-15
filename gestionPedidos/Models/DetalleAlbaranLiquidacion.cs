using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class DetalleAlbaranLiquidacion
    {
        public int IdFacturapago { get; set; }
        public string? Pedidokey { get; set; }
        public string? Cliente { get; set; }
        public string? NroFactura { get; set; }
        public float? Importe { get; set; }
        public float? Descuento { get; set; }
        public float? ImporteConDes { get; set; }
        public float? ImporteCobrado { get; set; }
        public float? ImportePendiente { get; set; }
        public string? SituacionPago { get; set; }
        public int? EstadoLiqui { get; set; }
        public string? Vendedor { get; set; }
        public string? Obsalbaran { get; set; }
        public int? Comision { get; set; }
        public float? ImporteComision { get; set; }
    }
}
