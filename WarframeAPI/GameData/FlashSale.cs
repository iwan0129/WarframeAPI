using System;

namespace WarframeAPI.GameData
{
    public class FlashSale
    {
        public string Id { get; set; }

        public string Item { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime Activation { get; set; }

        public int Discount { get; set; }

        public int RegularOverride { get; set; }

        public int PremiumOverride { get; set; }

        public bool IsShownInMarket { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsPopular { get; set; }

        public bool Expired { get; set; }

        public string ETA { get; set; }
    }
}
