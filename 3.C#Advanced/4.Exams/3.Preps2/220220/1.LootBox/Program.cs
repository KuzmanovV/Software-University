using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootbox = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack secondLootbox = new Stack(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int loot = 0;

            while (firstLootbox.Count>0&&secondLootbox.Count>0)
            {
                int currentFirst = firstLootbox.Peek();
                int currentSecond = (int)secondLootbox.Pop();
                int sum = currentSecond + currentFirst;

                if (sum%2==0)
                {
                    loot += sum;
                    firstLootbox.Dequeue();
                }
                else
                {
                    firstLootbox.Enqueue(currentSecond);
                }
            }

            if (firstLootbox.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (loot>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {loot}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {loot}");
            }
        }
    }
}
