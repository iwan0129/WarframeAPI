using System;

namespace WarframeAPI.Data.GameEvents
{
    public class DailyDeal
    {
        public string Item { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime Activation { get; set; }

        public int OriginalPrice { get; set; }

        public int SalePrice { get; set; }

        public int Total { get; set; }

        public int Sold { get; set; }

        public string Id { get; set; }

        public string ETA { get; set; }

        public int Discount { get; set; }
    }
}