using System;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private UnitDriver unitDriver;
        private UnitCar unitCar;
        private RaceEntry raceEntry;
        [SetUp]
        public void Setup()
        {
            unitCar = new UnitCar("Lada",20, 1.5);
            unitDriver = new UnitDriver("Pe6o", unitCar);
            raceEntry = new RaceEntry();
            raceEntry.AddDriver(unitDriver);
        }

        [Test]
        public void CountCounts()
        {
            Assert.AreEqual(raceEntry.Counter,1);
        }

        [Test]
        public void NullDriver()
        {
            UnitDriver nullDriver = null;

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(nullDriver));
        }
        
        [Test]
        public void lDriverExist()
        {
            UnitDriver doubleDriver = new UnitDriver("Pe6o", unitCar);

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(doubleDriver));
        }
        
        [Test]
        public void CheckDriverCountMin()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }
        
        [Test]
        public void CalcsAverHorsePower()
        {
            UnitCar secondCar = new UnitCar("Ford", 40, 1.5);
            UnitDriver secondDriver = new UnitDriver("Go6o", secondCar);
            raceEntry.AddDriver(secondDriver);

            Assert.AreEqual(raceEntry.CalculateAverageHorsePower(),30);
        }
    }
}