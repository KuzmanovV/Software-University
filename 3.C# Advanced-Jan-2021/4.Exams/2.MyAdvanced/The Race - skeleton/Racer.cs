using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Racer
    {
        //        Name: string
        //Age: int
        //Country: string
        //Car: Car
        public Racer(string name, int age, string country, Car car)
        {
            Name = name;
            Age = age;
            Country = country;
            Car = car;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }
        public override string ToString()
        {
            return $"Racer: {Name}, {Age} ({Country})"; 
        }
    }
}
