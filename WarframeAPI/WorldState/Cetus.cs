using WarframeAPI.Base;

namespace WarframeAPI.WorldState
{
    public class Cetus : WorldBase
    {
        public bool IsDay { get; set; }

        public string State { get; set; }

        public bool IsCetus { get; set; }

        public string ShortString { get; set; }
    }
}