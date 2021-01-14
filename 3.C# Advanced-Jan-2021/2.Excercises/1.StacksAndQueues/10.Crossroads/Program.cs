using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenInput = int.Parse(Console.ReadLine());
            int windowInput = int.Parse(Console.ReadLine());

            int carCounter = 0;
            string command;
            Queue<string> queue = new Queue<string>();

            while ((command = Console.ReadLine()) != "END")
            {
                string passing = "";
                int green = greenInput;
                int window = windowInput;

                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while (queue.Count > 0 && green > 0)
                    {
                        passing = queue.Dequeue();
                        green -= passing.Length;
                        carCounter++;
                    }

                    if (green<0)
                    {
                        window += green;
                    }

                    if (window<0)
                    {
                        Stack<char> forReversing = new Stack<char>(passing);

                        for (int i = 0; i < 0-window-1; i++)
                        {
                            forReversing.Pop();
                        }
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{passing} was hit at {forReversing.Pop()}.");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        }
    }
}
