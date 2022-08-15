using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Cliente
    {
        public string? ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? ClientTitle { get; set; }
        public string? ClientGender { get; set; }
        public string? RelationKindId { get; set; }
        public string? RelationKindName { get; set; }
        public string? GroupKindId { get; set; }
        public string? GroupKindName { get; set; }
        public string? IndustryKindId { get; set; }
        public string? IndustryKindName { get; set; }
        public string? ScaleKindId { get; set; }
        public string? ScaleKindName { get; set; }
        public string? SourceKindId { get; set; }
        public string? SourceKindName { get; set; }
        public string? ValidGrade { get; set; }
        public string? EnterpriseStatus { get; set; }
        public string? HandlerId { get; set; }
        public string? HandlerName { get; set; }
        public string? ClientUsername { get; set; }
        public string? ClientPasswd { get; set; }
        public string? ClientConsignee { get; set; }
        public string? ClientAddress { get; set; }
        public string? CityName { get; set; }
        public string? ProvinceName { get; set; }
        public string? ClientPostal { get; set; }
        public string? CountryName { get; set; }
        public string? ContactPersonId { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ClientMobile1 { get; set; }
        public string? ClientMobile2 { get; set; }
        public string? ClientTel { get; set; }
        public string? ClientFax { get; set; }
        public string? ClientWeb { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientWechat { get; set; }
        public string? ClientQq { get; set; }
        public string? TaxNumber { get; set; }
        public string? IdCard { get; set; }
        public string? ClientRecipient { get; set; }
        public string? ClientPec { get; set; }
        public string? BankName { get; set; }
        public string? AccountName { get; set; }
        public string? BankAccount { get; set; }
        public string? TaxStatus { get; set; }
        public string? SurchargeStatus { get; set; }
        public string? TaxRateId { get; set; }
        public string? MoneyRateId { get; set; }
        public string? PaymentKindId { get; set; }
        public string? PaymentLimit { get; set; }
        public string? ClientCredit { get; set; }
        public string? OriginalReceivable { get; set; }
        public string? OriginalPayable { get; set; }
        public string? ClientRemark { get; set; }
        public int? Processed { get; set; }
        public int Id { get; set; }
    }
}
