namespace WarframeAPI.GameData
{
    public class AlertMission
    {
        public string Description { get; set; }

        public string Node { get; set; }

        public string Type { get; set; }

        public string Faction { get; set; }

        public Reward Reward { get; set; }

        public int MinEnemyLevel { get; set; }

        public int MaxEnemyLevel { get; set; }

        public int MaxWaveNum { get; set; }

        public bool Nightmare { get; set; }

        public bool ArchwingRequired { get; set; }

        public bool IsSharkwing { get; set; }

        public string LevelOverride { get; set; }

        public string EnemySpec { get; set; }

        public string[] AdvancedSpawners { get; set; }

        public string[] RequiredItems { get; set; }

        public string[] LevelAuras { get; set; }
    }
}