using System;

namespace WarframeAPI.GameEvents
{
    public class Arbitration
    {
        public DateTime Activation { get; set; }

        public DateTime Expiry { get; set; }

        public string Enemy { get; set; }

        public string Type { get; set; }

        public bool Archwing { get; set; }

        public bool Sharkwing { get; set; }

        public string Node { get; set; }
    }
}