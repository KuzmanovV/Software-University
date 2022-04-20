using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PockemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] input = command.Split();

                List<string> Pockemons = new List<string>();

                Pockemon currentPockemon = new Pockemon
                {
                    Name = input[1],
                    Element = input[2],
                    Health = int.Parse(input[3])
                };

                Trainer trainer = trainers.FirstOrDefault(t => t.Name == input[0]);

                if (trainer == null)
                {
                    Trainer currentTrainer = new Trainer()
                    {
                        Name = input[0],
                        Pockemons = new List<Pockemon>() { currentPockemon }
                    };

                    trainers.Add(currentTrainer);
                }
                else
                {
                    trainers[trainers.IndexOf(trainer)].Pockemons.Add(currentPockemon);
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var item in trainers)
                {
                    item.CheckElementFromCommand(command);
                }
            }

            foreach (var player in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{player.Name} {player.NumberOfBadges} {player.Pockemons.Count}");
            }
        }
    }
}
