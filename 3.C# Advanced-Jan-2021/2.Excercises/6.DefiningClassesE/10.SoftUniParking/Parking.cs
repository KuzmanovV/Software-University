using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }
        public int Count => cars.Count();
        public string AddCar(Car car)
        {
            string result = "";

            if (cars.Contains(car))
            {
                return result = "Car with that registration number, already exists!";
            }

            if (cars.Count==capacity)
            {
                return result = "Parking is full!";
            }

            cars.Add(car);
            return result = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            string result = "";

                Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

                if (car==null)
                {
                return result = "Car with that registration number, doesn't exist!";
                }

            this.cars.Remove(car);
            return result = $"Successfully removed {registrationNumber}";
        }
        public string GetCar(string registrationNumber)
        {
            string result = "";
            Car car = cars.FirstOrDefault(c=>c.RegistrationNumber==registrationNumber);
           
            return result = car.ToString();
           
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            cars = cars.Where(c => !registrationNumbers.Contains(c.RegistrationNumber)).ToList();
        }
    }
}
