using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;

namespace MCToken.WebApi
{
    public static class Serialization
    {
        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions {
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true,
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            // options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            options.Converters.Add(new DateTimeIsoConverter());

            return options;
        }

        public static void InitializeJsonSerializerOptions(JsonSerializerOptions options)
        {
            var needOptions = GetJsonSerializerOptions();
            options.IgnoreNullValues = needOptions.IgnoreNullValues;
            options.IgnoreReadOnlyProperties = needOptions.IgnoreReadOnlyProperties;
            options.WriteIndented = needOptions.WriteIndented;
            options.PropertyNamingPolicy = needOptions.PropertyNamingPolicy;
            options.Encoder = needOptions.Encoder;
            options.Converters.Clear();
            foreach (var converter in needOptions.Converters)
            {
                options.Converters.Add(converter);
            }
        }

        public static string SerializeUtf8(object obj)
        {
            var options = GetJsonSerializerOptions();
            var serializedObj = JsonSerializer.SerializeToUtf8Bytes(obj, options);
            return Encoding.UTF8.GetString(serializedObj);
        }

        public static T DeserializeUtf8<T>(string jsonObj)
        {
            if (string.IsNullOrWhiteSpace(jsonObj))
                return default;

            var options = GetJsonSerializerOptions();
            var serializedObj = new ReadOnlySpan<byte>(Encoding.UTF8.GetBytes(jsonObj));
            var obj = JsonSerializer.Deserialize<T>(serializedObj, options);
            return obj;
        }

        public static async Task<T> DeserializeUtf8Async<T>(string jsonObj, CancellationToken cancellationToken = default)
        {
            var options = GetJsonSerializerOptions();
            using (var memStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memStream, Encoding.UTF8))
                {
                    await streamWriter.WriteAsync(jsonObj);
                    await streamWriter.FlushAsync();
                    
                    memStream.Seek(0, SeekOrigin.Begin);
                    
                    var obj = await JsonSerializer.DeserializeAsync<T>(memStream, options, cancellationToken);
                    return obj;
                }
            }
        }
    }
}
