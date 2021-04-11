using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Models.Decorations
{
    public class Decoration:IDecoration
    {
        protected Decoration(int comfort, decimal price)
        {
            Comfort = comfort;
            Price = price;
        }
        public int Comfort { get; protected set; }
        public decimal Price { get; private set; }
    }
}