using System;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string container = arr[0];

                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length-1] = container;
            }

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
