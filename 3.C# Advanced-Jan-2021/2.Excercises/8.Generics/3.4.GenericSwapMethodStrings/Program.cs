using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> values = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                values.Add(value);
            }

            int[] cmd = Console.ReadLine().Split();
            int firstIndex = cmd[0];
            int secondIndex = cmd[1];

            Box<string> box = new Box<string>(values);
            
            box.Swap(firstIndex, secondIndex);

            foreach (var value in values)
            {
                Console.WriteLine($"{value.GetType()}: {value}");
            }
        }
    }
}
