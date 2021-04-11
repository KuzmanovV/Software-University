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
        }

        [Test]
        public void CheckCompCtor()
        {
            Assert.AreEqual(computer.Manufacturer,"ASUS");
            Assert.AreEqual(computer.Model,"Zen");
            Assert.AreEqual(computer.Price,1000.50m);
        }
        
        [Test]
        public void CheckCompManagerCtor()
        {
            Assert.AreEqual(computerManager.Computers.Count,0);
        }
        
        [Test]
        public void CheckCounter()
        {
            computerManager.AddComputer(computer);
            Assert.AreEqual(computerManager.Count,1);
            Assert.That(computerManager.Computers, Has.Member(computer));
        }
        
        [Test]
        public void CheckAdd()
        {
            computerManager.AddComputer(computer);
            Computer computer1 = new Computer("ASUS", "Zen", 500.50m);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer1), "This computer already exists.");

            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null), "Can not be null!");

            Assert.AreEqual(computerManager.Count, 1);
            Assert.That(computerManager.Computers, Has.Member(computer));
        }
        
        [Test]
        public void CheckRemoving()
        {
            computerManager.AddComputer(computer);
            
            var result = computerManager.RemoveComputer("ASUS", "Zen");

            Assert.AreEqual(computerManager.Computers.Count,0);
            Assert.AreEqual(result,computer);

            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("Mac", "Biik"),
                "There is no computer with this manufacturer and model.");
        }

        [Test]
        public void GetComp()
        {
            computerManager.AddComputer(computer);
           
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "Zen"), "Can not be null!");
           Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("PC", null), "Can not be null!");
            Assert.AreEqual(computerManager.GetComputer("ASUS","Zen"),computer);
           Assert.Throws<ArgumentException>(() => computerManager.GetComputer("PC", "Zen"), "There is no computer with this manufacturer and model.");
        }

        [Test]
        public void CheckListByManuf()
        {
            computerManager.AddComputer(computer);

            var collection = computerManager.GetComputersByManufacturer("ASUS");
            Assert.AreEqual(collection.Count,1);
           
           Computer computer1 = new Computer("ASUS", "Pen", 500.50m);
            computerManager.AddComputer(computer1);
            List<Computer> checkList = new List<Computer>() {computer, computer1};
            Computer computer2 = new Computer("Mac", "Book", 2000);
            computerManager.AddComputer(computer2);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("ASUS"),checkList);
            
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputersByManufacturer(null), "Can not be null!");
        }
    }
}