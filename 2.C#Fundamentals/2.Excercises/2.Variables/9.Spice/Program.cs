using System;

namespace _9.Spice
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;
            int spice = 0;

            while (yield > 99)
            {
                days++;
                spice += yield - 26;
                yield -= 10;
            }

            if (yield > 0 && yield < 100)
            {
                spice -= 26;
            }

            if (spice < 0)
            {
                spice = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
