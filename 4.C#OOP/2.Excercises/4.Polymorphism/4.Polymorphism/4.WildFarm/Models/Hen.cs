using _4.WildFarm.Abstract;

namespace _4.WildFarm.Models
{
    public class Hen: Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
        }
    }
}