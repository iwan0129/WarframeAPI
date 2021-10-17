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

        public static T Read<T>(string json)
        {
            try
            {
                JsonDocument jsonDocument = JsonDocument.Parse(json);

                var jsonData = jsonDocument.GetPropertyJson(typeof(T).Name) ?? jsonDocument.RootElement.GetRawText();

                return JsonSerializer.Deserialize<T>(jsonData, JsonOptions);
            }
            catch
            {
                return default;
            }
        }

        public static T Read<T>(GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            try
            {
                using WebClient client = new();

                return Read<T>(client.DownloadString($"{Url}/{gamePlatform}/{endPoint}"));
            }
            catch
            {
                return default;
            }
        }

        public static bool TryRead<T>(string json, out T data)
        {
            try
            {
                JsonDocument jsonDocument = JsonDocument.Parse(json);

                var jsonData = jsonDocument.GetPropertyJson(typeof(T).Name) ?? jsonDocument.RootElement.GetRawText();

                data = JsonSerializer.Deserialize<T>(jsonData, JsonOptions);

                return true;
            }
            catch
            {
                data = default;

                return false;
            }
        }

        public static bool TryRead<T>(out T data, GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            try
            {
                using WebClient client = new();

                return TryRead(client.DownloadString($"{Url}/{gamePlatform}/{endPoint}"), out data);
            }
            catch
            {
                data = default;

                return false;
            }
        }
    }
}