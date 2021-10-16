using System;
using WarframeAPI.Data.GameData;

namespace WarframeAPI.Data.GameEvents
{
    public class Nightwave
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        public DateTime Expiry { get; set; }

        public bool Active { get; set; }

        public int Season { get; set; }

        public string Tag { get; set; }

        public int Phase { get; set; }

        public object Params { get; set; }

        public NightwaveChallenge[] PossibleChallenges { get; set; }

        public NightwaveChallenge[] ActiveChallenges { get; set; }

        public string[] RewardTypes { get; set; }
    }
}