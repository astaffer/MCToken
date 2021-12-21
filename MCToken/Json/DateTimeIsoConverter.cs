using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MCToken.WebApi
{
    public class DateTimeIsoConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(typeToConvert == typeof(DateTime))
                return DateTime.Parse(reader.GetString());

            return DateTime.MinValue;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var isoDate = value.ToString("o", CultureInfo.InvariantCulture);
            writer.WriteStringValue(isoDate);
        }
    }
}
