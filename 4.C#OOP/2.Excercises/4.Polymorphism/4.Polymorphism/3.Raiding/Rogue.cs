namespace _3.Raiding
{
    public class Rogue: BaseHero
    {
        public const int power = 80;
        public Rogue(string name) 
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}