using System;

namespace WarframeAPI.Data.GameEvents
{
    public class ConclaveChallenge
    {
        public string Id { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime Activation { get; set; }

        public int Amount { get; set; }

        public string Mode { get; set; }

        public string Category { get; set; }

        public string ETA { get; set; }

        public bool Expired { get; set; }

        public bool Daily { get; set; }

        public bool RootChallenge { get; set; }

        public string EndString { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public int Standing { get; set; }

        public string AsString { get; set; }
    }
}