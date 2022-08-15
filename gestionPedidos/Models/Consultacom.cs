using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Consultacom
    {
        public string? DocumentId { get; set; }
        public string? ItemId { get; set; }
        public string? ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? DocumentDate { get; set; }
        public string? MoneyRateId { get; set; }
        public string? HandlerId { get; set; }
        public string? HandlerName { get; set; }
        public string? StoreId { get; set; }
        public string? StoreName { get; set; }
        public string? DocumentKindId { get; set; }
        public string? DocumentKindName { get; set; }
        public string? ClientConsignee { get; set; }
        public string? ClientAddress { get; set; }
        public string? CityName { get; set; }
        public string? ProvinceName { get; set; }
        public string? ClientPostal { get; set; }
        public string? CountryName { get; set; }
        public string? DocumentRemark { get; set; }
        public string? ClientDocumentId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductModel { get; set; }
        public string? ProductMark { get; set; }
        public string? SequenceNumber { get; set; }
        public string? ProductBarcode { get; set; }
        public string? ClientModel { get; set; }
        public string? ProviderModel { get; set; }
        public string? ProductBatch { get; set; }
        public string? ProductDescription { get; set; }
        public string? LocalDescription { get; set; }
        public string? SpecDescription { get; set; }
        public string? ProductUnit { get; set; }
        public string? ProductColor { get; set; }
        public string? ProductSize { get; set; }
        public string? MaterialDescription { get; set; }
        public string? TechnicRequest { get; set; }
        public string? PackRequest { get; set; }
        public string? ProductBrand { get; set; }
        public string? ProduceArea { get; set; }
        public string? ProcessProcedure { get; set; }
        public string? ProcessUnit { get; set; }
        public string? ProcessKind { get; set; }
        public string? BoxNumber { get; set; }
        public string? MiddleQuantity { get; set; }
        public string? UnitQuantity { get; set; }
        public string? PackQuantity { get; set; }
        public int? ProductQuantity { get; set; }
        public string? UnitPrice { get; set; }
        public string? DiscountPercent { get; set; }
        public string? TaxRate { get; set; }
        public string? PackVolume { get; set; }
        public string? NetWeight { get; set; }
        public string? GrossWeight { get; set; }
        public string? ProductKindId { get; set; }
        public string? ProductKindName { get; set; }
        public string? DeliverTimestamp { get; set; }
        public string? ItemRemark { get; set; }
    }
}
