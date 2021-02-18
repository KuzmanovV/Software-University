using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name, string playerClass)
        {
            Name = name;
            Class = playerClass;
            Rank = "Trial";
            Description = "n/a";
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Player {Name}: {Class}");
            result.AppendLine($"Rank: {Rank}");
            result.Append($"Description: {Description}");
            return result.ToString();
        }
    }
}
