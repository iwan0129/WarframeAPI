using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WarframeAPI.Utilities;

namespace WarframeAPI
{
    public static class API
    {
        private static readonly HttpClient HttpClient = new()
        {
            Timeout = TimeSpan.FromMinutes(1)
        };

        public const string Url = "https://api.warframestat.us";

        public static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static TimeSpan ReadTimeout
        {
            get => HttpClient.Timeout;
            set => HttpClient.Timeout = value;
        }

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
        public static async Task<T> Read<T>(GamePlatform gamePlatform = GamePlatform.Pc, string endPoint = "")
        {
            HttpResponseMessage response = await HttpClient.GetAsync($"{Url}/{gamePlatform}/{endPoint}");

            string responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(responseContent);
            }

            return Parse<T>(responseContent);
        }
    }
}