// See https://aka.ms/new-console-template for more information
using PocImportCsvFile;
using System.Data;

Console.WriteLine("Hello, World!");

DataTable dtData = CsvToDataTable.ConvertCsvToDataTable(@"C:\\Users\\sdioum\\Downloads\\settlement_detail_report_batch_640_20230412.csv");

var jsonString = CsvToDataTable.DataTableToJSONWithJSONNet(dtData);

var journauxAdyen = CsvToDataTable.GetListObjectFromJsonString<JournalAdyenDTO>(jsonString);

var journalTransactionAdyen = CsvToDataTable.MapJournalAdyenDtoToJournalTransactionsAdyen(journauxAdyen);

var jsonStringToJournalTransactionAdyen = CsvToDataTable.GetJsonStringFromListObjects(journalTransactionAdyen);

var dataTableJournalTransactionAdyen = CsvToDataTable.GetObjectFromJsonString<DataTable>(jsonStringToJournalTransactionAdyen);

Console.WriteLine("Hello, World!");