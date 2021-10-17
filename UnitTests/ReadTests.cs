using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeAPI;
using WarframeAPI.GameEvents;

namespace UnitTests
{
    [TestClass]
    public class ReadTests
    {
        [TestMethod]
        public void TestRead()
        {
            Warframe warframe = API.Read<Warframe>();

            Assert.IsTrue(warframe != default);
        }

        [TestMethod]
        public void TestReadWithEndpoint()
        {
            Nightwave nightWave = API.Read<Nightwave>(endPoint: "nightwave");

            Assert.IsTrue(nightWave != default);
        }

        [TestMethod]
        public void TestTryRead()
        {
            bool result = API.TryRead(out Nightwave nightWave);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTryReadWithEndpoint()
        {
            bool result = API.TryRead(out Nightwave nightWave, endPoint: "nightwave");

            Assert.IsTrue(result);
        }
    }
}
