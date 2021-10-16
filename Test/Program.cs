using System;
using WarframeAPI;
using WarframeAPI.GameEvents;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            API.ReadData(out Warframe warframe);

            API.ReadData(out Nightwave nightWave, endPoint: "nightwave");

            API.ReadData(out SteelPath steelPath);

            Console.WriteLine("qweqweqweqwe");
        }
    }
}