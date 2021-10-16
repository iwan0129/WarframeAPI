using System;
using System.Text.Json.Serialization;

namespace WarframeAPI.GameData
{
    public class GlobalUpgrade
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Upgrade { get; set; }

        public string Operation { get; set; }

        public string OperationSymbol { get; set; }

        public int UpgradeOperationValue { get; set; }

        public bool Expired { get; set; }

        public string ETA { get; set; }

        [JsonPropertyName("desc")]
        public string Description { get; set; }
    }
}