﻿namespace _3.Raiding
{
    public class Warrior: BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}