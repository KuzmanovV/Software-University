using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                queue.Enqueue(input);
            }

            int counter = 0;
            int[] start = new int[2];
            int tank = 0;
            for (int i = 0; i < N; i++)
            {
                start = queue.Dequeue().Split().Select(int.Parse).ToArray();
                tank += start[0] - start[1];
                queue.Enqueue(string.Join(" ", start));
                if (tank < 0)
                {
                    counter++;
                    tank = 0;
                    continue;
                }

                bool optimalFound = true;
                int[] next = new int[2];
                for (int j = 0; j < N - 1; j++)
                {
                    next = queue.Dequeue().Split().Select(int.Parse).ToArray();
                    tank += next[0] - next[1];
                    queue.Enqueue(string.Join(" ", next));
                    if (tank < 0)
                    {
                        optimalFound = false;
                        continue;
                    }
                }

                if (optimalFound)
                {
                    Console.WriteLine(counter);
                    Environment.Exit(0);
                }
            }

        }
    }
}
