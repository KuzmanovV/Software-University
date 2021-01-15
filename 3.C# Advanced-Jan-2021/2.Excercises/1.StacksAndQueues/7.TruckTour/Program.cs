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
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input[0] - input[1]);
            }

            int counter = -1;
            int sum = 0;
            bool found = true;

            for (int i = 0; i < queue.Count; i++)
            {
                if (queue.Peek() >= 0)
                {
                    counter++;
                    int circulating = 0;
                    
                    for (int j = 0; j < queue.Count; j++)
                    {
                        circulating = queue.Dequeue();
                        queue.Enqueue(circulating);
                        sum += circulating;

                        if (sum < 0)
                        {
                            found = false;
                            break;
                        }

                        if (found)
                        {
                            Console.WriteLine(counter);
                            System.Environment.Exit(0);
                        }

                        circulating = queue.Dequeue();
                        queue.Enqueue(circulating);
                    }
                }
                else
                {
                    counter++;
                    queue.Dequeue();
                }
            }
        }
    }
}
