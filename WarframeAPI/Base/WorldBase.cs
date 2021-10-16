using System;

namespace WarframeAPI.Base
{
    public abstract class WorldBase
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public DateTime Expiry { get; set; }

        public string TimeLeft { get; set; }
    }
}