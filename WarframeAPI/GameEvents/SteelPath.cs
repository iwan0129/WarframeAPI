using System;
using WarframeAPI.GameData;

namespace WarframeAPI.GameEvents
{
    public class SteelPath
    {
        public DateTime Activation { get; set; }

        public DateTime Expiry { get; set; }

        public SteelPathItem CurrentReward { get; set; }

        public SteelPathItem[] Rotation { get; set; }

        public SteelPathItem[] evergreens { get; set; }

        public Incursions Incursions { get; set; }
    }
}