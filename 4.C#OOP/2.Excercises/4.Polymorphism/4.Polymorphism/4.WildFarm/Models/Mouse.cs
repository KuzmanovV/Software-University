using System;

namespace _4.WildFarm.Models
{
    public class Mouse: Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Squeak");
        }
    }
}