using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

public class DateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (var jsonDoc = JsonDocument.ParseValue(ref reader))
        {
            var stringValue = jsonDoc.RootElement.GetRawText().Trim('"').Trim('\'');
            var value = DateTime.Parse(stringValue, null, System.Globalization.DateTimeStyles.RoundtripKind);
            return value;
        }
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", System.Globalization.CultureInfo.InvariantCulture));
    }

}
