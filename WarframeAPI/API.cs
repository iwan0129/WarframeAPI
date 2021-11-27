using System;
using System.Net;
using System.Text.Json;
using WarframeAPI.Utilities;

namespace WarframeAPI
{
    public static class API
    {
        public const string Url = "https://api.warframestat.us";

        public static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static T Parse<T>(string json)
        {
            using JsonDocument jsonDocument = JsonDocument.Parse(json);

            Type type = typeof(T);

            string jsonData = (jsonDocument.RootElement.ValueKind switch
            {
                JsonValueKind.Array => jsonDocument.RootElement,
                _ => jsonDocument.GetPropertyJson(type.GetElementType()?.Name ?? type.Name) ?? jsonDocument.RootElement
            }).GetRawText();

            return JsonSerializer.Deserialize<T>(jsonData, JsonOptions);
        }

        public static T Read<T>(GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            using WebClient client = new();

            string json = client.DownloadString($"{Url}/{gamePlatform}/{endPoint}");

            return !string.IsNullOrEmpty(json)
                ? Parse<T>(json)
                : default;
        }

        public static bool TryRead<T>(out T data, GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            using WebClient client = new();

            string json = client.DownloadString($"{Url}/{gamePlatform}/{endPoint}");

            data = !string.IsNullOrEmpty(json)
                ? Parse<T>(json)
                : default;

            return !data.Equals(Nullable.GetUnderlyingType(typeof(T)) != null ? null : default);
        }
    }
}