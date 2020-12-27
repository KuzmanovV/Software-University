using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.AnonymousThread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] comArgs = command.Split().ToArray();

                int startIndex = int.Parse(comArgs[1]);
                int endIndex = int.Parse(comArgs[2]);


                if (comArgs[0] == "merge")
                {
                    int dif = startIndex - endIndex - 1;

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex < startIndex)
                    {
                        startIndex -= dif;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    string conc = "";
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        conc += input[i];
                    }

                    input.Insert(startIndex, conc);

                    for (int i = endIndex + 1; i >= startIndex + 1; i--)
                    {
                        input.RemoveAt(i);
                    }
                }
                else
                {
                    
                    int lengthEquals = input[startIndex].Length / endIndex;

                    for (int i = 0; i < endIndex * lengthEquals; i += lengthEquals)
                    {
                        string conc = "";

                        for (int j = i; j < lengthEquals + i; j++)
                        {
                            conc += input[startIndex][j];
                        }

                        input.Insert(startIndex, conc);
                        startIndex++;
                    }

                    input.RemoveAt(startIndex);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
