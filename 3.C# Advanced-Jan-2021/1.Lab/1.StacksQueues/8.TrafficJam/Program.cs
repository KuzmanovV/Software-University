using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string command;
            Queue<string> queue = new Queue<string>();
            int counter = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < capacity; i++)
                    {
                        if (queue.Count==0)
                        {
                            break;
                        }
                        
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
