using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count();

        Racer Racer = null;
        //•	Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
        public void Add(Racer Racer)
        {
            if (Count<Capacity)
            {
                data.Add(Racer);
            }
        }

        //•	Method Remove(string name) – removes an Racer by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            Racer = GetRacer(name);
            if (Racer==null)
            {
                return false; ;
            }
            data.Remove(Racer);
            return true;
        }

        //•	Method GetOldestRacer() – returns the oldest Racer.
        public Racer GetOldestRacer()
        {
            return Racer = data.OrderByDescending(r => r.Age).First();
        }

        //•	Method GetRacer(string name) – returns the Racer with the given name.
        public Racer GetRacer(string name)
        {
            return Racer = data.FirstOrDefault(r => r.Name == name);
        }

        //•	Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer()
        {
            return Racer = data.OrderByDescending(r => r.Car.Speed).First();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Racers participating at {Name}:");
            foreach (Racer item in data)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
