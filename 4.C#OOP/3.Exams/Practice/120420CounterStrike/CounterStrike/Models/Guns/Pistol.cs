using System;

namespace CounterStrike.Models.Guns
{
    public class Pistol: Gun
    {
        private int fireRate = 1;
        public Pistol(string name, int bulletsCount) 
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount-fireRate>=0)
            {
                BulletsCount -= fireRate;
                return fireRate;
            }

            return 0;
        }
    }
}