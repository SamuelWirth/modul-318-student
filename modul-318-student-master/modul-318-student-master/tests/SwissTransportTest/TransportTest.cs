using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport _testee;

        [TestMethod]
        public void Locations()
        {
            _testee = new Transport();
            var stations = _testee.GetStations("Sursee,");

            Assert.AreEqual(50, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            _testee = new Transport();
            var stationBoard = _testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            _testee = new Transport();
            var connections = _testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }
    }
}
