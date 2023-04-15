using Newtonsoft.Json;

namespace PocImportCsvFile
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class JournalTransactionsAdyen
    {
        [JsonProperty("jta_guid")]
        public string JtaGuid { get; set; }

        [JsonProperty("jta_bcd_guid")]
        public string JtaBcdGuid { get; set; }

        [JsonProperty("jta_company_account")]
        public string JtaCompanyAccount { get; set; }

        [JsonProperty("jta_merchant_account")]
        public string JtaMerchantAccount { get; set; }

        [JsonProperty("jta_psp_reference")]
        public string JtaPspReference { get; set; }

        [JsonProperty("jta_merchant_reference")]
        public string JtaMerchantReference { get; set; }

        [JsonProperty("jta_payment_method")]
        public string JtaPaymentMethod { get; set; }

        [JsonProperty("jta_creation_date")]
        public DateTime JtaCreationDate { get; set; } = DateTime.Now;

        [JsonProperty("jta_timezone")]
        public string JtaTimezone { get; set; }

        [JsonProperty("jta_type")]
        public string JtaType { get; set; }

        [JsonProperty("jta_modification_reference")]
        public string JtaModificationReference { get; set; }

        [JsonProperty("jta_gross_currency")]
        public string JtaGrossCurrency { get; set; }

        [JsonProperty("jta_gross_debit")]
        public decimal JtaGrossDebit { get; set; }

        [JsonProperty("jta_gross_credit")]
        public decimal JtaGrossCredit { get; set; }

        [JsonProperty("jta_exchange_rate")]
        public decimal JtaExchangeRate { get; set; }

        [JsonProperty("jta_net_currency")]
        public string JtaNetCurrency { get; set; }

        [JsonProperty("jta_net_debit")]
        public decimal JtaNetDebit { get; set; }

        [JsonProperty("jta_net_credit")]
        public decimal JtaNetCredit { get; set; }

        [JsonProperty("jta_commission")]
        public decimal JtaCommission { get; set; }

        [JsonProperty("jta_markup")]
        public decimal JtaMarkup { get; set; }

        [JsonProperty("jta_scheme_fees")]
        public string JtaSchemeFees { get; set; }

        [JsonProperty("jta_interchange")]
        public decimal JtaInterchange { get; set; }

        [JsonProperty("jta_payment_method_variant")]
        public string JtaPaymentMethodVariant { get; set; }

        [JsonProperty("jta_batch_number")]
        public string JtaBatchNumber { get; set; }

        [JsonProperty("jta_reserved4")]
        public string JtaReserved4 { get; set; }

        [JsonProperty("jta_reserved5")]
        public string JtaReserved5 { get; set; }

        [JsonProperty("jta_reserved6")]
        public string JtaReserved6 { get; set; }

        [JsonProperty("jta_reserved7")]
        public string JtaReserved7 { get; set; }

        [JsonProperty("jta_reserved8")]
        public string JtaReserved8 { get; set; }

        [JsonProperty("jta_reserved9")]
        public string JtaReserved9 { get; set; }

        [JsonProperty("jta_reserved10")]
        public string JtaReserved10 { get; set; }

        [JsonProperty("jta_modification_merchant_reference")]
        public string JtaModificationMerchantReference { get; set; }

        [JsonProperty("jta_store")]
        public string JtaStore { get; set; }

        [JsonProperty("jta_mag_type")]
        public string JtaMagType { get; set; }

        [JsonProperty("jta_order_type")]
        public string JtaOrderType { get; set; } = "1";

        [JsonProperty("jta_est_origine")]
        public string JtaEstOrigine { get; set; }

        [JsonProperty("jta_date_import")]
        public DateTime JtaDateImport { get; set; }
    }
}