using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.PockemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pockemon> Pockemons { get; set; }

        public void CheckElementFromCommand(string command)
        {
            if (Pockemons.Any(p=>p.Element==command))
            {
                this.NumberOfBadges += 1;
            }
            else
            {
                for (int i = 0; i < Pockemons.Count; i++)
                {
                    Pockemons[i].Health -= 10;

                    if (Pockemons[i].Health<=0)
                    {
                        Pockemons.Remove(Pockemons[i]);
                    }
                }
            }
        }
    }
}
