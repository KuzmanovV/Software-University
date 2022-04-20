using System;

namespace _2.SumDigits1
{
    class Program
    {
        static void Main(string[] args)
        {
            string single = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < single.Length; i++)
            {
                sum += int.Parse(single[i].ToString());
            }
            
            Console.WriteLine(sum);
        }
    }
}
