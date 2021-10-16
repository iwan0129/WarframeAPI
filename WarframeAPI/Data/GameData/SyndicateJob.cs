namespace WarframeAPI.Data.GameData
{
    public class SyndicateJob
    {
        public string Id { get; set; }

        public string[] RewardPool { get; set; }

        public string Type { get; set; }

        public int[] EnemyLevels { get; set; }

        public int[] StandingStages { get; set; }

        public int MinMR { get; set; }
    }
}