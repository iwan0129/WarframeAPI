using System.IO;
using System.Text.Json;

namespace WarframeAPI.Data
{
    public static class API
    {
        public const string Url = "https://api.warframestat.us/pc";

        public static readonly JsonSerializerOptions JsonSettings = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static Warframe Load()
        {
            try
            {
                //using WebClient client = new();

                //var jsonData = client.DownloadString(Url);

                return JsonSerializer.Deserialize<Warframe>(File.ReadAllText(@"D:\test.json"), JsonSettings);
            }
            catch
            {
                return null;
            }
        }
    }
}
