using System;

namespace WarframeAPI.GameEvents
{
    public class VoidTrader
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public string Character { get; set; }

        public string Location { get; set; }

        public string[] Inventory { get; set; }

        public string PsId { get; set; }

        public string EndString { get; set; }
    }
}