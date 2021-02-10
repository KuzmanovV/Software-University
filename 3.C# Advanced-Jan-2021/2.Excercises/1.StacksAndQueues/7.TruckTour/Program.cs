using System;
using System.Collections.Generic;
using System.Linq;

namespace NewTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> commandsQueue = new Queue<string>();

            //filling of commands
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                commandsQueue.Enqueue(input);
            }

            //circuling the commands
            for (int i = 0; i < n; i++)
            {
                int tank = 0;
                bool isSuccessful = true;

                for (int j = 0; j < n; j++)
                {
                    string container = commandsQueue.Dequeue();
                    int[] firstStation = container.Split().Select(int.Parse).ToArray();
                    commandsQueue.Enqueue(container);

                    tank += firstStation[0] - firstStation[1];
                
                    if (tank < 0)
                    {
                        isSuccessful = false;

                        for (int k = j+1; k < n; k++)
                        {
                            commandsQueue.Enqueue(commandsQueue.Dequeue());
                        }
                        break;
                    }
                }

                if (isSuccessful)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    commandsQueue.Enqueue(commandsQueue.Dequeue());
                }
            }
        }
    }
}
