using System;
using System.Text.Json.Serialization;
using WarframeAPI.GameData;
using WarframeAPI.GameEvents;
using WarframeAPI.WorldState;

namespace WarframeAPI
{
    public class Warframe
    {
        [JsonPropertyName("timestamp")]
        public DateTime Time { get; set; }

        public News[] News { get; set; }

        public Event[] Events { get; set; }

        public Sortie Sortie { get; set; }

        public SyndicateMission[] SyndicateMissions { get; set; }

        public Fissure[] Fissures { get; set; }

        public GlobalUpgrade[] GlobalUpgrades { get; set; }

        public FlashSale[] FlashSales { get; set; }

        public Invasion[] Invasions { get; set; }

        public VoidTrader VoidTrader { get; set; }

        public Simaris Simaris { get; set; }

        public DailyDeal[] DailyDeals { get; set; }

        public ConclaveChallenge[] ConclaveChallenges { get; set; }

        public Earth EarthCycle { get; set; }

        public Cetus CetusCycle { get; set; }

        public Vallis VallisCycle { get; set; }

        public ConstructionProgress ConstructionProgress { get; set; }

        public Nightwave Nightwave { get; set; }

        public Arbitration Arbitration { get; set; }

        public SentientOutposts SentientOutposts { get; set; }

        public SteelPath SteelPath { get; set; }
    }
}