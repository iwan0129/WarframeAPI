﻿using System;
using WarframeAPI.Data;
using WarframeAPI.Data.GameEvents;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            API.ReadData(@"D:\test.json", out Warframe warframe);

            API.ReadData(@"D:\test.json", out Nightwave nightWave);

            API.ReadData(@"D:\test.json", out SteelPath steelPath);

            Console.WriteLine("qweqweqweqwe");
        }
    }
}