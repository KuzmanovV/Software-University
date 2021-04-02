using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> counterTerrorists;

        public Map()
        {
            this.terrorists = new List<IPlayer>();
            this.counterTerrorists = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            SeparateTeams(players);

            while (IsTeamAlive(terrorists) && IsTeamAlive(counterTerrorists))
            {
                Attack(terrorists, counterTerrorists);
                Attack(counterTerrorists, terrorists);
            }

            if (IsTeamAlive(terrorists))
            {
                return "Terrorist wins!";
            }
            else if (IsTeamAlive(counterTerrorists))
            {
                return "Counter Terrorist wins!";
            }

            return "Smth horrible happened!";
        }

        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void Attack(List<IPlayer> attackingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attackingTeam)
            {
                if (!attacker.IsAlive) continue;

                foreach (var defender in defendingTeam)
                {
                    defender.TakeDamage(attacker.Gun.Fire());
                }
            }
        }

        private void SeparateTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
                else if (player is CounterTerrorist)
                {
                    counterTerrorists.Add(player);
                }
            }
        }
    }
}