using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car= new Car("Make", "Model", 10, 100);
        }

        [Test]
        [TestCase("Make", "Model", 10, -100)]
        [TestCase("Make", "Model", 10, 0)]
        [TestCase("Make", "Model", -10, 100)]
        [TestCase("Make", "Model", 0, 100)]
        [TestCase("Make", "", 10, 100)]
        [TestCase("Make", null, 10, 100)]
        [TestCase("", "Model", 10, 100)]
        [TestCase(null, "Model", 10, 100)]
        public void CtorThrowsException_WhenDataInvalid(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(()=>new Car(make, model,fuelConsumption,fuelCapacity));
        }

        [Test]
        public void CtorSetsIniitialValues_WhenArgumentsValid()
        {
            string make = "Make";
            string model = "Model";
            double fuelConsumption = 10.0;
            double fuelCapacity = 100.0;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.That(car.Make, Is.EqualTo(make));
            Assert.That(car.Model, Is.EqualTo(model));
            Assert.That(car.FuelConsumption, Is.EqualTo(fuelConsumption));
            Assert.That(car.FuelCapacity, Is.EqualTo(fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-20)]
        public void RefuelThrowsException_WhenFuelIsZeroOrNegative(double fuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
        }

        [Test]
        public void RefuelIncreasesAmount_WhenFuelAmountIsValid()
        {
            double refuelAmount = car.FuelCapacity / 2;
            car.Refuel(refuelAmount);
            Assert.That(car.FuelAmount,Is.EqualTo(refuelAmount));
        }
        
        [Test]
        public void RefuelSetsFuelAmountToCapacity_WhenCapacityIsExceeded()
        {
            car.Refuel(car.FuelCapacity*1.2);
            Assert.That(car.FuelAmount,Is.EqualTo(car.FuelCapacity));
        }

        [Test]
        public void DriveThrowsException_WhenFuelIsZero()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(100));
        }

        [Test]
        public void DriveDecreasesFuelAmount_WhenDistanceIsValid()
        {
            double initialFuel = car.FuelCapacity;
            car.Refuel(initialFuel);
            car.Drive(100);
            Assert.That(car.FuelAmount, Is.EqualTo(initialFuel-car.FuelConsumption));
        }

        [Test]
        public void DriveDecreasesFuelAmountToZero_WhenRequiredFuelIsEqualToFuelAmount()
        {
            car.Refuel(car.FuelCapacity);
            double distance = car.FuelCapacity * car.FuelConsumption;
            car.Drive(distance);
            Assert.That(car.FuelAmount,Is.EqualTo(0));
        }
    }
}