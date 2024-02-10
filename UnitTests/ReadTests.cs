namespace UnitTests
{
    public class ReadTests
    {
        [Fact]
        public async void ReadTest()
        {
            Warframe warframe = await API.Read<Warframe>();

            Assert.True(warframe != default);
        }

        [Fact]
        public async void ReadWithEndpointTest()
        {
            Nightwave nightWave = await API.Read<Nightwave>(endPoint: "nightwave");

            Assert.True(nightWave != default);
        }

        [Fact]
        public async void ReadArrayTest()
        {
            News[] news = await API.Read<News[]>();

            Assert.True(news != null);
        }

        [Fact]
        public async void ReadArrayWithEndpointTest()
        {
            News[] news = await API.Read<News[]>(endPoint: "news");

            Assert.True(news != null);
        }
    }
}
