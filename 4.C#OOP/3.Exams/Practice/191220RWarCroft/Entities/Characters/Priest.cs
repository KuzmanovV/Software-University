using System;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Priest:Character,IHealer
    {
        private Backpack backpack;

        public Priest(string name)
            : base(name, 50, 25, 40, Bag)
        {
            Name = name;
            BaseHealth = 50;
            BaseArmor = 25;
            backpack = new Backpack();
        }

        public void Heal(Character character)
        {
            EnsureAlive();

            if (character.IsAlive)
            {
                character.Health += 40;
            }
        }
    }
}