using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeAPI;
using WarframeAPI.GameData;
using WarframeAPI.GameEvents;

namespace UnitTests
{
    [TestClass]
    public class ReadTests
    {
        [TestMethod]
        public void ReadTest()
        {
            Warframe warframe = API.Read<Warframe>();

            Assert.IsTrue(warframe != default);
        }

        [TestMethod]
        public void ReadWithEndpointTest()
        {
            Nightwave nightWave = API.Read<Nightwave>(endPoint: "nightwave");

            Assert.IsTrue(nightWave != default);
        }

        [TestMethod]
        public void TryReadTest()
        {
            bool result = API.TryRead(out Nightwave nightWave);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TryReadWithEndpointTest()
        {
            bool result = API.TryRead(out Nightwave nightWave, endPoint: "nightwave");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReadArrayTest()
        {
            GlobalUpgrade[] globalUpgrades = API.Read<GlobalUpgrade[]>();

            Assert.IsTrue(globalUpgrades != null);
        }

        [TestMethod]
        public void TryReadArrayTest()
        {
            bool result = API.TryRead(out GlobalUpgrade[] globalUpgrades);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReadArrayWithEndpointTest()
        {
            GlobalUpgrade[] globalUpgrades = API.Read<GlobalUpgrade[]>(endPoint: "globalUpgrades");

            Assert.IsTrue(globalUpgrades != null);
        }

        [TestMethod]
        public void TryReadArrayWithEndpointTest()
        {
            bool result = API.TryRead(out GlobalUpgrade[] globalUpgrades, endPoint: "globalUpgrades");

            Assert.IsTrue(result);
        }
    }
}