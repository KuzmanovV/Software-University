using System.Collections.Generic;
using _4.WildFarm.Models;

namespace _4.WildFarm.Abstract
{
    public abstract class Feline: Mammal
    {
        protected Feline(
            HashSet<string> allowedFoods,
            string name, double weight,
            double weightModifier, 
            string livingRegion, 
            string breed)
            : base(allowedFoods, name, weight, weightModifier, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; }
    }
}