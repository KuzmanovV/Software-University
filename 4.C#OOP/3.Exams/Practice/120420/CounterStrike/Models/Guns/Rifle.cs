using System;

namespace CounterStrike.Models.Guns
{
    public class Rifle:Gun
    {
        private int fireRate = 10;
        public Rifle(string name, int bulletsCount) 
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount-fireRate<=0)
            {
                BulletsCount -= fireRate;
                return fireRate;
            }

            return 0;
        }
    }
}