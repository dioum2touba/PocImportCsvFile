using Newtonsoft.Json;

namespace PocImportCsvFile
{
    public class ConverterToDecimalNullValue : JsonConverter<decimal>
    {
        public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var result = reader.Value;
            return decimal.TryParse(result.ToString(), out decimal converted) ? converted : 0m;
        }

        public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }
}