using System;
using System.Text.Json.Serialization;
using WarframeAPI.GameData;

namespace WarframeAPI.GameEvents
{
    public class Sortie
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public string RewardPool { get; set; }

        [JsonPropertyName("variants")]
        public MissionVariant[] MissionVariants { get; set; }

        public string Boss { get; set; }

        public string Faction { get; set; }

        public bool Expired { get; set; }

        public string ETA { get; set; }
    }
}