using System;
using WarframeAPI.Data.GameData;

namespace WarframeAPI.Data.GameEvents
{
    public class SentientOutposts
    {
        public Mission Mission { get; set; }

        public DateTime Activation { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public string Id { get; set; }
    }
}