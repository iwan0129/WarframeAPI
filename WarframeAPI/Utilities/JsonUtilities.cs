using System;
using System.Text.Json;

namespace WarframeAPI.Utilities
{
    public static class JsonUtilities
    {
        public static bool GetPropertyJson(this JsonDocument jsonDocument, string propertyName, out string jsonData)
        {
            JsonElement.ObjectEnumerator jsonEnumerator = jsonDocument.RootElement.EnumerateObject();

            while (jsonEnumerator.MoveNext())
            {
                JsonProperty jsonProperty = jsonEnumerator.Current;

                if (jsonProperty.Name.StartsWith(propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    jsonData = jsonProperty.Value.GetRawText();

                    return true;
                }
            }

            jsonData = "";

            return false;
        }
    }
}