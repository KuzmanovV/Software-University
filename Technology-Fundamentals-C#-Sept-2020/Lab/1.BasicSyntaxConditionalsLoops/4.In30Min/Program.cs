using System;

namespace _4.In30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minuts = int.Parse(Console.ReadLine());

            minuts += 30;
            
            if (minuts > 59)
            {
                hours++;
                minuts -= 60;
            }

            if (hours>23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minuts:D2}");
        }
    }
}
