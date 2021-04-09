using System;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Warrior:Character,IAttacker
    {
        public Warrior(string name, double health, double armor, double abilityPoints, Bag bag) 
            : base(name, health, armor, abilityPoints, bag)
        {
        }
        public void Attack(Character character)
        {
            EnsureAlive();

            if (character.Name==Name)
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }

            character.TakeDamage(AbilityPoints);
        }
    }
}