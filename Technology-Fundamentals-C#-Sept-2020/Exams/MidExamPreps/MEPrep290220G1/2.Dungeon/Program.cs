using System;
using System.Linq;

namespace _2.Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            int health = 100;
            int coins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] cmdArgs = rooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int qty = int.Parse(cmdArgs[1]);
                bool isDead = false;
                int dif = 0;

                switch (cmdArgs[0])
                {
                    case "potion":
                        dif = 100 - health;
                        health += qty;

                        if (health > 100)
                        {
                            health = 100;
                            Console.WriteLine($"You healed for {dif} hp.\nCurrent health: {health} hp.");
                            break;
                        }

                        Console.WriteLine($"You healed for {qty} hp.\nCurrent health: {health} hp.");
                        break;
                    case "chest":
                        coins += qty;
                        Console.WriteLine($"You found {qty} bitcoins.");
                        break;
                    default:
                        health -= qty;

                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {cmdArgs[0]}.\nBest room: {i + 1}");
                            isDead = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {cmdArgs[0]}.");
                        }

                        break;
                }

                if (isDead)
                {
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine($"You've made it!\nBitcoins: {coins}\nHealth: {health}");
            }
        }
    }
}
