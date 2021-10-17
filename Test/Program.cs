using System;
using WarframeAPI;
using WarframeAPI.GameEvents;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Warframe warframe = API.Read<Warframe>();

            Nightwave nightWave = API.Read<Nightwave>(endPoint: "nightwave");

            SteelPath steelPath = API.Read<SteelPath>();

            var result = API.TryRead(out Arbitration arbitration);
        }
    }
}