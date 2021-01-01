using System;
using System.Linq;

namespace _8.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int counter = 0;
            int index = 0;
            int greatestCounter = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > greatestCounter)
                {
                    greatestCounter = counter;
                    index = i;
                }

                counter = 0;
            }

            for (int i = index; i <= index+greatestCounter; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
