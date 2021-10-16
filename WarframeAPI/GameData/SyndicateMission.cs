using System;
using WarframeAPI.GameData;

namespace WarframeAPI.GameEvents
{
    public class SyndicateMission
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public string Syndicate { get; set; }

        public string[] Nodes { get; set; }

        public SyndicateJob[] Jobs { get; set; }
    }
}