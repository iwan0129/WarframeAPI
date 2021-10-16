using System;
using WarframeAPI;
using WarframeAPI.GameEvents;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            API.Read(out Warframe warframe);

            API.Read(out Nightwave nightWave, endPoint: "nightwave");

            API.Read(out SteelPath steelPath);

            Console.WriteLine("qweqweqweqwe");
        }
    }
}