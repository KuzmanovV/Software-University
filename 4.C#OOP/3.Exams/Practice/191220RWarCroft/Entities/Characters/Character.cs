using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private float baseHealth;
        private float health;
        private float baseArmor;
        private float armor;
        private float abilityPoints;
        private Bag bag;

        //string name, double health, double armor, double abilityPoints, Bag bag

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            BaseHealth = baseHealth;
            Health = (float)health;
            BaseArmor = baseArmor;
            Armor = (float)armor;
            AbilityPoints = (float)abilityPoints;
            Bag = bag;
        }

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
            }
        }
		public bool IsAlive { get; private set; } = true;

        public float BaseHealth { get; protected set; }
        public float Health { get; internal set; }
        public float BaseArmor { get; protected set; }
        public float Armor { get; protected set; }
        public float AbilityPoints { get; private set; }
        public static Bag Bag { get; set; }

        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();

            if (hitPoints<=Armor)
            {
                Armor -= (float)hitPoints;
            }
            else
            {
                Armor = 0;
                Health -= (float) hitPoints - Armor;
            }

            if (Health<=0)
            {
                Health = 0;
                IsAlive = false;
            }
        }

        public void UseItem(Item item)
        {
            EnsureAlive();

            if (item.GetType().Name=="HealthPotion")
            {
                Health += 20;
            }
            else if (item.GetType().Name == "FirePotion")
            {
                Health -= 20;

                if (Health < 0)
                {
                    Health = 0;
                }

                if (Health == 0)
                {
                    IsAlive = false;
                }
            }
        }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}