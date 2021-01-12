using System;
using System.Collections;
using System.Linq;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack stack = new Stack();

            for (int i = 0; i < inputData.Length; i++)
            {
                stack.Push(inputData[i]);
            }

            for (int i = 0; i < inputCommands[1]; i++)
            {
                stack.Pop();
            }

            int smallest = int.MaxValue;
            bool isFound = false;

            if (inputCommands[0] - inputCommands[1] > 0)
            {
                for (int i = 0; i < inputCommands[0] - inputCommands[1]; i++)
                {
                    int element = (int)stack.Pop();

                    if (inputCommands[2]==element)
                    {
                        Console.WriteLine("true");
                        isFound = true;
                        break;
                    }

                    if (element<smallest)
                    {
                        smallest = element;
                    }
                }
            }
            else
            {
                Console.WriteLine("0");
                isFound = true;
            }

            if (!isFound)
            {
                Console.WriteLine(smallest);
            }
        }
    }
}
