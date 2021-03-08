using _4.WildFarm.Models;

namespace _4.WildFarm.Abstract
{
    public abstract class Feline: Mammal
    {
        protected Feline(string name, double weight, int foodEaten, string livingRegion, string breed) 
            : base(name, weight, foodEaten, livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get; }
    }
}