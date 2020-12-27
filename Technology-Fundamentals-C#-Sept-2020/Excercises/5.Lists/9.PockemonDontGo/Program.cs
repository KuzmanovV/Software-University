using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PockemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int index = int.Parse(Console.ReadLine());
            int sum = 0;

            while (input.Count!=0)
            {
                if (index >= 0 && index < input.Count)
                {
                    sum += input[index];
                    int pockemonGot = input[index];
                    input.RemoveAt(index);

                    if (input.Count == 0)
                    {
                        break;
                    }

                    Changer(input, pockemonGot);
                }
                else if (index < 0)
                {
                    sum += input[0];
                    int pockemonGot = input[0];
                    input[0] = input[input.Count - 1];

                    if (input.Count == 0)
                    {
                        break;
                    }

                    Changer(input, pockemonGot);
                }
                else if (index >= input.Count)
                {
                    sum += input[input.Count - 1];
                    int pockemonGot = input[input.Count - 1];
                    input[input.Count - 1] = input[0];

                    if (input.Count == 0)
                    {
                        break;
                    }

                    Changer(input, pockemonGot);
                }

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }

        private static void Changer(List<int> input, int pockemonGot)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > pockemonGot)
                {
                    input[i] -= pockemonGot;
                }
                else
                {
                    input[i] += pockemonGot;
                }
            }
        }
    }
}
