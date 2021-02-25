using System;

namespace _02bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonuses = 0;
            if (points<=100)
            {
                bonuses = 5;
            }
            else if (points<=1000)
            {
                bonuses = points * 0.2;
            }
            else
            {
                bonuses = points * 0.1;      
            }
            if (points % 2 == 0)
            {
                bonuses = bonuses + 1;
            }
            else if (points % 10 == 5)
            {
                bonuses = bonuses + 2;
            }
            Console.WriteLine(bonuses);
            Console.WriteLine(bonuses+points);
        }
    }
}
