using Newtonsoft.Json;
using System.Data;
using System.Reflection;

namespace PocImportCsvFile
{
    public static class ImportCsvFileHelper
    {
        public static DataTable ConvertCsvToDataTable(string filePath)
        {
            //reading all the lines(rows) from the file.
            string[] rows = File.ReadAllLines(filePath);

            DataTable dtData = new DataTable();
            dtData.GetColumnsFromCsv(rows);
            dtData.GetRowsFromCsv(rows);

            return dtData;
        }

        private static void GetColumnsFromCsv(this DataTable dtData, string[] rows)
        {
            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(new char[] { ';', '|', ',' }))
                    dtData.Columns.Add(columnName);
            }
        }

        private static void GetRowsFromCsv(this DataTable dtData, string[] rows)
        {
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

        public static DataTable ConvertListToDataTable<T>(List<T> list)
        {
            DataTable dataTable = new DataTable();
            PropertyInfo[] propertyInfos = typeof(T).GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                dataTable.Columns.Add(propertyInfo.Name, propertyInfo.PropertyType);
            }

            foreach (T item in list)
            {
                DataRow dataRow = dataTable.NewRow();

                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    dataRow[propertyInfo.Name] = propertyInfo.GetValue(item, null);
                }

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        public static List<T> GetListObjectFromJsonString<T>(string json)
            => JsonConvert.DeserializeObject<List<T>>(json);

        public static string GetJsonStringFromListObjects<T>(List<T> journalAdyens)
            => JsonConvert.SerializeObject(journalAdyens);
    }
}