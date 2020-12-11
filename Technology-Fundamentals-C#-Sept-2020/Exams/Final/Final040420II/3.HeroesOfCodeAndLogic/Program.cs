using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxHP = 100;
            int maxMP = 200;

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                heroes[tokens[0]] = new List<int> { int.Parse(tokens[1]),int.Parse(tokens[2])};
            }

            string command;

            while ((command = Console.ReadLine())!="End")
            {
                string[] cmd = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string hero = cmd[1];

                switch (cmd[0])
                {
                    case "CastSpell":
                        int neededMP = int.Parse(cmd[2]);
                        string spell = cmd[3];

                        if (heroes[hero][1]>=neededMP)
                        {
                            heroes[hero][1] -= neededMP;
                            Console.WriteLine($"{hero} has successfully cast {spell} and now has {heroes[hero][1]} MP!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(cmd[2]);
                        string attacker = cmd[3];

                        heroes[hero][0] -= damage;

                        if (heroes[hero][0]<=0)
                        {
                            heroes.Remove(hero);
                            Console.WriteLine($"{hero} has been killed by {attacker}!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero][0]} HP left!");
                        }
                        break;
                    case "Recharge":
                        int amount = int.Parse(cmd[2]);
                        int oldMP = heroes[hero][1];
                        heroes[hero][1] += amount;

                        if (heroes[hero][1]>maxMP)
                        {
                            amount = maxMP - oldMP;
                            heroes[hero][1] = maxMP;
                        }
                        
                        Console.WriteLine($"{hero} recharged for {amount} MP!");
                        break;
                    case "Heal":
                        amount = int.Parse(cmd[2]);
                        int oldHP = heroes[hero][0];
                        heroes[hero][0] += amount;

                        if (heroes[hero][0] > maxHP)
                        {
                            amount = maxHP - oldHP;
                            heroes[hero][0] = maxHP;
                        }
                        
                        Console.WriteLine($"{hero} healed for {amount} HP!");
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in heroes.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
