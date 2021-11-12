using System;
using WarframeAPI.GameData;

namespace WarframeAPI.GameEvents
{
    public class Alert
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public AlertMission Mission { get; set; }

        public string ETA { get; set; }

        public string[] RewardTypes { get; set; }
    }
}