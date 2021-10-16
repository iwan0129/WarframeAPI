using System;
using System.Collections.Generic;

namespace WarframeAPI.Data.GameEvents
{
    public class News
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public string Link { get; set; }

        public string ImageLink { get; set; }

        public bool Priority { get; set; }

        public DateTime Date { get; set; }

        public string ETA { get; set; }

        public bool Update { get; set; }

        public bool PrimeAccess { get; set; }

        public bool Stream { get; set; }

        public Dictionary<string, string> Translations { get; set; }

        public string AsString { get; set; }
    }
}