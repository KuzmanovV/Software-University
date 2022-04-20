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
        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (Count<Capacity)
            {
                roster.Add(player);
            }
        }

        Player player;
        public bool RemovePlayer(string name)
        {
            return roster.Remove(GetPlayer(name));
        }

        public Player GetPlayer(string name)
        {
            return player = roster.FirstOrDefault(p => p.Name == name);
        }

        public void PromotePlayer(string name)
        {
            var playerToPromote = GetPlayer(name);
            
            if (playerToPromote.Rank=="Trial")
            {
                GetPlayer(name).Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            GetPlayer(name).Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string Class)
        {
        Player[] output = roster.Where(p=>p.Class==Class).ToArray();
        roster.RemoveAll(p => p.Class == Class);
        return output;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}