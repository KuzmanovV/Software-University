using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }
        public int Count => data.Count();
        public string Type { get; set; }
        public int Capacity { get; set; }
        public void Add(Car car)
        {
            if (data.Count != Capacity)
            {
                data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car carToRemove = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (carToRemove == null)
            {
                return false;
            }

            data.Remove(carToRemove);
            return true;
        }
        public Car GetLatestCar()
        {
            Car latestCar = data.OrderByDescending(c => c.Year).FirstOrDefault();
            return latestCar;
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            return car;
        }
        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The cars are parked in {Type}:");

            foreach (var item in data)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
