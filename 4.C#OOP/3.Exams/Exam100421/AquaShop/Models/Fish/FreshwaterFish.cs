namespace AquaShop.Models.Fish
{
    public class FreshwaterFish:Fish
    {
        public FreshwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
            
        }
        public int Size => 5;


        public override void Eat()
        {
            Size += 3;
        }
    }
}