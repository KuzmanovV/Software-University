using System;
using System.Collections.Generic;

namespace _6.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Queue<string> queue = new Queue<string>();

            while ((input=Console.ReadLine())!="End")
            {
                if (input!="Paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int qCount = queue.Count;

                    for (int i = 0; i < qCount; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
