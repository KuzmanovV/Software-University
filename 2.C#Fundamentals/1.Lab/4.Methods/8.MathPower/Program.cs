using System;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(Powered(number, power));
        }

        private static double Powered(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
