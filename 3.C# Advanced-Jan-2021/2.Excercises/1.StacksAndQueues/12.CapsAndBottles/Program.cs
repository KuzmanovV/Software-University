using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CapsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> caps = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int currentCap = caps.Dequeue();
            int wasted = 0;

            do
            {
                int currentBottle = bottles.Pop();

                if (currentCap == 0)
                {
                    currentCap = caps.Dequeue();
                }

                if (currentCap > currentBottle)
                {
                    currentCap -= currentBottle;
                }
                else if (currentCap < currentBottle)
                {
                    wasted += currentBottle - currentCap;
                    currentCap = 0;
                }
                else
                {
                    currentCap = 0;
                }
            } while (caps.Count != 0 && bottles.Count != 0);
           
            if (caps.Count>0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", caps.ToArray())}");
                Console.WriteLine($"Wasted litters of water: {wasted}");
            }

            if (bottles.Count>0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles.ToArray())}");
                Console.WriteLine($"Wasted litters of water: {wasted}");
            }
        }
    }
}
