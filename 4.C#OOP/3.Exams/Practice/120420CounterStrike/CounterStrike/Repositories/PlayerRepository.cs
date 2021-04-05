using System;
using System.Collections.Generic;
using System.Linq;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private List<IPlayer> models;

        public PlayerRepository()
        {
            this.models = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models
        {
            get
            {
                return models.AsReadOnly();
            }
        }
        public void Add(IPlayer model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            models.Add(model);
        }

        public bool Remove(IPlayer model)
        {
            return models.Remove(model);
        }

        public IPlayer FindByName(string name)
        {
            return models.FirstOrDefault(m => m.Username == name);
        }
    }
}