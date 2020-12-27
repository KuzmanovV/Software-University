using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string user = input[0];
                string newTeam = input[1];
                Team team = new Team(user, newTeam);
                if (teams.Select(x => x.TeamName).Contains(newTeam))
                {
                    Console.WriteLine($"Team {newTeam} was already created!");
                }
                else if (teams.Select(x => x.Owner).Contains(user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {newTeam} has been created by {user}!");
                    teams.Add(team);
                }
            }

            string joiner = Console.ReadLine();

            while (joiner != "end of assignment")
            {
                string[] assignment = joiner.Split("->");
                string member = assignment[0];
                string targetTeam = assignment[1];

                if (!teams.Select(x => x.TeamName).Contains(targetTeam))
                {
                    Console.WriteLine($"Team {targetTeam} does not exist!");
                }
                else if (teams.Select(x => x.Owner).Contains(member) 
                    || teams.Select(x => x.Members).Any(x => x.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {targetTeam}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == targetTeam);
                    teams[index].Members.Add(member);
                }

                joiner = Console.ReadLine();
            }

            Team[] disbanded = teams.OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();

            Team[] regular = teams.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Members.Count > 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team item in regular)
            {
                sb.AppendLine(item.TeamName);
                sb.AppendLine($"- {item.Owner}");

                foreach (string member in item.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine("Teams to disband:");
            
            foreach (Team item in disbanded)
            {
                sb.AppendLine(item.TeamName);
            }

            Console.WriteLine(sb);
        }
    }

    public class Team
    {
        public Team(string owner, string teamName)
        {
            Owner = owner;
            TeamName = teamName;
            Members = new List<string>();
        }
        public string Owner { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}
