using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Poee
    {
        public uint PedidoCod { get; set; }
        public string Pedidokey { get; set; } = null!;
        public int? Formaped { get; set; }
        public string? Cliente { get; set; }
        public string? Namecliente { get; set; }
        public string? Vendedor { get; set; }
        public string? Namevendedor { get; set; }
        public int? Vip { get; set; }
        public string? Operador { get; set; }
        public DateTime? Fechapedido { get; set; }
        public DateTime? Fechaenvio { get; set; }
        public string? Formapago { get; set; }
        public DateTime? FechaComienza { get; set; }
        public string? Estado { get; set; }
        public string? OperadorOficina { get; set; }
        public DateTime? FechaOficina { get; set; }
        public string? SitioReparto { get; set; }
        public int? Urgente { get; set; }
        public DateTime? FechaHoraurgente { get; set; }
        public int? SuperUrgente { get; set; }
        public DateTime? FechaSuperurgente { get; set; }
        public string? EstadoOficina { get; set; }
        public string? OperadorEscoger { get; set; }
        public DateTime? FechaEscoger { get; set; }
        public string? EstadoEscogerped { get; set; }
        public string? OperadorFinaliza { get; set; }
        public DateTime? FechaFinaliza { get; set; }
        public string? Navepre { get; set; }
        public string? Letrapre { get; set; }
        public string? Sitiopre { get; set; }
        public int? CantidadCarro { get; set; }
        public int? CantidadRecogePalet { get; set; }
        public int? CantidadRecogeBultos { get; set; }
        public string? CajeroInicia { get; set; }
        public DateTime? CafechaInicia { get; set; }
        public string? CajeroFinaliza { get; set; }
        public string? Navecom { get; set; }
        public string? Letracom { get; set; }
        public string? Sitiocom { get; set; }
        public int? CantidadcajaPalet { get; set; }
        public int? CantidadcajaBultos { get; set; }
        public int? CantidadcajaCarro { get; set; }
        public DateTime? CafechaFinaliza { get; set; }
        public string? EstadoEscoger { get; set; }
        public string? OperadorEmbalaje { get; set; }
        public DateTime? FechaEmbalaje { get; set; }
        public string? UbicacionEmbalaje { get; set; }
        public string? Embalajeter { get; set; }
        public DateTime? Embalajefeter { get; set; }
        public string? EstadoEmbalaje { get; set; }
        public int? EmbalajePeso { get; set; }
        public string? EmbalajePesob { get; set; }
        public string? EmbalajePesom { get; set; }
        public string? EmbalajePesop { get; set; }
        public string? Naveemba { get; set; }
        public string? Letraemba { get; set; }
        public string? Sitioemba { get; set; }
        public string? Dirubi { get; set; }
        public int? EstadoFacturacion { get; set; }
        public string? UsuarioAutorizafac { get; set; }
        public int? EstadoContabilizado { get; set; }
        public string? UsuarioAutorizaconta { get; set; }
        public int? IniciarFacturacion { get; set; }
        public int? FinalizarEtiquetado { get; set; }
        public int? Unido { get; set; }
        public string? Banco { get; set; }
        public int? AutorizaSalida { get; set; }
        public string? NomAutorizaSalida { get; set; }
        public string? OperadorTransporte { get; set; }
        public DateTime? FechaTransporte { get; set; }
        public string? Agencia { get; set; }
        public string? Transportista { get; set; }
        public int? CantidadBultos { get; set; }
        public int? CantidadMedio { get; set; }
        public int? CantidadPalet { get; set; }
        public string? TipoPalet { get; set; }
        public DateTime? Fechasalida { get; set; }
        public string? Matricula { get; set; }
        public string? Color { get; set; }
        public string? Color2 { get; set; }
        public string? Color3 { get; set; }
        public string? Color4 { get; set; }
        public string? Color5 { get; set; }
        public string? Nalbaran { get; set; }
        public string? Nfactura { get; set; }
        public int? Borrado { get; set; }
        public int? Devolucion { get; set; }
        public int? Logico { get; set; }
        public int? Liquidado { get; set; }
        public DateOnly? Fechapreparado { get; set; }
        public float? Importepedido { get; set; }
        public float? Importefactura { get; set; }
        public float? Cobrado { get; set; }
        public decimal? Jinez { get; set; }
        public int? Marcocomprobar { get; set; }
        public int? Dejapedi { get; set; }
        public int? Retenerpedido { get; set; }
        public DateOnly? Fechapreparado2 { get; set; }
        public string? Quienborro { get; set; }
        public string? Obsenviopedido { get; set; }
        public int? Naveagencia { get; set; }
        public DateTime? FechaEntregaExpe { get; set; }
        public string? Expedicion { get; set; }
        public string? Pagadologistica { get; set; }
        public int? Vuelta { get; set; }
        public int? Estadoweb { get; set; }
        public string? Comentario { get; set; }
        public string? NuevaUbicacion { get; set; }
        public int? MarcadoSalida { get; set; }
        public int? FormaPedido { get; set; }
        public DateTime? FechaLiquidado { get; set; }
        public DateTime? LiquiFechafactura { get; set; }
        public DateTime? LiquiFechaEnvio { get; set; }
        public string? LiquiNumeroFactura { get; set; }
        public float? LiquiImportefactura { get; set; }
        public int? LiquiDescuento { get; set; }
        public float? LiquiImporteConDes { get; set; }
        public float? LiquiDevolucion { get; set; }
        public float? LiquiImportependiente { get; set; }
        public float? LiquiImportecobrado { get; set; }
        public string? LiquiSituacionpago { get; set; }
        public string? LiquiObspago { get; set; }
        public int? LiquiComision { get; set; }
        public float? LiquiImporteComision { get; set; }
        public int? EstadoLiquidacion { get; set; }
        public int? EstadoReponer { get; set; }
        public int? Kmsalidaempresa { get; set; }
        public int? Kmllegadaempresa { get; set; }
        public string? Horasalidaempresa { get; set; }
        public string? Horallegadaempresa { get; set; }
        public string? Empresa { get; set; }
        public int? EmpezarCaja { get; set; }
        /// <summary>
        /// Sirve para saber lo que guardamos nosotros
        /// </summary>
        public int? Almacenar { get; set; }
    }
}
