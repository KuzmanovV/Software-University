namespace _4.WildFarm.Abstract
{
    public abstract class Bird: Animal
    {
        protected Bird(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; }
    }
}