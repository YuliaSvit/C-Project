using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Trip
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void CalculateMilesPerGallonTest()
        {
            Trip myTrip = new Trip("New York", 1000, 2000M, 34);
            var a = myTrip.CalculateMilesPerGallon();
            Assert.AreEqual(a, 29.4,0.1);
            Console.WriteLine(myTrip);
        }
        [TestMethod]
        public void CalculateCostPerMileTest()
        {
            Trip myTrip = new Trip("New York", 1000, 2000M, 34);
            var a = myTrip.CalculateCostPerMile();
            Assert.AreEqual(a, 2);
        }
        [TestMethod]
        public void ToStringTest()
        {
            Trip myTrip = new Trip("New York", 1000, 2000M, 34);
            Console.WriteLine(myTrip);
        }
    }
}
