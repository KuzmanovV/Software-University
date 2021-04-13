using System;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize entity
            Player player = new Player("Mark", "Rogue");
            //Print player
            Console.WriteLine(player);
            //Player Mark: Rogue
            //Rank: Trial
            //Description: n/a

            //Initialize the repository (guild)
            Guild guild = new Guild("Weekend Raiders", 20);
            
            //Add player
            guild.AddPlayer(player);
            Console.WriteLine(guild.Count); //1
            Console.WriteLine(guild.RemovePlayer("Gosho")); //False

            Player firstPlayer = new Player("Pep", "Warrior");
            Player secondPlayer = new Player("Lizzy", "Priest");
            Player thirdPlayer = new Player("Mike", "Rogue");
            Player fourthPlayer = new Player("Marlin", "Mage");

            //Add description to player
            secondPlayer.Description = "Best healer EU";

            //Add players
            guild.AddPlayer(firstPlayer);
            guild.AddPlayer(secondPlayer);
            guild.AddPlayer(thirdPlayer);
            guild.AddPlayer(fourthPlayer);
            Console.WriteLine(guild.Count); //5

            //Promote player
            guild.PromotePlayer("Lizzy");

            //RemovePlayer
            Console.WriteLine(guild.RemovePlayer("Pep")); //True
            Console.WriteLine(guild.Count); //4

            Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");
            Console.WriteLine(string.Join(", ", kickedPlayers.Select(p => p.Name))); //Mark, Mike

            Console.WriteLine(guild.Report());
            //Players in the guild: Weekend Raiders
            //Player Lizzy: Priest
            //Rank: Member
            //Description: Best healer EU
            //Player Marlin: Mage
            //Rank: Trial
            //Description: n/a

        }
    }
}
