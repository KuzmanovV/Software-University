using System.Collections.Generic;

namespace _4.WildFarm.Abstract
{
    public abstract class Bird: Animal
    {
       protected Bird(HashSet<string> allowedFoods, 
            string name,
            double weight, 
            double weightModifier,
            double wingSize) 
            : base(allowedFoods, name, weight, weightModifier)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; }
    }
}