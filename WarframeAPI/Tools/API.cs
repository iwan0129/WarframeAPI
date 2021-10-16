using System;
using System.IO;
using System.Net;
using System.Text.Json;
using WarframeAPI.Utilities;

namespace WarframeAPI.Data
{
    public static class API
    {
        public const string Url = "https://api.warframestat.us";

        public static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static bool ReadData<T>(out T data, GamePlatform gamePlatform = GamePlatform.Pc)
        {
            try
            {
                using WebClient client = new();

                JsonDocument jsonDocument = JsonDocument.Parse(client.DownloadString($"{Url}/{gamePlatform}"));

                data = JsonSerializer.Deserialize<T>(jsonDocument.GetPropertyJson(typeof(T).Name, out string jsonData)
                    ? jsonData
                    : jsonDocument.RootElement.GetRawText(), JsonOptions);

                return true;
            }
            catch
            {
                data = default;

                return false;
            }
        }

        public static bool ReadData<T>(string jsonPath, out T data)
        {
            try
            {
                using FileStream fstream = new(jsonPath, FileMode.Open, FileAccess.Read);

                byte[] bytes = new byte[fstream.Length];

                if (fstream.Read(bytes, 0, bytes.Length) < bytes.Length)
                {
                    throw new Exception("Unable to read full data");
                }

                JsonDocument jsonDocument = JsonDocument.Parse(bytes);

                data = JsonSerializer.Deserialize<T>(jsonDocument.GetPropertyJson(typeof(T).Name, out string jsonData)
                    ? jsonData
                    : jsonDocument.RootElement.GetRawText(), JsonOptions);

                return true;
            }
            catch
            {
                data = default;

                return false;
            }
        }
    }
}