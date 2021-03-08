using System;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Tiger: Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) 
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}