using System.Collections.Generic;
using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public abstract class Mammal: Animal
    {
        protected Mammal(
            HashSet<string> allowedFoods, 
            string name, 
            double weight,
            double weightModifier,
            string livingRegion) 
            : base(allowedFoods, name, weight, weightModifier)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }
    }
}