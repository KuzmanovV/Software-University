using System;

namespace _3.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            string result = "";
            double spent = budget;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        budget -= 39.99;
                        if (budget < 0)
                        {
                            result = "Too Expensive";
                            budget += 39.99;
                        }
                        else
                        {
                            result = $"Bought {game}"; 
                        } break;
                    case "CS: OG":
                        budget -= 15.99;
                        if (budget < 0)
                        {
                            result = "Too Expensive";
                            budget += 15.99;
                        }
                        else
                        {
                            result = $"Bought {game}";
                        }
                        break;
                    case "Zplinter Zell":
                        budget -= 19.99;
                        if (budget < 0)
                        {
                            result = "Too Expensive";
                            budget += 19.99;

                        }
                        else
                        {
                            result = $"Bought {game}";
                        }
                        break;
                    case "Honored 2":
                        budget -= 59.99;
                        if (budget < 0)
                        {
                            result = "Too Expensive";
                            budget += 59.99;
                        }
                        else
                        {
                            result = $"Bought {game}";
                        }
                        break;
                    case "RoverWatch":
                        budget -= 29.99;
                        if (budget < 0)
                        {
                            result = "Too Expensive";
                            budget += 29.99;
                        }
                        else
                        {
                            result = $"Bought {game}";
                        }
                        break;
                    default: result = "Not Found"; break;
                }

                Console.WriteLine(result);

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                game = Console.ReadLine();
            }

            if (budget != 0)
            {
                spent -= budget;
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
