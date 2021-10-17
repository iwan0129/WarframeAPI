using System;
using System.Text.Json;

namespace WarframeAPI.Utilities
{
    public static class JsonUtilities
    {
        public static string GetPropertyJson(this JsonDocument jsonDocument, string propertyName)
        {
            JsonElement.ObjectEnumerator jsonEnumerator = jsonDocument.RootElement.EnumerateObject();

            while (jsonEnumerator.MoveNext())
            {
                JsonProperty jsonProperty = jsonEnumerator.Current;

                if (jsonProperty.Name.StartsWith(propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    return jsonProperty.Value.GetRawText();
                }
            }

            return null;
        }
    }
}