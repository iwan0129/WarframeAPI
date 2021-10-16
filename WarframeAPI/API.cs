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

        public static bool Read<T>(string jsonData, out T data)
        {
            try
            {
                JsonDocument jsonDocument = JsonDocument.Parse(jsonData);

                data = JsonSerializer.Deserialize<T>(jsonDocument.GetPropertyJson(typeof(T).Name, out string jsonPropertyData)
                    ? jsonPropertyData
                    : jsonDocument.RootElement.GetRawText(), JsonOptions);

                return true;
            }
            catch
            {
                data = default;

                return false;
            }
        }

        public static bool Read<T>(out T data, GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            try
            {
                using WebClient client = new();

                return Read(client.DownloadString($"{Url}/{gamePlatform}/{endPoint}"), out data);
            }
            catch
            {
                data = default;

                return false;
            }
        }
    }
}