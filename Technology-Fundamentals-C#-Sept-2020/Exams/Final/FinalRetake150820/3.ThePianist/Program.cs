using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];

                output[piece] = new List<string> { composer, key };
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmd = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = cmd[1];

                switch (cmd[0])
                {
                    case "Add":
                        string composer = cmd[2];
                        string key = cmd[3];

                        if (output.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            output[piece] = new List<string> { composer, key };
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;

                    case "Remove":
                        if (output.ContainsKey(piece))
                        {
                            output.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string newKey = cmd[2];

                        if (output.ContainsKey(piece))
                        {
                            output[piece][1] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in output.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
