using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>();

            foreach (var item in input)
            {
                queue.Enqueue(item);
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (queue.Count > 0)
                {
                    switch (cmd)
                    {
                        case "Play":
                            queue.Dequeue();
                            break;
                        case "Show":
                            Queue<string> container = new Queue<string>();

                            int forCount = queue.Count;
                            for (int i = 0; i < forCount - 1; i++)
                            {
                                Console.Write($"{queue.Peek()}, ");
                                container.Enqueue(queue.Dequeue());
                            }
                            Console.WriteLine(queue.Peek());
                            container.Enqueue(queue.Dequeue());
                            queue = container;
                            break;
                        default:
                            string song = cmd.Substring(4);
                            if (queue.Contains(song))
                            {
                                Console.WriteLine($"{song} is already contained!");
                            }
                            else
                            {
                                queue.Enqueue(song);
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}
