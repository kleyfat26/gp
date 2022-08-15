using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Liquidacione
    {
        public uint Idliqui { get; set; }
        public string? Pedidokey { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int? NumeroFactura { get; set; }
        public string? CodCliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? CodVendedor { get; set; }
        public string? Vendedor { get; set; }
        public string? Agencia { get; set; }
        public string? Telefono { get; set; }
        public string? TipoEnvio { get; set; }
        public string? Direccion { get; set; }
        public string? Cp { get; set; }
        public string? Provincia { get; set; }
        public float? ImportePedido { get; set; }
        public float? ImporteFactura { get; set; }
        public int? Descuento { get; set; }
        public float? ImporteConDescuento { get; set; }
        public float? Devolucion { get; set; }
        public float? ImportePendiente { get; set; }
        public float? ImporteCobrado { get; set; }
        public string? SituacionPago { get; set; }
        public string? Obs { get; set; }
        public int? Comision { get; set; }
        public float? ImporteComision { get; set; }
        public int? Palet { get; set; }
        public int? Mediopalet { get; set; }
        public int? Bultos { get; set; }
        public int? EstadoLiquidacion { get; set; }
    }
}
