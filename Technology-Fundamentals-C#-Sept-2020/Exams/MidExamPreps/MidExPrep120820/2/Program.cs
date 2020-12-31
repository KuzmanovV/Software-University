using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool areAllWagonsFull = true;

            for (int i = 0; i < wagons.Count; i++)
            {
                for (int j = wagons[i]; j < 4; j++)
                {
                    if (peopleWaiting > 0)
                    {
                        peopleWaiting--;
                        wagons[i]++;
                    }
                    else
                    {
                        Console.WriteLine($"The lift has empty spots!\n{string.Join(' ', wagons)}");
                        areAllWagonsFull = false;
                        break;
                    }
                }

                if (!areAllWagonsFull)
                {
                    break;
                }
            }

            if (areAllWagonsFull)
            {
                if (peopleWaiting == 0)
                {
                    Console.WriteLine(string.Join(' ', wagons));
                }
                else
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!\n{string.Join(' ', wagons)}");
                }
            }
        }
    }
}
