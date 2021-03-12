using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            var n = int.Parse(Console.ReadLine());

            while (heroes.Count < n)
            {
                var name = Console.ReadLine();
                var type = Console.ReadLine();

                BaseHero hero = CreateHero(name, type);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                }
                else
                {
                    heroes.Add(hero);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int commonPower = 0;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                commonPower += hero.Power;
            }

            if (commonPower>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string name, string type)
        {
            BaseHero hero = null;

            switch (type)
            {
                case nameof(Druid):
                    hero = new Druid(name);
                    break;
                case nameof(Paladin):
                    hero = new Paladin(name);
                    break;
                case nameof(Rogue):
                    hero = new Rogue(name);
                    break;
                case nameof(Warrior):
                    hero = new Warrior(name);
                    break;

            }

            return hero;
        }
    }
}
