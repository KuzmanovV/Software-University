using System;
using System.Collections.Generic;

namespace _5.GenericCountMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> values = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                values.Add(value);
            }

            Box<double> box = new Box<double>(values);

            Console.WriteLine(box.GetCountGreaterElements(double.Parse(Console.ReadLine())));
        }
    }
}
