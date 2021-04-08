using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        private Computer computer;
        private ComputerManager computerManager;
        [SetUp] 
        public void Setup()
        {
            computer = new Computer("ASUS","Zen",1000.50m);
            computerManager = new ComputerManager();
            computerManager.AddComputer(computer);
        }

        [Test]
        public void CheckCounter()
        {
            Assert.AreEqual(computerManager.Count,1);
        }
        
        [Test]
        public void CheckAdd()
        {
            Computer computer1 = new Computer("ASUS", "Zen", 500.50m);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer1));

            //Computer computer2 = new Computer("PC", "Zen", 500.50m);
            //computerManager.AddComputer(computer2);
            //Assert.AreEqual(computerManager.Computers.Count,2);
        }
        
        [Test]
        public void CheckRemoving()
        {
            computerManager.RemoveComputer("ASUS", "Zen");

            Assert.AreEqual(computerManager.Computers.Count,0);
        }

        [Test]
        public void GetComp()
        {
            Assert.Throws<ArgumentException>(() => computerManager.GetComputer("PC", "Zen"));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "Zen"));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("PC", null));
            Assert.AreEqual(computerManager.GetComputer("ASUS","Zen"),computer);
        }

        [Test]
        public void CheckListByManuf()
        {
            Computer computer1 = new Computer("ASUS", "Pen", 500.50m);
            computerManager.AddComputer(computer1);
            Computer computer2 = new Computer("PC", "Zen", 500.50m);
            List<Computer> checkList = new List<Computer>() {computer, computer1};

            Assert.AreEqual(computerManager.GetComputersByManufacturer("ASUS"),checkList);
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputersByManufacturer(null));
        }
    }
}