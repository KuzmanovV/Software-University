using System;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Cat: Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) 
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}