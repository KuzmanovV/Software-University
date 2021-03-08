using System;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Owl: Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}