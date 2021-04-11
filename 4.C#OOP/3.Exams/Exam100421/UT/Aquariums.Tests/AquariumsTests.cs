using NUnit.Framework;

namespace Aquariums.Tests
{
    using System;

    public class AquariumsTests
    {
        private Fish dFish;
        private Aquarium dAquarium;
        [SetUp]
        public void Setup()
        {
            dFish = new Fish("Pepi");
            dAquarium = new Aquarium("Home", 2);
            dAquarium.Add(dFish);
        }

        [Test]
        public void CheckName()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null,3), "Invalid aquarium name!");
            Assert.Throws<ArgumentNullException>(() => new Aquarium("",3), "Invalid aquarium name!");
        }
        [Test]
        public void CheckCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Pee",-1), "Invalid aquarium capacity!");
        }
        [Test]
        public void CheckCounter()
        {
            Assert.AreEqual(dAquarium.Count,1);
        }
        [Test]
        public void CheckAdding()
        {
            dAquarium.Add(new Fish("Wanda"));
            Assert.AreEqual(dAquarium.Count,2);
            Assert.Throws<InvalidOperationException>(() => dAquarium.Add(new Fish("New")), "Aquarium is full!");
        }
        [Test]
        public void CheckRemoving()
        {
            dAquarium.Add(new Fish("Wanda"));
            Assert.Throws<InvalidOperationException>(() => dAquarium.RemoveFish("New"), "Fish with the name {name} doesn't exist!");

            dAquarium.RemoveFish("Wanda");
            Assert.AreEqual(dAquarium.Count,1);
        }
        [Test]
        public void CheckSell()
        {
            Fish requested = new Fish("Wanda");
            dAquarium.Add(requested);
            Assert.Throws<InvalidOperationException>(() => dAquarium.SellFish("New"), "Fish with the name {name} doesn't exist!");
            
            Fish returnedFish = dAquarium.SellFish("Wanda");
            Assert.AreEqual(requested.Available, false);

            Assert.AreEqual(returnedFish,requested);
        }
        [Test]
        public void CheckReport()
        {
            dAquarium.Add(new Fish("Wanda"));
           
            Assert.AreEqual(dAquarium.Report(), "Fish available at Home: Pepi, Wanda");
        }
    }
}
