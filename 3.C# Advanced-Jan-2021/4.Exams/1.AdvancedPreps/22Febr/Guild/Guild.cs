using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count();
        public void AddPlayer(Player player)
        {
            if (roster.Count<Capacity)
            {
                roster.Add(player);
            }
        }
        
        //•	Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool
        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p=>p.Name==name);

            if (player==null)
            {
                return false;
            }
            roster.Remove(player);
            return true;
        }

        //•	Method PromotePlayer(string name) - promote (set his rank to "Member") the first player with the given name. If the player is already a "Member", do nothing.
        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);

            if (player != null)
            {
                player.Rank="Member";
            }
        }

        //•	Method DemotePlayer(string name)- demote (set his rank to "Trial") the first player with the given name. If the player is already a "Trial",  do nothing.
        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);

            if (player != null)
            {
                player.Rank = "Trial";
            }
        }

        //•	Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array
        public Player[] KickPlayersByClass(string Class)
        {
            Player[] output = roster.Where(p => p.Class == Class).ToArray();
            roster.RemoveAll(p => p.Class == Class);
            return output;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Players in the guild: {Name}");

            foreach (var item in roster)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
