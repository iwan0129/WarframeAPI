using System;
using System.Collections.Generic;
using WarframeAPI.Data.GameData;

namespace WarframeAPI.Data.GameEvents
{
    public class Event
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public int MaximumScore { get; set; }

        public int CurrentScore { get; set; }

        public object SmallInterval { get; set; }

        public object LargeInterval { get; set; }

        public string Description { get; set; }

        public string Tooltip { get; set; }

        public string Node { get; set; }

        public string[] ConcurrentNodes { get; set; }

        public string ScoreLocTag { get; set; }

        public Reward[] Rewards { get; set; }

        public bool Expired { get; set; }

        public int Health { get; set; }

        public InterimStep[] InterimSteps { get; set; }

        public object[] ProgressSteps { get; set; }

        public bool IsPersonal { get; set; }

        public bool IsCommunity { get; set; }

        public object[] RegionDrops { get; set; }

        public object[] ArchwingDrops { get; set; }

        public string AsString { get; set; }

        public object Metadata { get; set; }

        public object[] CompletionBonuses { get; set; }

        public string ScoreVar { get; set; }

        public DateTime AltExpiry { get; set; }

        public DateTime AltActivation { get; set; }

        public Dictionary<string, DateTime> NextAlt { get; set; }
    }
}