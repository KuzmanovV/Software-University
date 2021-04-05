using System;
using System.Text;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Models.Players
{
    public abstract class Player: IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        protected Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public string Username
        {
            get { return username; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
            
                username= value;
            }
        }
        public int Health
        {
            get { return health; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
            
                health= value;
            }
        }
        public int Armor
        {
            get { return armor; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
            
                armor= value;
            }
        }
        public IGun Gun
        {
            get { return gun; }
            private set
            {
                if (value==null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
            
                gun= value;
            }
        }
        public bool IsAlive
        {
            get { return Health > 0; }
        }
        public void TakeDamage(int points)
        {
            if (Armor-points>=0)
            {
                Armor -= points;
                return;
            }
            else if (Armor>0)
            {
                points -= Armor;
                Armor = 0;
            }

            Health -= points;

            if (Health<0)
            {
                Health = 0;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.GetType().Name}: {username}");
            result.AppendLine($"--Health: {health}");
            result.AppendLine($"--Armor: {armor}");
            result.AppendLine($"--Gun: {gun.Name}");

            return result.ToString().Trim();
        }
    }
}