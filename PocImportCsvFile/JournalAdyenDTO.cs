using Newtonsoft.Json;

namespace PocImportCsvFile
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class JournalAdyenDTO
    {
        [JsonProperty("Company Account")]
        public string CompanyAccount { get; set; }

        [JsonProperty("Merchant Account")]
        public string MerchantAccount { get; set; }

        [JsonProperty("Psp Reference")]
        public string PspReference { get; set; }

        [JsonProperty("Merchant Reference")]
        public string MerchantReference { get; set; }

        [JsonProperty("Payment Method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("Creation Date")]
        public DateTime CreationDate { get; set; }

        public string TimeZone { get; set; }

        public string Type { get; set; }

        [JsonProperty("Modification Reference")]
        public string ModificationReference { get; set; }

        [JsonProperty("Gross Currency")]
        public string GrossCurrency { get; set; }

        [JsonProperty("Gross Debit (GC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal GrossDebit { get; set; }

        [JsonProperty("Gross Credit (GC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal GrossCredit { get; set; }

        [JsonProperty("Exchange Rate")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal ExchangeRate { get; set; }

        [JsonProperty("Net Currency")]
        public string NetCurrency { get; set; }

        [JsonProperty("Net Debit (NC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal NetDebit { get; set; }

        [JsonProperty("Net Credit (NC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal NetCredit { get; set; }

        [JsonProperty("Commission (NC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal Commission { get; set; }

        [JsonProperty("Markup (NC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal Markup { get; set; }

        [JsonProperty("Scheme Fees (NC)")]
        public string SchemeFees { get; set; }

        [JsonProperty("Interchange (NC)")]
        [JsonConverter(typeof(ConverterToDecimalNullValue))]
        public decimal InterChange { get; set; }

        [JsonProperty("Payment Method Variant")]
        public string PaymentMethodVariant { get; set; }

        [JsonProperty("Batch Number")]
        public string BatchNumber { get; set; }

        public string Reserved4 { get; set; }
        public string Reserved5 { get; set; }
        public string Reserved6 { get; set; }
        public string Reserved7 { get; set; }
        public string Reserved8 { get; set; }
        public string Reserved9 { get; set; }
        public string Reserved10 { get; set; }

        [JsonProperty("Modification Merchant Reference")]
        public string ModificationMerchantReference { get; set; }

        public string Store { get; set; }

        public string MagType { get; set; }

        public string OrderType { get; set; }

        public string EstOrigine { get; set; }
    }
}