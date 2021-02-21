using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> wave = new Stack<int>();

            int fightingPlate = 0;
            int wavesCounter = 0;
            bool platesOver = false;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var item in input)
                {
                    wave.Push(item);
                }

                wavesCounter++;
                if (wavesCounter % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while (wave.Count > 0)
                {
                    if (plates.Count > 0)
                    {
                        if (fightingPlate <= 0)
                        {
                            fightingPlate = plates.Dequeue();
                        }
                        int fight = fightingPlate - wave.Pop();

                        if (fight >= 0)
                        {
                            fightingPlate = fight;
                        }
                        else
                        {
                            wave.Push(0 - fight);
                        }
                    }
                    else
                    {
                        platesOver = true;
                        break;
                    }
                }

                if (platesOver)
                {
                    break;
                }
            }

            //Output
            if (platesOver)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.Write($"Orcs left: ");
                for (int i = 0; i < wave.Count - 1; i++)
                {
                    Console.Write($"{wave.Pop()}, ");
                }
                Console.WriteLine(wave.Pop());
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.Write($"Plates left: ");
                for (int i = 0; i < plates.Count - 1; i++)
                {
                    Console.Write($"{plates.Dequeue()}, ");
                }
                Console.WriteLine(plates.Dequeue());
            }
        }
    }
}
