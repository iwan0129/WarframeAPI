namespace WarframeAPI.GameData
{
    public class Reward
    {
        public string[] Items { get; set; }

        public CountedItem[] CountedItems { get; set; }

        public int Credits { get; set; }

        public string AsString { get; set; }

        public string ItemString { get; set; }

        public string Thumbnail { get; set; }

        public int Color { get; set; }
    }
}
