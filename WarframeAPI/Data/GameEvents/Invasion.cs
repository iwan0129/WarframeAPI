using System;
using System.Text.Json.Serialization;
using WarframeAPI.Data.GameData;

namespace WarframeAPI.Data.GameEvents
{
    public class Invasion
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public string Node { get; set; }

        public string NodeKey { get; set; }

        [JsonPropertyName("desc")]
        public string Description { get; set; }

        public InvasionFaction Attacker { get; set; }

        public InvasionFaction Defender { get; set; }

        public bool VsInfestation { get; set; }

        public int Count { get; set; }

        public int RequiredRuns { get; set; }

        public double Completion { get; set; }

        public bool Completed { get; set; }

        public string ETA { get; set; }

        public string[] RewardTypes { get; set; }
    }
}