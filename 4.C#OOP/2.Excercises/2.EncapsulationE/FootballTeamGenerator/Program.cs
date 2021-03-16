using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teamsByName = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line=="END")
                {
                    break;
                }

                var parts = line.Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (parts[0])
                    {
                        case "Team":
                            var teamName = parts[1];
                            var team = new Team(teamName);
                            teamsByName.Add(teamName, team);
                            break;
                        case "Add":
                            teamName = parts[1];
                            if (!teamsByName.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                continue;
                            }

                            var playerName = parts[2];
                            var endurance = int.Parse(parts[3]);
                            var sprint = int.Parse(parts[4]);
                            var dribble = int.Parse(parts[5]);
                            var passing = int.Parse(parts[6]);
                            var shooting = int.Parse(parts[7]);
                            var player = new Player(playerName, endurance, sprint,dribble,passing,shooting);
                            teamsByName[teamName].AddPlayer(player);
                            break;
                        case "Remove":
                            teamName = parts[1];
                            playerName = parts[2];
                            team = teamsByName[teamName];
                            team.RemovePlayer(playerName);
                            break;
                        case "Rating":
                            teamName = parts[1];
                            if (!teamsByName.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                continue;
                            }

                            Console.WriteLine($"{teamName} - {teamsByName[teamName].AverigeRating}");
                            break;
                    }
                }
                catch (Exception ex)
                when (ex is ArgumentException || ex is InvalidOperationException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
