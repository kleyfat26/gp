using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Salidamadrid
    {
        public int Id { get; set; }
        public string? Pedidokey { get; set; }
        public string? Cliente { get; set; }
        public string? Namecliente { get; set; }
        public string? Vendedor { get; set; }
        public string? Direccion { get; set; }
        public string? Cp { get; set; }
        public string? Tel { get; set; }
        public string? Poblacion { get; set; }
        public string? Diasalida { get; set; }
        public string? Turno { get; set; }
        public decimal? Importe { get; set; }
        public int? Estadosalida { get; set; }
        public string? Comentario { get; set; }
        public DateOnly? FechaSalida { get; set; }
        public int? ListadoSalida { get; set; }
        public int? CantidadBulto { get; set; }
        public int? CantidadMedio { get; set; }
        public int? CantidadPalet { get; set; }
        public decimal? ImporteFactura { get; set; }
        public string? NroFactura { get; set; }
        public string? Bultos { get; set; }
        public string? Conductor { get; set; }
        public string? Autoriza { get; set; }
        public string? Matricula { get; set; }
        public int? Kmsalidaempresa { get; set; }
        public int? Kmllegadaempresa { get; set; }
        public string? Horasalidaempresa { get; set; }
        public string? Horallegadaempresa { get; set; }
    }
}
