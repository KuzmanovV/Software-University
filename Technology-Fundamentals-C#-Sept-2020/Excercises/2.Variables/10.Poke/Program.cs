using System;

namespace _10.Poke
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());

            double halfPower = power / 2.0;
            int pokes = 0;

            while (distance <= power)
            {
                power -= distance;
                pokes++;

                if (power == halfPower && factor != 0)
                {
                    power /= factor;
                }
            }
            
            Console.WriteLine(power);
            Console.WriteLine(pokes);
        }
    }
}
