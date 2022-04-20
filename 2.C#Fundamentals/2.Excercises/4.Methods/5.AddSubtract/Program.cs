using System;

namespace _5.AddSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Subtract(Sum(first,second),third));
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }

        private static int Subtract(int sum, int third)
        {
            return sum - third;
        }
    }
}
