using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
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

        /// <summary>
        /// Parse json data to data type
        /// </summary>
        /// <typeparam name="T">The data type the json will be parsed to.</typeparam>
        /// <param name="json">The json data that will be parsed.</param>
        /// <returns>Parsed json to the data type if successful otherwise default value of the type.</returns>
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

        /// <summary>
        /// Read data type from the API.
        /// </summary>
        /// <typeparam name="T">The data type to be read.</typeparam>
        /// <param name="gamePlatform">The platfrom from which the data will be read.</param>
        /// <param name="endPoint">The endpoint from which the data will be read.</param>
        /// <returns>Parsed json to the data type if successful otherwise default value of the type.</returns>
        public static T Read<T>(GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            using WebClient client = new();

            string json = client.DownloadString($"{Url}/{gamePlatform}/{endPoint}");

            return !string.IsNullOrEmpty(json) ? Parse<T>(json) : default;
        }

        /// <summary>
        /// Read data type from the API async.
        /// </summary>
        /// <typeparam name="T">The data type to be read.</typeparam>
        /// <param name="gamePlatform">The platfrom from which the data will be read.</param>
        /// <param name="endPoint">The endpoint from which the data will be read.</param>
        /// <returns>Parsed json to the data type if successful otherwise default value of the type.</returns>
        public static async Task<T> ReadAsync<T>(GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            using WebClient client = new();

            string json = await client.DownloadStringTaskAsync($"{Url}/{gamePlatform}/{endPoint}");

            return !string.IsNullOrEmpty(json) ? Parse<T>(json) : default;
        }

        /// <summary>
        /// Try to read data type from the API
        /// </summary>
        /// <typeparam name="T">The data type to be read.</typeparam>
        /// <param name="data">The data type that the json will be parsed to. If the json isn't successfuly parsed then the default value of the type is set instead.</param>
        /// <param name="gamePlatform">The platfrom from which the data will be read.</param>
        /// <param name="endPoint">The endpoint from which the data will be read.</param>
        /// <returns>True if the json is successfuly parsed to the data type otherwise false</returns>
        public static bool TryRead<T>(out T data, GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            using WebClient client = new();

            string json = client.DownloadString($"{Url}/{gamePlatform}/{endPoint}");

            data = !string.IsNullOrEmpty(json) ? Parse<T>(json) : default;

            return !data.Equals(default(T));
        }
    }
}