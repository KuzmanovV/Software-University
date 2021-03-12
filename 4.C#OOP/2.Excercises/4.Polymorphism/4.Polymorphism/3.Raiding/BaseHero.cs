namespace _3.Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }
        public virtual string Name { get; private set; }
        public int Power { get; private set; }

        public abstract string CastAbility();
    }
}