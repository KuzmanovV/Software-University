using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _6.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                if (line.Length == 3)
                {
                    var name = line[0];
                    var age = int.Parse(line[1]);
                    var group = line[2];
                    buyers[name] = new Rebel(name, age, group);
                }
                else if (line.Length == 4)
                {
                    var name = line[0];
                    var age = int.Parse(line[1]);
                    var id = line[2];
                    var birthdate = line[3];
                    buyers[name] = new Citizen(name, age, id, birthdate);
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(line))
                {
                    buyers[line].BuyFood();
                }
            }

            Console.WriteLine(buyers.Values.Sum(b => b.Food));
        }
    }
}
