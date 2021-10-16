namespace WarframeAPI.GameData
{
    public class InvasionReward
    {
        public string[] Items { get; set; }

        public InvasionItem[] CountedItems { get; set; }

        public int Credits { get; set; }

        public string AsString { get; set; }

        public string ItemString { get; set; }

        public string Thumbnail { get; set; }

        public int Color { get; set; }
    }
}
