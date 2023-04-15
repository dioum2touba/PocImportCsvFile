using Newtonsoft.Json;
using System.Data;

namespace PocImportCsvFile
{
    public static class CsvToDataTable
    {
        public static DataTable ConvertCsvToDataTable(string filePath)
        {
            //reading all the lines(rows) from the file.
            string[] rows = File.ReadAllLines(filePath);

            DataTable dtData = new();
            dtData.GetColumnsFromCsv(rows);
            dtData.GetRowsFromCsv(rows);

            return dtData;
        }

        private static void GetColumnsFromCsv(this DataTable dtData, string[] rows)
        {
            //Creating columns
            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(new char[] { ';', '|', ',' }))
                    dtData.Columns.Add(columnName);
            }
        }

        private static void GetRowsFromCsv(this DataTable dtData, string[] rows)
        {
            //Creating row for each line.(except the first line, which contain column names)
            for (int row = 1; row < rows.Length; row++)
            {
                string[] rowValues = rows[row].Split(',');
                DataRow dr = dtData.NewRow();
                dr.ItemArray = rowValues;
                dtData.Rows.Add(dr);
            }
        }

        public static string DataTableToJSONWithJSONNet(DataTable table)
            => JsonConvert.SerializeObject(table);

        public static T GetObjectFromJsonString<T>(string json)
            => JsonConvert.DeserializeObject<T>(json);

        public static List<T>? GetListObjectFromJsonString<T>(string json)
            => JsonConvert.DeserializeObject<List<T>>(json);

        public static string GetJsonStringFromListObjects<T>(List<T> journalAdyens)
            => JsonConvert.SerializeObject(journalAdyens);

        public static List<JournalTransactionsAdyen> MapJournalAdyenDtoToJournalTransactionsAdyen(List<JournalAdyenDTO> journalAdyens)
            => journalAdyens.Select(journal =>
            {
                return new JournalTransactionsAdyen()
                {
                    JtaBatchNumber = journal.BatchNumber,
                    JtaCommission = journal.Commission,
                    JtaCompanyAccount = journal.CompanyAccount,
                    JtaCreationDate = journal.CreationDate,
                    JtaExchangeRate = journal.ExchangeRate,
                    JtaGrossCredit = journal.GrossCredit,
                    JtaGrossCurrency = journal.GrossCurrency,
                    JtaGrossDebit = journal.GrossDebit,
                    JtaEstOrigine = journal.EstOrigine,
                    JtaInterchange = journal.InterChange,
                    JtaMarkup = journal.Markup,
                    JtaMerchantAccount = journal.MerchantAccount,
                    JtaMerchantReference = journal.MerchantReference,
                    JtaModificationMerchantReference = journal.ModificationMerchantReference,
                    JtaModificationReference = journal.ModificationReference,
                    JtaNetCredit = journal.NetCredit,
                    JtaNetCurrency = journal.NetCurrency,
                    JtaNetDebit = journal.NetDebit,
                    JtaPaymentMethod = journal.PaymentMethod,
                    JtaPaymentMethodVariant = journal.PaymentMethodVariant,
                    JtaPspReference = journal.PspReference,
                    JtaReserved4 = journal.Reserved4,
                    JtaReserved5 = journal.Reserved5,
                    JtaReserved6 = journal.Reserved6,
                    JtaReserved7 = journal.Reserved7,
                    JtaReserved8 = journal.Reserved8,
                    JtaReserved9 = journal.Reserved9,
                    JtaReserved10 = journal.Reserved10,
                    JtaSchemeFees = journal.SchemeFees,
                    JtaStore = journal.Store,
                    JtaTimezone = journal.TimeZone,
                    JtaType = journal.Type
                };
            }).ToList();
    }
}