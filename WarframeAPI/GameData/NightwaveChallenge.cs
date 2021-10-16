using System;
using System.Text.Json.Serialization;

namespace WarframeAPI.GameData
{
    public class NightwaveChallenge
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public bool IsDaliy { get; set; }

        public bool IsElite { get; set; }

        [JsonPropertyName("desc")]
        public string Description { get; set; }

        public string Title { get; set; }

        public int Reputation { get; set; }
    }
}