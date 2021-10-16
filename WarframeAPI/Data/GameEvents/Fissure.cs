using System;

namespace WarframeAPI.Data.GameEvents
{
    public class Fissure
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public string Node { get; set; }

        public string NodeKey { get; set; }

        public string MissionType { get; set; }

        public string MissionKey { get; set; }

        public string Enemy { get; set; }

        public string EnemyKey { get; set; }

        public string Tier { get; set; }

        public int TierNum { get; set; }

        public bool Expired { get; set; }

        public string ETA { get; set; }

        public bool IsStorm { get; set; }
    }
}