using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sport;
using System;

namespace SportTest
{
    [TestClass]
    public class FootballPlayerTest
    {
        [TestMethod]
        public void TestWithinExpected()
        {
            FootballPlayer player = new FootballPlayer(12, "Helle Hellesen", 123.49m, 22);

            Assert.AreEqual(12, player.Id);
            Assert.AreEqual("Helle Hellesen", player.Name);
            Assert.AreEqual(123.49m, player.Price, "0.0001");
            Assert.AreEqual(22, player.ShirtNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "")]
        public void TestNameUnexpected()
        {
            FootballPlayer player = new FootballPlayer(12, "Hel", 123.49m, 22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "")]
        public void TestPriceUnexpected()
        {
            FootballPlayer player = new FootballPlayer(12, "Helle Hellesen", 0, 22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "")]
        public void TestShirtNumberUnexpected()
        {
            FootballPlayer player = new FootballPlayer(12, "Helle Hellesen", 123.49m, 2212);
        }
    }
}
